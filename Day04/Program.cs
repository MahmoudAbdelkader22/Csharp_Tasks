using System;

enum DayOfWeek  //problem11 part02
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

namespace CSharpDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            // way 1
            //int[] Arr1 = new int[3];
            //Arr1[0] = 15;
            //Arr1[1] = 30;
            //Arr1[2] = 45;
            //Console.WriteLine("Array 1:");

            //for (int i = 0; i < Arr1.Length; i++)
            //{
            //    Console.WriteLine(Arr1[i]);
            //}

            ////way 2
            //int[] Arr2 = new int[] { 10, 20, 30 };
            //Console.WriteLine("\nArray 2:");
            //for (int i = 0; i < Arr2.Length; i++)
            //{
            //    Console.WriteLine(Arr2[i]);
            //}
            ////way 3 
            //int[] Arr3 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("\nArray 3:");

            //for (int i = 0; i < Arr3.Length; i++)
            //{
            //    Console.WriteLine(Arr3[i]);
            //}


            //Console.WriteLine("\nException Example:");
            //try
            //{
            //    Console.WriteLine(Arr1[3]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("IndexOutOfRangeException occurred!");

            //}
            #endregion

            #region problem2
            //// Shallow Copy
            //int[] arr1 = { 10, 20, 30, 40 };
            //int[] arr2;

            //arr2 = arr1;
            //Console.WriteLine("Before modification:");
            //Console.WriteLine($"arr1[0] =  {arr1[0]}");
            //Console.WriteLine($"arr2[0] =  {arr2[0]}");

            //arr1[0] = 23;
            //Console.WriteLine("after modification:");
            //Console.WriteLine($"arr1[0] =  {arr1[0]}");
            //Console.WriteLine($"arr2[0] =  {arr2[0]}");

            //// Deep Copy using Clone()

            //int[] arr3 = (int[])arr1.Clone();
            //Console.WriteLine("\nbefore deep copy modification:");
            //Console.WriteLine($"arr1[1] = {arr1[1]}");
            //Console.WriteLine($"arr3[1] = {arr3[1]}");

            //arr1[1] = 100;
            //Console.WriteLine("\nafter deep copy modification:");
            //Console.WriteLine($"arr1[1] = {arr1[1]}");
            //Console.WriteLine($"arr3[1] = {arr3[1]}"); 
            #endregion

            #region problem3
            //int[,] grades = new int[3, 3];


            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Enter grades for Student {student + 1}:");

            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write($"Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}


            //Console.WriteLine("\nStudent Grades:");

            //for (int student = 0; student < 3; student++)
            //{
            //    Console.Write($"Student {student + 1}: ");

            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write(grades[student, subject] + " ");
            //    }

            //    Console.WriteLine();
            //} 
            #endregion

            #region problem4
            //int[] numbers = { 50, 20, 40, 10, 30 };

            //// Before Sort
            //Console.WriteLine("Before Sort:");
            //Console.WriteLine(string.Join(", ", numbers));

            //// Sort
            //Array.Sort(numbers);

            //// After Sort
            //Console.WriteLine("After Sort:");
            //Console.WriteLine(string.Join(", ", numbers));


            //// Reverse
            //Console.WriteLine("\nBefore Reverse:");
            //Console.WriteLine(string.Join(", ", numbers));

            //Array.Reverse(numbers);

            //Console.WriteLine("After Reverse:");
            //Console.WriteLine(string.Join(", ", numbers));


            //// IndexOf
            //int index = Array.IndexOf(numbers, 40);

            //Console.WriteLine("\nIndexOf:");
            //Console.WriteLine("Index of 40 = " + index);


            //// Copy
            //int[] copiedArray = new int[5];

            //Console.WriteLine("\nBefore Copy:");
            //Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));

            //Array.Copy(numbers, copiedArray, numbers.Length);

            //Console.WriteLine("After Copy:");
            //Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));


            //// Clear
            //Console.WriteLine("\nBefore Clear:");
            //Console.WriteLine(string.Join(", ", numbers));

            //Array.Clear(numbers, 0, numbers.Length);

            //Console.WriteLine("After Clear:");
            //Console.WriteLine(string.Join(", ", numbers)); 
            #endregion

            #region problem5
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// Using for loop
            //Console.WriteLine("Using for loop:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //// Using foreach loop
            //Console.WriteLine("\nUsing foreach loop:");

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //// Using while loop to print in reverse order
            //Console.WriteLine("\nUsing while loop in reverse:");

            //int index = numbers.Length - 1;

            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;

            //} 
            #endregion

            #region problem6
            //int number;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number.");
            //        continue;
            //    }

            //    if (number <= 0 || number % 2 == 0)
            //    {
            //        Console.WriteLine("Please enter a positive odd number.");
            //    }

            //} while (number <= 0 || number % 2 == 0);

            //Console.WriteLine("Valid number: " + number); 
            #endregion

            #region problem7
            //    // Create a 2D array with fixed values
            //    int[,] numbers =
            //    {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //    // Print the array in matrix format
            //    for (int row = 0; row < 3; row++)
            //    {
            //        for (int column = 0; column < 3; column++)
            //        {
            //            Console.Write(numbers[row, column] + "\t");
            //        }

            //        Console.WriteLine();
            //    } 
            #endregion

            #region problem8
            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //// Using if-else
            //if (month == 1)
            //{
            //    Console.WriteLine("Using if-else: January");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Using if-else: February");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Using if-else: March");
            //}
            //else if (month == 4)
            //{
            //    Console.WriteLine("Using if-else: April");
            //}
            //else if (month == 5)
            //{
            //    Console.WriteLine("Using if-else: May");
            //}
            //else if (month == 6)
            //{
            //    Console.WriteLine("Using if-else: June");
            //}
            //else if (month == 7)
            //{
            //    Console.WriteLine("Using if-else: July");
            //}
            //else if (month == 8)
            //{
            //    Console.WriteLine("Using if-else: August");
            //}
            //else if (month == 9)
            //{
            //    Console.WriteLine("Using if-else: September");
            //}
            //else if (month == 10)
            //{
            //    Console.WriteLine("Using if-else: October");
            //}
            //else if (month == 11)
            //{
            //    Console.WriteLine("Using if-else: November");
            //}
            //else if (month == 12)
            //{
            //    Console.WriteLine("Using if-else: December");
            //}
            //else
            //{
            //    Console.WriteLine("Using if-else: Invalid month number");
            //}

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Using switch: January");
            //        break;

            //    case 2:
            //        Console.WriteLine("Using switch: February");
            //        break;

            //    case 3:
            //        Console.WriteLine("Using switch: March");
            //        break;

            //    case 4:
            //        Console.WriteLine("Using switch: April");
            //        break;

            //    case 5:
            //        Console.WriteLine("Using switch: May");
            //        break;

            //    case 6:
            //        Console.WriteLine("Using switch: June");
            //        break;

            //    case 7:
            //        Console.WriteLine("Using switch: July");
            //        break;

            //    case 8:
            //        Console.WriteLine("Using switch: August");
            //        break;

            //    case 9:
            //        Console.WriteLine("Using switch: September");
            //        break;

            //    case 10:
            //        Console.WriteLine("Using switch: October");
            //        break;

            //    case 11:
            //        Console.WriteLine("Using switch: November");
            //        break;

            //    case 12:
            //        Console.WriteLine("Using switch: December");
            //        break;

            //    default:
            //        Console.WriteLine("Using switch: Invalid month number");
            //        break;
            //} 
            #endregion

            #region problem9
            //int[] numbers = { 50, 20, 30, 20, 40, 20, 10 };

            //// Sort the array
            //Array.Sort(numbers);

            //Console.WriteLine("Sorted Array:");

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //// Search for a specific value
            //int value = 20;

            //int firstIndex = Array.IndexOf(numbers, value);
            //int lastIndex = Array.LastIndexOf(numbers, value);

            //Console.WriteLine("\n\nFirst index of " + value + ": " + firstIndex);
            //Console.WriteLine("Last index of " + value + ": " + lastIndex); 
            #endregion

            #region problem10
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// Using for loop
            //int sum1 = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum1 += numbers[i];
            //}

            //Console.WriteLine("Sum using for: " + sum1);


            //// Using foreach loop
            //int sum2 = 0;

            //foreach (int number in numbers)
            //{
            //    sum2 += number;
            //}

            //Console.WriteLine("Sum using foreach: " + sum2); 
            #endregion

            #region problem11
            //Console.Write("Enter a number from 1 to 7: ");
            //int number = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), number.ToString());

            //Console.WriteLine("Day: " + day); 
            #endregion

        }
    }
}
