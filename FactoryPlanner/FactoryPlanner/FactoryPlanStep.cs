using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;
namespace FactoryPlanner
{
    public class FactoryPlanStep
    {
        public string Name { get; internal set; }
        public List<string> Ingredients { get; internal set; }

        public int Count { get; internal set; }

        public FactoryPlanStep(LuaTable block)
        {
            Name = block["name"] as string;
            Ingredients = new List<string>();

            var ingredients = block["ingredients"] as LuaTable;
            foreach (string key in ingredients.Keys)
            {
                Ingredients.Add(key);
            }
            

            Count = (int)Math.Ceiling(LuaHelper.GetLuaTableValue<double>(block, "recipes", "R1", "factory", "count"));
               
        }

       
    }
}
