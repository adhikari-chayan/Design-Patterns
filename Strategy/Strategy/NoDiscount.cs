﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class NoDiscount:DiscountStrategy
    {
        public NoDiscount()
        {
            _discountPercentage = 0;
                
        }

        public override decimal ApplyDiscount(decimal sale)
        {
            return (decimal)(100 - _discountPercentage) * sale / 100;
        }
    }
}