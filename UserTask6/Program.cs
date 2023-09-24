using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace UserTask6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("[поздаровайся с дневником Тома Реддла:)]");
            string hi = Console.ReadLine();
            Console.WriteLine("Как Вас зовут?");
            string name =  Console.ReadLine();
            Console.WriteLine("Привет, " + name + "\n[спроси что нибудь о тайной комнате у дневника]");
            string question = Console.ReadLine();
            Console.WriteLine("Да");
            string request = Console.ReadLine();
            Console.Write("Нет");
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("...но могу показать...");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
