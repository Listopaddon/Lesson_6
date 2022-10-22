using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    public class Food : Products
    {
        static decimal price = 30;
        static int id = 1;
        static int quantity = 10;
        static ProductsType type = ProductsType.Food;

        public Food() : base(price, id, quantity, type) { }
    }
}
