using System.Text.RegularExpressions;

namespace AlgorithmnPractice
{
    internal class Program
    {
       
        static int Fib(int n)
        #region
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        #endregion

       
        static int Fib2 (int number)
        #region
        {
            if (number == 0 || number == 1) 
            {
                return number;
            }
            var currentPos = 2;
            var sLast = 0;
            var last = 1;
            while (currentPos <= number)
            {
                int temp = last;
                last = last + sLast;
                sLast = temp;
                currentPos++;
            }
            return last;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Fib2(11));

            string pattern = "(We)";
            Regex regex = new Regex(pattern);
            var text = "We are up for it. We are!";
            Match match = regex.Match(text);
            MatchCollection matches = regex.Matches(text);
        }
    }
}
