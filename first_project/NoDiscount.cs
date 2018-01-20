using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    /// <summary>
    /// 不打折
    /// </summary>
    class NoDiscount : DiscountBase
    {
        public override double GetDiscountedAmount(double TotalAmount)
        {
            return TotalAmount;
        }
    }
}
