﻿using System;
using System.Numerics;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write(factorial);

            Console.ReadLine();
        }
    }
}