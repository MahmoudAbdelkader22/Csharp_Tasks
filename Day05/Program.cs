using System;

namespace CSharpDay05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete.");
            //}
            #endregion

            #region problem2
            //static void TestDefensiveCode()
            //{
            //    int x, y;

            //    do
            //    {
            //        Console.Write("Enter a positive value for X: ");
            //    } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

            //    do
            //    {
            //        Console.Write("Enter a value for Y (must be greater than 1): ");
            //    } while (!int.TryParse(Console.ReadLine(), out y) || y <= 1);

            //    Console.WriteLine($"X = {x}, Y = {y}");
            //}

            //TestDefensiveCode();
            #endregion

            #region problem3
            //int? number = null;

            //int defaultValue = number ?? 10;
            //Console.WriteLine("Value using ?? operator: " + defaultValue);

            //if (number.HasValue)
            //{
            //    Console.WriteLine("Number has a value: " + number.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Number has no value.");
            //}

            //number = 25;

            //if (number.HasValue)
            //{
            //    Console.WriteLine("Now number has a value: " + number.Value);
            //}
            #endregion

            #region problem4
            //int[] arr = new int[5];

            //try
            //{
            //    Console.WriteLine(arr[10]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index is out of range.");
            //}
            #endregion

            #region problem5
            //int[,] arr = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value [{i},{j}]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int rowSum = 0;

            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        rowSum += arr[i, j];
            //    }

            //    Console.WriteLine($"Sum of row {i} = {rowSum}");
            //}

            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    int colSum = 0;

            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        colSum += arr[i, j];
            //    }

            //    Console.WriteLine($"Sum of column {j} = {colSum}");
            //}
            #endregion

            #region problem6
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[2];
            //jagged[1] = new int[4];
            //jagged[2] = new int[3];

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for row {i}, column {j}: ");
            //        jagged[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.Write($"Row {i}: ");

            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region problem7
            //#nullable enable
            //string? name = null;

            //Console.Write("Do you want to enter your name? (y/n): ");
            //string? answer = Console.ReadLine();

            //if (answer == "y")
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine("Name: " + name!);
            //#nullable disable
            #endregion

            #region problem8
            //int num = 100;
            //object boxed = num;
            //Console.WriteLine("Boxed value: " + boxed);

            //int unboxed = (int)boxed;
            //Console.WriteLine("Unboxed value: " + unboxed);

            //try
            //{
            //    double invalid = (double)boxed;
            //    Console.WriteLine(invalid);
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Invalid cast detected.");
            //}
            #endregion

            #region problem9
            //static void SumAndMultiply(int a, int b, out int sum, out int product)
            //{
            //    sum = a + b;
            //    product = a * b;
            //}

            //// call inside Main:
            //// SumAndMultiply(5, 3, out int sum, out int product);
            //// Console.WriteLine("Sum = " + sum);
            //// Console.WriteLine("Product = " + product);
            #endregion

            #region problem10
            //static void PrintString(string text, int times = 5)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        Console.WriteLine(text);
            //    }
            //}

            //// calls inside Main:
            //// PrintString("Hello");
            //// PrintString(text: "Hi", times: 3);
            #endregion

            #region problem11
            //int[]? numbers = null;
            //Console.WriteLine("Length: " + numbers?.Length);

            //numbers = new int[] { 1, 2, 3 };
            //Console.WriteLine("Length: " + numbers?.Length);
            #endregion

            #region problem12
            //Console.Write("Enter day name (e.g. Monday): ");
            //string day = Console.ReadLine();

            //int dayNumber = day switch
            //{
            //    "Monday" => 1,
            //    "Tuesday" => 2,
            //    "Wednesday" => 3,
            //    "Thursday" => 4,
            //    "Friday" => 5,
            //    "Saturday" => 6,
            //    "Sunday" => 7,
            //    _ => -1
            //};

            //Console.WriteLine("Day number: " + dayNumber);
            #endregion

            #region problem13
            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;

            //    foreach (int n in numbers)
            //    {
            //        sum += n;
            //    }

            //    return sum;
            //}

            //// calls inside Main:
            //// int[] arr = { 1, 2, 3, 4 };
            //// Console.WriteLine("Sum from array: " + SumArray(arr));
            //// Console.WriteLine("Sum from values: " + SumArray(10, 20, 30));
            #endregion

            #region program1
            //Console.Write("Enter a positive integer: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i);

            //    if (i != n)
            //    {
            //        Console.Write(", ");
            //    }
            //}

            //Console.WriteLine();
            #endregion

            #region program2
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i);

            //    if (i != 12)
            //    {
            //        Console.Write(", ");
            //    }
            //}

            //Console.WriteLine();
            #endregion

            #region program3
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i);

            //    if (i + 2 <= n)
            //    {
            //        Console.Write(", ");
            //    }
            //}

            //Console.WriteLine();
            #endregion

            #region program4
            //Console.Write("Enter base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine("Result: " + result);
            #endregion

            #region program5
            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //char[] charArray = text.ToCharArray();
            //Array.Reverse(charArray);
            //string reversed = new string(charArray);

            //Console.WriteLine("Reversed: " + reversed);
            #endregion

            #region program6
            //Console.Write("Enter an integer: ");
            //string numStr = Console.ReadLine();

            //char[] digits = numStr.ToCharArray();
            //Array.Reverse(digits);
            //string reversedStr = new string(digits);
            //int reversedNum = int.Parse(reversedStr);

            //Console.WriteLine("Reversed: " + reversedNum);
            #endregion

            #region program7
            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter value [{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;

            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Longest distance: " + maxDistance);
            #endregion

            #region program8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));
            #endregion
        }
    }
}