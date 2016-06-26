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
            string cc;
            
            do
            {
                Console.Write(">");
                commandText = Console.ReadLine();

                cc = TodoCommandsClass.ParseCommand(commandText);
                               
                if (cc != TodoCommandsClass.INVALID)

                //if (IsCommmand(commandText))
                {
                    switch (commandText)
                    {
                        case TodoCommandsClass.HELP:
                            WriteHelp();
                            break;
                        case TodoCommandsClass.LIST:
                            app.List();
                            break;
                        case TodoCommandsClass.ADD:
                            app.Add();
                            break;
                        case TodoCommandsClass.DONE:
                            app.SetDone();
                            break;
                        case TodoCommandsClass.UNDONE:
                            app.Undone();
                            break;
                        case TodoCommandsClass.REMOVE:
                            app.Remove();
                            break;
                        case TodoCommandsClass.REMOVE_ALL:
                            app.RemoveAll();
                            break;
                    }
                }else {
                    //Console.WriteLine("Incorrect input! Please enter valid command.\n");
                    //WriteHelp();
                    WriteInvalidCommandMessage();
                }
            } while (cc != TodoCommandsClass.EXIT);
        }

        //private bool IsCommmand(string tmp)
        //{
        //    List<string> commands = new List<string>()
        //    {
        //        "list", "add", "done", "undone", "remove", "remove all", "help", "exit" 
        //    };

        //    if (commands.Contains(tmp))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private void WriteInvalidCommandMessage()
        {
            Console.WriteLine("Incorrect input! Please enter valid command.\n");
            WriteHelp();
        }

        private void WriteHelp()
        {
            // Read each line of the file into a string array. Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Antonija\Documents\Visual Studio 2015\Projects\EfWithMySql\EfFirstContact\bin\Debug\help.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            System.Console.ReadKey();
        }
    }
}