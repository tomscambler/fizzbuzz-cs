namespace FizzBuzz
{
    public class Rule
    {
        public string keyword;
        public string mode;
        public int    divisibilityTest;

        public Rule(string keyword, string mode, int divisibilityTest)
        {
            this.keyword          = keyword;
            this.mode             = mode;
            this.divisibilityTest = divisibilityTest;
        }
        private bool IsAMultipleOf(int denominator, int numerator)
        {
            return numerator % denominator == 0;
        }
        private string ReverseInBatchesOf(int n, string message)
        {
            string result = "";

            while (message != "" )
            {
                result  = message.Substring(0,n) + result;
                message = message.Substring(n);
            }
            return result;
        }
        public string ApplyTo(int testNumber, string resultString)
        {
            if (IsAMultipleOf(divisibilityTest, testNumber))
            {
                switch(mode)
                {
                    case "Add":
                        return resultString + keyword;
                    case "Replace":
                        return keyword;
                    case "Reverse":
                        return ReverseInBatchesOf(4, resultString);
                    default:
                        return resultString;
                }
            }
            return resultString;
        }
    }
}