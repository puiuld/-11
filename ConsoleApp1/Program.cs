using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// вычисление
    /// </summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            double y = Fune(15, 8) + Fune(6, 12) + Fune(7, 21);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        public static double Fune(int x, int z)
        {
            return (x + Math.Sqrt(z) / z + Math.Sqrt(x));
        }

    }
}