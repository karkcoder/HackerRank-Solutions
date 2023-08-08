namespace Answers.Easy
{
    public class BreakingRecords : IRun
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int? min = null;
            int? max = null;
            int maxCount = 0;
            int minCount = 0;

            foreach (var score in scores)
            {
                if (min == null && max == null) //initialization
                {
                    min = score;
                    max = score;
                }
                else if (score > max && score > min)
                {
                    maxCount++;
                    max = score;
                }
                else if (score < min && score < max)
                {
                    minCount++;
                    min = score;
                }
            }
            return new List<int>() { maxCount, minCount };
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}