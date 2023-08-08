namespace Answers.Easy
{
    public class GetMoneySpent : IRun
    {
        private static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var cost = 0;
            int? selectKB = null;
            int? selectDR = null;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    var tempCost = keyboards[i] + drives[j];
                    if (tempCost <= b && tempCost > cost && tempCost <= b)
                    {
                        cost = keyboards[i] + drives[j];
                        selectKB = i;
                        selectDR = j;
                    }
                }
            }

            if (selectDR != null && selectKB != null)
            {
                return keyboards[(int)selectKB] + drives[(int)selectDR];
            }

            return -1;
        }

        public void Run()
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }
    }
}