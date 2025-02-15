﻿using System;
using System.Collections.Generic;

namespace _07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|');
            List<string> result = new List<string>();
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] elements = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
