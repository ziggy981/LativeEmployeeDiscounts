using System;

namespace Lative.SharedKernel
{
    public static class DatesCalulator
    {
        public static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            int years = endDate.Year - startDate.Year;

            if (startDate.Month == endDate.Month && // if the start month and the end month are the same
                endDate.Day < startDate.Day // AND the end day is less than the start day
                || endDate.Month < startDate.Month) // OR if the end month is less than the start month
            {
                years--;
            }

            return years;
        }

    }
}
