using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    public delegate string GreetinsDelegate(string name);
    class LambdaExpressions
    {
        public void Greetings(string name)
        {
            GreetinsDelegate obj = (n) => 
            {
                return "Hello " + n;
            };
            string str = obj.Invoke(name);
            Console.WriteLine(str);

        }
    }
}
