using HealthCareSystem.Data;
using System;

namespace HealthCareSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new HealthCareDbContext();

            System.Console.WriteLine( "Health Care Database Context Created Successfully.");

            System.Console.ReadLine();
        }
    }
}
