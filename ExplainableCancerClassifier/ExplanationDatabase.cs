﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainableCancerClassifier
{
    static class ExplanationDatabase
    {
        private static string WSI_PATH = "C:\\Users\\CitLat_Sabol\\Documents\\School\\Image_data\\" +
                "Kather_texture_2016_larger_images_10\\";
        public static string[] wsi_paths =
        {
            WSI_PATH+"CRC-Prim-HE-01_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-02_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-03_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-04_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-05_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-06_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-07_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-08_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-09_APPLICATION.tif",
            WSI_PATH+"CRC-Prim-HE-10_APPLICATION.tif"
        };

        public static string[] ground_truth =
        {
            WSI_PATH+"GT_WSI_01.png",
            WSI_PATH+"GT_WSI_02.png",
            WSI_PATH+"GT_WSI_03.png",
            WSI_PATH+"GT_WSI_04.png",
            WSI_PATH+"GT_WSI_05.png",
            WSI_PATH+"GT_WSI_06.png",
            WSI_PATH+"GT_WSI_07.png",
            WSI_PATH+"GT_WSI_08.png",
            WSI_PATH+"GT_WSI_09.png",
            WSI_PATH+"GT_WSI_10.png"
        };

        public static string WSI_DATA_PATH = "C:\\Users\\CitLat_Sabol\\Documents\\School\\Image_data\\results_WSI_data\\";
        public static string[] wsi_labels_paths =
        {
            WSI_DATA_PATH+"WSI_01\\labelMap_CFCMC_WSI_01.tif",
            WSI_DATA_PATH+"WSI_02\\labelMap_CFCMC_WSI_02.tif",
            WSI_DATA_PATH+"WSI_03\\labelMap_CFCMC_WSI_03.tif",
            WSI_DATA_PATH+"WSI_04\\labelMap_CFCMC_WSI_04.tif",
            WSI_DATA_PATH+"WSI_05\\labelMap_CFCMC_WSI_05.tif",
            WSI_DATA_PATH+"WSI_06\\labelMap_CFCMC_WSI_06.tif",
            WSI_DATA_PATH+"WSI_07\\labelMap_CFCMC_WSI_07.tif",
            WSI_DATA_PATH+"WSI_08\\labelMap_CFCMC_WSI_08.tif",
            WSI_DATA_PATH+"WSI_09\\labelMap_CFCMC_WSI_09.tif",
            WSI_DATA_PATH+"WSI_10\\labelMap_CFCMC_WSI_10.tif"            
        };

        public static string[] factOfMisclass_dir_path = 
        {
            WSI_DATA_PATH+"WSI_01\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_02\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_03\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_04\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_05\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_06\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_07\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_08\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_09\\fact_class2class_png",
            WSI_DATA_PATH+"WSI_10\\fact_class2class_png"            
        };

        public static string[] wsi_membership_path =
        {
            WSI_DATA_PATH+"WSI_01\\memberships_CFCMC_WSI_01.bin",
            WSI_DATA_PATH+"WSI_02\\memberships_CFCMC_WSI_02.bin",
            WSI_DATA_PATH+"WSI_03\\memberships_CFCMC_WSI_03.bin",
            WSI_DATA_PATH+"WSI_04\\memberships_CFCMC_WSI_04.bin",
            WSI_DATA_PATH+"WSI_05\\memberships_CFCMC_WSI_05.bin",
            WSI_DATA_PATH+"WSI_06\\memberships_CFCMC_WSI_06.bin",
            WSI_DATA_PATH+"WSI_07\\memberships_CFCMC_WSI_07.bin",
            WSI_DATA_PATH+"WSI_08\\memberships_CFCMC_WSI_08.bin",
            WSI_DATA_PATH+"WSI_09\\memberships_CFCMC_WSI_09.bin",
            WSI_DATA_PATH+"WSI_10\\memberships_CFCMC_WSI_10.bin",
            
        };
            
            


        private static double[,] colors = new double[,]        
            { {1 ,0, 0 },{0, 1, 0 },{1, 1, 0 },{0, 0, 1},{1, 0, 1},{1, 0.71, 0.75}, {0.5, 0.5, 0.5},{0, 0, 0}};

        public static Color[] colorsRGB = new Color[]
            {
                Color.FromArgb(255,0,0),
                Color.FromArgb(0,255,0),
                Color.FromArgb(255,255,0),
                Color.FromArgb(0,0,255),
                Color.FromArgb(255,0,255),
                Color.FromArgb(255,181,191),
                Color.FromArgb(127,127,127),
                Color.FromArgb(0,0,0),
            };

        public static int GetLabel(Color col)
        {
            for (int i = 0; i < colorsRGB.Length; i++)
            {
                if (colorsRGB[i].Equals(col))
                {
                    return i + 1;
                }
            }
            return 0;
        }        

        public static string data_memberships_path = "C:\\Users\\CitLat_Sabol\\Documents\\School\\" +
            "Image_data\\results_WSI_data\\memberships_whole_dataset.bin";
        public static string data_paths = "C:\\Users\\CitLat_Sabol\\Documents\\School\\" +
            "Image_data\\results_WSI_data\\trainingData_list.txt";

        public static Dictionary<int, string> classes = new Dictionary<int, string>
        {
            {0, "nešpecifikované" },
            {1,"Tumour epithelum" },
            {2,"Simple stroma" },
            {3,"Complex stroma" },
            {4,"Immune cells" },
            {5,"Debris or mucus" },
            {6,"Mucosal glands" },
            {7,"Adipose tissue" },
            {8,"Background" }
        };

        public static ExperimentsNames[] experimentsNames = new ExperimentsNames[]
        {
            new ExperimentsNames("WSI_01", 0),
            new ExperimentsNames("WSI_02", 1),
            new ExperimentsNames("WSI_03", 2),
            new ExperimentsNames("WSI_04", 3),
            new ExperimentsNames("WSI_05", 4),
            new ExperimentsNames("WSI_06", 5),
            new ExperimentsNames("WSI_07", 6),
            new ExperimentsNames("WSI_08", 7),
            new ExperimentsNames("WSI_09", 8),
            new ExperimentsNames("WSI_10", 9)
        };           



    }

    public struct ExperimentsNames
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public ExperimentsNames(string name, int order)
        {
            Name = name;
            Order = order;
        }
    }
}
