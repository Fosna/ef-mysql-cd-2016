using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfTodoDb
{
    class TodoCommandsClass
    {
        public const string INVALID = "";
        public const string HELP = "help";
        public const string EXIT = "exit";
        public const string LIST = "list";
        public const string ADD = "add";
        public const string REMOVE = "remove";
        public const string REMOVE_ALL = "remove all";
        public const string DONE = "done";
        public const string UNDONE = "undone";

            //"list", "add", "done", "undone", "remove", "remove all", "help", "exit" 

        private static List<string> GetAllCommands()
        {
            var commandList = new List<string>
        {
            INVALID,
            HELP,
            EXIT,
            LIST,
            ADD,
            REMOVE,
            REMOVE_ALL,
            DONE,
            UNDONE
        };
            return commandList;
        }

        public static string ParseCommand(string userInput)
        {
            var command = GetAllCommands().SingleOrDefault(x => x.ToLower() == userInput.Trim().ToLower());
            if (command == null)
            {
                command = INVALID;
            }
            return command;
        }
    }
}
