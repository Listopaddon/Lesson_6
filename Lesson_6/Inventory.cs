using Lesson_6.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Inventory
    {
        List<Products> products = new List<Products>();
        decimal totalCost = 0;

        public decimal TotalCost
        {
            get { return totalCost; }
        }

        private void AddProduct()
        {
            products.Add(new Food());
            products.Add(new Machinery());
            products.Add(new Chemicals());
            products.Add(new Food());
            products.Add(new Machinery());
            products.Add(new Chemicals());
            products.Add(new Food());
            products.Add(new Machinery());
            products.Add(new Chemicals());

            Cost();
        }

        private void Cost()
        {
            foreach (Products product in products)
            {
                totalCost += product.Price;
            }
        }

        public void OutputProducts()
        {
            AddProduct();
            Console.WriteLine("You chose next products: ");
            foreach (Products product in products)
            {
                Console.WriteLine("   " + product.Type);
            }
        }

        public void OutputProductsByType(ProductsType type)
        {
            AddProduct();
            Console.WriteLine($"You chose product is {type}:");
            foreach (Products product in products)
            {
                if (product.Type == type)
                {
                    Console.WriteLine("  " + product.Type);
                }
            }
        }
    }
}
