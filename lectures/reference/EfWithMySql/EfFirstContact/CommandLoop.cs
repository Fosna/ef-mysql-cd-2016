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

            } while (isExit == false);
        }

        private void ShowHelp()
        {
            Console.WriteLine("list - Write todo items.");
            Console.WriteLine("help - Show this message.");
            Console.WriteLine("exit - exit program.");
            Console.WriteLine();
        }
    }
}
