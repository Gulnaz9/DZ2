using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите какой нибудь текст");
            string str = Console.ReadLine();
            var strlook = str.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
            var strRedact = new string(strlook.ToArray());
            Console.WriteLine(strRedact);
        }
    }
}
