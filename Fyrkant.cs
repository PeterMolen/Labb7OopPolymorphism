using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism
{
    public class Fyrkant : Geometri // inheritance from Geometri class
    {
        public double Base { get; set; } // property
        public double Height { get; set; } // property

        public Fyrkant()
        {
            Base = 12;
            Height = 17;
        }
        public override double Area() // implemented an abstract class from  the Geometri class // overrided it
        {
            double area = Base * Height; // setting the value / the math formel here 
            return area; // returning it here
        }
    }
}
