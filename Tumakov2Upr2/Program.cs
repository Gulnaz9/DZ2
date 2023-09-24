using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2Upr2
{
    internal class Program
    {
        static void Main(string[] args)
        { //упр 2.2
            Console.WriteLine("Введите два целых числа, после каждого нажмите <Enter>"); 
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            if (b == 0)
            { Console.WriteLine("т.к. мы ищем частное, второе число не может равняться нулю"); }
            else { double q = a / b; 
                Console.WriteLine("Частное равно " + q); 
            }
            
        }
    }
}
