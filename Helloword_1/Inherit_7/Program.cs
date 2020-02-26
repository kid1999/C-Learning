using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_7
{
    class Program
    {

        class Father
        {
            public String name;
            public int age;

            public Father(String name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public void show()
            {
                Console.WriteLine("name:{0},age:{1}", name, age);
                Console.ReadKey();
            }
        }

        class Son : Father
        {
            public Son(string name, int age) : base(name, age){}

        }


        static void Main(string[] args)
        {
            Son son = new Son("kid", 20);
            son.show();
        }
    }
}
