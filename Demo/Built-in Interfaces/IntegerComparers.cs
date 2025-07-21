using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    internal class IntegerComparers : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int? NumberX = (int?)x;
            int? NumberY = (int?)y;

            //return NumberX is null ? 0 : -1
            return -NumberX.Value.CompareTo(NumberY.Value) /*?? (NumberY is null? 0: -1)*/;
            //return -NumberX?.Value.CompareTo(NumberY?.Value) ?? (NumberY is null? 0: -1);

        }
    }
}
