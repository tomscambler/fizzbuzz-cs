using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh, hai!");
            Console.WriteLine("Arguments used: ");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
