using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", System.Globalization.CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", System.Globalization.CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
