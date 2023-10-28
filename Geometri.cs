using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OopPolymorphism
{
    public abstract class Geometri // main class, made it abstract and an abstract method without a body
    {

        abstract public double Area(); // method that all the underclasses will inheritance
    }
}
