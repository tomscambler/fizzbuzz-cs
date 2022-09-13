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

            int maxNumber;
            string userInput;

            do 
            {
                Console.WriteLine("How many numbers would you like to print?");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out maxNumber));

            FizzBuzz fizzBuzz = new FizzBuzz(listOfRules, maxNumber);

            fizzBuzz.DoTheFizzBuzz();
        }
    }
}
