namespace Answers.Easy
{
    public class SuperDigit : IRun
    {
        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string n = firstMultipleInput[0];

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int result = superDigit(n, k);

            Console.WriteLine(result);
        }

        public static int superDigit(string n, int k)
        {
            if (n.Length == 1)
            {
                return Convert.ToInt32(n);
            }
            var cArray = n.ToArray();
            long total = 0;
            foreach (var c in cArray)
            {
                total = total + (int)char.GetNumericValue(c);
            }
            total = total * k;
            return superDigit(total.ToString(), 1);
        }
    }
}