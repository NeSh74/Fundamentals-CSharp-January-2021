﻿using System;

namespace _09_Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            int lightsaberCounter = (int)Math.Ceiling(countOfStudents * 1.1);
            int beltCounter = countOfStudents - countOfStudents / 6;

            double totalAmount = priceOfLightsaber * lightsaberCounter +
                                 priceOfRobe * countOfStudents +
                                 priceOfBelt * beltCounter;
            if (amountOfMoney >= totalAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalAmount - amountOfMoney:f2}lv more.");
            }
        }
    }
}

