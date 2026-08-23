using System;
using System.Text;

namespace CsharpDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part01
            #region problem 1
            //Console.WriteLine("enter the number");
            //string Name = Console.ReadLine();

            //try
            //{
            //    int number1 = int.Parse(Name);
            //    int number2 = Convert.ToInt32(Name);

            //    Console.WriteLine($"using int.parse : {number1}");
            //    Console.WriteLine($"using convert.ToInt32 : {number2}");
            //}

            //catch (Exception error)
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer");

            //}
            #endregion

            #region problem 2
            //Console.WriteLine("input a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    Console.WriteLine($"your number is : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid integer input!");
            //} 
            #endregion

            #region problem 3
            //object value;

            //value = 10;
            //Console.WriteLine("Integer value: " + value);
            //Console.WriteLine("HashCode: " + value.GetHashCode());

            //value = "Hello";
            //Console.WriteLine("\nString value: " + value);
            //Console.WriteLine("HashCode: " + value.GetHashCode());

            //value = 10.5;
            //Console.WriteLine("\nDouble value: " + value);
            //Console.WriteLine("HashCode: " + value.GetHashCode()); 
            #endregion

            #region problem 4
            //StringBuilder object1 = new StringBuilder("wlcome");

            //StringBuilder object2 = object1;

            //object1.Append(" To C#");


            //Console.WriteLine(object2); 
            #endregion

            #region problem 5
            //string text = "Hello ";


            //Console.WriteLine($"String:   {text}");
            //Console.WriteLine($"HashCode:  {text.GetHashCode()}");

            //text += "Hi Willy";


            //Console.WriteLine($"String:   {text}");
            //Console.WriteLine($"HashCode:  {text.GetHashCode()"}); 
            #endregion

            #region problem 6
            //StringBuilder text = new StringBuilder("Hi Willy");

            //Console.WriteLine($"Text: {text}");
            //Console.WriteLine($"HashCode:  { text.GetHashCode()}");

            //text.Append(" Welcome!");

            //Console.WriteLine($"Text: {text}");
            //Console.WriteLine($"HashCode: { text.GetHashCode()}"); 
            #endregion

            #region problem 7
            //Console.Write("Enter the first number: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;

            //// 1. Concatenation
            //Console.WriteLine("Sum is " + input1 + "+" + input2 + " = " + sum);

            //// 2. Composite Formatting
            //Console.WriteLine(string.Format("Sum is {0}+{1} = {2}", input1, input2, sum));

            //// 3. String Interpolation
            //Console.WriteLine($"Sum is {input1}+{input2} = {sum}"); 
            #endregion

            #region problem 8 
            //StringBuilder text = new StringBuilder("Hello World");


            //text.Append(" Welcome");
            //Console.WriteLine("After Append: " + text);


            //text.Replace("World", "Willy");
            //Console.WriteLine("After Replace: " + text);


            //text.Insert(6, "Hi ");
            //Console.WriteLine("After Insert: " + text);


            //text.Remove(6, 3);
            //Console.WriteLine("After Remove: " + text); 
            #endregion


        }
    }
}
