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
                // Code review: This message get's displayed when exit commend is issued. That was a bug. This is fix. 
                
                // This should be last command check. 
                else if (commandText != "exit")
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
                // Code review: Don't forget to close file after you read it. It saves memory. With "using" statement Close instruction is automatically issued at the end of using block. 
                // Code review: Help file should be included in solution. Build action for this file should be set to "copy if newer".
                using (var sr = new StreamReader("Help.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            // Code review: Try to get more expecific exception.
            catch (IOException)
            {
                Console.Write("There is no help!");
            }
        }
    }
}