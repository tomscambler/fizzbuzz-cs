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

        public bool IsDivisbleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }

        public string ApplyTo(int testNumber, string resultString)
        {
            if ( IsDivisbleBy(testNumber,divisibilityTest) )
            {
                if (mode == "addon")
                {
                    return resultString + keyword;
                }
                else if (mode == "overwrite")
                {
                    return keyword;
                }
            }
            return resultString;
        }
    }
}