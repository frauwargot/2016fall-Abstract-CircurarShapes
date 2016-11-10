using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularShapesLib;

namespace CircularShapesLib
{
    public class Cone:CircularShape
    {
        //constravtor
        public Cone(double radius, double height, double side):base(radius, height, side)
        {
            
        }
        //properties
        public override string Name { get { return "Cone"; } }
        //methods
        public override double Area()
        {
            return Math.PI * Radius * Side;
        }
        public override double Volume()
        {
            return  Math.PI * Radius* Radius * Height / 3;            
        }
        public override double Perimeter()
        {
            return 0;
        }
    }
}
