using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism 
{
    public class Parallellogram : Geometri // Heritance
    {
        public double Base { get; set; } // property
        public double Height { get; set; } // property

        public Parallellogram() // contructor with no imperamenter cause of alrdy set values
        {
            Base = 6; // set value
            Height = 7; // set value
        }
        public override double Area() // implemented an abstract class from  the Geometri  (heritance)
        {
            double area = Base * Height; // setting the value / the math formel here 
            return area; // returning it here
        }
    }
}
