using Answers.Easy;

namespace Answers.Medium
{
    public class PickingNumbers : IRun

    {
        public static int pickingNumbers(List<int> a)
        {
            int count = 1;
            var r = 0;
            //4 6 5 3 3 1
            var arr = a.ToArray();
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 >= arr.Length)
                {
                    r = r + 1;
                    return r;
                }
                if (Math.Abs(arr[i + 1] - arr[i]) < 2)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (r < count)
                {
                    r = count;
                }
            }
            r = r + 1;
            return r;
        }

        public void Run()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
    }
}