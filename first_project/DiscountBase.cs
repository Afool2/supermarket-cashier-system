using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class DiscountBase
    {
        /// <summary>
        /// 返回打折后的价钱
        /// </summary>
        /// <param name="TotalAmount">打折前的总价</param>
        /// <returns>打折后的总价</returns>
        public abstract double GetDiscountedAmount(double TotalAmount);
    }
}
