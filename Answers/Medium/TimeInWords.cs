using Answers.Easy;

namespace Answers.Medium
{
    public class TimeInWords : IRun
    {
        public static string timeInWords(int h, int m)
        {
            var p = new string[]
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen",
                "twenty",
                "twenty one",
                "twenty two",
                "twenty three",
                "twnety four",
                "twenty five",
                "twenty six",
                "twenty seven",
                "twenty eight",
                "twenty nine"
            };

            var pronounce = string.Empty;
            if (m == 30)
            {
                pronounce = "half past " + p[h - 1];
            }
            else if (m == 0)
            {
                pronounce = p[h - 1] + " o' clock";
            }
            else if (m == 15)
            {
                pronounce = "quarter past " + p[h - 1];
            }
            else if (m == 45)
            {
                pronounce = "quarter to " + p[h];
            }
            else if (m > 0 && m < 30)
            {
                var plural = string.Empty;
                if (m > 1)
                {
                    plural = "s";
                }
                pronounce = p[m - 1] + " minute" + plural + " past " + p[h - 1];
            }
            else if (m < 60 && m > 3)
            {
                var r = 60 - m;
                var plural = string.Empty;
                if ((60 - m) > 1)
                {
                    plural = "s";
                }
                pronounce = p[r - 1] + " minute" + plural + " to " + p[h];
            }

            return pronounce;
        }

        public void Run()
        {
            int h = Convert.ToInt32(Console.ReadLine().Trim());

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
        }
    }
}