﻿using System;
using System.Numerics;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxSnowballValue = -1;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
