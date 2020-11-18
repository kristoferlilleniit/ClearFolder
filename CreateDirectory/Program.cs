﻿using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFolderOne();
            CreateFolderTwo();
        }

        public static void CreateFolderOne()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerOne";
            string fullFolderPath = Path.Combine(rootPath, folderName);

            if(Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The folder already exists.");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }

        public static void CreateFolderTwo()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerTwo";
            string fullFolderPath = Path.Combine(rootPath, folderName);

            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The folder already exists.");
            }
            else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
    }
}
