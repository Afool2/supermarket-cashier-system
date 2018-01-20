using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 仓库类
    /// </summary>
    class Repository
    {
        List<List<Goods>> _storageRack = new List<List<Goods>>();
        public List<List<Goods>> StorageRack
        {
            get { return _storageRack; }
            set { _storageRack = value; }
        }//仓库的货架
        public Repository()
        {
            this.StorageRack.Add(new List<Goods>());// Nokia 货架
            this.StorageRack.Add(new List<Goods>());// Lenovo 货架
            this.StorageRack.Add(new List<Goods>());// Apple 货架

        }
        
        /// <summary>
        /// 进货方法
        /// </summary>
        /// <param name="goodsType">货物类型</param>
        /// <param name="quantity">进货数量</param>
        /// <param name="price">单价</param>
        public Repository importGoods(string goodsType, int quantity, double price)
        {   
            for(int i = 0; i < quantity; i++)
            {
                switch (goodsType)
                {
                    case "Nokia":
                        this.StorageRack[0].Add(new Nokia(Guid.NewGuid().ToString(), price));
                        break;
                    case "Lenovo":
                        this.StorageRack[1].Add(new Lenovo(Guid.NewGuid().ToString(), price));
                        break;
                    case "Apple":
                        this.StorageRack[2].Add(new Apple(Guid.NewGuid().ToString(), price));
                        break;
                }
            }
            return this;
        }

        /// <summary>
        /// 从仓库取货
        /// </summary>
        /// <param name="goodsType">货物类型</param>
        /// <param name="quantity">数量</param>
        /// <returns></returns>
        public Goods[] GetGoods(string goodsType, int quantity)
        {
            Goods[] goodsBatch = new Goods[quantity]; // 存一批货的数组

            for(int i = 0; i < quantity; i++)
            {
                switch (goodsType)
                {
                    case "Nokia":
                        goodsBatch[i] = this.StorageRack[0][i];
                        break;
                    case "Lenovo":
                        goodsBatch[i] = this.StorageRack[1][i];
                        break;
                    case "Apple":
                        goodsBatch[i] = this.StorageRack[2][i];
                        break;
                }
            }
            switch (goodsType) //从仓库删除已被取出的货
            {
                case "Nokia":
                    this.StorageRack[0].RemoveRange(0, quantity);
                    break;
                case "Lenovo":
                    this.StorageRack[1].RemoveRange(0, quantity);
                    break;
                case "Apple":
                    this.StorageRack[2].RemoveRange(0, quantity);
                    break;
            }
            return goodsBatch;
        }

        public void showGoods()
        {
            foreach(List<Goods> goodsList in this.StorageRack)
            {
                Console.WriteLine("there are {0} {1} in the repository", goodsList.Count, goodsList[0].Name);
            }
        }
    }
}
