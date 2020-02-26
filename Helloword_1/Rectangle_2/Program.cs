using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_2
{
 
    class Rectangle
    {
        // 成员变量
        double length;
        double width;
        // void 方法
        public void initData()
        {
            length = 4;
            width = 3;
        }

        // double 方法
        public double GetArea()
        {
            return length * width;
        }

        // void show 方法
        public void Display()
        {
            Console.WriteLine("lenth:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", GetArea());
        }   
    }


    // 实例对象
    class RunInstance
    {
        static void Main(String[] args)
        {
            Rectangle r = new Rectangle();
            r.initData();
            r.Display();
            Console.ReadLine();
        }
    }
}



