namespace Answers.Easy
{
    public class RotateLeft : IRun
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            var arrCount = arr.Count();
            var arr1 = arr.ToArray();
            int[] result = new int[arrCount];
            d = d % arr.Count;

            for (int i = d; i < arr.Count; i++) //4 - 1 2 3 4 5
            {
                result[i - d] = arr[i];
            }

            for (int i = 0; i < d; i++)
            {
                result[arr.Count() - d + i] = arr[i];
            }

            return result.ToList();
        }

        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}