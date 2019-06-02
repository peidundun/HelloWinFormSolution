using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForm.Shapes
{
    class Ellipse : Shape
    {
        public Ellipse(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        private double _radius;

        public override double CalcArea()
        {
            return _radius * _radius * 3.14;
        }
    }
}
