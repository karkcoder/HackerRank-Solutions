namespace Answers.Easy
{
    public class SockMerchant : IRun
    {
        public static int sockMerchant(List<int> ar)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            var pairs = 0;
            foreach (int a in ar)
            {
                if (keyValues.ContainsKey(a))
                {
                    if (keyValues[a] == 1)
                    {
                        keyValues[a] = 0;
                        pairs++;
                    }
                    else
                    {
                        keyValues[a] = 1;
                    }
                }
                else
                {
                    keyValues[a] = 1;
                }
            }
            return pairs;
        }

        public void Run()
        {
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(ar);

            Console.WriteLine(result);
        }
    }
}