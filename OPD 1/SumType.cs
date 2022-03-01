using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public class SumType:Type
    {
        public SumType(bool val) : base(val) {}
        public override bool IsCorrect(int[] a, int[] b)
        {
            int sumA = 0;
            int sumB = 0;

            foreach(int i in a)
            {
                sumA += i;
            }

            foreach(int i in b)
            {
                sumB += i;
            }

            return desc ? sumB > sumA : sumB < sumA;
        }
    }
}
