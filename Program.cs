using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, z1, z2;
            Console.WriteLine("a=");
            a = Convert.ToDouble(Console.ReadLine());
            z1 = (Math.Cos(a) + Math.Sin(a)) / (Math.Cos(a) - Math.Sin(a));
            Console.WriteLine(z1);
            z2 = (Math.Tan(2 * a) + 1 / Math.Cos(2 * a));
            Console.WriteLine(z2);
            Console.ReadLine();
        }
    }
}
