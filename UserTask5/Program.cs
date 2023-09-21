using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите обычную стоимость бутылки");
            int normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение скидки в процентах");
            int salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = int.Parse(Console.ReadLine());
            int plus = (normPrice *  salePrice)/100;
            int bottles = holidayPrice / plus;
            Console.WriteLine("Количество беспошлинных бутылок: " + bottles);
        }
    }
}
