using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    public class Food : Products
    {
        string name = string.Empty;
        static ProductsType type = ProductsType.Food;

        public Food(int id, decimal price, int quantity, string name) : base(price, id, quantity, type)
        {
            this.name = name;
        }
    }
}
