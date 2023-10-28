using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism
{
    internal class Ellips : Geometri
    {

        public double MainAxis { get; set; }
        public double MinorAxis { get; set; }
        public double Pi { get; set; }

        public Ellips() // constructor with alrdy set values so dont need imperamtiers
        {
            MainAxis = 10;
            MinorAxis = 6;
            Pi = 3.14;
        }
        public override double Area() //implemented the method from  the geometri class
        {
            double area = Pi * MainAxis / 2 * MinorAxis / 2;
            return area;
        }
    }
}
