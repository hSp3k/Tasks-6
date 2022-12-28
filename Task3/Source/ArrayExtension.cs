using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Source
{
    public static class ArrayExtension
    {
        public static int SumAt(this IList<int> array, int startPos, int endPos)
        {
            return array.ToList().GetRange(startPos, endPos).Sum();
        }
    }
}
