using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {

            string shp, attribute;
            Console.WriteLine("Please input your shape and the attribute of your shape");
            Console.WriteLine("(you can write shape in a line but all the border length in another line:  ");
            shp = Console.ReadLine();
            attribute = Console.ReadLine();
            Shape shape = Productor.getShape(shp, attribute);
            if(shape != null) {
                Console.WriteLine("you get a " + shp);
                Console.WriteLine(shape.attr);
                Console.Write($"its area is {shape.area}.");
            } 
        }
    }
    class Productor
    {
        public static Shape getShape(String shp, String attribute)
        {

            if (shp.ToLower() == "triangle") {
                Shape shape = Triangle.creatTriangle(attribute);
                return shape;
            } else if (shp.ToLower() == "circle") {
                Shape shape = Circle.creatCircle(attribute);
                return shape;
            } else if (shp.ToLower() == "square") {
                Shape shape = Square.creatSquare(attribute);
                return shape;
            } else if (shp.ToLower() == "rectangle") {
                Shape shape = Rectangle.creatRectangle(attribute);
                return shape;
            } else {
                Console.Write("there is no such shape.");
                return null;
            }
        }
    }

    abstract class Shape
    {

        protected double[] size;

        public virtual bool initialization(String attribute)
        {
            int n = 0;
            bool flag = true;
            string[] attrib = Regex.Split(attribute.Trim(), " +", RegexOptions.IgnoreCase);
            size = new double[attrib.Length];
            foreach (string i in attrib) {
                flag &= (Double.TryParse(i, out size[n]) && size[n] > 0);
                n++;
            }
            return flag;
        }

        public abstract string area
        {
            get;
        }

        public abstract string attr
        {
            get;
        }
    }
    class Triangle : Shape
    {

        private double[] bLenth;
        private double halfAva;

        public override bool initialization(String attribute)
        {
            bool flag = base.initialization(attribute);
            if (base.size.Length >= 3
                && base.size[0] + base.size[1] > base.size[2]
                && base.size[1] + base.size[2] > base.size[0]
                && base.size[0] + base.size[2] > base.size[1]
                ) {
                bLenth = base.size;
                foreach (int i in bLenth) {
                    halfAva += i;
                }
                halfAva /= 2.0;
                return (true && flag);
            } else {
                return (false && flag);
            }
        }

        public static Triangle creatTriangle(String attribute)
        {
            Triangle triangle = new Triangle();
            if (!triangle.initialization(attribute)) {
                triangle = null;
                Console.WriteLine("something wrong");
            }
            return triangle;
        }

        public override string area
        {
            get {
                    return Math.Round(Math.Sqrt(halfAva * (halfAva - bLenth[0]) * (halfAva - bLenth[1]) * (halfAva - bLenth[2])), 2).ToString();              
            }
        }
        public override string attr
        {
            get {
                return $"the triangle has three borders, the length of them are {bLenth[0]}, {bLenth[1]}, {bLenth[2]}.";
            }
        }
    }
    class Circle : Shape
    {
        const double PI = 3.14;
        private double radius;
        public override bool initialization(String attribute)
        {
            bool flag = base.initialization(attribute);
            radius = base.size[0];
            return (true && flag);

        }
        public static Circle creatCircle(String attribute)
        {
            Circle circle = new Circle();
            if (!circle.initialization(attribute)) {
                circle = null;
                Console.WriteLine("something wrong");
            }
            return circle;
        }
        public override string area
        {
            get {
                    return Math.Round((PI * radius * radius), 2).ToString();
                }
        }
        public override string attr
        {
            get {
                return $"the circle's radius is {radius}.";
            }
        }
    }

    class Square : Shape
    {
        private double bLength;
        public override bool initialization(String attribute)
        {
            bool flag = base.initialization(attribute);
            bLength = base.size[0];
            return (true && flag);
        }
        public static Square creatSquare(String attribute)
        {
            Square square = new Square();
            if (!square.initialization(attribute)) {
                square = null;
                Console.WriteLine("something wrong");
            }
            return square;
        }
        public override string area
        {
            get {
                return Math.Round((bLength * bLength), 2).ToString();
            }
        }
        public override string attr
        {
            get {
                return $"the square's border length is {bLength}.";
            }
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public override bool initialization(String attribute)
        {
            bool flag = base.initialization(attribute);
            length = base.size[0];
            width = base.size[1];
            return (true && flag);
        }
        public static Rectangle creatRectangle(String attribute)
        {
            Rectangle rectangle = new Rectangle();
            if (!rectangle.initialization(attribute)) {
                rectangle = null;
                Console.WriteLine("something wrong");
            }
            return rectangle;
        }

        public override string area
        {
            get {
                return Math.Round((length * width)).ToString();
            }
        }
        public override string attr
        {
            get {
                return $"the rectangle's length is {length}, its width is {width}.";
            }
        }
    }
}
