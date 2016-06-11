﻿using System.Collections.Generic;
using System.Linq;

namespace EfCodeFirstTodo
{
    class TodoCommands
    {
        public const string INVALID = "";
        public const string HELP = "help";
        public const string EXIT = "exit";

        public const string LIST = "list";
        public const string ADD = "add";
        public const string SET_DONE = "done";
        public const string REMOVE = "remove";

        public static List<string> GetAllCommands()
        {
            var commandList = new List<string>
            {
                LIST,
                ADD,
                SET_DONE,
                REMOVE,
                HELP,
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