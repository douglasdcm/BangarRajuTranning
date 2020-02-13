using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class Program
    {

        readonly int r; //does not need to be initialize, bt nver changes after initialization
                        //it is a non-variante variable for each instance

        public Program()
        {
            r = 1; //must be initialize in the constructor
        }

        static void Main(string[] args)
        {
            ////parameterized constructor demo
            //ParamiterizedConDemo cd1 = new ParamiterizedConDemo(10);
            //Console.ReadLine();

            ////Copy constructor demo
            //CopyConDemo cd1 = new CopyConDemo(10);
            //cd1.Display();

            //CopyConDemo cd2 = new CopyConDemo(cd1);
            //cd2.Display();

            ////difference between static and non-static constructors
            //ConstructorDemo cd = new ConstructorDemo();
            //Console.WriteLine(ConstructorDemo.y);

            ////reference variable
            //First f1 = new First(20);
            //f1.Display();
            //First f2 = f1; //f2 is a pointer to f
            //f2.Display();

            //Access specifier demo

            //types of variables
            const int c = 2; //must be initialided and never changes. it is the same for all instances
            Console.WriteLine(c);
            Program p = new Program();
            Console.WriteLine(p.r);

            Console.ReadLine();
        }
    }
}
