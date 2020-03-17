using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    static class ExtensionClassDeriv
    {
        public static void Deriv(this ExtensionClassOrig d)
        {

        }

        public static void Orig1()
        {
            Console.WriteLine("Extension Orig2");
        }

        public static void Deriv2(this ExtensionClassOrig e, int i)
        {

        }

        public static void Factorial(this Int32 x)
        {
            
        }

        public static string ToProper(this String s)
        {
            return "test";
        }
    }
}
