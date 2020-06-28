using System;

namespace factorial
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter factorial number");
            int factorialNumber = int.Parse(Console.ReadLine());
            int factorialCounter = factorialNumber;
            int factorailResult = 1;

            while (factorialCounter > 0)
            {
                factorailResult *= factorialCounter;
                factorialCounter--;
            }

            Console.WriteLine($"{factorialNumber}! = {factorailResult}");
        }
    }
}
