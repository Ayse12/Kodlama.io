using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };
            List<Product> products = new List<Product> {
                new Product{ProductId=1, CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=5000,UnitsInStock=3 },
                new Product{ProductId=2, CategoryId=1,ProductName="ASUS Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=250,UnitsInStock=5 },
                new Product{ProductId=3, CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=1000,UnitsInStock=2 },
                new Product{ProductId=4, CategoryId=2,ProductName="Samsung ",QuantityPerUnit="64 GB RAM",UnitPrice=6800,UnitsInStock=10 },
                new Product{ProductId=5, CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="16 GB RAM",UnitPrice=7000,UnitsInStock=7 },

            };
            //Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinq(products);

            UsingJoin(categories, products);
        }

        private static void UsingJoin(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDTO { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName + " " + productDto.CategoryName);

                ///Console.WriteLine("{0} ---- {1}",productDto.ProductName,productDto.CategoryName);
            }
        }

        private static void ClassicLinq(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            var result2 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
            Console.WriteLine("----------------------Küçükten büyüğe--------------------------");
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("<-------------------------------------------------------------------------------------------------------->");
            Console.WriteLine("----------------------Büyükten küçüğe--------------------------");
            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            //FindAll o şarta uyan tüm şeyleri getirir.
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            //Find aradığımız kritere uygun nesnenin kendisini döner
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static bool AnyTest(List<Product> products)
        {
            //Any bir listenin içerisinde bir eleman var mı yok mu onu aramak için kullanırım.
            //Var ise true yok ise false geri döner
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
            return result;
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik-----------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }
            Console.WriteLine("Linq-----------");
            var result = products.Where(p => p.UnitPrice > 4000 && p.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
    class ProductDTO
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
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
