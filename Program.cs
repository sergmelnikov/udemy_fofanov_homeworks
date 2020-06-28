using System;

namespace homework_2_2
{
    class Program
    {
        static void Main7(string[] args)
        {
            //Console.WriteLine("Enter lengths of triangle");
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());

            //double p = (a + b + c) / 2;
            //double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //Console.WriteLine($"Triangle area is {area:F}");


            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();

            Console.WriteLine("Enter your weight in kg");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height in m");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string profile = $"Your profile:{Environment.NewLine}"
                + $"Full Name: {lastName} {firstName}{Environment.NewLine}"
                + $"Age: {age}{Environment.NewLine}"
                + $"Weight: {weight}{Environment.NewLine}"
                + $"Height: {height}{Environment.NewLine}"
                + $"BMI: {bmi}";
            Console.WriteLine(profile);



        }
    }
}
