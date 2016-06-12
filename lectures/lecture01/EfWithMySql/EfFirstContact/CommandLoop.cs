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
                Console.Write("> ");
                commandText = Console.ReadLine().ToLower().Trim();

                if (commandText == "help")
                {
                    WriteHelp();
                }
                else if (commandText == "list")
                {
                    app.List();
                }


            } while (commandText != "exit");
        }

        private void WriteHelp()
        {
            Console.WriteLine("There will be some help here one day!");
        }
    }
}