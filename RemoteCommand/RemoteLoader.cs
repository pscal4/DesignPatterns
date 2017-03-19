using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class RemoteLoader
    {
        // Appliances are created
        Light moLivingRoomLight = new Light("Living Room");
        Light moKitchenLight = new Light("Kitchen");
        // Need Ceiling Fan?
        GarageDoor moGarageDoor = new GarageDoor();
        Stereo moLivingRoomStereo = new Stereo("Living Room");

        // Commands
        LightOnCommand moLivingRoomLightOn, moKitchenLightOn;
        LightOffCommand moLivingRoomLightOff, moKitchenLightOff;
        // Need Ceiling Fam
        GarageDoorOpenCommand moGarageOpen;
        GarageDoorCloseCommand moGarageClose;
        StereoOnWithCDCommand moStereoOnCD;
        StereOffCommand moStereoOff;

        public RemoteLoader(RemoteControl voRemote)
        {
            // Instantiate the command associating them with the appliances
            moLivingRoomLightOn = new LightOnCommand(moLivingRoomLight);
            moLivingRoomLightOff = new LightOffCommand(moLivingRoomLight);
            moKitchenLightOn = new LightOnCommand(moKitchenLight);
            moKitchenLightOff = new LightOffCommand(moKitchenLight);
            moGarageOpen = new GarageDoorOpenCommand(moGarageDoor);
            moGarageClose = new GarageDoorCloseCommand(moGarageDoor);
            // Need Ceiling Fan
            moStereoOnCD = new StereoOnWithCDCommand(moLivingRoomStereo);
            moStereoOff = new StereOffCommand(moLivingRoomStereo);

            voRemote.SetCommand(0, moLivingRoomLightOn, moLivingRoomLightOff);
            voRemote.SetCommand(1, moKitchenLightOn, moKitchenLightOff);
            voRemote.SetCommand(2, moStereoOnCD, moStereoOff);

        }
    }
}
