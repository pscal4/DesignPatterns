using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("Garage is Open");
        }
        public void Close()
        {
            Console.WriteLine("Garage is Closed");
        }
    }
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor moGarageDoor;
        public GarageDoorOpenCommand(GarageDoor voGarageDoor)
        {
            moGarageDoor = voGarageDoor;
        }
        public void Execute()
        {
            moGarageDoor.Open();
        }
        public void Undo()
        {
            moGarageDoor.Close();
        }
    }
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor moGarageDoor;
        public GarageDoorCloseCommand(GarageDoor voGarageDoor)
        {
            moGarageDoor = voGarageDoor;
        }
        public void Execute()
        {
            moGarageDoor.Close();
        }
        public void Undo()
        {
            moGarageDoor.Open();
        }
    }
}
