using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_timeConversion_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;

            temp = int.Parse(Console.ReadLine());

            int hour = temp / 3600;
            temp = temp - (hour * 3600);

            int min = temp / 60;
            temp = temp - (min * 60);

            Console.WriteLine("{0}:{1}:{2}", hour, min, temp);
            Console.ReadKey();
        }
    }
}
