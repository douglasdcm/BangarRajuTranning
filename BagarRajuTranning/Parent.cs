using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method T1 from parent class");
        }

        public void Test2()
        {
            Console.WriteLine("Method T2 from parent class");
        }

    }

    class ChildClass : ParentClass
    {
        //reimplement the parent method (virtual method)
        //override is allowed just for virtual classes
        public override void Test1()
        {
            Console.WriteLine("Method T1 from child class");
        }

        //method hidding/shadowing (using the new)
        //the parent class can not call it because it is hidden
        public new void Test2() 
        {
            Console.WriteLine("Method T1 from child class");
        }

        public void ParenteTest1()
        {
            base.Test1();
        }

        public void ParenteTest2()
        {
            base.Test2();
        }

    }

}
