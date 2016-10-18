using System;
using Tutorial.Model;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = AskQuestion("What is your name?");
            Console.WriteLine($"Hello world: {name}");
            var dateOfBirthString = AskQuestion("When were you born?");
            string sex = AskQuestion("What is your sex? (m/v)");
            Human human = null;
            while (human == null)
            {
                switch (sex)
                {
                    case "m":
                        human = new Male();
                        break;
                    case "v":
                        human = new Female();
                        break;
                    default:
                        sex = AskQuestion("What is your sex? (m/v)");
                        break;
                }
            }
            var dateOfBirth = DateTime.Parse(dateOfBirthString);
            human.Name = name;
            human.BirthDate = dateOfBirth;
            Console.WriteLine($"If you were born on {human.FullBirthDate}, that means you must be {human.Age} now");
            human.SayBirthDayMessage();
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
