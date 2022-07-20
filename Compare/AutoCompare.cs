using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    internal class AutoComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Rocznik > y.Rocznik)
                return 1;
            else if (x.Rocznik == y.Rocznik)
                return 0;
            else
                return -1;
        }
    }
}
