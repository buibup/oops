using System;
using LibraryUtil; // add library namespace

namespace oops
{
    public class LibraryClass
    {
        static void Main()
        {
            //library class instance
            var obj = new MathLib();

            //method populate
            obj.calculareSum(2, 5);
            obj.calculareSqrt(25);
        }
    }
}
