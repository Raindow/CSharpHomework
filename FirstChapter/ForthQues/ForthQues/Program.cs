using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthQues
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            double a, b;
            Console.Write("Please input First number: ");
            num = Console.ReadLine();
            a = Double.Parse(num);
            Console.Write("Please input Second number: ");
            num = Console.ReadLine();
            b = Double.Parse(num);
            Console.WriteLine($"The sum of {a} and {b} is: {a * b}");
        }
    }
}
