using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    class DateDifferenceCalculator
    {
        // İlk sürüm: Gün cinsinden farkı hesaplar
        public int CalculateDifference(DateTime date1, DateTime date2)
        {
            return (int)(date2 - date1).TotalDays;
        }

        // İkinci sürüm: Saat cinsinden farkı hesaplar
        public int CalculateDifferenceInHours(DateTime date1, DateTime date2)
        {
            return (int)(date2 - date1).TotalHours;
        }

        // Üçüncü sürüm: Yıl, ay ve gün cinsinden farkı hesaplar
        public (int years, int months, int days) CalculateDetailedDifference(DateTime date1, DateTime date2)
        {
            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(date1.Year, date1.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            return (years, months, days);
        }
    }
}
