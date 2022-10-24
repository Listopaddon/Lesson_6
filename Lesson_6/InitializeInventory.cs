using Lesson_6.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class InitializeInventory : Inventory
    {
        Inventory inventory = new Inventory();

        public Inventory AddProduct()
        {
            int quantity = 0;
            decimal price = 0;
            string name = string.Empty;
            int id = 1;
            for (; ; )
            {
                Console.WriteLine("Enter prodect:");
                Console.WriteLine("1 - Food");
                Console.WriteLine("2 - Machinary");
                Console.WriteLine("3 - Chemicals");
                Console.WriteLine("0 - Exit");
                string inputLine = Console.ReadLine();

                int chose = 0;
                while (!CheckEnterChose(inputLine))
                {
                    Console.WriteLine("enter correct number");
                    inputLine = Console.ReadLine();
                }
                chose = int.Parse(inputLine);
                                
                switch (chose)
                {
                    case 1:
                        quantity = CheckQuantityProduct();
                        price = CheckPriceProduct();
                        name = EnterNameProduct();
                        Products food = new Food(id, price, quantity, name);
                        inventory.AddProduct(food);
                        id += 1;
                        break;
                    case 2:
                        quantity = CheckQuantityProduct();
                        price = CheckPriceProduct();
                        name = EnterNameProduct();
                        Products machinary = new Machinery(id, name, price, quantity);
                        inventory.AddProduct(machinary);
                        id += 1;
                        break;
                    case 3:
                        quantity = CheckQuantityProduct();
                        price = CheckPriceProduct();
                        name = EnterNameProduct();
                        Products chemicals = new Chemicals(id, price, name, quantity);
                        inventory.AddProduct(chemicals);
                        id += 1;
                        break;
                    case 0:
                        Console.WriteLine("Good buy");
                        return inventory;
                    default:
                        Console.WriteLine("Wrong chose, enter correct number");
                        Console.WriteLine();
                        break;

                }
            }

            return inventory;
        }
        
        private decimal CheckPriceProduct()
        {
            decimal resultPrice = 0;
            for (; ; )
            {
                Console.Write("Enter price: ");
                string price = Console.ReadLine();
                if (decimal.TryParse(price, out decimal result))
                {
                    resultPrice = decimal.Parse(price);
                    return resultPrice;
                }
                else
                {
                    Console.WriteLine("Enter correct price");
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

        private int CheckQuantityProduct()
        {

            int resultPrice = 0;
            for (; ; )
            {
                Console.Write("Enter quantity: ");
                string price = Console.ReadLine();
                if (int.TryParse(price, out int result))
                {
                    resultPrice = int.Parse(price);
                    return resultPrice;
                }
                else
                {
                    Console.WriteLine("Enter correct price");
                }
            }
        }

        private string EnterNameProduct()
        {
            Console.Write("Enter name: ");
            return Console.ReadLine();
        }
    }
}
