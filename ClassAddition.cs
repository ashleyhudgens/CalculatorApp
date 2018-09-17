using System;

namespace CalculatorApp
{
    public class CalculateTotalAddition
    {
        public int Operand1;
        public int Operand2;

        public int CalculateTotal()
        {
            return Operand1 + Operand2;
        }

        public void displayTotal()
        {
            Console.WriteLine("The total of " + Operand1 + "+" + Operand2 + " is " + CalculateTotal());
        }

    }
}
