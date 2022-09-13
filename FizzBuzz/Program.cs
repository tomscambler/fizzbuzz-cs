using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rule> listOfRules = new List<Rule>()
            {
                new Rule("Fizz"    , "Add"    , 3  ),
                new Rule("Fezz"    , "Add"    , 13 ),
                new Rule("Buzz"    , "Add"    , 5  ),
                new Rule("Bang"    , "Add"    , 7  ),
                new Rule("Bong"    , "Replace", 11 ),
                new Rule("FezzBong", "Replace", 143),
                new Rule(""        , "Reverse", 17 )
            };

            FizzBuzz fizzBuzz = new FizzBuzz(listOfRules);

            int MAX;
            string userInputInteger;

            do 
            {
                Console.WriteLine("How many numbers would you like to print?");
                userInputInteger = Console.ReadLine();
            }
            while (!int.TryParse(userInputInteger, out MAX));

            for (int i = 1; i <= MAX; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzFor(i));
            }
        }
    }
}
