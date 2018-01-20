using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Nokia : Goods
    {
        public override string Name { get { return "Nokia"; } }
        public Nokia(string id, double price)
            : base(id, price)
        {
            
        }

    }
}
