using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    public delegate string GrettingDelegate(string name);
    class AnonymousMethods
    {
        public void AnonymousMethod()
        {
            //bind a delegate using a method without name
            GrettingDelegate obj = delegate (string name)
            {
                return "Hello " + name + " good morning";
            };

            string str = obj.Invoke("Scott");
            Console.WriteLine(str);
        }

        public void AnonymousMethodArrowFunc()
        {
            GrettingDelegate obj = (name) =>
            {
                return "Hello " + name;
            };

            string str = obj.Invoke("Ted");
            Console.WriteLine(str);
        }
    }
}
