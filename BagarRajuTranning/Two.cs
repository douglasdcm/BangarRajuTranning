using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class Two : AccessDemo
    {
        private void InheritanceAccessDemo()
        {
            Two t = new Two();
            t.D_Internal1(); t.D_Protected3();
            t.D_ProtectedInternal4(); t.D_Public5();
        }
    }
}
