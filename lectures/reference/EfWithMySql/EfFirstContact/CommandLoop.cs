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
            var isExit = false;
            do
            {
                Console.Write("> ");
                var commandText = Console.ReadLine();
                var command = TodoCommands.ParseCommand(commandText);
                if (command == TodoCommands.INVALID)
                {
                    Console.WriteLine("Command not supported.");
                    ShowHelp();
                    continue;
                }

                if (command == TodoCommands.EXIT)
                {
                    isExit = true;
                }

            } while (isExit == false);
        }

        private void ShowHelp()
        {
            Console.WriteLine("TODO: help :)");
        }
    }
}
