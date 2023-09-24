using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask2
{
    internal class Program
    {
        struct Student
        {

            public string name;

        }
        static void Main(string[] args)
        {
            Student student;
            student.name = "dfghj";

            Console.Write("Ваше имя - ");
            string name = Console.ReadLine();
            Console.Write("Ваш город - ");
            string city = Console.ReadLine();
            Console.Write("Ваш возраст - ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Ваш PIN-код - ");
            int pin = int.Parse(Console.ReadLine());
            //то, что вышло на консоли сохраняем как файл и печатаем


        }
    }
}
