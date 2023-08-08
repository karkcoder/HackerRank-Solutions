namespace Answers.Easy
{
    public class MigratoryBirds : IRun
    {
        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (var a in arr)
            {
                if (result.ContainsKey(a))
                {
                    var value = result.GetValueOrDefault(a);
                    value++;
                    result[a] = value;
                }
                else
                    result.Add(a, 1);
            }

            var z = result.Max(x => x.Value);

            var r = result.Where(x => x.Value == z).OrderBy(x => x.Key).FirstOrDefault();
            return r.Key;
        }

        public void Run()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }
    }
}