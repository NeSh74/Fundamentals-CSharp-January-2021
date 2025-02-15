﻿using System;
using System.Text.RegularExpressions;

namespace _03_SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"%([A-Z][a-z]+)%[^|%$.]*<(\w+)>[^|%$.]*\|(\d+)\|[^|%$.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(patern);
            double totalPrice = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    double sum = price * count;
                    totalPrice += sum;
                    Console.WriteLine($"{customer}: {product} - {sum:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
