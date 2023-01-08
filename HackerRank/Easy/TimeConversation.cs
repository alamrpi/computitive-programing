using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.HackerRank.Easy
{
    public  class TimeConversation
    {
        public string Solution(string s)
        {
            var amOrPm = s.Substring(8);
            var hourComponent = s.Substring(0, 2);
            var remainingTimeComponent = s.Substring(2, 6);
            if (amOrPm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (amOrPm == "PM")
            {
                var numericHourComponent = int.Parse(hourComponent);
                if (numericHourComponent != 12)
                {
                    hourComponent = Convert.ToString(12 + numericHourComponent);
                }
            }

            return $"{hourComponent + remainingTimeComponent}";
        }
    }
}
