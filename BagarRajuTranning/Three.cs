using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class Three
    {
        public void InstanceAccessDemo()
        {
            AccessDemo a = new AccessDemo();
            a.D_Internal1(); a.D_ProtectedInternal4(); a.D_Public5();
        }
    }
}
