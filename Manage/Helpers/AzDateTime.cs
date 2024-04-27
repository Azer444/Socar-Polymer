using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Helpers
{
    public class AzDateTime
    {
        public static DateTime Now
        {
            get
            {
                return TimeZoneInfo.ConvertTime(DateTime.UtcNow, tzi());
            }
        }

        public static TimeZoneInfo tzi()
        {
            TimeZoneInfo zi;
            try
            {
                zi = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
            }
            catch (Exception)
            {
                zi = TimeZoneInfo.FindSystemTimeZoneById("Asia/Baku");
            }
            return zi;
        }
    }
}
