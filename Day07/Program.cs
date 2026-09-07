using System;

namespace Csharp_Day07
{
    internal class Program
    {

        #region problem1
        //public class Car
        //{
        //    public int Id;
        //    public string Brand;
        //    public double Price;

        //    // 1. Default constructor
        //    public Car()
        //    {
        //        Id = 0;
        //        Brand = "Unknown";
        //        Price = 0;
        //    }

        //    // 2. Constructor with one parameter
        //    public Car(int id)
        //    {
        //        Id = id;
        //        Brand = "Unknown";
        //        Price = 0;
        //    }

        //    // 3. Constructor with two parameters
        //    public Car(int id, string brand)
        //    {
        //        Id = id;
        //        Brand = brand;
        //        Price = 0;
        //    }

        //    // 4. Constructor with all three parameters
        //    public Car(int id, string brand, double price)
        //    {
        //        Id = id;
        //        Brand = brand;
        //        Price = price;
        //    }
        //}
        #endregion

        #region problem2
        //public class Calculator
        //{
        //    // 1. Add two integers
        //    public int Sum(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    // 2. Add three integers
        //    public int Sum(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }

        //    // 3. Add two doubles
        //    public double Sum(double a, double b)
        //    {
        //        return a + b;
        //    }
        //}
        #endregion

        #region problem3
        //public class ParentP3
        //{
        //    public int X;
        //    public int Y;

        //    public ParentP3(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}

        //public class ChildP3 : ParentP3
        //{
        //    public int Z;

        //    // Constructor chaining: calls the base class constructor first using base(...)
        //    public ChildP3(int x, int y, int z) : base(x, y)
        //    {
        //        Z = z;
        //    }
        //}
        #endregion

        #region problem4
        //public class ParentP4
        //{
        //    public int X;
        //    public int Y;

        //    public ParentP4(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    // Must be virtual so ChildP4Override can override it
        //    public virtual int Product()
        //    {
        //        return X * Y;
        //    }
        //}

        //// Hides the base method using "new" (no polymorphism)
        //public class ChildP4New : ParentP4
        //{
        //    public ChildP4New(int x, int y) : base(x, y) { }

        //    public new int Product()
        //    {
        //        return (X * Y) * 2;
        //    }
        //}

        //// Overrides the base method using "override" (true polymorphism)
        //public class ChildP4Override : ParentP4
        //{
        //    public ChildP4Override(int x, int y) : base(x, y) { }

        //    public override int Product()
        //    {
        //        return (X * Y) * 2;
        //    }
        //}
        #endregion

        #region problem5
        //public class ParentP5
        //{
        //    public int X;
        //    public int Y;

        //    public ParentP5(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    public override string ToString()
        //    {
        //        return $"({X}, {Y})";
        //    }
        //}

        //public class ChildP5 : ParentP5
        //{
        //    public int Z;

        //    public ChildP5(int x, int y, int z) : base(x, y)
        //    {
        //        Z = z;
        //    }

        //    public override string ToString()
        //    {
        //        return $"({X}, {Y}, {Z})";
        //    }
        //}
        #endregion

        #region problem6
        //public interface IShape
        //{
        //    double Area { get; } // get-only property
        //    void Draw();
        //}

        //public class RectangleP6 : IShape
        //{
        //    public double Width;
        //    public double Height;

        //    public RectangleP6(double width, double height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public double Area
        //    {
        //        get { return Width * Height; }
        //    }

        //    public void Draw()
        //    {
        //        Console.WriteLine("Drawing a Rectangle");
        //    }
        //}
        #endregion

        #region problem7
        //public interface IShapeP7
        //{
        //    double Area { get; }
        //    void Draw();

        //    // Default interface implementation (C# 8.0+)
        //    void PrintDetails()
        //    {
        //        Console.WriteLine("This shape has an area of: " + Area);
        //    }
        //}

        //public class Circle : IShapeP7
        //{
        //    public double Radius;

        //    public Circle(double radius)
        //    {
        //        Radius = radius;
        //    }

        //    public double Area
        //    {
        //        get { return Math.PI * Radius * Radius; }
        //    }

        //    public void Draw()
        //    {
        //        Console.WriteLine("Drawing a Circle");
        //    }

        //    // PrintDetails() is NOT written here -> Circle uses the interface's default implementation
        //}
        #endregion

        #region problem8
        //public interface IMovable
        //{
        //    void Move();
        //}

        //// Renamed to CarP8 to avoid clashing with the "Car" class from problem1
        //public class CarP8 : IMovable
        //{
        //    public void Move()
        //    {
        //        Console.WriteLine("Car is moving...");
        //    }
        //}
        #endregion

        #region problem9
        //public interface IReadable
        //{
        //    void Read();
        //}

        //public interface IWritable
        //{
        //    void Write();
        //}

        //// Renamed to MyFile to avoid clashing with System.IO.File
        //public class MyFile : IReadable, IWritable
        //{
        //    public void Read()
        //    {
        //        Console.WriteLine("Reading from file...");
        //    }

        //    public void Write()
        //    {
        //        Console.WriteLine("Writing to file...");
        //    }
        //}
        #endregion

        #region problem10
        //public abstract class Shape
        //{
        //    // Virtual method: has a default body, CAN be overridden but doesn't have to be
        //    public virtual void Draw()
        //    {
        //        Console.WriteLine("Drawing Shape");
        //    }

        //    // Abstract method: no body at all, MUST be implemented by any non-abstract derived class
        //    public abstract double CalculateArea();
        //}

        //public class RectangleP10 : Shape
        //{
        //    public double Width;
        //    public double Height;

        //    public RectangleP10(double width, double height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public override void Draw()
        //    {
        //        Console.WriteLine("Drawing Rectangle");
        //    }

        //    public override double CalculateArea()
        //    {
        //        return Width * Height;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region problem1
            //Car defaultCar = new Car();
            //Car carWithId = new Car(1);
            //Car carWithIdAndBrand = new Car(2, "Toyota");
            //Car fullCar = new Car(3, "BMW", 55000);

            //Console.WriteLine($"Default: Id={defaultCar.Id}, Brand={defaultCar.Brand}, Price={defaultCar.Price}");
            //Console.WriteLine($"With Id: Id={carWithId.Id}, Brand={carWithId.Brand}, Price={carWithId.Price}");
            //Console.WriteLine($"With Id+Brand: Id={carWithIdAndBrand.Id}, Brand={carWithIdAndBrand.Brand}, Price={carWithIdAndBrand.Price}");
            //Console.WriteLine($"Full: Id={fullCar.Id}, Brand={fullCar.Brand}, Price={fullCar.Price}");
            #endregion

            #region problem2
            //Calculator calc = new Calculator();

            //Console.WriteLine("Sum(2, 3) = " + calc.Sum(2, 3));
            //Console.WriteLine("Sum(2, 3, 4) = " + calc.Sum(2, 3, 4));
            //Console.WriteLine("Sum(2.5, 3.5) = " + calc.Sum(2.5, 3.5));
            #endregion

            #region problem3
            //ChildP3 child = new ChildP3(10, 20, 30);
            //Console.WriteLine($"X={child.X}, Y={child.Y}, Z={child.Z}");
            #endregion

            #region problem4
            //ChildP4New cNew = new ChildP4New(2, 3);
            //ParentP4 refNew = cNew;

            //Console.WriteLine("Direct call using 'new'      -> " + cNew.Product());   // 12 (2*3*2)
            //Console.WriteLine("Via Parent reference ('new')  -> " + refNew.Product()); // 6  (2*3) -> calls Parent's version (hiding, no polymorphism)

            //ChildP4Override cOverride = new ChildP4Override(2, 3);
            //ParentP4 refOverride = cOverride;

            //Console.WriteLine("Direct call using 'override'      -> " + cOverride.Product()); // 12
            //Console.WriteLine("Via Parent reference ('override')  -> " + refOverride.Product()); // 12 -> calls Child's version (true polymorphism)
            #endregion

            #region problem5
            //ParentP5 p = new ParentP5(1, 2);
            //ChildP5 c = new ChildP5(3, 4, 5);

            //Console.WriteLine(p); // (1, 2)
            //Console.WriteLine(c); // (3, 4, 5)

            //ParentP5 polyRef = c;
            //Console.WriteLine(polyRef); // (3, 4, 5) -> polymorphism: runs Child's ToString()
            #endregion

            #region problem6
            //RectangleP6 rect = new RectangleP6(4, 5);
            //rect.Draw();
            //Console.WriteLine("Area = " + rect.Area);
            #endregion

            #region problem7
            //Circle circle = new Circle(3);
            //circle.Draw();

            //// Default interface methods can only be called through an interface reference,
            //// not directly on the class instance (circle.PrintDetails() would NOT compile).
            //IShapeP7 shapeRef = circle;
            //shapeRef.PrintDetails();
            #endregion

            #region problem8
            //IMovable movable = new CarP8();
            //movable.Move();
            #endregion

            #region problem9
            //MyFile file = new MyFile();
            //file.Read();
            //file.Write();
            #endregion

            #region problem10
            //RectangleP10 rect = new RectangleP10(6, 4);
            //rect.Draw();
            //Console.WriteLine("Area = " + rect.CalculateArea());
            #endregion
        }
    }
}
