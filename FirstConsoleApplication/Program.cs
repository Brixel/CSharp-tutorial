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
            int substringIndex = 5;
            Console.WriteLine(output);
            Console.WriteLine(output.ToUpper());
            var strippedPart = output.Substring(substringIndex);
            Console.WriteLine(strippedPart);
            Console.ReadLine();
        }
    }
}
