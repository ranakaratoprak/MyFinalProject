﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        //Data Transformation Object
        static void Main(string[] args)
        {
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            //ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetProductDetails();

            //if (result.Success == true) {
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product in productManager.GetByUnitPrice(40,100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //

        }
    }
}
