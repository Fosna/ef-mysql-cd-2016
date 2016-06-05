using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFirstContact
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TodoApp();

            var commandLoop = new CommandLoop(app);
            commandLoop.Run();
        }
    }
}
