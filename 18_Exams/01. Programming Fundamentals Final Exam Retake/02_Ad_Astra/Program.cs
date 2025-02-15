﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches =
                Regex.Matches(input, @"(\||#)([A-Za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,4}|10000)\1");

            int callories = matches
                .Select(c => int.Parse(c.Groups[4].Value.ToString()))
                .Sum();
            Console.WriteLine($"You have food to last you for: {callories / 2000} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value }, Best before: {match.Groups[3].Value }, Nutrition: {match.Groups[4].Value }");
            }
        }
    }
}
