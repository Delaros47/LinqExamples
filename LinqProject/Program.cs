using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Computer"},
                new Category{CategoryId=2,CategoryName="Phone"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Toshiba",QuantityPerUnit="64 GB RAM",UnitPrice=9400,UnitsInStock=74},
                new Product{ProductId=2, CategoryId=1,ProductName="HP",QuantityPerUnit="32 GB RAM",UnitPrice=7450,UnitsInStock=320},
                new Product{ProductId=3, CategoryId=2,ProductName="Xioami",QuantityPerUnit="32 GB RAM",UnitPrice=1400,UnitsInStock=540},
                new Product{ProductId=4, CategoryId=2,ProductName="Iphone",QuantityPerUnit="64 GB RAM",UnitPrice=3100,UnitsInStock=2541},


            };




            //OrderBy(products);
            //Where(products);
            //FindAll(products);
            //FindMethod(products);
            //AnyMethod(products);

            //GetProducts(products);
            //GetProductsByLinq(products);

            Console.ReadLine();
        }

        private static void OrderBy(List<Product> products)
        {
            var result = products.OrderBy(p => p.UnitPrice);
            foreach (var item in result)
            {
                Console.WriteLine(item.UnitPrice);
            }
        }

        private static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Xi"));
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Xi"));
            Console.WriteLine(result);
        }

        private static void FindMethod(List<Product> products)
        {
            var result = products.First(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyMethod(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "HP");
            Console.WriteLine(result);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 3000)
                {
                    filteredProduct.Add(product);

                }
            }
            return filteredProduct;
        }

        static List<Product> GetProductsByLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 300).ToList();
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
