using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplainableCancerClassifier
{
    public static class Utilities
    {
        public static int[] GetAbsolutCoordinates(Point coordinates, int ORIGINAL_SIZE, PictureBox pcBx_cancer)
        {
            int x = coordinates.X;
            int y = coordinates.Y;

            double act_scale = (double)ORIGINAL_SIZE / (double)pcBx_cancer.Width;
            int xx = (int)(x * act_scale);
            int yy = (int)(y * act_scale);

            return new int[] { xx, yy };
        }

        public static int[] GetRelativeCoordinates(int x, int y, int ORIGINAL_SIZE, PictureBox pcBx_cancer)
        {

            double act_scale = (double)ORIGINAL_SIZE / (double)pcBx_cancer.Width;
            int xx = (int)(x / act_scale);
            int yy = (int)(y / act_scale);

            return new int[] { xx, yy };
        }

        public static void HighlightWords(string[] words, RichTextBox rich)
        {
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < rich.TextLength)
                {

                    int wordStartIndex = rich.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        rich.SelectionStart = wordStartIndex;
                        rich.SelectionLength = word.Length;
                        var myKey = ExplanationDatabase.classes.FirstOrDefault(x => x.Value == word).Key;
                        rich.SelectionBackColor = ExplanationDatabase.colorsRGB[myKey - 1];
                        rich.SelectionColor = Color.White;
                        if (myKey == 3) rich.SelectionColor = Color.Black;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }
            }
            rich.SelectAll();
            // Changes the font size to 11pt if some text is selected
            rich.SelectionFont = new System.Drawing.Font(
                rich.SelectionFont.FontFamily.Name,
                12F,
                rich.SelectionFont.Style,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
        }

        public static List<int> GetElementsByValue(Dictionary<int, string> facts, string value)
        {
            List<int> result = new List<int>();
            foreach (var fact in facts)
            {
                if (fact.Value == value)
                {
                    result.Add(fact.Key);
                }
            }

            return result;
        }

        public static string ExtractSemantic(int predictedLabel, Dictionary<int, string> facts)
        {
            StringBuilder result = new StringBuilder();

            //result.Append($"Vybrané tkanivo je s najväčšou pravdepodobnosti {ExplanationDatabase.classes[predictedLabel]}");
            result.Append($"The selected area is  {ExplanationDatabase.classes[predictedLabel]}");

            var highProbLabels = GetElementsByValue(facts, "3");
            var lowProbLabels = GetElementsByValue(facts, "2");

            if (highProbLabels.Count == 0 && lowProbLabels.Count == 0)
            {
                //result.Append(" s najväčšou istotou.");
                result.Append(".");
            }
            if (highProbLabels.Count > 0)
            {
                result.Append(", however, there is high posibility that in reality, it could be");
                //result.Append(", avšak v skutočnosti to môže byť s vysokou pravdepodobnosťou");
                for (int i = 0; i < highProbLabels.Count; i++)
                {
                    result.Append($" {ExplanationDatabase.classes[highProbLabels[i]]}");
                    if (i < highProbLabels.Count - 1)
                    {
                        if (highProbLabels.Count > 1)
                            result.Append(" or");
                            //result.Append(" alebo");
                    }
                    else result.Append(".");
                }
            }
            if (lowProbLabels.Count > 0)
            {
                if (highProbLabels.Count > 0)
                    result.Append(" Moreover, there is low possibility that it could be");
                    //result.Append(" Okrem toho s nízkou pravdepodobnosťou to v skutočnosti môže byť");
                else result.Append(", however, there is low possibility that in reality it could be");
                //else result.Append(", avšak v skutočnosti to môže byť s nízkou pravdepodobnosťou");
                for (int i = 0; i < lowProbLabels.Count; i++)
                {
                    result.Append($" {ExplanationDatabase.classes[lowProbLabels[i]]}");
                    if (i < lowProbLabels.Count - 1)
                    {
                        if (lowProbLabels.Count > 1)
                            result.Append(" or");
                    }
                    else result.Append(".");
                }
            }

            return result.ToString();
        }

        public static List<int[]> LoadSuggestedPoints(string wsi_name)
        {
            List<int[]> suggestedPoints = new List<int[]>();
            string path = ExplanationDatabase.WSI_DATA_PATH + wsi_name;
            string fileName = $"\\suggested_points_{wsi_name}.txt";
            string[] lines = System.IO.File.ReadAllLines(path + fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                var parsedLine = lines[i].Split(',');
                Int32.TryParse(parsedLine[0], out int x);
                Int32.TryParse(parsedLine[1], out int y);
                Int32.TryParse(parsedLine[2], out int flag);
                if(flag == 3 || flag == 4)
                    suggestedPoints.Add(new int[] { x, y, flag });
            }

            return suggestedPoints;
        }

        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
