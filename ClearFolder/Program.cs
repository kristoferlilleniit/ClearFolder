﻿using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Samples";
            DeleteAllFiles();

            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }
        }

        //a function to delete all files
        public static void DeleteAllFiles()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach(FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }

        //a function to delete all the folders
        public static void DeleteAllFolders(string directoryName, bool ifExists)
        {
            if(Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            }else if(ifExists)
            {
                throw new SystemException("No such directory to delete.");
            }
        }
    }
}
