﻿using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 30;
            for (int i = 1; i <= max; i++)
            {
                {
                    Console.WriteLine($"{FizzBuzz(i)}");
                }
            }
        }
        public static string FizzBuzz(int n)
        {
            if (n % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (n % 3 == 0)
            {
                return "Fizz";
            } 
            if (n % 5 == 0)
            {
                return "Buzz";
            }
            else
                return n.ToString();
            //throw new NotImplementedException();
        }
    }
}
