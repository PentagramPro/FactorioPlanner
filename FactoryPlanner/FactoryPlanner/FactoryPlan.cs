using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;

namespace FactoryPlanner
{
    public class FactoryPlan
    {
        Lua mContext;
        LuaTable mPlanTable;
        List<FactoryPlanStep> mProductionSteps = new List<FactoryPlanStep>();

        public IReadOnlyList<FactoryPlanStep> Steps => mProductionSteps;

        public FactoryPlan(string encodedPlan)
        {

            byte[] decodedPlan = Convert.FromBase64String(encodedPlan);
            string planString = Encoding.UTF8.GetString(LuaHelper.Decompress(decodedPlan));

            mContext = new Lua();
            mPlanTable = mContext.DoString(planString)[0] as LuaTable;
            var blocks = mPlanTable["blocks"] as LuaTable;
            foreach(var block in blocks.Values)
            {
                mProductionSteps.Add(new FactoryPlanStep(block as LuaTable));
            }
        }

        

        public override string ToString()
        {
            string res = "";
            foreach(var key in mPlanTable.Keys)
            {
                res += key+" = ";
                res += mPlanTable[key].ToString();
                res += ";";
            }
            return res;
        }
    }
}
