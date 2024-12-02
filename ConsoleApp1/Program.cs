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
            double y = Fune(7) + Fune(11) + Fune(15);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        public static double Fune(int x)
        {
            return (Math.Sqrt(x) + x / 3);
        }
    }
}