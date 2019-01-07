using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Circle
    {
        public virtual string GetShape()
        {
            return "Circle";
        }
    }

    class Triangle:Circle
    {
        public override string GetShape()
        {
            return "Triangle";
        }


    }
}
