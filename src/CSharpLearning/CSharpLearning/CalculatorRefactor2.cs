﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class CalculatorRefactor2
    {
        static void Run()
        {

            double firstNumber = GetNumber("First");
            double secondNumber = GetNumber("Second");

            double result = AddNumbers(firstNumber, secondNumber);

            PrintResult(result);

            Console.ReadKey();
        }

        static double GetNumber(string whichNumber)
        {
            Console.Write($"{whichNumber} Number: ");
            string numberInput = Console.ReadLine();
            double number = double.Parse(numberInput);
            return number;
        }

        static double AddNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static void PrintResult(double result)
        {
            Console.WriteLine($"Your result is {result}.");
        }
    }
}
