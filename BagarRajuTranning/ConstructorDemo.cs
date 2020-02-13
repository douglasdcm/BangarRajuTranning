using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class ConstructorDemo
    {
        int x;
        public static int y;

        //executes one and just once
        static ConstructorDemo()
        {
            y = 10;
            Console.WriteLine("Static constructor");
        }

        public ConstructorDemo()
        {
            Console.WriteLine("Non-static");
        }
    }
}
