using System.Runtime;

namespace Answers.Easy
{
    //ToDo
    public class GetTotalX : IRun
    {
        //Find number of all integers that: 1. are divided evenly by all numbers in first array, and 2. divide evenly all numbers from second array.
        public static int getTotalX(List<int> a, List<int> b)
        {
            List<int> cm = new List<int>();
            List<int> cf = new List<int>();

            var result = cm.Where(x => cf.Contains(x)).Count();
            return result;
        }

        public void Run()
        {
        }
    }
}