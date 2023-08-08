namespace Answers.Easy
{
    public class BonAppetit : IRun
    {
        public static void bonAppetit(List<int> bill, int k, int b) //k = anna denial of food, b = anna contribution
        {
            var arr = bill.ToArray();
            bool owe = false;

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            var annaBill = (sum - arr[k]) / 2;
            var annaRefund = b - annaBill;

            if (annaRefund > 0)
            {
                Console.WriteLine(annaRefund);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }

        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}