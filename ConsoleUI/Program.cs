using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {



















        }

        //    private static void DTOsTest()
        //    {
        //        ProductManager productManager = new ProductManager(new EfProductDal());
        //        foreach (var product in productManager.GetProductDetail().Data)
        //        {
        //            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        //        }
        //    }

        //    private static void CategoryTest()
        //    {
        //        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //        foreach (var category in categoryManager.GetAll())
        //        {
        //            Console.WriteLine(category.CategoryName);
        //        }
        //    }

        //    private static void InMemoryTest()
        //    {
        //        //InMemory

        //        ProductManager productManager = new ProductManager(new InMemoryProductDal());
        //        foreach (var product in productManager.GetAll().Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    private static void EntityFrameworkTest()
        //    {
        //        // EntityFramework

        //        ProductManager productManager = new ProductManager(new EfProductDal());
        //        foreach (var product in productManager.GetAll().Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    private static void ProductTest2()
        //    {
        //        ProductManager productManager = new ProductManager(new EfProductDal());
        //        foreach (var product in productManager.GetAllByCategoryId(2).Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    private static void ProductTest()
        //    {
        //        ProductManager productManager = new ProductManager(new EfProductDal());
        //        foreach (var product in productManager.GetByUnitPrice(40, 100).Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }
        //}
    }
}
