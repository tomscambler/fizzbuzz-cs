using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            int MAX;
            string value;

            do 
            {
                Console.WriteLine("How many numbers would you like to print?");
                value = Console.ReadLine();
            }
            while (!int.TryParse(value, out MAX));

            for (int i = 1; i <= MAX; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzFor(i));
            }
            
        }
    }
}
