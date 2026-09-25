using day10_G01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EFDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            //#region Question 1
            //// Find all products that are out of stock.
            //var outOfStockProducts = ListGenerators.ProductList
            //    .Where(p => p.UnitsInStock == 0);

            //Console.WriteLine("=== Restriction Operators - Question 1 ===");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Find all products that are in stock and cost more than 3.00 per unit.
            //var inStockAndPriceMoreThan3 = ListGenerators.ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //Console.WriteLine("=== Restriction Operators - Question 2 ===");
            //foreach (var product in inStockAndPriceMoreThan3)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Returns digits whose name is shorter than their value.
            //string[] restrictionDigits =
            //{
            //    "zero", "one", "two", "three", "four",
            //    "five", "six", "seven", "eight", "nine"
            //};

            //var digitsWhoseNameIsShorter = restrictionDigits
            //    .Where((name, index) => name.Length < index);

            //Console.WriteLine("=== Restriction Operators - Question 3 ===");
            //foreach (var digit in digitsWhoseNameIsShorter)
            //{
            //    Console.WriteLine(digit);
            //}
            //Console.WriteLine();
            //#endregion

            #endregion


            #region Element Operators

            //#region Question 1
            //// Get first Product out of Stock.
            //var firstOutOfStockProduct = ListGenerators.ProductList
            //    .First(p => p.UnitsInStock == 0);

            //Console.WriteLine("=== Element Operators - Question 1 ===");
            //Console.WriteLine(firstOutOfStockProduct);
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Return the first product whose Price > 1000, otherwise null.
            //var firstProductPriceMoreThan1000 = ListGenerators.ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 1000M);

            //Console.WriteLine("=== Element Operators - Question 2 ===");
            //Console.WriteLine(firstProductPriceMoreThan1000 == null ? "null" : firstProductPriceMoreThan1000.ToString());
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Retrieve the second number greater than 5.
            //int[] elementNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondNumberGreaterThan5 = elementNumbers
            //    .Where(n => n > 5)
            //    .ElementAt(1);

            //Console.WriteLine("=== Element Operators - Question 3 ===");
            //Console.WriteLine(secondNumberGreaterThan5);
            //Console.WriteLine();
            //#endregion

            #endregion


            #region Aggregate Operators

            //#region Question 1
            //// Uses Count to get the number of odd numbers in the array.
            //int[] aggregateNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var oddNumbersCount = aggregateNumbers.Count(n => n % 2 != 0);

            //Console.WriteLine("=== Aggregate Operators - Question 1 ===");
            //Console.WriteLine($"Number of odd numbers = {oddNumbersCount}");
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Return a list of customers and how many orders each has.
            //var customersWithOrderCounts = ListGenerators.CustomerList
            //    .Select(c => new
            //    {
            //        CustomerName = c.Name,
            //        OrderCount = c.Orders?.Count() ?? 0
            //    });

            //Console.WriteLine("=== Aggregate Operators - Question 2 ===");
            //foreach (var customer in customersWithOrderCounts)
            //{
            //    Console.WriteLine($"{customer.CustomerName} -> {customer.OrderCount} orders");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Return a list of categories and how many products each has.
            //var categoryProductCounts = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    });

            //Console.WriteLine("=== Aggregate Operators - Question 3 ===");
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"{category.Category} -> {category.ProductCount} products");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 4
            //// Get the total of the numbers in an array.
            //int[] aggregateTotalNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var totalOfNumbers = aggregateTotalNumbers.Sum();

            //Console.WriteLine("=== Aggregate Operators - Question 4 ===");
            //Console.WriteLine($"Total = {totalOfNumbers}");
            //Console.WriteLine();
            //#endregion




            #endregion

            #region Ordering Operators

            //#region Question 1
            //// Sort a list of products by name.
            //var productsByName = ListGenerators.ProductList
            //    .OrderBy(p => p.ProductName);

            //Console.WriteLine("=== Ordering Operators - Question 1 ===");
            //foreach (var product in productsByName)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] orderingWords1 =
            //{
            //    "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"
            //};

            //var caseInsensitiveWords = orderingWords1
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("=== Ordering Operators - Question 2 ===");
            //foreach (var word in caseInsensitiveWords)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Sort a list of products by units in stock from highest to lowest.
            //var productsByStockDescending = ListGenerators.ProductList
            //    .OrderByDescending(p => p.UnitsInStock);

            //Console.WriteLine("=== Ordering Operators - Question 3 ===");
            //foreach (var product in productsByStockDescending)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 4
            //// Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] orderingDigits =
            //{
            //    "zero", "one", "two", "three", "four",
            //    "five", "six", "seven", "eight", "nine"
            //};

            //var digitsSortedByLengthThenName = orderingDigits
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name);

            //Console.WriteLine("=== Ordering Operators - Question 4 ===");
            //foreach (var digit in digitsSortedByLengthThenName)
            //{
            //    Console.WriteLine(digit);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 5
            //// Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] orderingWords2 =
            //{
            //    "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"
            //};

            //var wordsSortedByLengthThenCaseInsensitive = orderingWords2
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("=== Ordering Operators - Question 5 ===");
            //foreach (var word in wordsSortedByLengthThenCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 6
            //// Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var productsByCategoryThenPrice = ListGenerators.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //Console.WriteLine("=== Ordering Operators - Question 6 ===");
            //foreach (var product in productsByCategoryThenPrice)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 7
            //// Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] orderingWords3 =
            //{
            //    "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"
            //};

            //var wordsSortedByLengthThenDescendingCaseInsensitive = orderingWords3
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("=== Ordering Operators - Question 7 ===");
            //foreach (var word in wordsSortedByLengthThenDescendingCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 8
            //// Create a list of all digits in the array whose second letter is 'i'
            //// that is reversed from the order in the original array.
            //string[] orderingDigits2 =
            //{
            //    "zero", "one", "two", "three", "four",
            //    "five", "six", "seven", "eight", "nine"
            //};

            //var digitsWithSecondLetterIReversed = orderingDigits2
            //    .Where(digit => digit.Length > 1 && digit[1] == 'i')
            //    .Reverse();

            //Console.WriteLine("=== Ordering Operators - Question 8 ===");
            //foreach (var digit in digitsWithSecondLetterIReversed)
            //{
            //    Console.WriteLine(digit);
            //}
            //Console.WriteLine();
            //#endregion


            #endregion

            #region Transformation Operators

            //#region Question 1
            //// Return a sequence of just the names of a list of products.
            //var productNames = ListGenerators.ProductList
            //    .Select(p => p.ProductName);

            //Console.WriteLine("=== Transformation Operators - Question 1 ===");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Produce a sequence containing the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] transformationWords = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var upperAndLowerWords = transformationWords
            //    .Select(word => new
            //    {
            //        Upper = word.ToUpper(),
            //        Lower = word.ToLower()
            //    });

            //Console.WriteLine("=== Transformation Operators - Question 2 ===");
            //foreach (var word in upperAndLowerWords)
            //{
            //    Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Produce a sequence containing some properties of Products,
            //// including UnitPrice which is renamed to Price in the resulting type.
            //var selectedProductProperties = ListGenerators.ProductList
            //    .Select(p => new
            //    {
            //        p.ProductID,
            //        p.ProductName,
            //        p.Category,
            //        Price = p.UnitPrice
            //    });

            //Console.WriteLine("=== Transformation Operators - Question 3 ===");
            //foreach (var product in selectedProductProperties)
            //{
            //    Console.WriteLine(
            //        $"ID: {product.ProductID}, Name: {product.ProductName}, Category: {product.Category}, Price: {product.Price}");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 4
            //// Determine if the value of ints in an array matches its position in the array.
            //int[] transformationNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numbersInPlace = transformationNumbers
            //    .Select((number, index) => new
            //    {
            //        Number = number,
            //        InPlace = number == index
            //    });

            //Console.WriteLine("=== Transformation Operators - Question 4 ===");
            //Console.WriteLine("Number: In-place?");
            //foreach (var item in numbersInPlace)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 5
            //// Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var numberPairs =
            //    from a in numbersA
            //    from b in numbersB
            //    where a < b
            //    select new
            //    {
            //        A = a,
            //        B = b
            //    };

            //Console.WriteLine("=== Transformation Operators - Question 5 ===");
            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in numberPairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 6
            //// Select all orders where the order total is less than 500.00.
            //var ordersLessThan500 = ListGenerators.CustomerList
            //    .SelectMany(c => c.Orders ?? Array.Empty<Order>())
            //    .Where(o => o.Total < 500.00);

            //Console.WriteLine("=== Transformation Operators - Question 6 ===");
            //foreach (var order in ordersLessThan500)
            //{
            //    Console.WriteLine(order);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 7
            //// Select all orders where the order was made in 1998 or later.
            //var ordersFrom1998OrLater = ListGenerators.CustomerList
            //    .SelectMany(c => c.Orders ?? Array.Empty<Order>())
            //    .Where(o => o.OrderDate.Year >= 1998);

            //Console.WriteLine("=== Transformation Operators - Question 7 ===");
            //foreach (var order in ordersFrom1998OrLater)
            //{
            //    Console.WriteLine(order);
            //}
            //Console.WriteLine();
            //#endregion

            #endregion

            #region Partitioning Operators

            //#region Question 1
            //// Get the first 3 orders from customers in Washington.
            //// The supplied ListGenerators.cs Customer class does not contain a State/Region property,
            //// so the Washington filter cannot be implemented exactly with the provided data.
            //Console.WriteLine("=== Partitioning Operators - Question 1 ===");
            //Console.WriteLine("Not implemented: the supplied Customer class has no State/Region property for Washington filtering.");
            //Console.WriteLine();
            //#endregion

            //#region Question 2
            //// Get all but the first 2 orders from customers in Washington.
            //// The supplied ListGenerators.cs Customer class does not contain a State/Region property,
            //// so the Washington filter cannot be implemented exactly with the provided data.
            //Console.WriteLine("=== Partitioning Operators - Question 2 ===");
            //Console.WriteLine("Not implemented: the supplied Customer class has no State/Region property for Washington filtering.");
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] partitionNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numbersUntilValueLessThanPosition = partitionNumbers
            //    .TakeWhile((number, index) => number >= index);

            //Console.WriteLine("=== Partitioning Operators - Question 3 ===");
            //foreach (var number in numbersUntilValueLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 4
            //// Get the elements of the array starting from the first element divisible by 3.
            //int[] partitionNumbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var elementsFromFirstDivisibleBy3 = partitionNumbers2
            //    .SkipWhile(number => number % 3 != 0);

            //Console.WriteLine("=== Partitioning Operators - Question 4 ===");
            //foreach (var number in elementsFromFirstDivisibleBy3)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 5
            //// Get the elements of the array starting from the first element less than its position.
            //int[] partitionNumbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var elementsFromFirstLessThanPosition = partitionNumbers3
            //    .SkipWhile((number, index) => number >= index);

            //Console.WriteLine("=== Partitioning Operators - Question 5 ===");
            //foreach (var number in elementsFromFirstLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //#endregion


            #endregion

            #region Quantifiers

            //#region Question 2
            //// Return a grouped list of products only for categories that have at least one product that is out of stock.
            //var categoriesWithOutOfStockProducts = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            //Console.WriteLine("=== Quantifiers - Question 2 ===");
            //foreach (var category in categoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"  {product}");
            //    }
            //}
            //Console.WriteLine();
            //#endregion

            //#region Question 3
            //// Return a grouped list of products only for categories that have all of their products in stock.
            //var categoriesWhereAllProductsAreInStock = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //Console.WriteLine("=== Quantifiers - Question 3 ===");
            //foreach (var category in categoriesWhereAllProductsAreInStock)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"  {product}");
            //    }
            //}
            //Console.WriteLine();
            //#endregion

            #endregion
        }
    }
}
