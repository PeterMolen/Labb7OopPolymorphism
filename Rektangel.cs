using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism
{
    public class Rektangel : Geometri  // inhertiance 
    {
        public double Base { get; set; } // properties 
        public double Height { get; set; }  // properties

        public Rektangel() // constructor with empty imaremter 
        {
            Base = 10;  // set the constructor here, No imparatemters required
            Height = 16; // set the constructor here, No imparatemters required
        }

        public override double Area()  //implemented an abstract class from  the Geometri class
        {
            double area = Base * Height / 2; // set the value 
            return area; // return value here
        }

    }
}
