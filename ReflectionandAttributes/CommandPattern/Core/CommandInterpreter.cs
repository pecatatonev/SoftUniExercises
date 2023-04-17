using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {

            string[] arguments = args.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string command = arguments[0];

            string[] commandArgs = arguments.Skip(1).ToArray();
            
            Type type = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(t => t.Name == $"{command}Command");

            if (commandArgs == null)
            {
                throw new InvalidOperationException("Command not found");
            }

            ICommand commandInstance = Activator.CreateInstance(type) as ICommand;

            string result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}
