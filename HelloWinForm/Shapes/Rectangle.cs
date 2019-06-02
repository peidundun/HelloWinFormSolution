using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForm.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double w, double h)
        {
            W = w;
            H = h;
        }

        private double _W;
        private double _H;

        public double W { get => _W; set => _W = value; }
        public double H { get => _H; set => _H = value; }

        public override double CalcArea()
        {
            return W + H;
        }
    }
}
