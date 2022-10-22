using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    public class Chemicals : Products
    {
        static decimal price = 42;
        static int id = 2;
        static int quantity = 50;
        static ProductsType type = ProductsType.Chemicals;

        public Chemicals() : base(price, id, quantity, type) { }
    }
}
