using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Order customer = new Order();
                Console.WriteLine("your name：");
            }
            catch (ArgumentNullException e) {
                Console.WriteLine("there's no such thing");
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Invalid inpur");
            }
        }
    }
}
