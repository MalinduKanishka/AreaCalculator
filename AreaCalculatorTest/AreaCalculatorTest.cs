using AreaCalculator.Models;
using FluentAssertions;

namespace AreaCalculatorTest
{
    public class AreaCalculatorTest
    {
        [Fact(DisplayName = "Calculate Square Area")]
        public void CalculateSquareArea()
        {
            int length = 4;
            Square square = new Square(length);
            double area = square.CalculateArea();

            area.Should().Be(16);
        }

        [Fact(DisplayName = "Calculate Circle Area")]
        public void CalculateCircleArea()
        {
            int radius = 5;
            Circle circle = new Circle(radius);
            double area = circle.CalculateArea();

            area.Should().Be(78.54);
        }

        [Fact(DisplayName = "Calculate Triangle Area")]
        public void CalculateTriangleArea()
        {
            int @base = 4;
            int height = 8;
            Triangle triangle = new Triangle(@base, height);
            double area = triangle.CalculateArea();

            area.Should().Be(16);
        }
    }
}