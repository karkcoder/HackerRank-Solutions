namespace Answers.Easy
{
    public class SaveThePrisoner : IRun
    {
        public static int saveThePrisoner(int n, int m, int s)
        {

            var newStartPrisoner = s % n; //where prisoner will start on the last cycle
            var newCandyNumber = m % n; //how many candies are left on last cycle

            if (newStartPrisoner == 0)
            {
                newStartPrisoner = n; //if the start prisoner is 0 that means the last cycle was the end of prisoners, hence we start point to that prisoner.
            }

            var victim = (newStartPrisoner + (newCandyNumber - 1)) % n; // adding -1 so we are starting at the start prisoner rather than the next prisoner to start prisoner
            if (victim == 0) // if there is no remainder means it ended on last cycle, hence set the value to the last prisoner
            {
                victim = n;
            }

            return victim;
        }

        public void Run()
        {
            while (1 == 1)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }
    }
}