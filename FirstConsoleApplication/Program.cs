using System;
using System.Collections.Generic;
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
            var age = AskQuestion("What is your age?");
            Console.WriteLine($"Your age: {age}");
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
