using System;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            String firstNumber;
            String secondNumber;
            int convertFirstNumber;
            int convertSecondNumber;

            //Get user input for first number and convert from String to int
            Console.Write("Enter the first number: ");
            firstNumber = Console.ReadLine();
            convertFirstNumber = Convert.ToInt32(firstNumber);
            //Get user input for second number and convert from String to int
            Console.Write("Enter the second number: ");
            secondNumber = Console.ReadLine();
            convertSecondNumber = Convert.ToInt32(secondNumber);

            //Call Calculate function and assign convertFirstNumber, convertSecondNumber to public variables Operand1 and Operand2
            CalculateTotalAddition addition = new CalculateTotalAddition();
            addition.Operand1 = convertFirstNumber;
            addition.Operand2 = convertSecondNumber;
            //Call Calculate function and assign convertFirstNumber, convertSecondNumber to public variables Operand1 and Operand2
            CalculateTotalSubtraction subtraction = new CalculateTotalSubtraction();
            subtraction.Operand1 = convertFirstNumber;
            subtraction.Operand2 = convertSecondNumber;

            //Call displayTotal function to display total
            addition.displayTotal();

            //Call displayTotal function to display subtraction total
            subtraction.displayTotal();

            //causes cmd prompt to stay open for debugging
            Console.ReadLine();
        }
    }
}
