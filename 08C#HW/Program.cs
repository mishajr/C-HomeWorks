
using System;
using System.Collections.Generic;

namespace _08C_HW
{

    abstract class GeometryFigure
    {

        public abstract double GetArea();

        public abstract double GetPerimeter();


        public virtual void Print()

        {
            Console.WriteLine($"Area: {GetArea()}, Perimeter: {GetPerimeter()}");

        }
    }







    class Triangle : GeometryFigure

    {
        public double A { get; }
        public double B { get; }

        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;

            B = b;

            C = c;

        }

        public override double GetArea()
        {
            double s = (A + B + C) / 2;

            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double GetPerimeter()
        {

            return A + B + C;
        }

        public override void Print()
        {
            Console.WriteLine($"Triangle - A: {A}, B: {B}, C: {C}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");

        }
    }









    class Square : GeometryFigure
    {
        public double Side { get; }


        public Square(double side)
        {
            Side = side;

        }

        public override double GetArea()
        {
            return Side * Side;


        }

        public override double GetPerimeter()
        {
            return 4 * Side;



        }

        public override void Print()
        {
            Console.WriteLine($"Square - Side: {Side}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }









    class Rhombus : GeometryFigure
    {
        public double Diagonal1 { get; }

        public double Diagonal2 { get; }

        public Rhombus(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override double GetArea()
        {

            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double GetPerimeter()
        {
            double side = Math.Sqrt((Diagonal1 / 2) * (Diagonal1 / 2) + (Diagonal2 / 2) * (Diagonal2 / 2));
            return 4 * side;
        }

        public override void Print()
        {

            Console.WriteLine($"Rhombus - Diagonal1: {Diagonal1}, Diagonal2: {Diagonal2}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }










    class Rectangle : GeometryFigure
    {
        public double Width { get; }

        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;

            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override void Print()
        {
            Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }










    class Parallelogram : GeometryFigure
    {
        public double Base { get; }


        public double Height { get; }

        public Parallelogram(double baseLength, double height)
        {
            Base = baseLength;

            Height = height;

        }

        public override double GetArea()
        {

            return Base * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Base + Height); 

        }

        public override void Print()
        {

            Console.WriteLine($"Parallelogram - Base: {Base}, Height: {Height}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }



    






    class Trapezoid : GeometryFigure
    {
        public double Base1 { get; }

        public double Base2 { get; }


        public double Height { get; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;

            Base2 = base2;

            Height = height;
        }

        public override double GetArea()
        {
            return ((Base1 + Base2) * Height) / 2;

        }

        public override double GetPerimeter()
        {
            
            double leg = Math.Sqrt(Math.Pow((Base1 - Base2) / 2, 2) + Math.Pow(Height, 2));

            return Base1 + Base2 + 2 * leg;
        }

        public override void Print()
        {



            Console.WriteLine($"Trapezoid - Base1: {Base1}, Base2: {Base2}, Height: {Height}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }










    class Circle : GeometryFigure
    {



        public double Radius { get; }


        public Circle(double radius)
        {

            Radius = radius;
        }

        public override double GetArea()
        {


            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Print()
        {
            Console.WriteLine($"Circle - Radius: {Radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }











    class Ellipse : GeometryFigure
    {
        public double MajorAxis { get; }


        public double MinorAxis { get; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            MajorAxis = majorAxis;

            MinorAxis = minorAxis;
        }

        public override double GetArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }

        public override double GetPerimeter()
        {
            

            return Math.PI * (3 * (MajorAxis + MinorAxis) - Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)));
        }

        public override void Print()
        {

            Console.WriteLine($"Ellipse - MajorAxis: {MajorAxis}, MinorAxis: {MinorAxis}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }













    class CompositeFigure : GeometryFigure
    {

        private GeometryFigure[] figures;


        public CompositeFigure(params GeometryFigure[] figures)
        {

            this.figures = figures;
        }

        public override double GetArea()
        {

            double totalArea = 0;

            foreach (var figure in figures)
            {
                totalArea += figure.GetArea();
            }

            return totalArea;
        }

        public override double GetPerimeter()
        {

            double totalPerimeter = 0;

            foreach (var figure in figures)
            {
                totalPerimeter += figure.GetPerimeter();
            }

            return totalPerimeter;
        }

        public override void Print()
        {
            foreach (var figure in figures)
            {

                figure.Print();
            }


            Console.WriteLine($"Composite Figure - Total Area: {GetArea()}, Total Perimeter: {GetPerimeter()}");
        }
    }

    internal class Program
    {
        static void Main()
        {




            GeometryFigure[] figures = {

                new Triangle(3, 4, 5),

                new Square(4),

                new Rectangle(4, 5),
                new Circle(3)

            };



            CompositeFigure compositeFigure = new CompositeFigure(figures);


            compositeFigure.Print();










        }
    }
}
