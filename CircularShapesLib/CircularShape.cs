using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public abstract class CircularShape
    {
        //fields
        private double _radius;
        private double _height;
        private double _side;
        
        //constractor
        public CircularShape (double radius, double  height, double side)
        {
            _radius = radius;
            _height = height;
            _side = side;
        }       
        //properties
        public abstract string Name { get; }
        public virtual double Radius
        { get { return _radius; } }
        public virtual double Height
        { get { return _height; } }
        public virtual double Side
        { get { return _side; } }
        //methods Perimeter, Area, and Voliume
        public abstract double Perimeter();
        //{
        //    return 2 * Math.PI * _radius;
        //}
        public abstract double Area();
        //{
        //    return Math.PI * _radius * _radius;
        //}
        public abstract double Volume();
     
    }
}
