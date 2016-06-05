using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFirstContact
{
    class TodoCommands
    {
        public const string INVALID = "";
        public const string LIST = "list";
        public const string HELP = "help";
        public const string ADD = "add";
        public const string SET_DONE = "done";
        public const string EXIT = "exit";

        public static List<string> GetAllCommands()
        {
            var commandList = new List<string>
            {
                LIST,
                HELP,
                ADD,
                SET_DONE,
                EXIT,
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
