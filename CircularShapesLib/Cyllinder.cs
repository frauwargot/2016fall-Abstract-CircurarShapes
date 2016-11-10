using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularShapesLib;



namespace CircularShapesLib
{
    public class Cyllinder : CircularShape
    {
       //constractor
        public Cyllinder (double radius, double height):base(radius, height, 0)
        {
           
        }   
        //properties
        public override string Name { get { return "Cyllinder"; } }
        //methods
        public override double Area()
        {
            return 2 * Math.PI * Radius * Height + 2 * Math.PI * Radius * Radius;
        }
        public override double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }
        public override double Perimeter()
        {
            return 0;
        }
    }
}
