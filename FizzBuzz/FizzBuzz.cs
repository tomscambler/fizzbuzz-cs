namespace FizzBuzz
{
    public class FizzBuzz
    {
        private static bool IsDivisbleBy(int numerator, int denominator)
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
            String answer = "";

            if (IsDivisbleBy(n,3))
            {
                answer += "Fizz";
            }
            if (IsDivisbleBy(n,13))
            {
                answer += "Fezz";
            }
            if (IsDivisbleBy(n,5))
            {
                answer += "Buzz";
            }
            if (IsDivisbleBy(n,7))
            {
                answer += "Bang";
            }
            if (IsDivisbleBy(n,11))
            {
                answer  = "Bong";
            }
            if (IsDivisbleBy(n,143))
            {
                answer  = "FezzBong";
            }
            if (IsDivisbleBy(n,17))
            {
                answer = ReverseInBatchesOf(4, answer);
            }
            if (answer=="")
            {
                answer += n.ToString();
            }
            return answer;
        }
    }
}
