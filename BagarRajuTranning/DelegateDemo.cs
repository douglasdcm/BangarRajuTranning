using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class DelegateDemo
    {
        //1- defining a delegate
        public delegate void AddDelegate(int i, int j);
        public delegate string SayDelegate(string str);
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
