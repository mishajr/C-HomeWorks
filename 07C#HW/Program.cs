using System.Drawing;
namespace ConsoleApp1
{
    class Square
    {
        public int A { get; set; }
        public Square() : this(0) { }
        public Square(int a)
        {
            A = a;
        }
        public static Square operator -(Square s)
        {
            Square res = new Square()
            {
                A = s.A * -1
            };
            return res;
        }
        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.A--;
            return s;
        }

        public static Square operator +(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A + s2.A
            };
            return res;
        }
        public static Square operator -(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A - s2.A,
            };
            return res;
        }
        public static Square operator *(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A * s2.A,
            };
            return res;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A / s2.A,
            };
            return res;
        }


        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }

        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return !(s1 < s2);
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return !(s1 <= s2);
        }

        public static bool operator true(Square s)
        {
            return s.A >= 0;
        }
        public static bool operator false(Square s)
        {
            return s.A < 0;
        }
        public static explicit operator int(Square s)
        {
            return s.A + s.A;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, 10);
        }
        public override bool Equals(object? obj)
        {
            return obj is Square square && A == square.A;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A);
        }
    }
    class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rectangle() : this(0, 0) { }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public static Rectangle operator -(Rectangle r)
        {
            Rectangle res = new Rectangle()
            {
                A = r.A * -1,
                B = r.B * -1
            };
            return res;
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.A--;
            r.B--;
            return r;
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A + r2.A,
                B = r1.B + r2.B
            };
            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A - r2.A,
                B = r1.B - r2.B
            };
            return res;
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A * r2.A,
                B = r1.B * r2.B
            };
            return res;
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A / r2.A,
                B = r1.B / r2.B
            };
            return res;
        }

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }

        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.A + r2.A < r1.B + r2.B;
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return !(r1 < r2);
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return r1.A + r2.A <= r1.B + r2.B;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return !(r1 <= r2);
        }

        public static bool operator true(Rectangle r)
        {
            return r.A >= 0 && r.B >= 0;
        }
        public static bool operator false(Rectangle r)
        {
            return r.A < 0 || r.B < 0;
        }

        public static explicit operator int(Rectangle r)
        {
            return r.A + r.B;
        }
        public static explicit operator Square(Rectangle r)
        {
            return new Square(r.A);
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle && A == rectangle.A &&
                   B == rectangle.B;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }
    }

    internal class Program
    {
        static void Main()
        {
        
            Square s1 = new Square(5);
            Square s2 = new Square(3);

            Square s3 = s1 + s2;
            Square s4 = s1 - s2;
            Square s5 = s1 * s2;
            Square s6 = s1 / s2;
            Square s7 = -s1;
            s1++;
            s2--;

            Console.WriteLine($"s3 (s1 + s2): {s3.A}");
            Console.WriteLine($"s4 (s1 - s2): {s4.A}");
            Console.WriteLine($"s5 (s1 * s2): {s5.A}");
            Console.WriteLine($"s6 (s1 / s2): {s6.A}");
            Console.WriteLine($"s7 (-s1): {s7.A}");
            Console.WriteLine($"s1++: {s1.A}");
            Console.WriteLine($"s2--: {s2.A}");

            Console.WriteLine($"s1 == s2: {s1 == s2}");
            Console.WriteLine($"s1 != s2: {s1 != s2}");
            Console.WriteLine($"s1 < s2: {s1 < s2}");
            Console.WriteLine($"s1 > s2: {s1 > s2}");
            Console.WriteLine($"s1 <= s2: {s1 <= s2}");
            Console.WriteLine($"s1 >= s2: {s1 >= s2}");

            Console.WriteLine($"(int)s1: {(int)s1}");
            Rectangle r1 = s1;
            Console.WriteLine($"(Rectangle)s1: A={r1.A}, B={r1.B}");

      
            Rectangle r2 = new Rectangle(4, 6);
            Rectangle r3 = new Rectangle(2, 3);

            Rectangle r4 = r2 + r3;
            Rectangle r5 = r2 - r3;
            Rectangle r6 = r2 * r3;
            Rectangle r7 = r2 / r3;
            Rectangle r8 = -r2;
            r2++;
            r3--;

            Console.WriteLine($"r4 (r2 + r3): A={r4.A}, B={r4.B}");
            Console.WriteLine($"r5 (r2 - r3): A={r5.A}, B={r5.B}");
            Console.WriteLine($"r6 (r2 * r3): A={r6.A}, B={r6.B}");
            Console.WriteLine($"r7 (r2 / r3): A={r7.A}, B={r7.B}");
            Console.WriteLine($"r8 (-r2): A={r8.A}, B={r8.B}");
            Console.WriteLine($"r2++: A={r2.A}, B={r2.B}");
            Console.WriteLine($"r3--: A={r3.A}, B={r3.B}");

            Console.WriteLine($"r2 == r3: {r2 == r3}");
            Console.WriteLine($"r2 != r3: {r2 != r3}");
            Console.WriteLine($"r2 < r3: {r2 < r3}");
            Console.WriteLine($"r2 > r3: {r2 > r3}");
            Console.WriteLine($"r2 <= r3: {r2 <= r3}");
            Console.WriteLine($"r2 >= r3: {r2 >= r3}");

            Console.WriteLine($"(int)r2: {(int)r2}");
            Square s8 = (Square)r2;
            Console.WriteLine($"(Square)r2: A={s8.A}");
        }
    }
}
