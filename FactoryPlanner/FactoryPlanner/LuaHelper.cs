using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlanner
{
    public class LuaHelper
    {
        public static byte[] Decompress(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }

        public static T GetLuaTableValue<T>(LuaTable table, params string[] keys)
        {
            if (keys.Length == 0)
                return default;

            for (int i = 0; i < keys.Length - 1; i++)
            {
                table = table[keys[i]] as LuaTable;
                if (table == null)
                    return default;
            }
            object result = table[keys.Last()];
            return (T)result;
        }
    }
}
