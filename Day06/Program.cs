using System;

namespace Csharp_Day06
{
    internal class Program
    {
        #region problem1
        //public struct Point
        //{
        //    public int X;
        //    public int Y;

        //    // Parameterized constructor
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    public override string ToString()
        //    {
        //        return $"({X}, {Y})";
        //    }
        //}
        #endregion

        #region problem2
        //public class TypeA
        //{
        //    private int F = 1;
        //    internal int G = 2;
        //    public int H = 3;

        //    public void ShowFromInside()
        //    {
        //        // F is accessible here because we are inside TypeA itself
        //        Console.WriteLine("Inside TypeA -> F = " + F + ", G = " + G + ", H = " + H);
        //    }
        //}

        //// Another class in the SAME project
        //public class AccessDemo
        //{
        //    public void AccessMembers()
        //    {
        //        TypeA obj = new TypeA();

        //        // F is private -> NOT accessible here (would cause a compile error)
        //        // Console.WriteLine(obj.F);

        //        // G is internal -> accessible because AccessDemo is in the same assembly
        //        Console.WriteLine("G (internal) = " + obj.G);

        //        // H is public -> accessible from anywhere, even a different assembly
        //        Console.WriteLine("H (public) = " + obj.H);
        //    }
        //}
        #endregion

        #region problem3
        //public struct Employee
        //{
        //    private int empId;
        //    private string name;
        //    private double salary;

        //    public Employee(int empId, string name, double salary)
        //    {
        //        this.empId = empId;
        //        this.name = name;
        //        this.salary = salary;
        //    }

        //    // Methods to access the private "name" field
        //    public string GetName()
        //    {
        //        return name;
        //    }

        //    public void SetName(string newName)
        //    {
        //        name = newName;
        //    }

        //    // Properties to access the other private fields
        //    public int EmpId
        //    {
        //        get { return empId; }
        //        set { empId = value; }
        //    }

        //    public double Salary
        //    {
        //        get { return salary; }
        //        set { salary = value; }
        //    }
        //}
        #endregion

        #region problem4
        //public struct Point
        //{
        //    public int X;
        //    public int Y;

        //    // Overload 1: sets X to a specific value, Y defaults to 0
        //    public Point(int x)
        //    {
        //        X = x;
        //        Y = 0;
        //    }

        //    // Overload 2: sets both X and Y to specific values
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}
        #endregion

        #region problem5
        //public struct Point
        //{
        //    public int X;
        //    public int Y;

        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    // Custom formatted ToString
        //    public override string ToString()
        //    {
        //        return $"Point -> X: {X}, Y: {Y}";
        //    }
        //}
        #endregion

        #region problem6
        //public struct PointVT
        //{
        //    public int X;
        //    public int Y;
        //}

        //public class EmployeeRT
        //{
        //    public string Name;
        //}

        //static void ModifyStruct(PointVT p)
        //{
        //    // This only changes the local copy, since struct is a value type
        //    p.X = 999;
        //}

        //static void ModifyClass(EmployeeRT e)
        //{
        //    // This changes the actual object, since class is a reference type
        //    e.Name = "Changed";
        //}
        #endregion
        static void Main(string[] args)
        {
            #region problem1
            //Point p1 = new Point();
            //Point p2 = new Point(5, 10);
            //Console.WriteLine("p1: " + p1);
            //Console.WriteLine("p2: " + p2);
            #endregion

            #region problem2
            //TypeA a = new TypeA();
            //a.ShowFromInside();

            //AccessDemo demo = new AccessDemo();
            //demo.AccessMembers();
            #endregion

            #region problem3
            //Employee emp = new Employee(101, "Mahmoud", 5000);
            //Console.WriteLine("Name: " + emp.GetName());

            //emp.SetName("Abdo");
            //Console.WriteLine("Updated Name: " + emp.GetName());

            //emp.Salary = 6000;
            //Console.WriteLine("Salary: " + emp.Salary);
            #endregion

            #region problem4
            //Point p1 = new Point(5);
            //Point p2 = new Point(3, 8);

            //Console.WriteLine($"p1: X={p1.X}, Y={p1.Y}");
            //Console.WriteLine($"p2: X={p2.X}, Y={p2.Y}");
            #endregion

            #region problem5
            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(10, 20);
            //Point p3 = new Point(-5, 7);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            #endregion

            #region problem6
            //PointVT point = new PointVT { X = 1, Y = 2 };
            //ModifyStruct(point);
            //Console.WriteLine("After ModifyStruct: X = " + point.X);

            //EmployeeRT emp = new EmployeeRT { Name = "Original" };
            //ModifyClass(emp);
            //Console.WriteLine("After ModifyClass: Name = " + emp.Name);
            #endregion
        }
    }
}
    