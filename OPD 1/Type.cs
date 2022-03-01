using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public abstract class Type
    {
        public bool desc { get; private set; }
        public Type(bool val)
        {
            desc = val;
        }
        public abstract bool IsCorrect(int[] a, int[] b);

    }
}
