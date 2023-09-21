using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любую русскую букву"); 
            var letter = Console.ReadKey().KeyChar;
            var letter1 = letter == 'я' ? 'а' : (char)(letter + 1);
                Console.Write(letter1);
            //не смогла поставить условие для разных алфавитов((
           

        }
    }
}
