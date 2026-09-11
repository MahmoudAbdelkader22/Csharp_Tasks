using System;

namespace CsharpDay08
{
    internal class Program
    {
        #region part01
        #region problem1
        //public interface IVehicle
        //{
        //    void StartEngine();
        //    void StopEngine();
        //}

        //public class Car : IVehicle
        //{
        //    public void StartEngine()
        //    {
        //        Console.WriteLine("Car engine started");
        //    }

        //    public void StopEngine()
        //    {
        //        Console.WriteLine("Car engine stopped");
        //    }
        //}

        //public class Bike : IVehicle
        //{
        //    public void StartEngine()
        //    {
        //        Console.WriteLine("Bike engine started");
        //    }

        //    public void StopEngine()
        //    {
        //        Console.WriteLine("Bike engine stopped");
        //    }
        //}
        #endregion

        #region problem2
        //public abstract class Shape
        //{
        //    public abstract double GetArea();

        //    public void Display()
        //    {
        //        Console.WriteLine("Area = " + GetArea());
        //    }
        //}

        //public class Rectangle : Shape
        //{
        //    public double Width;
        //    public double Height;

        //    public Rectangle(double width, double height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public override double GetArea()
        //    {
        //        return Width * Height;
        //    }
        //}

        //public class Circle : Shape
        //{
        //    public double Radius;

        //    public Circle(double radius)
        //    {
        //        Radius = radius;
        //    }

        //    public override double GetArea()
        //    {
        //        return Math.PI * Radius * Radius;
        //    }
        //}
        #endregion

        #region problem3
        //public class Product : IComparable<Product>
        //{
        //    public int Id;
        //    public string Name;
        //    public double Price;

        //    public Product(int id, string name, double price)
        //    {
        //        Id = id;
        //        Name = name;
        //        Price = price;
        //    }

        //    public int CompareTo(Product other)
        //    {
        //        return Price.CompareTo(other.Price);
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name} - {Price}";
        //    }
        //}
        #endregion

        #region problem4
        //public class Address
        //{
        //    public string City;
        //}

        //public class Student
        //{
        //    public int Id;
        //    public string Name;
        //    public string Grade;
        //    public Address StudentAddress;

        //    public Student(int id, string name, string grade, Address address)
        //    {
        //        Id = id;
        //        Name = name;
        //        Grade = grade;
        //        StudentAddress = address;
        //    }

        //    // copy constructor, makes a deep copy of the Address too
        //    public Student(Student other)
        //    {
        //        Id = other.Id;
        //        Name = other.Name;
        //        Grade = other.Grade;
        //        StudentAddress = new Address { City = other.StudentAddress.City };
        //    }
        //}
        #endregion

        #region problem5
        //public interface IWalkable
        //{
        //    void Walk();
        //}

        //public class Robot : IWalkable
        //{
        //    public void Walk()
        //    {
        //        Console.WriteLine("Robot walking normally");
        //    }

        //    // explicit implementation, only reachable through an IWalkable reference
        //    void IWalkable.Walk()
        //    {
        //        Console.WriteLine("Robot walking in IWalkable mode");
        //    }
        //}
        #endregion

        #region problem6
        //public struct Account
        //{
        //    private int accountId;
        //    private string accountHolder;
        //    private double balance;

        //    public Account(int accountId, string accountHolder, double balance)
        //    {
        //        this.accountId = accountId;
        //        this.accountHolder = accountHolder;
        //        this.balance = balance;
        //    }

        //    public int AccountId
        //    {
        //        get { return accountId; }
        //        set { accountId = value; }
        //    }

        //    public string AccountHolder
        //    {
        //        get { return accountHolder; }
        //        set { accountHolder = value; }
        //    }

        //    public double Balance
        //    {
        //        get { return balance; }
        //        set { balance = value; }
        //    }
        //}
        #endregion

        #region problem7
        //public interface ILogger
        //{
        //    void Log()
        //    {
        //        Console.WriteLine("Default log message");
        //    }
        //}

        //public class ConsoleLogger : ILogger
        //{
        //    public void Log()
        //    {
        //        Console.WriteLine("ConsoleLogger: custom log message");
        //    }
        //}
        #endregion

        #region problem8
        //public class Book
        //{
        //    public string Title;
        //    public string Author;

        //    public Book()
        //    {
        //        Title = "Untitled";
        //        Author = "Unknown";
        //    }

        //    public Book(string title)
        //    {
        //        Title = title;
        //        Author = "Unknown";
        //    }

        //    public Book(string title, string author)
        //    {
        //        Title = title;
        //        Author = author;
        //    }
        //}
        #endregion 
        #endregion

        #region part02
        #region problem9
        //public interface IShapeSeries
        //{
        //    int CurrentShapeArea { get; set; }
        //    void GetNextArea();
        //    void ResetSeries();
        //}

        //public class SquareSeries : IShapeSeries
        //{
        //    public int CurrentShapeArea { get; set; }
        //    private int side;

        //    public void GetNextArea()
        //    {
        //        side++;
        //        CurrentShapeArea = side * side;
        //    }

        //    public void ResetSeries()
        //    {
        //        side = 0;
        //        CurrentShapeArea = 0;
        //    }
        //}

        //public class CircleSeries : IShapeSeries
        //{
        //    public int CurrentShapeArea { get; set; }
        //    private int radius;

        //    public void GetNextArea()
        //    {
        //        radius++;
        //        CurrentShapeArea = (int)(Math.PI * radius * radius);
        //    }

        //    public void ResetSeries()
        //    {
        //        radius = 0;
        //        CurrentShapeArea = 0;
        //    }
        //}

        //static void PrintTenShapes(IShapeSeries series)
        //{
        //    series.ResetSeries();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        series.GetNextArea();
        //        Console.WriteLine(series.CurrentShapeArea);
        //    }
        //}
        #endregion

        #region problem10
        //public class ShapeP10 : IComparable<ShapeP10>
        //{
        //    public string Name;
        //    public double Area;

        //    public ShapeP10(string name, double area)
        //    {
        //        Name = name;
        //        Area = area;
        //    }

        //    public int CompareTo(ShapeP10 other)
        //    {
        //        return Area.CompareTo(other.Area);
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name}: {Area}";
        //    }
        //}
        #endregion

        #region problem11
        //public abstract class GeometricShape
        //{
        //    public double Dimension1;
        //    public double Dimension2;

        //    public abstract double CalculateArea();
        //    public abstract double Perimeter { get; }
        //}

        //public class Triangle : GeometricShape
        //{
        //    public Triangle(double dim1, double dim2)
        //    {
        //        Dimension1 = dim1;
        //        Dimension2 = dim2;
        //    }

        //    public override double CalculateArea()
        //    {
        //        return 0.5 * Dimension1 * Dimension2;
        //    }

        //    // simplified, task only gives us 2 dimensions to work with
        //    public override double Perimeter
        //    {
        //        get { return Dimension1 + Dimension2; }
        //    }
        //}

        //// renamed to avoid clashing with the Rectangle class from problem2
        //public class RectangleP11 : GeometricShape
        //{
        //    public RectangleP11(double dim1, double dim2)
        //    {
        //        Dimension1 = dim1;
        //        Dimension2 = dim2;
        //    }

        //    public override double CalculateArea()
        //    {
        //        return Dimension1 * Dimension2;
        //    }

        //    public override double Perimeter
        //    {
        //        get { return 2 * (Dimension1 + Dimension2); }
        //    }
        //}
        #endregion

        #region problem12
        //public static void SelectionSort(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length - 1; i++)
        //    {
        //        int minIndex = i;

        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            if (numbers[j] < numbers[minIndex])
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        int temp = numbers[minIndex];
        //        numbers[minIndex] = numbers[i];
        //        numbers[i] = temp;
        //    }
        //}
        #endregion

        #region problem13
        //public abstract class GeometricShape
        //{
        //    public double Dimension1;
        //    public double Dimension2;

        //    public abstract double CalculateArea();
        //    public abstract double Perimeter { get; }
        //}

        //public class Triangle : GeometricShape
        //{
        //    public Triangle(double dim1, double dim2)
        //    {
        //        Dimension1 = dim1;
        //        Dimension2 = dim2;
        //    }

        //    public override double CalculateArea()
        //    {
        //        return 0.5 * Dimension1 * Dimension2;
        //    }

        //    // simplified, we only have 2 dimensions to work with
        //    public override double Perimeter
        //    {
        //        get { return Dimension1 + Dimension2; }
        //    }
        //}

        //public class Rectangle : GeometricShape
        //{
        //    public Rectangle(double dim1, double dim2)
        //    {
        //        Dimension1 = dim1;
        //        Dimension2 = dim2;
        //    }

        //    public override double CalculateArea()
        //    {
        //        return Dimension1 * Dimension2;
        //    }

        //    public override double Perimeter
        //    {
        //        get { return 2 * (Dimension1 + Dimension2); }
        //    }
        //}

        //public class ShapeFactory
        //{
        //    public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        //    {
        //        if (shapeType == "Rectangle")
        //        {
        //            return new Rectangle(dim1, dim2);
        //        }
        //        else if (shapeType == "Triangle")
        //        {
        //            return new Triangle(dim1, dim2);
        //        }

        //        return null;
        //    }
        //}
        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region part01
            #region problem1
            //IVehicle v1 = new Car();
            //IVehicle v2 = new Bike();

            //v1.StartEngine();
            //v1.StopEngine();

            //v2.StartEngine();
            //v2.StopEngine();
            #endregion

            #region problem2
            //Shape rect = new Rectangle(4, 5);
            //Shape circle = new Circle(3);

            //rect.Display();
            //circle.Display();
            #endregion

            #region problem3
            //Product[] products = new Product[]
            //{
            //    new Product(1, "Laptop", 15000),
            //    new Product(2, "Mouse", 150),
            //    new Product(3, "Keyboard", 400)
            //};

            //Array.Sort(products);

            //foreach (Product p in products)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region problem4
            //Address addr = new Address { City = "Cairo" };
            //Student original = new Student(1, "Ali", "A", addr);

            //Student shallow = original;              // just copies the reference
            //Student deep = new Student(original);     // copy constructor, independent object

            //original.StudentAddress.City = "Alexandria";

            //Console.WriteLine("Shallow copy city: " + shallow.StudentAddress.City); // Alexandria, same object
            //Console.WriteLine("Deep copy city: " + deep.StudentAddress.City);       // Cairo, unaffected
            #endregion

            #region problem5
            //Robot robot = new Robot();
            //robot.Walk(); 

            //IWalkable walkable = robot;
            //walkable.Walk(); 
            #endregion

            #region problem6
            //Account acc = new Account(101, "Ahmed", 5000);
            //Console.WriteLine($"{acc.AccountId} - {acc.AccountHolder} - {acc.Balance}");

            //acc.Balance = 6000;
            //Console.WriteLine("New balance: " + acc.Balance);
            #endregion

            #region problem7
            //ILogger logger = new ConsoleLogger();
            //logger.Log(); // ConsoleLogger overrides the default, so its own message prints
            #endregion

            #region problem8
            //Book b1 = new Book();
            //Book b2 = new Book("C# Basics");
            //Book b3 = new Book("C# Advanced", "John Smith");

            //Console.WriteLine($"{b1.Title} by {b1.Author}");
            //Console.WriteLine($"{b2.Title} by {b2.Author}");
            //Console.WriteLine($"{b3.Title} by {b3.Author}");
            #endregion 
            #endregion

            #region part02
            #region problem9
            //SquareSeries squares = new SquareSeries();
            //Console.WriteLine("Square areas:");
            //PrintTenShapes(squares);

            //CircleSeries circles = new CircleSeries();
            //Console.WriteLine("Circle areas:");
            //PrintTenShapes(circles);
            #endregion

            #region problem10
            //ShapeP10[] shapes = new ShapeP10[]
            //{
            //    new ShapeP10("Square", 25),
            //    new ShapeP10("Circle", 78.5),
            //    new ShapeP10("Rectangle", 40)
            //};

            //Array.Sort(shapes);

            //foreach (ShapeP10 s in shapes)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region problem11
            //GeometricShape tri = new Triangle(4, 6);
            //GeometricShape rect = new RectangleP11(5, 3);

            //Console.WriteLine("Triangle -> Area: " + tri.CalculateArea() + ", Perimeter: " + tri.Perimeter);
            //Console.WriteLine("Rectangle -> Area: " + rect.CalculateArea() + ", Perimeter: " + rect.Perimeter);
            #endregion

            #region problem12
            //int[] areas = { 25, 78, 40, 12, 90 };

            //Console.WriteLine("Before: " + string.Join(", ", areas));
            //SelectionSort(areas);
            //Console.WriteLine("After: " + string.Join(", ", areas));
            #endregion

            #region problem13
            //GeometricShape shape1 = ShapeFactory.CreateShape("Rectangle", 5, 4);
            //GeometricShape shape2 = ShapeFactory.CreateShape("Triangle", 6, 3);
            #endregion
            #endregion
        }
    }
}
