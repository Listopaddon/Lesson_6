using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    public class Products
    {
        decimal price;
        int id;
        int quantity;
        ProductsType type;

        public Products(decimal price, int id, int quantity, ProductsType type)
        {
            this.price = price;
            this.id = id;
            this.quantity = quantity;
            this.type = type;
        }

        public ProductsType Type
        {
            get { return type; }
        }

        public int ID
        {
            get { return id; }
        }

        public decimal Price
        {
            get { return price; }
        }

        public int Quantity
        {
            get { return quantity; }
        }
    }
}
