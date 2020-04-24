using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ExplainableCancerClassifier
{
    public static class LoadDatabase
    {
        public static byte[,,] Load_Png_Array(string path)
        {
            Image<Gray, Byte> img = new Image<Gray, Byte>(path);
            return img.Data;
        }

        public static Dictionary<string, byte[,,]> Load_Factors(string dir_path, RichTextBox rc)
        {
            Stopwatch sw = new Stopwatch();
            Dictionary<string, byte[,,]> factors = new Dictionary<string, byte[,,]>();
            int prog = 0;
            var dir = Directory.GetFiles(dir_path, "*.png");
            foreach (string file in dir)
            {
                prog += 1;

                sw.Start();
                factors.Add(GetKeyFromFileName(Path.GetFileNameWithoutExtension(file)), Load_Png_Array(file));
                sw.Stop();
                rc.Invoke((MethodInvoker)delegate { rc.Text = $"Načitávam {prog.ToString()} z {dir.Length} čas: {sw.ElapsedMilliseconds}"; });
                sw.Reset();
            }

            return factors;
        }

        public static Dictionary<int, string> GetFactors(Dictionary<string, byte[,,]> factors, int label, int row, int column)
        {
            Dictionary<int, string> vect = new Dictionary<int, string>();
            for (int i = 1; i <= 8; i++)
            {
                if (i != label)
                {
                    var fact = factors[label.ToString() + i.ToString()];
                    vect.Add(i,fact[column,row, 0].ToString());
                }
            }

            return vect;
        }

        public static byte[] LoadMemberships(int index)
        {
            var b = File.ReadAllBytes(ExplanationDatabase.wsi_membership_path[index]);
            
            return b;
        }

        public static float[] GetMembershipVector(byte[] memberships, int x, int y)
        {
            float[] vector = new float[8];
            for (int k = 0; k < 8; k++)
            {
                int a = y + x * 5000 + k * 5000 * 5000;
                vector[k] = System.BitConverter.ToSingle(memberships, a * 4);
            }

            return vector;
        }

        public static byte[] LoadDataMembership()
        {
            var b = File.ReadAllBytes(ExplanationDatabase.data_memberships_path);

            return b;
        }

        public static string GetTheMostSimilarImagePath(int label, int referenceLabel, float membValue, byte[] memberships, string[] data_paths)
        {
            // extract membershuips for label  from 5000x8
            float[] labelMembs = new float[625]; // there is 625 images for each class
            for (int i = 0; i < labelMembs.Length; i++)
            {
                labelMembs[i] = GetElementFromDataMembership(memberships, i + (label - 1) * 625, (referenceLabel - 1));
            }

            var index = Array.IndexOf(labelMembs, labelMembs.OrderBy(a => Math.Abs(membValue - a)).First());

            return data_paths[index+625*(referenceLabel-1)];
        }

        private static float GetElementFromDataMembership(byte[] memberships, int imgIdx, int refLabel)
        {
            int a = imgIdx + refLabel * 5000;//5000
            return System.BitConverter.ToSingle(memberships, a * 4);
        }

        public static string[] LoadDataPaths()
        {
            string[] lines = System.IO.File.ReadAllLines(ExplanationDatabase.data_paths);

            return lines;
        }
 

        /// <summary>
        /// example file name fact_1_to_2.mat
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private static string GetKeyFromFileName(string filename)
        {
            var parsed_name = filename.Split('_');

            return parsed_name[1] + parsed_name[3];
        }


    }
}
