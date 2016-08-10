using System;

namespace oops
{
    class Program
    {
        public void MainFunction()
        {
            Console.WriteLine("Main class");
        }
        static void Main(string[] args)
        {
            //partial class instance
            var obj = new partialclassDemo();
            obj.method1();
            obj.method2();

            //main class instance
            var objP = new Program();
            objP.MainFunction();

            //other class intance
            var dObj = new demo();
            dObj.addition();
        }
    }

    class demo
    {
        int x = 10;
        int y = 20;
        int z;

        public void addition()
        {
            z = x + y;
            Console.WriteLine("other class in Namespace");
            Console.WriteLine(z);
        }
    }
}
