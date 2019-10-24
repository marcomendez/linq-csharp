using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class JoinOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int CrossJoinQuery()
        {
            #region cross-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = products;

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            #endregion
            return 0;
        }

        public int GroupJoinQquery()
        {
            #region group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = categories;

            foreach (var v in q)
            {
                //Console.WriteLine(v.Category + ":");
                //foreach (var p in v.Products)
                //{
                //    Console.WriteLine("   " + p.ProductName);
                //}
            }
            #endregion
            return 0;
        }

        public int CrossGroupJoin()
        {
            #region cross-group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = categories;

            foreach (var v in q)
            {
                //Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            #endregion
            return 0;
        }

        public int LeftOuterJoin()
        {
            #region left-outer-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = categories;

            foreach (var v in q)
            {
                //Console.WriteLine($"{v.ProductName}: {v.Category}");
            }
            #endregion
            return 0;
        }
    }
}


