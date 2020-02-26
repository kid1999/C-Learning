using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAble_4
{
    class Program
    {

        static void func1()
        {
            int? a = null;
            int? b = 22;
            double? c = new double?();
            double? d = 3.14;

            bool? flag = new bool?();

            // show
            Console.WriteLine("{0},{1},{2},{3}", a, b, c, d);
            Console.WriteLine(flag);
        }

        static void func2()
        {
            double c;
            double? a = null;
            double? b = 5.21321;
            c = a ?? 5.2;
            Console.WriteLine(c);
            c = b ?? 5.2;
            Console.WriteLine(c);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            func1();
            func2();
        }
    }
}
