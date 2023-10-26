using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.IO;
namespace Ex2
{
    static class SerializeGeneric
    {
        public static void SerializeToJSON<T>(string path, T obj)
        {
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<T>(fs, obj);
            }
        }

        public static T DeserializeFromJSON<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
