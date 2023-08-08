namespace Answers.Easy
{
    public class SimpleArraySum : IRun
    {
        public static int simpleArraySum(List<int> ar)
        {
            var arr = ar.ToArray();
            var sum = 0;
            foreach (var a in arr)
            {
                sum = sum + a;
            }
            return sum;
        }

        public void Run()
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = simpleArraySum(ar);
            Console.WriteLine(result);
        }
    }
}