﻿using System;

namespace IRCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter loan amount: ");
            var loan = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter time in years: ");
            var years = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter interest rate: ");
            float interestRate = float.Parse(Console.ReadLine());

            InterestRateCalculator calc = new InterestRateCalculator(loan, interestRate, years);

            calc.Calculate();

        }
    }
}