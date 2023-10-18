using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle
    {
        private double radius;
        public double Radius 
        {
            get { return radius; } 
            set {
                if (value > 0) { radius = value; }
                else if (value == 0) { throw new InvalidRadiusException(radius); }
                else { throw new InvalidRadiusException(); }
                }
        }

        public Circle(double radius) 
        {
            Radius = radius;
        }
        public override string ToString() 
        {
            return "Cicrle created with radius " + Radius;
        }

    }
}
