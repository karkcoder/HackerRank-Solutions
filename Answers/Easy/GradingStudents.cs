namespace Answers.Easy
{
    internal class GradingStudents : IRun
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            var arr = grades.ToArray();
            var increment = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 38)
                {
                    var remainder = arr[i] % increment;
                    if (increment - remainder <= 2)
                    {
                        arr[i] = arr[i] + (increment - remainder);
                    }
                }
            }
            return arr.ToList();
        }

        public void Run()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}