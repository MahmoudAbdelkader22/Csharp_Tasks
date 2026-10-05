using ECommerceSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerceSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();

            Console.WriteLine("Database Context Created Successfully.");

            Console.ReadLine();

        }
    }
}
