using System;
using System.IO;

namespace FileStream_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FileStream f = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            byte[] bs = new byte[255];
            f.Read(bs, 0, 255);
            Console.WriteLine(bs.ToString());
            Console.ReadKey();
            */

            try
            {
                using(StreamReader sr = new StreamReader(@"F:\Git\C#Learning\Helloword_1\FileStream_8\test.txt"))
                {
                    String line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
