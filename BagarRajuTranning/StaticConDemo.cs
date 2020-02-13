using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class StaticConDemo
    {
        //static constructor are responsible to initialize static variables
        //it is the first thing executed
        static StaticConDemo()
        {
            Console.WriteLine("Static constructor");
        }
    }
}
