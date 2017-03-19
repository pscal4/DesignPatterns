using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class RemoteControl
    {
        List<ICommand> moOnCommands;
        List<ICommand> moOffCommands;
        int miCapacity;
        public RemoteControl(int viCapacity)
        {
            miCapacity = viCapacity;
            moOnCommands = new List<ICommand>(viCapacity);
            moOffCommands = new List<ICommand>(viCapacity);
            // Initialize all the slot to do nothing (NoCommand)
            var oNoCommand = new NoCommand();
            for (int i = 0; i < viCapacity; i++)
            {
                this.SetCommand(i, oNoCommand, oNoCommand);   
            }
        }
        public void SetCommand(int viSlot, ICommand voOnCommand, ICommand voOffCommand)
        {
            if (viSlot < miCapacity)
            {
                moOnCommands.Insert(viSlot, voOnCommand);
                moOffCommands.Insert(viSlot, voOffCommand);                
            }
            else
            {
                throw new Exception(String.Format("Slot {0} exceeds max slot {1}", viSlot, miCapacity - 1));
            }
        }
        public void OnButtonWasPressed(int viSlot)
        {
            moOnCommands[viSlot].Execute();
        }
        public void OffButtonWasPressed(int viSlot)
        {
            moOffCommands[viSlot].Execute();
        }
        public override string ToString()
        {
            var oStringBuilder = new StringBuilder();
            oStringBuilder.Append("\n------- Remote Control -------\n");
            int iNoSlots = moOnCommands.Count;
            for (int i = 0; i < iNoSlots; i++)
            {
                oStringBuilder.Append(String.Format("[slot {0}] {1} {2}\n",
                     i, moOnCommands[i].ToString(), moOffCommands[i].ToString()));
            }
            return oStringBuilder.ToString();
        }
    }
}
