using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle shape = new Triangle();
            Console.WriteLine(shape.GetShape());
            Console.ReadLine();
        }
    }
}
