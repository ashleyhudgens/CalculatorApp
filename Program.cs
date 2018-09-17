using System;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            String typeOfArithmetic;
            String firstNumber;
            String secondNumber;
            int convertFirstNumber;
            int convertSecondNumber;

            //Get user input per arithmetic type
            Console.Write("What type of arithmetic? Addition, Subtraction, Division or Multiplication: ");
            typeOfArithmetic = Console.ReadLine();

            //Get user input for first number and convert from String to int
            Console.Write("Enter the first number: ");
            firstNumber = Console.ReadLine();
            convertFirstNumber = Convert.ToInt32(firstNumber);
            //Get user input for second number and convert from String to int
            Console.Write("Enter the second number: ");
            secondNumber = Console.ReadLine();
            convertSecondNumber = Convert.ToInt32(secondNumber);

            if (typeOfArithmetic.ToLower() == "addition")
            {
                //Call Calculate function and assign convertFirstNumber, convertSecondNumber to public variables Operand1 and Operand2
                CalculateTotalAddition addition = new CalculateTotalAddition();
                addition.Operand1 = convertFirstNumber;
                addition.Operand2 = convertSecondNumber;
                //Call displayTotal function to display total
                addition.displayTotal();
            }
            else if (typeOfArithmetic.ToLower() == "subtraction")
            {
                //Call Calculate function and assign convertFirstNumber, convertSecondNumber to public variables Operand1 and Operand2
                CalculateTotalSubtraction subtraction = new CalculateTotalSubtraction();
                subtraction.Operand1 = convertFirstNumber;
                subtraction.Operand2 = convertSecondNumber;
                //Call displayTotal function to display subtraction total
                subtraction.displayTotal();
            }
            else if (typeOfArithmetic.ToLower() == "division")
            {
                //Call Division function and assigne convertFirstNumber, converSecondNumber to public variables Operand1 and Operand2
                CalculateTotalDivision division = new CalculateTotalDivision();
                division.Operand1 = convertFirstNumber;
                division.Operand2 = convertSecondNumber;
                //Call displayTotal Function to display subtraction total
                division.displayTotal();
            }
            else if (typeOfArithmetic.ToLower() == "multiplication")
            {
                //Call Multiplication function and assigne convertFirstNumber, converSecondNumber to public variables Operand1 and Operand2
                CalculateTotalMultiplication multiplication = new CalculateTotalMultiplication();
                multiplication.Operand1 = convertFirstNumber;
                multiplication.Operand2 = convertSecondNumber;
                //Call displayTotal Function to display subtraction total
                multiplication.displayTotal();
            }
            else
            {
                Console.Write("Invalid Arithmetic Type");
            }

            //causes cmd prompt to stay open for debugging
            Console.ReadLine();
        }
    }
}
