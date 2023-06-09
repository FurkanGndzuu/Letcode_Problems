﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letcode_Pow_x_n
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
             if (n == 0)
                return 1;

            if (n == 1)
                return x;

            if (n == -1)
                return 1 / x;

            double half = MyPow(x, n / 2);
            double remainder = MyPow(x, n % 2);

            return half * half * remainder;
        }
    }
}
