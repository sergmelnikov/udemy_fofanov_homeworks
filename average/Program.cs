using System;

namespace average
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter no more then 10 numbers");
            int numbers = 0;
            int sum = 0;

            while (numbers < 10)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else
                {
                    sum += number;
                    numbers++;
                }
            }

            if (numbers == 0)
            {
                numbers++;
            }

            double avg = (double)sum / numbers;
            Console.WriteLine($"Average numbers equal {avg}");
        }
    }
}
