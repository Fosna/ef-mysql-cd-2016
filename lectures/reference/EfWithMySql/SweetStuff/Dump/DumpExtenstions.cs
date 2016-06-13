using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetStuff.Dump
{
    public static class DumpExtenstions
    {
        public static string DumpJson(this object me)
        {
            var meJson = JsonConvert.SerializeObject(me, Formatting.Indented);
            return meJson;
        }
    }
}
