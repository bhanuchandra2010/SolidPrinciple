using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class GarageStation
    {
        IGarageUtility _utility;
       
        public GarageStation(IGarageUtility utility)
        {
            _utility = utility;
        }

        public void OpenServices() 
        {
            _utility.OpenGate();
        }
        public void CloseServices() 
        {
            _utility.CloseGate();
        }
        public void ProvideService() {
            _utility.PerformServices();
        }
    }
}
