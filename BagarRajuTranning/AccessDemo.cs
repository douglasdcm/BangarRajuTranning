using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    //class cannot be private, just public or protected
    public class AccessDemo
    {
        //accessible inside the class only
        private void D_Private1()
        {

        }

        //accessible just inside the project
        internal void D_Internal1()
        {

        }

        //accessible just by child classes
        protected void D_Protected3()
        {

        }

        //combination of protected and internal
        //just for child classes in this project
        protected internal void D_ProtectedInternal4()
        {

        }

        public void D_Public5()
        {

        }
    }

}
