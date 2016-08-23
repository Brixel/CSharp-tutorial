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
            var replaceable = "ger";
            string output = $"Debug{replaceable}";
            Console.WriteLine(output);
            replaceable = " me";
            output = $"Debug{replaceable}";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
