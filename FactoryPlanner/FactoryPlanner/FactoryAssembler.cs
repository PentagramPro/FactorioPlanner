using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlanner
{
    public class FactoryAssembler : FactoryUnit
    {
        
        List<string> mIngredients;

        public IReadOnlyList<string> Ingredients => mIngredients;

        public FactoryAssembler(string product, IEnumerable<string> ingredients) : base(product)
        {
            mIngredients.AddRange(ingredients);

        }
    }
}
