using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые коэффициенты квадратного уравнения (в порядке a-b-c,используя после каждого клавишу <Enter>)");
            double a = int.Parse(Console.ReadLine()); //парс чтобы присвоить "а" значение пользователя
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            //double D = b * b - 4 * a * c; простой вариант b в квадрате
            int stepen = 2;
            Math.Pow(b, stepen);
            double D = Math.Pow(b, stepen) - 4 * a * c;


            if (D < 0)
            {
                Console.WriteLine("Нет корней ");
            }
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a); //Sqrt = под корнем 
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("Корни уравнения: " + "х1=" + x1 + ", х2=" + x2);

            }
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корень уравнения: х=" + x);
            }
            }
    }
}
