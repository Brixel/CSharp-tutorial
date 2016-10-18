using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstConsoleApplication.Model;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = AskQuestion("What is your name?");
            Console.WriteLine($"Hello world: {name}");
            var dateOfBirthString = AskQuestion("When were you born?");
            string sex = AskQuestion("What is your sex? (m/v)");
            Person person = null;
            while (person == null)
            {
                switch (sex)
                {
                    case "m":
                        person = new Male();
                        break;
                    case "v":
                        person = new Female();
                        break;
                    default:
                        sex = AskQuestion("What is your sex? (m/v)");
                        break;
                }
            }
            var dateOfBirth = DateTime.Parse(dateOfBirthString);
            person.Name = name;
            person.BirthDate = dateOfBirth;
            Console.WriteLine($"If you were born on {person.FullBirthDate}, that means you must be {person.Age} now");
            Console.ReadLine();
        }
        

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            var response = Console.ReadLine();
            return response;
        }
    }
}
