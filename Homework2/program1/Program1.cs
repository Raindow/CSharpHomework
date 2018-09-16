using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Please input an integer:  ");
                calculate();
                Console.Write("\n");
            }
            catch(Exception e) {
                Console.WriteLine("input error :" + e.Message);
            }
            finally {
                Console.Write("Please input a new integer:  ");
                calculate();
                Console.ReadKey();
            }

        }
        private static void calculate()
        {
            int userNum = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int PrimeNum = 0;
            while (userNum != 1) {

                if (userNum % 2 == 0) {
                    if (PrimeNum != 2) Console.Write("2 ");
                    PrimeNum = 2;
                    userNum /= 2;

                } else {

                    if ((userNum % (2 * i + 1)) == 0) {
                        if (PrimeNum != (2 * i + 1))  Console.Write($"{2 * i + 1} ");
                        userNum /= (2 * i + 1);
                        PrimeNum = 2 * i + 1;
                        i = 1;
                    } else {
                        i++;
                    }
                }
            }
         
        }
    }
}
