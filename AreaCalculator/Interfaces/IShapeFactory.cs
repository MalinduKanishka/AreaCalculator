using AreaCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Interfaces
{
    public interface IShapeFactory
    {
        public IShape GetShape(Shape shape);
    }
}
