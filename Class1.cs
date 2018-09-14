using System;

namespace CalculatorApp
{
    public class Calculate
    {
        public int CalculateTotal(int a, int b)
        {
            //declare variable
            int total;

            //calculate total and write out to console
            total = a + b;
            Console.Write("The total of " + a + "+" + b + " is " + total);
            return total;
        }
    }
}
