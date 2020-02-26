using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                arr[i] = i * i;
            }

            foreach(int k in arr)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
    }
}
