using System;

namespace AngleBetweenHourAndMinute
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter hours :");
			int hours = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter minutes :");
			int minutes = int.Parse(Console.ReadLine());
			if (hours < 0 || minutes < 0 || hours > 12 || minutes > 60)
			{
				Console.WriteLine("Please enter correct input.");
			}
			else
			{
				if (hours == 12)
					hours = 0;
				if (minutes == 60)
					minutes = 0;

				double hourHandAngle = 0.5 * (hours * 60 + minutes);
				int minuteHandAngle = 6 * minutes;

				double angle = Math.Abs(hourHandAngle - minuteHandAngle);
				Console.WriteLine("Angle between hands is :" + angle);
			}	}
    }
}
