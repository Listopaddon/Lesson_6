using Lesson_6.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class UserInterface
    {
        Inventory inventory = new Inventory();
        InitializeInventory initialize = new InitializeInventory();
        public void Ui()
        {
            for (; ; )
            {
                Console.WriteLine("Chose action:");
                Console.WriteLine("1 - All products");
                Console.WriteLine("2 - Products by type");
                Console.WriteLine("3 - Total price");
                Console.WriteLine("4 - Add product");
                Console.WriteLine("5 - Delete product");
                Console.WriteLine("0 - Exit");
                string chose = Console.ReadLine();
                while (CheckStringByNumber(chose))
                {
                    Console.WriteLine("Enter correct number");
                    chose = Console.ReadLine();
                }

                int number = int.Parse(chose);

                switch (number)
                {
                    case 1:
                        inventory.OutputProducts();
                        Console.WriteLine();
                        break;
                    case 2:
                        ProductsType product = ChoseProductsType();
                        inventory.OutputProductsByType(product);
                        break;
                    case 3:
                        Console.WriteLine($"Total price is {inventory.TotalCost}");
                        break;
                    case 4:
                        inventory = initialize.AddProduct();
                        break;
                    case 5:
                        inventory.DeleteProductInInventory();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Wrong chose, enter correct number");
                        Console.WriteLine();
                        break;

                }
            }
        }

        private bool CheckStringByNumber(string line)
        {
            if (int.TryParse(line, out int result))
            {
                return false;
            }

            return true;
        }

        private ProductsType ChoseProductsType()
        {
            Console.WriteLine("Enter type products:");
            Console.WriteLine();
            Console.WriteLine("1 - Food");
            Console.WriteLine("2 - Chemicals");
            Console.WriteLine("3 - Machinary");
            string chose = Console.ReadLine();
            while (CheckStringByNumber(chose))
            {
                Console.WriteLine("Enter correct number");
                chose = Console.ReadLine();
            }

            int number = int.Parse(chose);

            switch (number)
            {
                case 1:
                    return ProductsType.Food;
                case 2:
                    return ProductsType.Chemicals;
                case 3:
                    return ProductsType.Machinery;
            }

            throw new Exception("Wrong type");
        }
    }
}
