using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public Cirkel()
        {
            Radius = 6;
            Pi = 3.14;
        }
        public override double Area() //implemented an abstract class from  the Geometri class
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
