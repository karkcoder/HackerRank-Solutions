using Answers.Easy;
using System.Threading.Tasks.Sources;

namespace Answers.Medium
{
    public class BiggerIsGreater : IRun
    {
        public static string biggerIsGreater(string w)
        {
            var wArr = w.ToCharArray();
            var endPos = 0;
            var swapPos = 0;

            //find where the difference is
            for (int i = wArr.Count() - 1; i > 0; i--)
            {
                if (wArr[i - 1] < wArr[i])
                {
                    endPos = i;
                    break;
                }
            }
            if (endPos == 0)
            {
                return "no answer";
            }

            //get smallest num in right array that is greater
            var str = string.Empty;
            for (int i = endPos; i < wArr.Length; i++)
            {
                if (wArr[endPos - 1] < wArr[i])
                {
                    str += wArr[i];
                }
            }
            var smallestChar = str.ToCharArray();
            Array.Sort(smallestChar);
            swapPos = Array.LastIndexOf(wArr, smallestChar[0]);

            var temp = wArr[swapPos];
            wArr[swapPos] = wArr[endPos - 1];
            wArr[endPos - 1] = temp;

            Array.Sort(wArr, endPos, wArr.Length - endPos);

            return new string(wArr);
        }

        public void Run()
        {
            //int T = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int TItr = 0; TItr < T; TItr++)
            //{
            string w = Console.ReadLine();

            string result = biggerIsGreater(w);

            Console.WriteLine(result);
            //}
        }
    }
}