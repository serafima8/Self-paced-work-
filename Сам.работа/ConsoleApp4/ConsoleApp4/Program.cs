using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, вариант 6.
            //Разработать программу с использованием класса StringBuilder, которая для заданной строки s:заменяет все группы стоящих рядом точек на многоточие.

            // 1 способ:
            //Console.Write("Введите строку: ");
            //string s1;
            //s1 = Console.ReadLine();
            //string s2 = s1.Replace(".", "...");
            //Console.WriteLine(s2);

            // 2 способ:
            //Console.Write("Введите строку: ");
            //string s;
            //s = Console.ReadLine();
            //StringBuilder sb1 = new StringBuilder($"{s}");
            //sb1.Replace(".", "...");
            //Console.WriteLine(sb1);

            Console.ReadKey();

        }
    }
}
