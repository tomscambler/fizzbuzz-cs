namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<Rule> listOfRules;
        public int maxNumber;
        public FizzBuzz(List<Rule> listOfRules, int maxNumber)
        {
            this.listOfRules = listOfRules;
            this.maxNumber = maxNumber;
        }

        public string FizzBuzzOfThisInteger(int n)
        {     
            String resultString = "";

            foreach(Rule rule in listOfRules)
            {
                resultString = rule.ApplyTo(n, resultString);
            }

            if (resultString=="")
            {
                resultString = n.ToString();
            }

            return resultString;
        }

        public void DoTheFizzBuzz()
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                Console.WriteLine(FizzBuzzOfThisInteger(i));
            }
        }
    }
}
