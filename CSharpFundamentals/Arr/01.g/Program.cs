﻿using System;

namespace _01.g
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintWorddEven(grade);
        }

        private static void PrintWorddEven(double grade)
        { 
            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade < 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }



        }
    }
}