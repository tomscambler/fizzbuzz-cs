namespace FizzBuzz
{
    public class FizzBuzz
    {
        public bool IsDivisbleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }

        private static string ReverseInBatchesOf(int n, string message)
        {
            string result = "";

            while (message != "" )
            {
                result = message.Substring(0,n) + result;
                message = message.Substring(n);
            }
            
            return result;
        }
        public string FizzBuzzFor(int n)
        {     
            Rule ruleOfFizz     = new Rule("Fizz"    , "Add"    , 3  );
            Rule ruleOfBuzz     = new Rule("Buzz"    , "Add"    , 5  );
            Rule ruleOfBang     = new Rule("Bang"    , "Add"    , 7  );
            Rule ruleOfFezz     = new Rule("Fezz"    , "Add"    , 13 );
            Rule ruleOfBong     = new Rule("Bong"    , "Replace", 11 );
            Rule ruleOfFezzBong = new Rule("FezzBong", "Replace", 143);

            List<Rule> listOfRules = new List<Rule>()
            {
                ruleOfFizz,
                ruleOfBuzz,
                ruleOfBang,
                ruleOfFezz,
                ruleOfBong,
                ruleOfFezzBong
            };

            String answer = "";

            foreach(Rule rule in listOfRules)
            {
                answer = rule.ApplyTo(n, answer);
            }

            if (IsDivisbleBy(n,17))
            {
                answer = ReverseInBatchesOf(4, answer);
            }

            if (answer=="")
            {
                answer = n.ToString();
            }
            return answer;
        }
    }
}
