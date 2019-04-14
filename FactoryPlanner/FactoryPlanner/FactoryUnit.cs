using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlanner
{
    public class FactoryUnit
    {
        public string Product { get; internal set; }

        public FactoryUnit(string product)
        {
            Product = product;
        }

    }
}
