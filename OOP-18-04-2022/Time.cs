using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_18_04_2022
{
    public class Time
    {
        private int hour, minutes, seconds;

        public Time()
        {
        }
        public Time(int hour, int minutes, int seconds)
        {
            //this.hour = hour;
            //this.minutes = minutes;
            //this.seconds = seconds;
            SetHour(hour);
            SetMinutes(minutes);
            SetSeconds(seconds);
        }

        public void SetHour(int hour)
        {
            if (hour < 0 || hour > 23)
            {
                Console.WriteLine($"Invalid value for hour: {hour}");
                return;
            }

            this.hour = hour;
        }

        public int GetHour()
        {
            return hour;
        }
        public void SetMinutes(int minutes)
        {
            if (minutes < 0 || minutes > 59)
            {
                Console.WriteLine($"Invalid value for minutes: {minutes}");
                return;
            }

            this.minutes = minutes;
        }

        public int GetMinutes()
        {
            return minutes;
        }

        public void SetSeconds(int seconds)
        {
            if (seconds < 0 || seconds > 59)
            {
                Console.WriteLine($"Invalid value for seconds: {seconds}");
                return;
            }

            this.seconds = seconds;
        }

        public int GetSeconds()
        {
            return seconds;
        }

        public string GetTime()
        {
            return $"{hour}:{minutes}:{seconds}";
        }

    }
}
