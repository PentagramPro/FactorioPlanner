using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlanner
{
    public class FactoryInputOutput : FactoryUnit
    {
        public bool IsOutput { get; internal set; }
        public FactoryInputOutput(string product, bool isOutput) : base(product)
        {
            IsOutput = isOutput;
        }
    }
}
