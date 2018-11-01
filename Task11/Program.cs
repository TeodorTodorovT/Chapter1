using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads your age from the console and prints your age after 10 years.

            Console.Write("Please enter your age: ");
            string AgeString = Console.ReadLine();
            int Age = Convert.ToInt32(AgeString);
            Console.WriteLine("In 10 years you will be {0}", Age + 10);
            Console.ReadLine();
        }
    }
}
