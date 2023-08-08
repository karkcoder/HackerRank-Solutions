using System.IO;

namespace Answers.Easy
{
    public class FindDigit : IRun
    {
        public static int findDigits(int n)
        {
            var arr = n.ToString().ToCharArray();
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var temp = Convert.ToInt32(arr[i].ToString());
                if (temp != 0)
                {
                    if (n % temp == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = findDigits(n);

            Console.WriteLine(result);
        }
    }
}