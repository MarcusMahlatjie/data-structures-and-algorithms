﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    internal class BigONotation
    {
        public int ConstantTimeComplexitity()
        {
            int i = 0;
            int j = 1;

            return j + i;
        }

        public void LinearTimeComplexitity() 
        {
            int total = 0;
            int i = 2;

            while (i <= 10)
            {
                total += i;
                i += 1;
            }
        }

        public void QuadraticTimeComplexitity()
        {
           var n = 6;

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= n ; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
