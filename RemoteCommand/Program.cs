using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //var oRemote = new SimpleRemoteControl();
            //var oLight = new Light();
            //var oLightOn = new LightOnCommand(oLight);
            //var oGarageDoor = new GarageDoor();
            //var oGarageDoorOpen = new GarageDoorOpenCommand(oGarageDoor);

            //oRemote.SetCommand(oLightOn);
            //oRemote.ButtonWasPressed();
            //oRemote.SetCommand(oGarageDoorOpen);
            //oRemote.ButtonWasPressed();

            var oRemoteControl = new RemoteControl(7);
            var oRemoteLoader = new RemoteLoader(oRemoteControl);
            Console.WriteLine(oRemoteControl.ToString());

            oRemoteControl.OnButtonWasPressed(0);
            oRemoteControl.OffButtonWasPressed(0);
            oRemoteControl.OnButtonWasPressed(1);
            oRemoteControl.OffButtonWasPressed(1);
            oRemoteControl.OnButtonWasPressed(2);
            oRemoteControl.OffButtonWasPressed(2);

            Console.ReadLine();
        }
    }
}
