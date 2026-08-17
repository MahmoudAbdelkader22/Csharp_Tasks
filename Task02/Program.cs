using System;


namespace CsharpDay02
{
    internal class Program
    {
        
        class Number // Regarding the fourth problem
        {
            public int X;
        }
        static void Main(string[] args)
        {
            #region problem 1
            /*
            This program calculates the sum of two numbers
            and displays the result
            */

            // declare two intger variables
            //int x = 10;
            //int y = 20;

            //// Calculate the sum
            //int sum = x + y;

            // Display the result
            //Console.WriteLine(sum);
            #endregion

            #region problem 2
            //int x = "10"; //x is assigned a string instead of an integer
            //console.WriteLine(x + y)
            /* 
             -Console is written incorrectly - Consle Case sensitive
             - y is not declare
             */
            #endregion

            #region problem 3

            //string FullName = "Mahmoud Abd Elkader Mahmoud";
            //int age = 22;
            //decimal MonthSalary = 10000;
            //bool isStudent = true;
            //Console.WriteLine($"{FullName} , {age} , {MonthSalary} , {isStudent}");
            #endregion


            #region problem 4


            //Number Num1 = new Number();
            //Number Num2 = Num1;

            //Console.WriteLine(Num1.X);

            //Num1.X = 15;

            //Console.WriteLine(Num2.X);

            #endregion

            #region problem 5
            //int x = 15;
            //int y = 4;

            //Console.WriteLine(x + y);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y); 
            //Console.WriteLine(x / y); 
            //Console.WriteLine(x % y); 
            #endregion

            #region problem 6
            //int x = 16;
            //bool result = x > 10 && x % 2 == 0;
            //Console.WriteLine(result);
            #endregion

            #region problem 7
            //double number = double.Parse(Console.ReadLine());

            //// Explicit
            //int explicitNumber = (int)number;

            //// Implicit
            //double implicitNumber = explicitNumber;

            //Console.WriteLine("Explicit: " + explicitNumber);
            //Console.WriteLine("Implicit: " + implicitNumber);
            #endregion

            #region problem 8
            //Console.Write("Enter your age: ");

            //string ageInput = Console.ReadLine();

            //int age = int.Parse(ageInput);

            //bool isValid = age > 0;

            //Console.WriteLine("Valid age: " + isValid);
            #endregion

            #region problem 9 
            //int x = 5;

            //Console.WriteLine(++x);

            //Console.WriteLine(x++);

            //Console.WriteLine(x);
            #endregion
        }
    }
}
