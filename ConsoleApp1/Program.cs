using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Определить статический метод int Centimeters (int m, int c), 
    /// который принимает два целых аргумента (метры m, сантиметры c) и возвращает количество сантиметров. 
    /// Используя этот метод, вычислить количество сантиметров для длины
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Vvod("Кол-во метров ");
            int c = Vvod("Кол-во сантиметров ");
            Add("Кол-во сантиметров=", Centimeters(m, c));
            Console.ReadKey();
        }
        public static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        public static int Vvod(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Add(string message, int m)
        {
            Console.WriteLine($"{message} {m}");
        }
    }
}
