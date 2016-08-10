using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    static class staticDemo
    {
        //static fields
        static int x = 10, y;

        //static method
        static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            //function calling directly
            staticDemo.calcute();
        }
    }
}
