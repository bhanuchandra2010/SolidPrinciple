using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
        void PerformServices();
    }
}
