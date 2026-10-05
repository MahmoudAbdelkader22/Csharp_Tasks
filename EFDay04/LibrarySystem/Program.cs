using LibrarySystem.Data;
using System;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new LibraryDbContext();

            Console.WriteLine("Database Context Created Successfully.");

            Console.ReadLine();
        }
    }
}
