﻿using System;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int convertFirstNumber;
            int convertSecondNumber;

            //Get user input for first number and convert from string to int
            String firstNumber;
            Console.Write("Enter the first number: ");
            firstNumber = Console.ReadLine();
            convertFirstNumber = Convert.ToInt32(firstNumber);

            //Get user input for second number and conver from string to int
            String secondNumber;
            Console.Write("Enter the second number: ");
            secondNumber = Console.ReadLine();
            convertSecondNumber = Convert.ToInt32(secondNumber);

            //call CalculateTotal method with int forms of firstnumber and secondnumber to calculate total
            var Calculator = new Calculate();
            int sumOfBothNumbers = Calculator.CalculateTotal(convertFirstNumber, convertSecondNumber);

            //causes cmd prompt to stay open for debugging
            Console.ReadLine();
        }
    }
}
