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
        public List<Products> products = new List<Products>();
        decimal totalCost = 0;

        public decimal TotalCost
        {
            get { return totalCost; }
        }

        public void AddProduct(Products product)
        {
            products.Add(product);
            totalCost += product.Price;
        }
        public void DeleteProductInInventory()
        {
            Console.Write("Enter number pruduct which you want delete: ");
            string inputLine = Console.ReadLine();

            int number = 0;
            while (!CheckEnterChose(inputLine))
            {
                Console.WriteLine("enter correct number");
                inputLine = Console.ReadLine();
            }
            number = int.Parse(inputLine);
            totalCost -= products[number - 1].Price;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ID == number)
                {
                    products.Remove(products[i]);
                }
            }
        }

        public void OutputProducts()
        {
            Console.WriteLine("You chose next products: ");
            foreach (Products product in products)
            {
                Console.WriteLine($"{product.ID}) Type is: {product.Type}, " +
                                  $"Price is: {product.Price}, Qouantity is: {product.Quantity}");

            }
        }

        public void OutputProductsByType(ProductsType type)
        {
            Console.WriteLine($"You chose product is {type}:");
            foreach (Products product in products)
            {
                if (product.Type == type)
                {
                    Console.WriteLine($"{product.ID}) Type is: {product.Type}, " +
                                      $"Price is: {product.Price}, Qouantity is: {product.Quantity}");
                }

            }
        }

        private bool CheckEnterChose(string inputLine)
        {
            if (int.TryParse(inputLine, out int result))
            {
                return true;
            }

            return false;
        }
    }
}
