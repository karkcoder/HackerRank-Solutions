namespace Answers.Easy
{
    public class WeightedUniformStrings : IRun
    {
        public static List<string> weightedUniformStrings(string s, List<int> queries)
        {
            HashSet<int> sum = new HashSet<int>();
            var result = new List<string>();

            var l = s.Length;

            int a = 0;
            int dup = 1;

            while (a < l)
            {
                var ch = s.Substring(a, 1).ToCharArray();
                var chInt = ch[0] - 96;
                var chStr = ch[0].ToString();
                sum.Add(chInt);
                a++;

                if (a >= l)
                {
                    break;
                }

                if (chStr == s.Substring(a, 1))
                {
                    dup++;
                    sum.Add(chInt * dup);
                }
                else
                {
                    dup = 1;
                }
            }

            foreach (var q in queries)
            {
                if (sum.Contains(q))
                {
                    result.Add("Yes");
                }
                else
                    result.Add("No");
            }

            return result;
        }

        public void Run()
        {
            string s = "abccddde";

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> queries = new List<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<string> result = weightedUniformStrings(s, queries);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}