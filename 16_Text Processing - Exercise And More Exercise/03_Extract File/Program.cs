﻿using System;

namespace _03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToAFile = Console.ReadLine();

            int startingIndexOtTheFileName = pathToAFile.LastIndexOf('\\');
            int endingIndexOtTheFileName = pathToAFile.IndexOf('.');

            string fileName = pathToAFile.Substring(startingIndexOtTheFileName + 1, endingIndexOtTheFileName -
                startingIndexOtTheFileName - 1);
            string extension = pathToAFile.Substring(endingIndexOtTheFileName + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
