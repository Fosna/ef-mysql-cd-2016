using System;
using System.Diagnostics;
using System.IO;

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
                else if (commandText == "undone")
                {
                    app.SetUndone();

                }
                else if (commandText == "removeall")
                {
                    app.RemoveAll();
                }
                else
                {
                    Console.WriteLine("Unknown message has been entered!");
                    WriteHelp();
                }


            } while (commandText != "exit");
        }

        private void WriteHelp()
        {
            try
            {
                StreamReader sr;
                string path = "Help.txt";
                sr = new StreamReader(path);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    Console.WriteLine(row);
                }
            }
            catch (Exception)
            {
                Console.Write("There is no help!");
            }
        }
    }
}