using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Easy
{
    public class CompareTriplets : IRun
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var ar = a.ToArray();
            var br = b.ToArray();
            var awins = 0;
            var bwins = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < b[i])
                {
                    bwins++;
                }
                else if (ar[i] > b[i])
                {
                    awins++;
                }
            }

            var result = new int[2];
            result[0] = awins;
            result[1] = bwins;
            return result.ToList();
        }

        public void Run()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}