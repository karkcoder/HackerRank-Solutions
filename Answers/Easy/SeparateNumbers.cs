namespace Answers.Easy
{
    public class SeparateNumbers : IRun
    {
        //1234
        //91011
        //99100
        //101103
        //010203
        //13
        //1

        public static void separateNumbers(string s)
        {
            if (s.Substring(0, 1) == "0")
            {
                Console.WriteLine("NO");
            }
            var beautifulno = "0";
            var beautiful = false;
            var end = false;
            var half = s.Length / 2 + 1;

            for (int i = 1; i < half; i++) //incrementor, 1, 12, 123, 1234
            {
                var subPos = 0;
                beautifulno = s.Substring(0, i);
                int incr = i;
                var temp = i;
                while (end != true)
                {
                    //check if the next number is increment of one
                    //beautifulno = initNum;

                    var init = s.Substring(subPos, incr);
                    var initNum = Convert.ToInt32(init);

                    var expNextNum = initNum + 1;
                    incr = expNextNum.ToString().Length;
                    if (s.Length - (subPos + temp + incr) < 0)
                    {
                        break;
                    }
                    var actNextNumStr = s.Substring(subPos + temp, incr);
                    int actNextNum;
                    if (actNextNumStr.Substring(0, 1) == "0")
                    {
                        break;
                    }
                    else
                    {
                        actNextNum = Convert.ToInt32(actNextNumStr);
                    }

                    if (actNextNum == expNextNum)
                    {
                        subPos = subPos + initNum.ToString().Length;
                        incr = actNextNumStr.Length;
                        temp = incr;
                    }
                    else
                    {
                        break;
                    }

                    if (subPos + incr + 1 > s.Length && actNextNum == expNextNum)
                    {
                        beautiful = true;
                        end = true;
                        break;
                    }
                }

                if (beautiful == true)
                {
                    break;
                }
            }

            if (beautiful == false)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES " + beautifulno);
            }
        }

        public void Run()
        {
            string s = Console.ReadLine();
            separateNumbers(s);
        }
    }
}