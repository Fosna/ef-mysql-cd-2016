using SweetStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfQueries
{
    public partial class teacher
    {
        public override string ToString()
        {
            var jsonPrep = new
            {
                TeacherId,
                TeacherName,
                StandardId,
            };

            var meString = jsonPrep.DumpJson();

            return meString;
        }
    }
}
