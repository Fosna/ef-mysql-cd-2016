using System;
using System.Collections.Generic;

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

                if (IsCommmand(commandText))
                {
                    switch (commandText)
                    {
                        case "help":
                            WriteHelp();
                            break;
                        case "list":
                            app.List();
                            break;
                        case "add":
                            app.Add();
                            break;
                        case "done":
                            app.SetDone();
                            break;
                        case "undone":
                            app.Undone();
                            break;
                        case "remove":
                            app.Remove();
                            break;
                        case "remove all":
                            app.RemoveAll();
                            break;
                    }
                }else {
                    Console.WriteLine("Incorrect input! Please enter valid commnd.\n");
                    WriteHelp();
                }
            } while (commandText != "exit");
        }

        private bool IsCommmand(string tmp)
        {
            List<string> commands = new List<string>()
            {
                "list", "add", "done", "undone", "remove", "remove all", "help", "exit" 
            };

            if (commands.Contains(tmp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void WriteHelp()
        {
            // Code review: Path has to be relative. Help file should be included in solution. Build action for this file should be set to "copy if newer".

            // Read each line of the file into a string array. Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"txt\Help.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // Code review: No point to press enter after help is presented.
        }
    }
}