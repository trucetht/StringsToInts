using System;

namespace StringsToInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string myName = Console.ReadLine();

            Console.WriteLine($"Hello, {myName}");

            Console.WriteLine("What is your age");
            int myAge = Convert.ToInt32(Console.ReadLine());

            if (myAge > 30 || myAge < 30)
            {
                Console.WriteLine($"{myName}, you are not 30 years old");
            }
            if (myAge < 31 && myAge > 29)
            {
                Console.WriteLine($"{myName}, you are 30 years old");
            }
        }
    }
}
