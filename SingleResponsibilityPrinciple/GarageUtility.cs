using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class GarageUtility : IGarageUtility
    {
        public void CloseGate()
        {
            Console.WriteLine("Gate is Getting Closed");
        }

        public void OpenGate()
        {
            Console.WriteLine("Gate is Getting Opened");
        }

        public void PerformServices()
        {
            Console.WriteLine("Vehicle is under service");
        }
    }
}
