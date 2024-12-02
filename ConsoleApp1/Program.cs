using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Определить статический метод int Kop (int r, int k), 
    /// который принимает два целых аргумента (рубли r, копейки k) и возвращает количество копеек. 
    /// Используя этот метод, вычислить количество копеек при
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Vvod("Кол-во рублей ");
            int k = Vvod("Кол-во копеек ");
            Add("Кол-во копеек=", Kop (r, k));
            Console.ReadKey();
        }
        public static int Kop (int r, int k)
        {
            return r * 100 + k;
        }
        public static int Vvod(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Add(string message, int r)
        {
            Console.WriteLine($"{message} {r}");
        }
    }
}