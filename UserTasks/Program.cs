using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tЧисловые целые\n   ");
            Console.WriteLine("byte\tmax=255 \t\t\t\tmin=0 \nsbyte\tmax=127\t\t\t\t\tmin=-128");
            Console.WriteLine("short\tmax=32767 \t\t\t\tmin=-32768 \nushort\tmax=65535\t \t\t\tmin=65535");
            Console.WriteLine("int\tmax=2147483647 \t\t\t\tmin=-2147483648 \nuint\tmax=4294967295\t\t\t\tmin=0");
            Console.WriteLine("long\tmax=9223372036854775807 \t\tmin=-9223372036854775808 \nulong\tmax=18446744073709551615\t\tmin=0");
            Console.WriteLine("   \n\t\tЧисловые с плавающей точкой\n   ");
            Console.WriteLine("float \tmax=3,402823E+38\t\t\tmin=-3,402823E+38 \ndouble\tmax=1,79769313486232E+308\t\tmin=-1,79769313486232E+308");
            Console.WriteLine("decimal\tmax=79228162514264337593543950335\tmin=-79228162514264337593543950335");
            Console.WriteLine("   \n\t\t\tСимвольные\n  ");
            Console.WriteLine("char\tmax=?   \t\t\t\tmin=N/A\nstring\tmax=N/A\t\t\t\t\tmin=N/A");
            Console.WriteLine("\t\t\tЛогические");
            Console.WriteLine("bool\tmax=True\t\t\t\tmin=False");
            Console.WriteLine("  \n\t\t\tОсобые");
            Console.WriteLine("object\tmax=N/A\t\t\t\t\tmin=N/A\ndynamic\tmax=N/A\t\t\t\t\tmin=N/A");
        }
    }
}
 