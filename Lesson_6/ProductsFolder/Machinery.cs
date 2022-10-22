using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    internal class Machinery :Products
    {
        static decimal price = 50;
        static int id = 3;
        static int quantity = 220;
        static ProductsType type = ProductsType.Machinery;

        public Machinery() : base(price, id, quantity, type) { }
    }
}
