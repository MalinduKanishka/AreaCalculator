using AreaCalculator.Factory;
using AreaCalculator.Interfaces;
using AreaCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Calculator
    {

        public static void CalculateAndShowAreaOfShape(Shape selectedShape, double radius, double length, double @base, double height)
        {
            IShapeFactory shapeFactory = new ShapeFactory(radius, length,  @base, height);
            IShape currentShape = shapeFactory.GetShape(selectedShape);
            double area = currentShape.CalculateArea();

            Console.WriteLine("Area of the " + selectedShape.ToString() + " is " + area);
            
        }
    }
}
