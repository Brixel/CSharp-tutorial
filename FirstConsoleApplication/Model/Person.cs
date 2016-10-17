using System;
using System.Globalization;

namespace FirstConsoleApplication.Model
{
    public class Person
    {
        public Person()
        {
        }

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public string FullBirthDate => string.Format(BirthDate.Day + " " +
                                                     CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(BirthDate.Month) + " " +
                                                     BirthDate.Year);

        public int Age => CalculateAge();

        private int CalculateAge()
        {
            var dateNow = DateTime.Now;
            var age = dateNow.Year - BirthDate.Year;
            if (BirthDate > dateNow.AddYears(-age))
                age--;
            return age;
        }
    }

    public class Female : Person
    {
        
    }

    public class Male : Person
    {
        
    }
}