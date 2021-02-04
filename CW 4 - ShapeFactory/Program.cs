/* Author: Jordan Taylor
 * Date: 02 / 04 / 2021
 * Description: Creates shapes from the factory.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4___ShapeFactory
{
    class ShapeFactory
    {
        public IGeometricShape getShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.LINE:
                    return new Line();
                case ShapeType.CIRCLE:

                    return new Circle();
                case ShapeType.RECTANGLE:

                    return new Rectangle();
                default:
                    return null;
            }
        }
    }

    enum ShapeType 
    { 
        LINE, CIRCLE, RECTANGLE, TRIANGLE 
    };
    
    interface IGeometricShape
    {
        void draw();
    }

    public class Line : IGeometricShape
    {
        string line = "Line";
        public void draw()
        {
            Console.WriteLine(line + " has been drawn.");
        }
    }

    public class Circle : IGeometricShape
    {
        string line = "Circle";
        public void draw()
        {
            Console.WriteLine(line + " has been drawn.");
        }
    }

    public class Rectangle : IGeometricShape
    {
        string line = "Rectangle";
        public void draw()
        {
            Console.WriteLine(line + " has been drawn.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            foreach (ShapeType shape in Enum.GetValues(typeof(ShapeType)))
            {
                var e = shapeFactory.getShape(shape);

                if (e == null)
                {
                    Console.WriteLine(shape.ToString() + " is not implemented.");
                }
                else
                {
                    e.draw();
                }
            }
            Console.ReadKey();
        }
    }
}
