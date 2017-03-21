using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class MacroCommand : ICommand
    {
        ICommand[] moCommands;
        public MacroCommand(ICommand[] voCommands)
        {
            moCommands = voCommands;
        }

        public void Execute()
        {
            foreach (var command in moCommands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in moCommands)
            {
                command.Undo();
            }
        }
    }
}
