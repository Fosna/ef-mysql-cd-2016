﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstTodo
{
    class TodoCommands
    {
        public const string INVALID = "";
        public const string HELP = "help";
        public const string EXIT = "exit";
        public const string LIST = "list";
        public const string ADD = "add";
        public const string DONE = "done";
        public static string REMOVE = "remove";

        private static List<string> GetAllCommands()
        {
            var commandList = new List<string>
        {
            INVALID,
            HELP,
            EXIT,
            LIST,
            ADD,
            DONE,
            REMOVE,
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
