﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping shop = new Shopping();
            shop.Process();
            shop.Transact();
            Console.ReadLine();

        }
    }
}
