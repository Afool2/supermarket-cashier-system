using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Goods
    {
        public string ID { get; set; }
        public double Price { get; set; }
        
        public virtual string Name { get; set; }

        
        public Goods(string id, double price)
        {
            this.ID = id;
            this.Price = price;
           
        }
    }
}
