using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
       
        public static void Main()
        {
            // Take Hour & Minute input from user
            Console.WriteLine("Please enter hours : ");
            double hour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter minutes : ");
            double minute = Convert.ToDouble(Console.ReadLine());

            // Check Hour & Minute valid/invalid
            if (hour < 0 || minute < 0 || hour > 12 || minute > 60)
                Console.Write("Wrong input");

            if (hour == 12)
                hour = 0;

            if (minute == 60)
            {
                minute = 0;
                hour += 1;
                if (hour > 12)
                    hour = hour - 12;
            }

            // Calculate hour angles
            int hour_angle = (int)((hour * 360) / 12 + (minute * 360) / (12 * 60));

            // Calculate minute angles
            int minute_angle = (int)((minute * 360) / (60));
            
            // Find the difference between two angles
            int angle = Math.Abs(hour_angle - minute_angle);

            // smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            Console.WriteLine("Degree between hours & minutes :"+ angle);
            Console.ReadLine();
        }
       
    }
}
