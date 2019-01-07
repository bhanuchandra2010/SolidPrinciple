using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobile mobile = new SUV();
            AutomobileController controller = new AutomobileController(mobile);
            controller.Ignition();
            controller.Stopped();
            Console.ReadLine();

        }
    }
}
