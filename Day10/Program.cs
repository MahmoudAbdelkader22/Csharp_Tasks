using System;

namespace CsharpDay10
{
    internal class Program
    {

        #region problem1
        //public class EmployeeP1 : IComparable<EmployeeP1>
        //{
        //    public string Name;
        //    public double Salary;

        //    public EmployeeP1(string name, double salary)
        //    {
        //        Name = name;
        //        Salary = salary;
        //    }

        //    public int CompareTo(EmployeeP1 other)
        //    {
        //        return Salary.CompareTo(other.Salary);
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name} - {Salary}";
        //    }
        //}

        //public class SortingAlgorithmP1<T> where T : IComparable<T>
        //{
        //    public static void Sort(T[] array)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j].CompareTo(array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem2
        //public class SortingTwoP2<T>
        //{
        //    public static void Sort(T[] array, Comparison<T> comparer)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (comparer(array[j], array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem3
        //public class SortingTwoP3<T>
        //{
        //    public static void Sort(T[] array, Comparison<T> comparer)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (comparer(array[j], array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem4
        //public class EmployeeP4
        //{
        //    public string Name;
        //    public double Salary;

        //    public EmployeeP4(string name, double salary)
        //    {
        //        Name = name;
        //        Salary = salary;
        //    }
        //}

        //public class ManagerP4 : EmployeeP4, IComparable<ManagerP4>
        //{
        //    public ManagerP4(string name, double salary) : base(name, salary) { }

        //    public int CompareTo(ManagerP4 other)
        //    {
        //        return Salary.CompareTo(other.Salary);
        //    }
        //}

        //public class SortingAlgorithmP4<T> where T : IComparable<T>
        //{
        //    public static void Sort(T[] array)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j].CompareTo(array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem5
        //public class EmployeeP5
        //{
        //    public string Name;
        //    public double Salary;

        //    public EmployeeP5(string name, double salary)
        //    {
        //        Name = name;
        //        Salary = salary;
        //    }
        //}

        //static void SortWithFuncBoolP5<T>(T[] array, Func<T, T, bool> shouldSwap)
        //{
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        for (int j = 0; j < array.Length - i - 1; j++)
        //        {
        //            if (shouldSwap(array[j], array[j + 1]))
        //            {
        //                T temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem6
        //public class SortingTwoP6<T>
        //{
        //    public static void Sort(T[] array, Comparison<T> comparer)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (comparer(array[j], array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem7
        //public class SortingAlgorithmP7<T> where T : IComparable<T>
        //{
        //    public static void Sort(T[] array)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j].CompareTo(array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }

        //    // standalone generic method, its own type param TItem, independent from the class's T
        //    public static void Swap<TItem>(ref TItem a, ref TItem b)
        //    {
        //        TItem temp = a;
        //        a = b;
        //        b = temp;
        //    }
        //}
        #endregion

        #region problem8
        //public class EmployeeP8
        //{
        //    public string Name;
        //    public double Salary;

        //    public EmployeeP8(string name, double salary)
        //    {
        //        Name = name;
        //        Salary = salary;
        //    }
        //}

        //public class SortingTwoP8<T>
        //{
        //    public static void Sort(T[] array, Comparison<T> comparer)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (comparer(array[j], array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem9
        //static T GetDefault<T>()
        //{
        //    return default(T);
        //}
        #endregion

        #region problem10
        //public class EmployeeP10 : IComparable<EmployeeP10>, ICloneable
        //{
        //    public string Name;
        //    public double Salary;

        //    public EmployeeP10(string name, double salary)
        //    {
        //        Name = name;
        //        Salary = salary;
        //    }

        //    public int CompareTo(EmployeeP10 other)
        //    {
        //        return Salary.CompareTo(other.Salary);
        //    }

        //    public object Clone()
        //    {
        //        return new EmployeeP10(Name, Salary);
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name} - {Salary}";
        //    }
        //}

        //public class SortingAlgorithmP10<T> where T : IComparable<T>, ICloneable
        //{
        //    public static void Sort(T[] array)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j].CompareTo(array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region problem11
        //public delegate string StringTransformerP11(string input);

        //static List<string> TransformListP11(List<string> list, StringTransformerP11 transformer)
        //{
        //    List<string> result = new List<string>();

        //    foreach (string s in list)
        //    {
        //        result.Add(transformer(s));
        //    }

        //    return result;
        //}
        #endregion

        #region problem12
        //public delegate int MathOperationP12(int a, int b);

        //static int CalculateP12(int a, int b, MathOperationP12 operation)
        //{
        //    return operation(a, b);
        //}
        #endregion

        #region problem13
        //public delegate R TransformerP13<T, R>(T input);

        //static List<R> TransformListP13<T, R>(List<T> list, TransformerP13<T, R> transformer)
        //{
        //    List<R> result = new List<R>();

        //    foreach (T item in list)
        //    {
        //        result.Add(transformer(item));
        //    }

        //    return result;
        //}
        #endregion

        #region problem14
        //static List<int> ApplyFuncP14(List<int> list, Func<int, int> func)
        //{
        //    List<int> result = new List<int>();

        //    foreach (int item in list)
        //    {
        //        result.Add(func(item));
        //    }

        //    return result;
        //}
        #endregion

        #region problem15
        //static void ApplyActionP15(List<string> list, Action<string> action)
        //{
        //    foreach (string item in list)
        //    {
        //        action(item);
        //    }
        //}
        #endregion

        #region problem16
        //static List<int> FilterListP16(List<int> list, Predicate<int> predicate)
        //{
        //    List<int> result = new List<int>();

        //    foreach (int item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            result.Add(item);
        //        }
        //    }

        //    return result;
        //}
        #endregion

        #region problem17
        //static List<string> FilterStringsP17(List<string> list, Func<string, bool> condition)
        //{
        //    List<string> result = new List<string>();

        //    foreach (string s in list)
        //    {
        //        if (condition(s))
        //        {
        //            result.Add(s);
        //        }
        //    }

        //    return result;
        //}
        #endregion

        #region problem18
        //static int PerformOperationP18(int a, int b, Func<int, int, int> operation)
        //{
        //    return operation(a, b);
        //}
        #endregion

        #region problem19
        //static List<string> FilterStringsP19(List<string> list, Func<string, bool> condition)
        //{
        //    List<string> result = new List<string>();

        //    foreach (string s in list)
        //    {
        //        if (condition(s))
        //        {
        //            result.Add(s);
        //        }
        //    }

        //    return result;
        //}
        #endregion

        #region problem20
        //static double PerformOperationP20(double a, double b, Func<double, double, double> operation)
        //{
        //    return operation(a, b);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region problem1
            //EmployeeP1[] employees =
            //{
            //    new EmployeeP1("Ali", 7000),
            //    new EmployeeP1("Sara", 4000),
            //    new EmployeeP1("Omar", 5500)
            //};

            //SortingAlgorithmP1<EmployeeP1>.Sort(employees);

            //foreach (var e in employees)
            //{
            //    Console.WriteLine(e);
            //}
            #endregion

            #region problem2
            //int[] numbers = { 5, 3, 8, 1, 9 };

            //SortingTwoP2<int>.Sort(numbers, (a, b) => b.CompareTo(a)); // descending, via lambda

            //Console.WriteLine(string.Join(", ", numbers));
            #endregion

            #region problem3
            //string[] words = { "banana", "fig", "apple", "kiwi" };

            //SortingTwoP3<string>.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            //Console.WriteLine(string.Join(", ", words));
            #endregion

            #region problem4
            //ManagerP4[] managers =
            //{
            //    new ManagerP4("Khaled", 12000),
            //    new ManagerP4("Mona", 9000),
            //    new ManagerP4("Youssef", 15000)
            //};

            //SortingAlgorithmP4<ManagerP4>.Sort(managers);

            //foreach (var m in managers)
            //{
            //    Console.WriteLine(m.Name + " - " + m.Salary);
            //}
            #endregion

            #region problem5
            //Func<EmployeeP5, EmployeeP5, bool> compareByNameLength = (e1, e2) => e1.Name.Length > e2.Name.Length;

            //EmployeeP5[] employees =
            //{
            //    new EmployeeP5("Ali", 5000),
            //    new EmployeeP5("Mohammed", 7000),
            //    new EmployeeP5("Sara", 4000)
            //};

            //SortWithFuncBoolP5(employees, compareByNameLength);

            //foreach (var e in employees)
            //{
            //    Console.WriteLine(e.Name);
            //}
            #endregion

            #region problem6
            //int[] numbersAnon = { 5, 2, 9, 1 };
            //int[] numbersLambda = { 5, 2, 9, 1 };

            //// anonymous function
            //Comparison<int> ascendingAnon = delegate (int a, int b) { return a.CompareTo(b); };

            //// lambda expression
            //Comparison<int> ascendingLambda = (a, b) => a.CompareTo(b);

            //SortingTwoP6<int>.Sort(numbersAnon, ascendingAnon);
            //SortingTwoP6<int>.Sort(numbersLambda, ascendingLambda);

            //Console.WriteLine("Anonymous: " + string.Join(", ", numbersAnon));
            //Console.WriteLine("Lambda: " + string.Join(", ", numbersLambda));
            #endregion

            #region problem7
            //int x = 5;
            //int y = 10;

            //Console.WriteLine($"Before swap: x={x}, y={y}");

            //SortingAlgorithmP7<int>.Swap(ref x, ref y);

            //Console.WriteLine($"After swap: x={x}, y={y}");
            #endregion

            #region problem8
            //EmployeeP8[] employees =
            //{
            //    new EmployeeP8("Sara", 5000),
            //    new EmployeeP8("Ali", 5000),
            //    new EmployeeP8("Omar", 3000)
            //};

            //SortingTwoP8<EmployeeP8>.Sort(employees, (e1, e2) =>
            //{
            //    int salaryCompare = e1.Salary.CompareTo(e2.Salary);
            //    if (salaryCompare != 0)
            //    {
            //        return salaryCompare;
            //    }
            //    return e1.Name.CompareTo(e2.Name);
            //});

            //foreach (var e in employees)
            //{
            //    Console.WriteLine(e.Name + " - " + e.Salary);
            //}
            #endregion

            #region problem9
            //Console.WriteLine("default(int) = " + GetDefault<int>());
            //Console.WriteLine("default(bool) = " + GetDefault<bool>());
            //Console.WriteLine("default(double) = " + GetDefault<double>());
            //Console.WriteLine("default(string) = " + (GetDefault<string>() ?? "null"));
            #endregion

            #region problem10
            //EmployeeP10[] original =
            //{
            //    new EmployeeP10("Ali", 7000),
            //    new EmployeeP10("Sara", 4000)
            //};

            //EmployeeP10[] cloned = new EmployeeP10[original.Length];
            //for (int i = 0; i < original.Length; i++)
            //{
            //    cloned[i] = (EmployeeP10)original[i].Clone();
            //}

            //SortingAlgorithmP10<EmployeeP10>.Sort(cloned);

            //Console.WriteLine("Original (untouched):");
            //foreach (var e in original)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine("Cloned (sorted):");
            //foreach (var e in cloned)
            //{
            //    Console.WriteLine(e);
            //}
            #endregion

            #region problem11
            //List<string> words = new List<string> { "hello", "world" };

            //List<string> upper = TransformListP11(words, s => s.ToUpper());

            //List<string> reversed = TransformListP11(words, s =>
            //{
            //    char[] arr = s.ToCharArray();
            //    Array.Reverse(arr);
            //    return new string(arr);
            //});

            //Console.WriteLine("Upper: " + string.Join(", ", upper));
            //Console.WriteLine("Reversed: " + string.Join(", ", reversed));
            #endregion

            #region problem12
            //Console.WriteLine("Add: " + CalculateP12(5, 3, (a, b) => a + b));
            //Console.WriteLine("Subtract: " + CalculateP12(5, 3, (a, b) => a - b));
            //Console.WriteLine("Multiply: " + CalculateP12(5, 3, (a, b) => a * b));
            //Console.WriteLine("Divide: " + CalculateP12(5, 3, (a, b) => a / b));
            #endregion

            #region problem13
            //List<int> numbers = new List<int> { 1, 2, 3 };

            //List<string> strings = TransformListP13<int, string>(numbers, n => n.ToString());

            //Console.WriteLine(string.Join(", ", strings));
            #endregion

            #region problem14
            //Func<int, int> square = x => x * x;

            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //List<int> squares = ApplyFuncP14(numbers, square);

            //Console.WriteLine(string.Join(", ", squares));
            #endregion

            #region problem15
            //Action<string> printAction = s => Console.WriteLine(s);

            //List<string> names = new List<string> { "Ali", "Sara", "Omar" };
            //ApplyActionP15(names, printAction);
            #endregion

            #region problem16
            //Predicate<int> isEven = x => x % 2 == 0;

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> evens = FilterListP16(numbers, isEven);

            //Console.WriteLine(string.Join(", ", evens));
            #endregion

            #region problem17
            //List<string> words = new List<string> { "apple", "banana", "avocado", "grape" };

            //Func<string, bool> startsWithA = delegate (string s) { return s.StartsWith("a"); };
            //Func<string, bool> containsAn = delegate (string s) { return s.Contains("an"); };

            //List<string> startWithAResult = FilterStringsP17(words, startsWithA);
            //List<string> containsAnResult = FilterStringsP17(words, containsAn);

            //Console.WriteLine("Starts with a: " + string.Join(", ", startWithAResult));
            //Console.WriteLine("Contains 'an': " + string.Join(", ", containsAnResult));
            #endregion

            #region problem18
            //Func<int, int, int> add = delegate (int a, int b) { return a + b; };
            //Func<int, int, int> subtract = delegate (int a, int b) { return a - b; };
            //Func<int, int, int> multiply = delegate (int a, int b) { return a * b; };

            //Console.WriteLine("Add: " + PerformOperationP18(5, 3, add));
            //Console.WriteLine("Subtract: " + PerformOperationP18(5, 3, subtract));
            //Console.WriteLine("Multiply: " + PerformOperationP18(5, 3, multiply));
            #endregion

            #region problem19
            //List<string> words = new List<string> { "cat", "house", "tree", "e", "sun" };

            //List<string> longerThan3 = FilterStringsP19(words, s => s.Length > 3);
            //List<string> containsE = FilterStringsP19(words, s => s.Contains("e"));

            //Console.WriteLine("Length > 3: " + string.Join(", ", longerThan3));
            //Console.WriteLine("Contains 'e': " + string.Join(", ", containsE));
            #endregion

            #region problem20
            //Func<double, double, double> divide = (a, b) => a / b;
            //Func<double, double, double> power = (a, b) => Math.Pow(a, b);

            //Console.WriteLine("Divide: " + PerformOperationP20(10, 3, divide));
            //Console.WriteLine("Power: " + PerformOperationP20(2, 5, power));
            #endregion
        }
    }
}
