using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Lenovo : Goods
    {
       
        public override string Name
        {
            get { return "Lenovo"; }
        }
        public Lenovo(string id, double price)
            : base(id, price)
        {
            
        }
    }
}
