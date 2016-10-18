using System;
using System.Globalization;
using Tutorial.Helper;

namespace Tutorial.Model
{
    public abstract class Person
    {
        protected Person()
        {
        }

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public string FullBirthDate => string.Format(BirthDate.Day + " " +
                                                     CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(BirthDate.Month) + " " +
                                                     BirthDate.Year);

        public int Age => CalculateAge();
        protected abstract int CalculateAge();
        
    }

    public class Female : Person
    {
        
        protected override int CalculateAge()
        {
            var age = Calculator.GetAge(BirthDate);
            return --age;
        }
    }

    public class Male : Person
    {
        protected override int CalculateAge()
        {
            var age = Calculator.GetAge(BirthDate);
            return age;
        }
    }
}