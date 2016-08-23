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
            Console.WriteLine("Hello world");
            string output = "Debugger";
            Console.WriteLine(output);
            var replacedOutput = output.Replace("ger", " me");
            Console.WriteLine(replacedOutput);
            Console.ReadLine();
        }
    }
}
