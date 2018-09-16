using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int[] primeSet = new int[50];
            for (int i = 0; i <= 98; i++) {
                for(int x = 0; x <= (i + 2); x++) {
                    if ((x + 2) == (i + 2))  {
                        primeSet[j] = i + 2;
                        j++;
                    } else if ((i + 2) % (x + 2) == 0) {
                        break;
                    }
                }
            }
            for (int i = 0; i < j; i++) {
                Console.Write(primeSet[i] + " ");
            }
        }
    }
}
