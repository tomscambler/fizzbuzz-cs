namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<Rule> listOfRules;
        public FizzBuzz(List<Rule> listOfRules)
        {
            this.listOfRules = listOfRules;
        }

        public string FizzBuzzFor(int n)
        {     
            String answer = "";

            foreach(Rule rule in listOfRules)
            {
                answer = rule.ApplyTo(n, answer);
            }

            if (answer=="")
            {
                answer = n.ToString();
            }
            return answer;
        }
    }
}
