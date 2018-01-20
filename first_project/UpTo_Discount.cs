using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 满一定价钱时打折
    /// </summary>
    class UpTo_Discount : DiscountBase
    {
        public double UpToAmount { get; set; } // 满此价钱打折
        public double ReduceAmount { get; set; }//满一定价钱后需要减少的价钱

        public UpTo_Discount(double upToAmount, double reduceAmount)
        {
            this.UpToAmount = upToAmount;
            this.ReduceAmount = reduceAmount;
        }
        
        /// <summary>
        /// 满多少减多少
        /// </summary>
        /// <param name="TotalAmount">打折前总价</param>
        /// <returns>打折后总价</returns>
        public override double GetDiscountedAmount(double TotalAmount)
        {
            return TotalAmount >= UpToAmount ? TotalAmount - ReduceAmount : TotalAmount;
        }
    }
}
