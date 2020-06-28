using System;
using System.Collections.Generic;

namespace autentification
{
    class Program
    {
        static void Main3(string[] args)
        {
            string login = "johnsilver";
            string password = "qwerty";
            int leftTries = 3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter login");
                string enteredLogin = Console.ReadLine();

                Console.WriteLine("Enter password");
                string enteredPassword = Console.ReadLine();

                if (enteredLogin == login && enteredPassword == password)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
                else
                {
                    leftTries--;
                    Console.WriteLine($"Wrong login or password. Tries left: {leftTries}");
                }
            }
            if (leftTries == 0)
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }

            
            var people = new Dictionary<int, string>();
            people.Add(1, "John");


        }
    }
}
