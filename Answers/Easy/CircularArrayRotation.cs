namespace Answers.Easy
{
    public class CircularArrayRotation : IRun
    {
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            var arr = a.ToArray();
            var rArray = new int[arr.Length];
            var q = queries.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + k < arr.Length)
                {
                    rArray[i + k] = arr[i];
                }
                else
                {
                    var pos = i + k - arr.Length;
                    rArray[pos] = arr[i];
                }
            }

            for (int i = 0; i < q.Length; i++)
            {
                q[i] = rArray[q[i]];
            }

            return q.ToList();
        }

        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int q = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<int> result = circularArrayRotation(a, k, queries);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}