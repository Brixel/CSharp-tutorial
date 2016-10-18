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
    }
}