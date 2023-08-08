using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Easy
{
    public class LibraryFine : IRun
    {
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var returned = string.Concat(m1.ToString(), "/", d1.ToString(), "/", y1.ToString());
            var borrowed = string.Concat(m2.ToString(), "/", d2.ToString(), "/", y2.ToString());
            DateTime b = new DateTime();
            DateTime r = new DateTime();

            b = DateTime.Parse(borrowed);
            r = DateTime.Parse(returned);

            int diffDays = Convert.ToInt32((r - b).TotalDays);
            if (diffDays <= 0)
            {
                return 0;
            }

            if (y1 != y2)
            {
                return 10000;
            }

            if (m1 == m2 && y1 == y2)
            {
                return 15 * diffDays;
            }
            else
            {
                return 500 * (m1 - m2);
            }
        }

        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d1 = Convert.ToInt32(firstMultipleInput[0]);

            int m1 = Convert.ToInt32(firstMultipleInput[1]);

            int y1 = Convert.ToInt32(firstMultipleInput[2]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d2 = Convert.ToInt32(secondMultipleInput[0]);

            int m2 = Convert.ToInt32(secondMultipleInput[1]);

            int y2 = Convert.ToInt32(secondMultipleInput[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }
    }
}