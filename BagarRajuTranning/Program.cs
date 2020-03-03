using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BagarRajuTranning.DelegateDemo;

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
            ////*parameterized constructor demo
            //ParamiterizedConDemo cd1 = new ParamiterizedConDemo(10);
            //Console.ReadLine();

            ////*Copy constructor demo
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

            ////types of variables
            //const int c = 2; //must be initialided and never changes. it is the same for all instances
            //Console.WriteLine(c);
            //Program p = new Program();
            //Console.WriteLine(p.r);

            ////*operator overloading
            ////we can override an operator like "+"
            //Matrix m1 = new Matrix(1, 2, 3, 4);
            //Matrix m2 = new Matrix(5, 6, 7, 8);

            //Matrix m = m1 + m2;

            //Console.WriteLine(m);


            ////*structures
            //Structure s = new Structure();
            //Structure s2; //the new is optional
            //s2.Method();

            ////*enums
            //Days d = 0;
            //Console.WriteLine(d); //print Seg

            //Days d2 = (Days)1;
            //Console.WriteLine(d2); //print Ter

            //Days d3 = Days.Dom;
            //Console.WriteLine(d3); //print Dom
            //Console.WriteLine((int)d3); //print the index of Dom


            ////*properties
            //PropertiesClass pc = new PropertiesClass();
            //pc.Radius = 10;
            //Console.WriteLine(pc.Radius);

            //pc.High = 23;
            //Console.WriteLine(pc.High);

            //PropertiesClass pc2 = new PropertiesClass();
            //Console.WriteLine(pc2.High);
            //Console.WriteLine(pc2.Radius);

            ////*Indexers
            //Employee Emp = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");
            //Console.WriteLine("Eno " + Emp[1]);
            //Console.WriteLine("Ename " + Emp[2]);
            //Console.WriteLine("Job " + Emp[3]);
            //Console.WriteLine("Salary " + Emp[4]);
            //Console.WriteLine("Dname " + Emp[5]);
            //Console.WriteLine("Location " + Emp[6]);
            //Console.WriteLine("Fail " + Emp[10]);

            //Emp[3] = "Sr Manager";
            //Console.WriteLine("Job " + Emp[3]);
            //Emp[10] = "Fail";

            ////with names
            //Emp["Job"] = "Master Manager";
            //Console.WriteLine("Job " + Emp["Job"]);
            //Emp["Fail"] = "Fail";

            ////*delegates
            ////it hold the referece of a method and them call the method for execution
            //DelegateDemo d = new DelegateDemo();
            //d.AddNums(100, 50);

            //string str = DelegateDemo.SayHello("Raju");
            //Console.WriteLine(str);

            ////to call using deleagate have 3 steps
            ////1- define a delegate
            ////the return of the delagate and the parameters must be the of the method
            ////the delegate is a type (like class is a type)
            ////delegate is a reference type and the types are defined in the namespaces

            ////2- instantiating the delegate
            //AddDelegate ad = new AddDelegate(d.AddNums); //instance method AddNums
            //SayDelegate sd = new SayDelegate(SayHello); //static method SayHello

            ////3- call the delegate passing parameters
            //ad(100, 50);
            //string strName = sd("Raju");
            //Console.WriteLine(strName);

            ////can call by invoke
            //ad.Invoke(100, 50);
            //strName = sd.Invoke("Raju");
            //Console.WriteLine(strName);

            ////*multicast delegate
            ////holds multiple method references
            //Rectangle rect = new Rectangle();
            //rect.GetArea(12.34, 56.78);
            //rect.GetPerimeter(12.34, 56.78);

            //RectDelegate obj = new RectDelegate(rect.GetArea);
            //obj.Invoke(12.34, 56.78);

            //Console.WriteLine("Multcast");
            //RectDelegate obj2 = rect.GetArea; //call the delegate by binding         
            //obj2 += rect.GetPerimeter; //adding the second method
            //obj2.Invoke(12.34, 56.78); //calling both methods

            //Console.WriteLine("My test");
            //RectDelegate deleg = null;
            //deleg += rect.GetArea; //bind the method to the delegate
            //deleg += rect.GetPerimeter;
            //deleg.Invoke(12.34, 56.78); ; //call all delegates

            ////*anonymous methods
            //AnonymousMethods am = new AnonymousMethods();
            //am.AnonymousMethodArrowFunc();
            //am.AnonymousMethod();

            ////*lambda expressions
            //LambdaExpressions le = new LambdaExpressions();
            //le.Greetings("Roy");

            //*generic delegates
            GenericDelegates gd = new GenericDelegates();
            //gd.CallDelegates();

            //func delegate is used when the method returns a values
            //action delegate is used when the methos is void
            //predicate delegate used when return type is boolean
            gd.TestGenericDelegate();

            Console.ReadLine();
        }
    }
}
