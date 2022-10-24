using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    internal class Machinery : Products
    {
        static ProductsType type = ProductsType.Machinery;
        string name = string.Empty;

        public Machinery(int id, string name, decimal price, int quantity) : base(price, id, quantity, type)
        {
            this.name = name;
        }
    }
}
