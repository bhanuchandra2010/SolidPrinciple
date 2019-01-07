using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IGarageUtility utility = new GarageUtility();

            GarageStation station = new GarageStation(utility);
            station.OpenServices();
            station.CloseServices();
            station.ProvideService();
            Console.ReadLine();
        }
    }
}
