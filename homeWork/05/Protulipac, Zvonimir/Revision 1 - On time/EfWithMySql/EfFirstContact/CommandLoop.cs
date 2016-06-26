using System;

namespace EfFirstContact
{
    internal class CommandLoop
    {
        public CommandLoop()
        {
        }

        internal void Run()
        {
            var app = new TodoApp();
            app.List();

            string command;
            do
            {
                Console.Write(">");
                var commandText = Console.ReadLine();
                command = TodoCommands.ParseCommand(commandText);

                if (command == TodoCommands.HELP)
                {
                    WriteHelp();
                }
                else if (command == TodoCommands.LIST)
                {
                    app.List();
                }
                else if (command == TodoCommands.ADD)
                {
                    app.Add();
                }
                else if (command == TodoCommands.DONE)
                {
                    app.SetDone();
                }
                else if (command == TodoCommands.REMOVE)
                {
                    app.Remove();
                }
                else if (command == TodoCommands.INVALID)
                {
                    WriteInvalidCommandMessage();
                }

            } while (command != TodoCommands.EXIT);
        }

        private void WriteInvalidCommandMessage(string commandText = "monkey")
        {
            Console.WriteLine("Incorrect command. Consider using supported commands.");
            WriteHelp();
        }

        private void WriteHelp()
        {
            Console.WriteLine("list - Write todo items.");
            Console.WriteLine("add - Add new todo item.");
            Console.WriteLine("done - Mark todo item as done.");
            Console.WriteLine("remove - Remove todo item from list.");
            Console.WriteLine("help - Show this message.");
            Console.WriteLine("exit - Exit program.");
            Console.WriteLine();
        }
    }
}