using BagarRajuTranning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Four : AccessDemo
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.D_Protected3(); f.D_ProtectedInternal4();
            f.D_Public5();
        }
    }
}
