using System;

namespace CalculatorApp
{
    public class Calculate
    {
        public int Operand1;
        public int Operand2;

        public int CalculateTotal()
        {
            return Operand1 + Operand2;
        }

        public int Subtraction()
        {
            return Operand1 - Operand2;
        }

        public void displayTotal()
        {
            Console.Write("The total of " + Operand1 + "+" + Operand2 + " is " + CalculateTotal());
        }

    }
}
