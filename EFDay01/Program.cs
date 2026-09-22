using System;
using System.Collections;
using System.Collections.Generic;


namespace EFDay01
{


    #region problem6
    //public static class StringExtensions
    //{
    //    public static bool IsPalindrome(this string s)
    //    {
    //        int left = 0;
    //        int right = s.Length - 1;

    //        while (left < right)
    //        {
    //            if (s[left] != s[right])
    //            {
    //                return false;
    //            }

    //            left++;
    //            right--;
    //        }

    //        return true;
    //    }
    //}
    #endregion


    #region problem7
    //public static class IntExtensions
    //{
    //    public static bool IsPrime(this int number)
    //    {
    //        if (number < 2)
    //        {
    //            return false;
    //        }

    //        for (int i = 2; i <= Math.Sqrt(number); i++)
    //        {
    //            if (number % i == 0)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }
    //}
    #endregion


    #region problem8
    //public static class ArrayExtensions
    //{
    //    // custom Sum, no LINQ used
    //    public static int Sum(this int[] array)
    //    {
    //        int total = 0;

    //        foreach (int num in array)
    //        {
    //            total += num;
    //        }

    //        return total;
    //    }
    //}
    #endregion


    #region problem10
    //public class EmployeeP10
    //{
    //    public string Name;
    //    public double Salary;

    //    public EmployeeP10(string name, double salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }
    //}
    #endregion


    internal class Program
    {

        static void Main(string[] args)
        {
            #region problem1
            //var number = 5;
            //var text = "hello";
            //var price = 19.99;
            //var isActive = true;
            //var numbers = new int[] { 1, 2, 3 };

            //Console.WriteLine(number.GetType());
            //Console.WriteLine(text.GetType());
            //Console.WriteLine(price.GetType());
            //Console.WriteLine(isActive.GetType());
            //Console.WriteLine(numbers.GetType());
            #endregion

            #region problem2
            //// explicit types
            //int x1 = 10;
            //string s1 = "test";
            //double d1 = 2.5;
            //bool b1 = true;

            //// same declarations using var
            //var x2 = 10;
            //var s2 = "test";
            //var d2 = 2.5;
            //var b2 = true;

            //// The result is exactly the same at compile time because var is not a dynamic
            //// or loosely-typed variable. The compiler infers the actual type from the
            //// right-hand side expression during compilation itself, and generates the exact
            //// same IL code either way. var is only a compile-time convenience for the
            //// developer; there is no difference at all once the code is compiled or running.

            //Console.WriteLine(x2 + " " + s2 + " " + d2 + " " + b2);
            #endregion

            #region problem3
            //var product = new { Name = "Laptop", Price = 15000, Quantity = 3 };

            //Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            #endregion

            #region problem4
            //var students = new[]
            //{
            //    new { Name = "Ali", Grade = "A" },
            //    new { Name = "Sara", Grade = "B" },
            //    new { Name = "Omar", Grade = "C" }
            //};

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Name} - {student.Grade}");
            //}
            #endregion

            #region problem5
            //var order = new
            //{
            //    OrderId = 1,
            //    Customer = new { Name = "Mona", City = "Cairo" },
            //    Total = 250.5
            //};

            //Console.WriteLine($"Order #{order.OrderId} - Customer: {order.Customer.Name} from {order.Customer.City} - Total: {order.Total}");
            #endregion

            #region problem6
            //Console.WriteLine("level".IsPalindrome());
            //Console.WriteLine("hello".IsPalindrome());
            //Console.WriteLine("civic".IsPalindrome());
            #endregion

            #region problem7
            //int num1 = 7;
            //int num2 = 10;
            //int num3 = 13;

            //Console.WriteLine(num1 + " is prime: " + num1.IsPrime());
            //Console.WriteLine(num2 + " is prime: " + num2.IsPrime());
            //Console.WriteLine(num3 + " is prime: " + num3.IsPrime());
            #endregion

            #region problem8
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Sum: " + numbers.Sum());
            #endregion

            #region problem9
            //List<string> employees = new List<string>();
            //employees.Add("Ali");
            //employees.Add("Sara");
            //employees.Add("Omar");

            //employees.Remove("Sara");

            //string searchName = "Omar";
            //bool found = false;

            //foreach (string name in employees)
            //{
            //    if (name == searchName)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(found ? searchName + " found" : searchName + " not found");

            //Console.WriteLine("Final list:");
            //foreach (string name in employees)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region problem10
            //List<EmployeeP10> employees = new List<EmployeeP10>
            //{
            //    new EmployeeP10("Ali", 6000),
            //    new EmployeeP10("Sara", 4000),
            //    new EmployeeP10("Omar", 8000)
            //};

            //double minSalary = 5000;

            //foreach (var emp in employees)
            //{
            //    if (emp.Salary > minSalary)
            //    {
            //        Console.WriteLine(emp.Name + " - " + emp.Salary);
            //    }
            //}
            #endregion

            #region problem11
            //Dictionary<string, double> products = new Dictionary<string, double>();
            //products.Add("Laptop", 15000);
            //products.Add("Mouse", 150);
            //products.Add("Keyboard", 400);

            //foreach (var pair in products)
            //{
            //    Console.WriteLine(pair.Key + " - " + pair.Value);
            //}
            #endregion

            #region problem12
            //Dictionary<int, string> students = new Dictionary<int, string>
            //{
            //    { 1, "Ali" },
            //    { 2, "Sara" },
            //    { 3, "Omar" }
            //};

            //Console.Write("Enter student ID: ");
            //int id = int.Parse(Console.ReadLine());

            //if (students.TryGetValue(id, out string name))
            //{
            //    Console.WriteLine("Student name: " + name);
            //}
            //else
            //{
            //    Console.WriteLine("No student found with this ID.");
            //}
            #endregion

            #region problem13
            //Hashtable table = new Hashtable();
            //table.Add(1, "One");
            //table.Add("Two", 2);
            //table.Add(3.5, true);

            //foreach (DictionaryEntry entry in table)
            //{
            //    Console.WriteLine(entry.Key + " -> " + entry.Value);
            //}
            #endregion

            #region problem14
            //Dictionary<int, string> dict = new Dictionary<int, string>
            //{
            //    { 1, "Ali" },
            //    { 2, "Sara" }
            //};

            //Hashtable hash = new Hashtable();
            //hash.Add(1, "Ali");
            //hash.Add(2, "Sara");

            //// Dictionary<int, string> is strongly typed: dict[1] directly returns a string,
            //// no casting needed, and a type mistake is caught by the compiler.
            //// Hashtable stores everything as object, so hash[1] returns an object and
            //// needs an explicit cast, e.g. (string)hash[1], to be used as a string -
            //// a wrong-type mistake there would only surface at runtime, not compile time.

            //string dictValue = dict[1];
            //string hashValue = (string)hash[1];

            //Console.WriteLine("Dictionary value: " + dictValue);
            //Console.WriteLine("Hashtable value: " + hashValue);
            #endregion
        }
    }
}
