using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c) { Console.WriteLine(a + b + c); }
            else if (b > a && b > c && a > c) { Console.WriteLine(b + a + c); }
            else if (c > a && c > b && b > a) { Console.WriteLine(c + b + a); }
            Console.ReadKey();
        } }
    }
    
