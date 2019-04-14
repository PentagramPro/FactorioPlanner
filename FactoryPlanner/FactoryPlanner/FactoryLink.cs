using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlanner
{
    public class FactoryLink : FactoryUnit
    {
        

        public List<FactoryUnit> Links;

        public FactoryLink(string product) : base(product)
        {
            
        }
    }
}
