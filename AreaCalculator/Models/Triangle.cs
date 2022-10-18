using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Models
{
    public class Triangle : IShape
    {
        private double _base;
        private double _height;

        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        public double CalculateArea()
        {
            return (0.5 *_base * _height);
        }
    }
}
