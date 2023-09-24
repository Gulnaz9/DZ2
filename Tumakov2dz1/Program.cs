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
            Console.WriteLine("Напишите любую букву"); 
            var letter = Console.ReadKey().KeyChar;
            if(letter=='z')
            {
                Console.WriteLine('a');
            }
            else if (letter == 'я')
            { 
                Console.WriteLine('а');
            }
            else
            {
                Console.WriteLine((char)(letter + 1));
            }
            
           

        }
    }
}
