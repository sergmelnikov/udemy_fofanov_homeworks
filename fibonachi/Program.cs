using System;

namespace fibonachi
{
    class Program
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter numbers of Fibonaci > 2");
            int numbers = int.Parse(Console.ReadLine());
            int[] fibonaciArray = new int[numbers];
            fibonaciArray[0] = 1;
            fibonaciArray[1] = 1;

            for (int i = 2; i < numbers; i++)
            {
                fibonaciArray[i] = fibonaciArray[i - 2] + fibonaciArray[i - 1];
            }

            //for (int i = 0; i < fibonaciArray.Length; i++)
            //{
            //    Console.Write(fibonaciArray[i] + " ");
            //}

            foreach (int number in fibonaciArray)
            {
                Console.Write(fibonaciArray[number] + " ");
            }
        }
    }
}
