using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{

    //delete this delegates to replace by generic delegates
    //public delegate double Delegate1(int x, float f, double z);
    //public delegate void Delegate2(int x, float f, double z);
    //public delegate bool Delegate3(string str);

    class GenericDelegates
    {
        public double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public void AddNums2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z );
        }

        public bool CheckLength (string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        public void CallDelegates()
        {
            //delegates comments to be replaced by generic delegates
            //Delegate1 obj1 =AddNums1;
            //recieves int, float, double and returns double
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 34.5f, 18.98);
            Console.WriteLine(result);

            //Delegate2 obj2 = AddNums2;
            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 34.5f, 18.98);

            //Delegate3 obj3 = CheckLength;
            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);

        }

        //receives a function that receives int and returns string
        //invoke the received function passing 1 as parameter and returns the string returned by the f function
        private string TestFunc(Func<int, string> f)
        {
            return f.Invoke(1);
        }

        //receives a function that receives an int and does not returns nothing
        //invokes the function a passing 2 to it
        private void TestAction(Action<int> a)
        {
            a.Invoke(2);
        }

        //receives a function that receives an int and returns a bool
        //invoke the function p passing 3 to it and returns the bool returned by p
        private bool TestPredicate(Predicate<int> p)
        {
            return p.Invoke(3);
        }

        public void TestGenericDelegate()
        {
            string s = TestFunc(delegate (int i)
            {
                Console.WriteLine(i);
                return "Hello";
                } 
            );

            Console.WriteLine("TestFunc " + s);

            TestAction(delegate (int i)
            {
                Console.WriteLine("TestAction " + i);
            }
            );

            bool p = TestPredicate(delegate (int i)
            {
                Console.WriteLine(i);
                return true;
                }
            );

            Console.WriteLine("TestPredicate " + p);
        }
    }
}
