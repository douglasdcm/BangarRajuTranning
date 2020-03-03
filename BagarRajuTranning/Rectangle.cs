using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    public delegate void RectDelegate(double w, double h);
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }
    }
}
