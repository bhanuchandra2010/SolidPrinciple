using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class CurrentAccount : IAccount
    {
        public double CalcInterest()
        {
            return 0.50 * 1000;
        }
    }
}
