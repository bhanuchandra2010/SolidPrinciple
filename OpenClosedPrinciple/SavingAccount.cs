using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class SavingAccount : IAccount
    {
        public double CalcInterest()
        {
            return 0.25 * 1000;
        }
    }
}
