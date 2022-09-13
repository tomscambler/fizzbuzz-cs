namespace FizzBuzz
{
    public class Rule
    {
        public string keyword;
        public string mode;
        public int    divisibilityTest;
        public int    testNumber;
        public string resultString;

        public Rule(string keyword, string mode, int divisibilityTest)
        {
            this.keyword          = keyword;
            this.mode             = mode;
            this.divisibilityTest = divisibilityTest;
        }

        private bool IsDivisbleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
        private string ReverseInBatchesOf(int n, string message)
        {
            string result = "";

            while (message != "" )
            {
                result = message.Substring(0,n) + result;
                message = message.Substring(n);
            }
            return result;
        }

        public string ApplyTo(int testNumber, string resultString)
        {
            if ( IsDivisbleBy(testNumber,divisibilityTest) )
            {
                if (mode == "Add")
                {
                    return resultString + keyword;
                }
                else if (mode == "Replace")
                {
                    return keyword;
                }
                else if (mode == "Reverse")
                {
                    return ReverseInBatchesOf(4, resultString);
                }
            }
            return resultString;
        }
    }
}