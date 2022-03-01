﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public class MaxType: Type
    {
        public MaxType(bool val) : base(val) { }
        public override bool IsCorrect(int[] a, int[] b)
        {
            int maxA =a[0];
            int maxB = b[0];
            for (  int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxA)
                {
                    maxA = a[i];
                }
                if (b[i] > maxB)
                {
                    maxB = b[i];
                }
            }
            return desc ? maxB > maxA : maxB < maxA;
        }
    }
}
