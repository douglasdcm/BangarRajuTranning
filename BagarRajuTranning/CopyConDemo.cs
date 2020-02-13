using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }

        public void Display()
        {
            Console.WriteLine("Value is " + x);
        }

        //copy constructor
        //calls itself
        public CopyConDemo(CopyConDemo obj)
        {
            x = obj.x;
        }
    }
}
