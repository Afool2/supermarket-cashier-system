using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 超市
    /// </summary>
    class SuperMarket
    {
        Repository repository = new Repository();

        public SuperMarket()
        {
            //初始化时往仓库存货
            repository
                .importGoods("Nokia", 100, 226)
                .importGoods("Lenovo", 100, 1000)
                .importGoods("Apple", 100, 7000);
        }

        /// <summary>
        /// 交易
        /// </summary>
        public void Dealing()
        {
            Console.WriteLine("Welcom! We got Nokia, Lenovo and Apple, what do you like?");
            string input = Console.ReadLine();
            Console.WriteLine("how many {0} do you want?", input);
            int quantity = Convert.ToInt32(Console.ReadLine());
            Goods[] goods = repository.GetGoods(input, quantity);
            double totalAmount = goods[0].Price * goods.Length;//打折前总价
            Console.WriteLine("select discounting type: 1--no discount  2--10% off   3--15% off 4--up to 500 reduce 100");
            DiscountBase discoun = GetDiscountType(Console.ReadLine());
           
            //打印小票
            foreach(Goods item in goods)
            {
                Console.WriteLine("item: {0}\tID: {2}\tprice: {1} Yuan", item.Name, item.Price, item.ID);
            }
            Console.WriteLine("total: {0} Yuan\npayment: {1} Yuan", goods[0].Price * goods.Length, discoun.GetDiscountedAmount(totalAmount));
        }

        /// <summary>
        /// 简单工厂模式，根据选择的打折方式返回打折对象
        /// </summary>
        /// <param name="input">输入的数字</param>
        /// <returns>打折的父类，装的是子类对象</returns>
        public DiscountBase GetDiscountType(string input)
        {
            DiscountBase dis = null;
            switch (input)
            {
                case "1":
                    dis = new NoDiscount();
                    break;
                case "2":
                    dis = new DisountByRate(0.9);
                    break;
                case "3":
                    dis = new DisountByRate(0.85);
                    break;
                case "4":
                    dis = new UpTo_Discount(500, 100);
                    break;
            }
            return dis;
        }

        /// <summary>
        /// 展示仓库
        /// </summary>
        public void ShowGoods()
        {
            repository.showGoods();
        }

    }
}
