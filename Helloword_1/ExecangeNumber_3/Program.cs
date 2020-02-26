using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecangeNumber_3
{
    class Program
    {

        // ref 引用类型
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // out 输出值给变量
        public void getValue(out int x)
        {
            int t = 5;
            x = t;
        }

    
        // 实例
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 1;
            int b = 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            // start
            Console.WriteLine("________________");

            p.swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);


            p.getValue(out a);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
