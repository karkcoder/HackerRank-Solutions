using Answers.Easy;

namespace Answers
{
    public class Encryption : IRun
    {
        public static string encryption(string s)
        {
            s = s.Replace(" ", "");
            var l = s.Length;

            var sq = Math.Sqrt(l);
            var column = (int)Math.Ceiling(sq);
            var row = (int)Math.Floor(sq);

            if (column * row < s.Length)
            {
                row = row + 1;
            }

            var orderResult = new string[row];

            var stringPointer = 0;

            for (int r = 1; r <= row; r++)
            {
                if ((stringPointer + column) >= s.Length)
                {
                    orderResult[r - 1] = s.Substring(stringPointer, (s.Length - stringPointer));
                    break;
                }

                orderResult[r - 1] = s.Substring(stringPointer, column);
                stringPointer = stringPointer + column;
            }

            var finalResult = string.Empty;

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    var cArr = orderResult[j].ToCharArray();
                    if (i < cArr.Length)
                    {
                        finalResult = finalResult + cArr[i].ToString();
                    }
                }
                finalResult = finalResult + " ";
            }

            return finalResult.Trim();
        }

        public void Run()
        {
            string s = Console.ReadLine();
            string result = encryption(s);
            Console.WriteLine(result);
        }
    }
}