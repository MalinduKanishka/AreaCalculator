using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Models
{
    public class Square : IShape
    {

        private double _length;

        public Square(double length)
        {
            _length = length;   
        }

        public double CalculateArea()
        {
            return _length *  _length;
        }
    }
}
