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

            string commandText;
            do
            {
                Console.Write(">");
                commandText = Console.ReadLine().ToLower().Trim();

                if (commandText == "help")
                {
                    WriteHelp();
                }
                else if (commandText == "list")
                {
                    app.List();
                }
                else if (commandText == "add")
                {
                    app.Add();
                }
                else if (commandText == "done")
                {
                    app.SetDone();
                }
                else if (commandText == "remove")
                {
                    app.Remove();
                }


            } while (commandText != "exit");
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