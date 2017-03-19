using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    class SimpleRemoteControl
    {
        ICommand moSlot;
        public SimpleRemoteControl() {}
        public void SetCommand(ICommand voCommand)
        {
            moSlot = voCommand;
        }
        public void ButtonWasPressed()
        {
            moSlot.Execute();
        }
    }
}
