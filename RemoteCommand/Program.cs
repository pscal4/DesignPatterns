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
            // This was from SimpleRemote
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
            oRemoteControl.UndoButtonWasPressed();

            oRemoteControl.OnButtonWasPressed(1); 
            oRemoteControl.OffButtonWasPressed(1);
            oRemoteControl.OnButtonWasPressed(2); // Stereo on CD
            oRemoteControl.OffButtonWasPressed(2); // Stereo off
            // This undo no longer works. It needs state like the Ceiling Fan!
            oRemoteControl.UndoButtonWasPressed(); // Stereo on CD
            //oRemoteControl.OnButtonWasPressed(2); 
            oRemoteControl.UndoButtonWasPressed(); // stereo off

            Console.WriteLine(oRemoteControl.ToString());

            oRemoteControl.OnButtonWasPressed(3); // On Medium
            oRemoteControl.OffButtonWasPressed(3);  // Off
            oRemoteControl.UndoButtonWasPressed();  // Should go back to medium
            oRemoteControl.OnButtonWasPressed(4); // On High
            oRemoteControl.UndoButtonWasPressed(); // Should go back to medium

            Console.ReadLine();
        }
    }
}
