using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q1: Why did the property "Id" become a Primary Key
// without any explicit configuration?
// Answer: Because EF Core convention recognizes a property named "Id"
// as the Primary Key.

// Q2: Why is "Country" nullable in the database while "Price" is not?
// Answer: Because Country is nullable (string?) while Price is a non-nullable
// value type (decimal).
namespace EFDay03.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishDate { get; set; }

    }
}
