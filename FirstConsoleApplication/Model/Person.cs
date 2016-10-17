using System;

namespace FirstConsoleApplication.Model
{
    public class Person
    {
        public Person()
        {
        }

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public static int CalculateAge(DateTime date)
        {

            var dateNow = DateTime.Now;
            int age = dateNow.Year - date.Year;
            if (date > dateNow.AddYears(-age))
                age--;
            return age;
        }
    }
}