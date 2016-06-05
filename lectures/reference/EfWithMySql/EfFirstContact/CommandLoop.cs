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
                }
                else if (command == TodoCommands.HELP)
                {
                    ShowHelp();
                }
                else if (command == TodoCommands.EXIT)
                {
                    isExit = true;
                }
                else if (command == TodoCommands.LIST)
                {
                    this.app.List();
                }
                else if (command == TodoCommands.ADD)
                {
                    this.app.AddTodoItem();
                }
                else if (command == TodoCommands.SET_DONE)
                {
                    this.app.SetDone();
                }

            } while (isExit == false);
        }

        private void ShowHelp()
        {
            Console.WriteLine($"{TodoCommands.LIST} - Write todo items.");
            Console.WriteLine($"{TodoCommands.ADD} - Add new todo item.");
            Console.WriteLine($"{TodoCommands.SET_DONE} - Mark todo item as done.");
            Console.WriteLine($"{TodoCommands.HELP} - Show this message.");
            Console.WriteLine($"{TodoCommands.EXIT} - Exit program.");
            Console.WriteLine();
        }
    }
}
