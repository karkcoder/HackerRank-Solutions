namespace Answers.Easy
{
    //Todo
    public class MinimumBribes : IRun
    {
        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                minimumBribes(q);
            }
        }

        public static void minimumBribes(List<int> q)
        {
            int numBribes = 0;
            bool isChaotic = false;

            var arr = q.ToArray<int>();
            for (int i = 0; i < q.Count; i++)
            {
            }
        }
    }
}