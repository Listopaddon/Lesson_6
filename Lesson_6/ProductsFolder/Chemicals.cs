using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.ProductsFolder
{
    public class Chemicals : Products
    {
        string name = string.Empty;
        static ProductsType type = ProductsType.Chemicals;

        public Chemicals(int id, decimal price, string name, int quantity) : base(price, id, quantity, type)
        {
            this.name = name;
        }
    }
}
