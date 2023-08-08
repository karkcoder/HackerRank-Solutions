using Answers.Easy;

namespace Answers.Medium
{
    public class LarrysArray : IRun
    {
        public static string larrysArray(List<int> A)
        {
            return string.Empty;
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            string result = larrysArray(A);

            Console.WriteLine(result);
        }
    }
}