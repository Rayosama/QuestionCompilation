using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0: //In the case that dayNum = 0, it will equal Sunday
                    dayName = "Sunday";
                    break; //special reserve word, that says we want to break out of the structer we're in
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: //This gets executed if none of the ones above are true
                    dayName = "Invalid day number";
                    break;
                
            }
            return dayName;
        }
    }
}
