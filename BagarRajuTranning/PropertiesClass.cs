using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    class PropertiesClass
    {
        private double _Radius { get; set; } = 100; //the property and the variable cannit have the same name, so the "_" is used in front of the variable
        public int High { get; set; } = 20;
        public double Radius
        {
            get { return _Radius; } //the get and set accessor can be used to expose values and also write conditions into the block od=f codes
            set {
                if (value > _Radius)
                _Radius = value; }
        }
    }
}
