using SweetStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfQueries
{
    public partial class standard
    {
        public override string ToString()
        {
            var jsonPrep = new
            {
                StandardId,
                StandardName,
                Description,
            };

            var meString = jsonPrep.DumpJson();

            return meString;
        }
    }
}
