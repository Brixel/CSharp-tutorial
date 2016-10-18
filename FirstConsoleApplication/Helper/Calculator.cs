using System;

namespace Tutorial.Helper
{
    public class Calculator
    {
        public static int GetAge(DateTime birthDate)
        {
            var dateNow = DateTime.Now;
            var age = dateNow.Year - birthDate.Year;
            if (birthDate > dateNow.AddYears(-age))
                age--;
            return age;
        }

        public static int GetDaysLeft(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime next = birthDate.AddYears(today.Year - birthDate.Year);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;
            return numDays;
        }
    }

    public interface ICalculator
    {
        int GetAge(DateTime birthDate);
    }
}