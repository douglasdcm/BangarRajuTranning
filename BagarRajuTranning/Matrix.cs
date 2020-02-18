using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class Matrix
    {
        int a, b, c, d;

        public Matrix(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }

        //overrrding the "+" operator
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }

        //override the ToString methdo to print the matrix values
        public override string ToString()
        {
            return a + " " + b + " " + c + " " + d;
        }

    }
}
