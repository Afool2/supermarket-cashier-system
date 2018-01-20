using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 按折扣打折
    /// </summary>
    class DisountByRate : DiscountBase
    {
        public double DiscountRate { get; set; }
        public DisountByRate(double discountRate)
        {
            this.DiscountRate = discountRate;
        }

        /// <summary>
        /// 返回按折扣打折后的总价钱
        /// </summary>
        /// <param name="totalAmount">打折前总价</param>
        /// <returns>打折后总价</returns>
        public override double GetDiscountedAmount(double totalAmount)
        {
            return totalAmount * this.DiscountRate;
        }
    }
}
