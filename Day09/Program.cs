using System;

namespace CsharpDay09
{
    internal class Program
    {

        #region problem1
        //public enum Weekdays
        //{
        //    Monday = 1,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday
        //}
        #endregion

        #region problem2
        //public enum GradesP2 : short
        //{
        //    A = 4,
        //    B = 3,
        //    C = 2,
        //    D = 1,
        //    F = -1
        //}
        #endregion

        #region problem3
        //public class PersonP3
        //{
        //    public string Name;
        //    public string Department;

        //    public PersonP3(string name, string department)
        //    {
        //        Name = name;
        //        Department = department;
        //    }
        //}
        #endregion

        #region problem4
        //public class ParentP4
        //{
        //    private double salary;

        //    public ParentP4(double salary)
        //    {
        //        this.salary = salary;
        //    }

        //    public virtual double Salary
        //    {
        //        get { return salary; }
        //        set { salary = value; }
        //    }
        //}

        //public class ChildP4 : ParentP4
        //{
        //    public ChildP4(double salary) : base(salary) { }

        //    // sealed override, so no further derived class can override Salary again
        //    public sealed override double Salary
        //    {
        //        get { return base.Salary; }
        //        set { base.Salary = value; }
        //    }

        //    public void DisplaySalary()
        //    {
        //        Console.WriteLine("Salary: " + Salary);
        //    }
        //}
        #endregion

        #region problem5
        //public static class UtilityP5
        //{
        //    public static double Perimeter(double length, double width)
        //    {
        //        return 2 * (length + width);
        //    }
        //}
        #endregion

        #region problem6
        //public class ComplexNumber
        //{
        //    public double Real;
        //    public double Imaginary;

        //    public ComplexNumber(double real, double imaginary)
        //    {
        //        Real = real;
        //        Imaginary = imaginary;
        //    }

        //    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        //    {
        //        double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
        //        double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
        //        return new ComplexNumber(real, imaginary);
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Real} + {Imaginary}i";
        //    }
        //}
        #endregion

        #region problem7
        //public enum GenderP7 : byte
        //{
        //    Male = 0,
        //    Female = 1
        //}
        #endregion

        #region problem8
        //public static class UtilityP8
        //{
        //    public static double CelsiusToFahrenheit(double celsius)
        //    {
        //        return (celsius * 9 / 5) + 32;
        //    }

        //    public static double FahrenheitToCelsius(double fahrenheit)
        //    {
        //        return (fahrenheit - 32) * 5 / 9;
        //    }
        //}
        #endregion

        #region problem9
        //public enum GradesP9
        //{
        //    A, B, C, D, F
        //}
        #endregion

        #region problem10
        //public class EmployeeP10
        //{
        //    public int Id;
        //    public string Name;

        //    public EmployeeP10(int id, string name)
        //    {
        //        Id = id;
        //        Name = name;
        //    }

        //    public override bool Equals(object obj)
        //    {
        //        if (obj is EmployeeP10 other)
        //        {
        //            return Id == other.Id && Name == other.Name;
        //        }

        //        return false;
        //    }

        //    public override int GetHashCode()
        //    {
        //        return HashCode.Combine(Id, Name);
        //    }
        //}

        //public class Helper2P10<T>
        //{
        //    public static int SearchArray(T[] array, T target)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i].Equals(target))
        //            {
        //                return i;
        //            }
        //        }

        //        return -1;
        //    }
        //}
        #endregion

        #region problem11
        //public class HelperP11
        //{
        //    public static T Max<T>(T a, T b) where T : IComparable<T>
        //    {
        //        return a.CompareTo(b) > 0 ? a : b;
        //    }
        //}
        #endregion

        #region problem12
        //public class Helper2P12<T>
        //{
        //    public static void ReplaceArray(T[] array, T oldValue, T newValue)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i].Equals(oldValue))
        //            {
        //                array[i] = newValue;
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem13
        //public struct RectangleP13
        //{
        //    public double Length;
        //    public double Width;
        //}

        //static void SwapRectangles(ref RectangleP13 a, ref RectangleP13 b)
        //{
        //    RectangleP13 temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        #region problem14
        //public class DepartmentP14
        //{
        //    public string Name;

        //    public DepartmentP14(string name)
        //    {
        //        Name = name;
        //    }
        //}

        //public class EmployeeP14
        //{
        //    public int Id;
        //    public string Name;
        //    public DepartmentP14 Department;

        //    public EmployeeP14(int id, string name, DepartmentP14 department)
        //    {
        //        Id = id;
        //        Name = name;
        //        Department = department;
        //    }
        //}

        //public class Helper2P14<T>
        //{
        //    public static int SearchArray(T[] array, T target)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i].Equals(target))
        //            {
        //                return i;
        //            }
        //        }

        //        return -1;
        //    }
        //}
        #endregion

        #region problem15
        //public struct CircleStruct
        //{
        //    public double Radius;
        //    public string Color;
        //}

        //public class CircleClass
        //{
        //    public double Radius;
        //    public string Color;
        //}
        #endregion

        #region part2problem1
        //static T[] ReverseArray<T>(T[] array)
        //{
        //    T[] result = new T[array.Length];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        result[i] = array[array.Length - 1 - i];
        //    }

        //    return result;
        //}
        #endregion

        #region part2problem2
        //public class MyStack<T>
        //{
        //    private List<T> items = new List<T>();

        //    public void Push(T item)
        //    {
        //        items.Add(item);
        //    }

        //    public T Pop()
        //    {
        //        T top = items[items.Count - 1];
        //        items.RemoveAt(items.Count - 1);
        //        return top;
        //    }

        //    public T Peek()
        //    {
        //        return items[items.Count - 1];
        //    }
        //}
        #endregion

        #region part2problem3
        //static void SwapElements<T>(T[] array, int index1, int index2)
        //{
        //    T temp = array[index1];
        //    array[index1] = array[index2];
        //    array[index2] = temp;
        //}
        #endregion

        #region part2problem4
        //static T FindMax<T>(T[] array) where T : IComparable<T>
        //{
        //    T max = array[0];

        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i].CompareTo(max) > 0)
        //        {
        //            max = array[i];
        //        }
        //    }

        //    return max;
        //}
        #endregion

        static void Main(string[] args)
        {
            #region problem1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine(day + " = " + (int)day);
            //}
            #endregion

            #region problem2
            //foreach (GradesP2 grade in Enum.GetValues(typeof(GradesP2)))
            //{
            //    Console.WriteLine(grade + " = " + (short)grade);
            //}
            #endregion

            #region problem3
            //PersonP3 p1 = new PersonP3("Ali", "IT");
            //PersonP3 p2 = new PersonP3("Sara", "HR");

            //Console.WriteLine($"{p1.Name} - {p1.Department}");
            //Console.WriteLine($"{p2.Name} - {p2.Department}");
            #endregion

            #region problem4
            //ChildP4 emp = new ChildP4(5000);
            //emp.DisplaySalary();
            #endregion

            #region problem5
            //Console.WriteLine("Perimeter = " + UtilityP5.Perimeter(5, 3));
            #endregion

            #region problem6
            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(1, 4);

            //ComplexNumber result = c1 * c2;
            //Console.WriteLine("Result: " + result);
            #endregion

            #region problem7
            //Console.WriteLine("Size of GenderP7 (byte): " + Marshal.SizeOf(typeof(GenderP7)) + " byte(s)");
            //Console.WriteLine("Size of int: " + Marshal.SizeOf(typeof(int)) + " byte(s)");
            #endregion

            #region problem8
            //Console.WriteLine("25C in F = " + UtilityP8.CelsiusToFahrenheit(25));
            //Console.WriteLine("77F in C = " + UtilityP8.FahrenheitToCelsius(77));
            #endregion

            #region problem9
            //Console.Write("Enter a grade (A, B, C, D, F): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse<GradesP9>(input, true, out GradesP9 grade))
            //{
            //    Console.WriteLine("Parsed grade: " + grade);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered.");
            //}
            #endregion

            #region problem10
            //EmployeeP10[] employees = new EmployeeP10[]
            //{
            //    new EmployeeP10(1, "Ali"),
            //    new EmployeeP10(2, "Sara"),
            //    new EmployeeP10(3, "Omar")
            //};

            //EmployeeP10 searchTarget = new EmployeeP10(2, "Sara");
            //int index = Helper2P10<EmployeeP10>.SearchArray(employees, searchTarget);

            //Console.WriteLine(index != -1 ? "Found at index: " + index : "Not found");
            #endregion

            #region problem11
            //Console.WriteLine("Max int: " + HelperP11.Max(5, 10));
            //Console.WriteLine("Max double: " + HelperP11.Max(3.5, 2.1));
            //Console.WriteLine("Max string: " + HelperP11.Max("apple", "banana"));
            #endregion

            #region problem12
            //int[] numbers = { 1, 2, 3, 2, 5 };
            //Helper2P12<int>.ReplaceArray(numbers, 2, 99);
            //Console.WriteLine(string.Join(", ", numbers));

            //string[] words = { "cat", "dog", "cat", "bird" };
            //Helper2P12<string>.ReplaceArray(words, "cat", "fish");
            //Console.WriteLine(string.Join(", ", words));
            #endregion

            #region problem13
            //RectangleP13 r1 = new RectangleP13 { Length = 5, Width = 3 };
            //RectangleP13 r2 = new RectangleP13 { Length = 8, Width = 6 };

            //Console.WriteLine($"Before: r1({r1.Length},{r1.Width}) r2({r2.Length},{r2.Width})");

            //SwapRectangles(ref r1, ref r2);

            //Console.WriteLine($"After: r1({r1.Length},{r1.Width}) r2({r2.Length},{r2.Width})");
            #endregion

            #region problem14
            //DepartmentP14 it = new DepartmentP14("IT");
            //DepartmentP14 hr = new DepartmentP14("HR");

            //EmployeeP14[] employees = new EmployeeP14[]
            //{
            //    new EmployeeP14(1, "Ali", it),
            //    new EmployeeP14(2, "Sara", hr)
            //};

            //DepartmentP14[] departments = { employees[0].Department, employees[1].Department };

            //// This works because "it" is the exact same object reference stored in employees[0].Department.
            //// A new DepartmentP14("IT") with the same Name would NOT be found here, since Department
            //// doesn't override Equals - the default is reference comparison.
            //int index = Helper2P14<DepartmentP14>.SearchArray(departments, it);
            //Console.WriteLine(index != -1 ? "Found at index: " + index : "Not found");
            #endregion

            #region problem15
            //CircleStruct cs1 = new CircleStruct { Radius = 5, Color = "Red" };
            //CircleStruct cs2 = new CircleStruct { Radius = 5, Color = "Red" };

            //// structs: Equals compares field values by default
            //Console.WriteLine("Struct Equals: " + cs1.Equals(cs2)); // true

            //// == is NOT defined by default for structs, this line would not compile:
            //// Console.WriteLine(cs1 == cs2);

            //CircleClass cc1 = new CircleClass { Radius = 5, Color = "Red" };
            //CircleClass cc2 = new CircleClass { Radius = 5, Color = "Red" };

            //// classes: both Equals and == compare references by default
            //Console.WriteLine("Class Equals: " + cc1.Equals(cc2)); // false, different objects
            //Console.WriteLine("Class ==: " + (cc1 == cc2));        // false, different objects
            #endregion

            #region part2problem1
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int[] reversedNums = ReverseArray(nums);
            //Console.WriteLine(string.Join(", ", reversedNums));

            //string[] words = { "a", "b", "c" };
            //string[] reversedWords = ReverseArray(words);
            //Console.WriteLine(string.Join(", ", reversedWords));
            #endregion

            #region part2problem2
            //MyStack<int> stack = new MyStack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine("Peek: " + stack.Peek());
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Peek after pop: " + stack.Peek());
            #endregion

            #region part2problem3
            //int[] numbers = { 10, 20, 30 };
            //SwapElements(numbers, 0, 2);
            //Console.WriteLine(string.Join(", ", numbers));
            #endregion

            #region part2problem4
            //int[] nums = { 4, 8, 2, 10, 6 };
            //Console.WriteLine("Max: " + FindMax(nums));
            #endregion
        
            
        }
    }
}
