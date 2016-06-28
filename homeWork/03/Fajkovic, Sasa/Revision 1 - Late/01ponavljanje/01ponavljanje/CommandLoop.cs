using System;
using System.IO;

namespace _01ponavljanje
{
    internal class CommandLoop
    {
        internal void Run()
        {
            TodoApp app = new TodoApp();
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
                    todoitem item = new todoitem();
                    Console.WriteLine("item ID > ");

                    try
                    {
                        item = app.TryGetTodoItem(int.Parse(Console.ReadLine().Trim().ToLower()));
                    }
                    // Code review: It's not a good practice to catch every exception. Only really expected exception should be handled. Perhaps one of int.Parse exceptions (FormatException, OverflowException) or ArgumentException that can be raised from TryGetTodoItem.
                    // Consider using int.TryParse() instead of int.Parse. This crazy exception handling won't be needed.
                    catch (OverflowException)
                    {
                        Console.WriteLine("Invalid ID number.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid ID number.");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid ID number.");
                    }
                    //catch (Exception)
                    //{
                    //    Console.WriteLine("Invalid ID number.");
                    //    // Code review: No need to terminate application. Give user ability to enter another command.
                    //    //return;
                    //}

                    todoitem.removeTodoItem(item);

                }

                else if (commandText == "undone")
                {
                    todoitem item = new todoitem();
                    Console.WriteLine("item ID > ");
                    try
                    {
                        item = app.TryGetTodoItem(int.Parse(Console.ReadLine().Trim().ToLower()));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid ID number.");
                        return;
                    }

                    todoitem.undoneTodoItem(item);
                }
                else if (commandText == "remove-all")
                {
                    app.RemoveAllToDoItems();
                }
                // Code review: exit command writes 'Unsupported command...' text to console. This is suggested fix.
                //else 
                else if (commandText != "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Unsupported command. " + Environment.NewLine + "Type \"help\" to see a list of available commands");
                }

            } while (commandText != "exit");
        }

        // Code review: Help file should be included in solution. Build action should be copy if newer.
        private void WriteHelp()
        {
            Console.Clear();
            string path = "txt/help-commands.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Help file doesn't exist");
                return;
            }
            
            StreamReader sr = new StreamReader(path);
           
            string line="";

            while ((line=sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
        }
    }
}