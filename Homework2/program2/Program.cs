using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a series of numbers: ");
            string input = Console.ReadLine();//input.Split(' ');
            string[] array = Regex.Split(input.Trim(), " +", RegexOptions.IgnoreCase);
            double max = 0;
            double min = 0;
            double sum = 0;
            double average = 0;
            foreach(string i in array) {
                if (array[0] == i) {
                    max = Convert.ToDouble(i);
                    min = Convert.ToDouble(i);
                }
                if (max < Convert.ToDouble(i)) {
                    max = Convert.ToDouble(i);
                }
                if (min > Convert.ToDouble(i)) {
                    min = Convert.ToDouble(i);
                }
                sum += Convert.ToDouble(i);
            }
            average = sum * 1.0 / array.Length;
            Console.WriteLine($"max: {max}  min: {min}  sum: {sum}  average: {average}");
            Console.ReadKey();
        }
    }
}
