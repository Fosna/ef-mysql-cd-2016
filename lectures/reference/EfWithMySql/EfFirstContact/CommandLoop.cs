using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFirstContact
{
    class CommandLoop
    {
        private TodoApp app;

        public CommandLoop(TodoApp app)
        {
            this.app = app;
        }

        internal void Run()
        {
            this.app.List();
        }
    }
}
