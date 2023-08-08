namespace Answers.Easy
{
    public class TimeConversion : IRun
    {
        public static string timeConversion(string s)
        {
            //super easy way
            //DateTime d = new DateTime();
            //d = DateTime.Parse(s);

            //return (d.ToString("HH:mm:ss"));

            //12:01:01AM
            //0123456789

            var l = s.Length;
            var ampm = s.Substring(s.Length - 2, 2);
            var hour = Convert.ToInt32(s.Substring(0, 2));
            var min = Convert.ToInt32(s.Substring(3, 2));
            var second = Convert.ToInt32(s.Substring(6, 2));

            if (hour != 12 && ampm == "PM")
            {
                hour = hour + 12;
            }
            else if (hour == 12 && ampm == "AM")
            {
                hour = 0;
            }

            var milTime = string.Concat(hour.ToString("00"), ":", min.ToString("00"), ":", second.ToString("00"));
            return milTime;
        }

        public void Run()
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}