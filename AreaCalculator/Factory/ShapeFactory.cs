using AreaCalculator.Interfaces;
using AreaCalculator.Models;
using AreaCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Factory
{
    public class ShapeFactory : IShapeFactory
    {
        private double _base;
        private double _height;
        private double _radius;
        private double _length;

        public ShapeFactory(double radius, double length, double @base, double height)
        {
            _base = @base;
            _height = height;
            _radius = radius;
            _length = length;
        }


        public IShape GetShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.Square:
                    return new Square(_length);
                case Shape.Circle:
                    return new Circle(_radius);
                case Shape.Triangle:
                    return new Triangle(_base, _height);
                default:
                    throw new ArgumentException("Select Valid Shape to Continue");
            }
        }
    }
}
