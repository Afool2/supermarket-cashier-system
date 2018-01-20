using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Apple : Goods
    {
        public override string Name { get { return "Apple"; } }
        public Apple(string id, double price) : base(id, price)
        {
        }
    }
}
