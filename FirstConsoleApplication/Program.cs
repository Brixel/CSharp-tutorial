using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = AskQuestion("What is your name?");
            Console.WriteLine($"Hello world: {name}");
            //var age = AskQuestion("What is your age?");
            var dateOfBirthString = AskQuestion("When were you born?");
            var dateOfBirth = DateTime.Parse(dateOfBirthString);
            var age = CalculateAge(dateOfBirth);
            var person = new Person()
            {
                Name = name,
                BirthDate = dateOfBirth
            };
            Console.WriteLine($"If you were born on {person.BirthDate.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(person.BirthDate.Month)} {person.BirthDate.Year}, that means you must be {age} now");
            Console.ReadLine();
        }

        private static int CalculateAge(DateTime date)
        {
            
            var dateNow = DateTime.Now;
            int age = dateNow.Year - date.Year;
            if (date > dateNow.AddYears(-age))
                age--;
            return age;
        }

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            var response = Console.ReadLine();
            return response;
        }
    }
}
