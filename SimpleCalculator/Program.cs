using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            string input = Console.ReadLine();

            int convertInputToNumber;
            int.TryParse(input, out convertInputToNumber);
            int number = 90;
            int result = 10 +10 - 100  +100 -number + convertInputToNumber;

        }
    }

}