using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Circle:CircularShape
    {
        //constractor
        public Circle (double radius):base(radius, 0, 0)
        {
           
        }       
        //properties
        public override string Name { get { return "Circle"; } }

        //methods Perimeter, Area, and Voliume
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override double Volume()
        {
            return 0;
        }
    }
}
