using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface IOfflineOrder
    {
        void Process();
        void Transact();
    }
    interface IOnlineOrder
    {
        void Process();
    }


    class Shopping : IOfflineOrder, IOnlineOrder
    {
        public void Process()
        {
            Console.WriteLine("Item processed");
        }

        public void Transact()
        {
            Console.WriteLine("Item Transacted");
        }
    }
}
