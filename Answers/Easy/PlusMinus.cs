namespace Answers.Easy
{
    public class PlusMinus : IRun
    {
        public static void plusMinus(List<int> arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            int arrLength = arr.Count();

            foreach (var a in arr)
            {
                if (a < 0)
                {
                    neg++;
                }
                else if (a > 0)
                {
                    pos++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine(((float)pos / arrLength).ToString("0.000000"));
            Console.WriteLine(((float)neg / arrLength).ToString("0.000000"));
            Console.WriteLine(((float)zero / arrLength).ToString("0.000000"));
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }
    }
}