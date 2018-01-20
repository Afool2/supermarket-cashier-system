
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {


            SuperMarket sm = new SuperMarket();
            sm.ShowGoods();
            sm.Dealing();
            Console.ReadKey();
       }
    }
}
