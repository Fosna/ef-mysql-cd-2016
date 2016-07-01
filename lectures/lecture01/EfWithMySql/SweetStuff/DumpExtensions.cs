using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetStuff
{
    public static class DumpExtensions
    {
        public static string DumpJson(this object me)
        {
            var json = JsonConvert.SerializeObject(me, Formatting.Indented);
            return json;
        }
    }
}
