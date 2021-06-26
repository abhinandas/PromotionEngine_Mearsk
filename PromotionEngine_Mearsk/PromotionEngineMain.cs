using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace PromotionEngine_Mearsk
{
    class PromotionEngineMain
    {
        private static IProductServices _productService;


        static void Main(string[] args)
        {
            _productService = DependencyResolver.InitializeDependencies.GetService<IProductServices>();
            List<Products> products = new List<Products>();
            Console.WriteLine("Total number of order");
            int orders = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < orders; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string orderType = Console.ReadLine();
                Products product = new Products(orderType);
                products.Add(product);
            }

            int totalPrice = _productService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

    }

}
