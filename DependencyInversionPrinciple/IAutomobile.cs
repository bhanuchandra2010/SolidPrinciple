using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    interface IAutomobile
    {
        void Start();
        void Stop();
    }

    class Sedan : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Sedan Started");
        }

        public void Stop()
        {
            Console.WriteLine("Sedan Stopped");
        }
    }

    class SUV : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("SUV Started");
        }

        public void Stop()
        {
            Console.WriteLine("SUV Stopped");
        }
    }

    class AutomobileController
    {
        IAutomobile _auto;
        public AutomobileController(IAutomobile auto)
        {
            this._auto = auto;
        }

        public void Ignition()
        {
            _auto.Start();
        }
        public void Stopped()
        {
            _auto.Stop();
        }
    }
}
