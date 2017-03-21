using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public static class RemoteLoader
    {

        public static void LoadRemote(RemoteControl voRemote)
        {
            // Create appliances and their commands
            var oLivingRoomLight = new Light("Living Room");
            var oLivingRoomLightOn = new LightOnCommand(oLivingRoomLight);
            var oLivingRoomLightOff = new LightOffCommand(oLivingRoomLight);

            var oKitchenLight = new Light("Kitchen");
            var oKitchenLightOn = new LightOnCommand(oKitchenLight);
            var oKitchenLightOff = new LightOffCommand(oKitchenLight);

            var oGarageDoor = new GarageDoor();
            var oGarageOpen = new GarageDoorOpenCommand(oGarageDoor);
            var oGarageClose = new GarageDoorCloseCommand(oGarageDoor);

            var oLivingRoomStereo = new Stereo("Living Room");
            var oStereoOnCD = new StereoOnWithCDCommand(oLivingRoomStereo);
            var oStereoOff = new StereOffCommand(oLivingRoomStereo);

            var oLivingRoomCeilingFan = new CeilingFan("Living Room");
            var oCeilngFanHighCommand = new CeilngFanHighCommand(oLivingRoomCeilingFan);
            var oCeilngFanMediumCommand = new CeilngFanMediumCommand(oLivingRoomCeilingFan);
            var oCeilngFanOffCommand = new CeilngFanOffCommand(oLivingRoomCeilingFan);

            var oHotTub = new HotTub();
            var oHotTubJetsOnCommand = new HotTubJetsOnCommand(oHotTub);
            var oHotTubJetsOffCommand = new HotTubJetsOffCommand(oHotTub);

            // Party (macro) button
            ICommand[] oPartyOn = { oLivingRoomLightOn, oStereoOnCD, oHotTubJetsOnCommand };
            ICommand[] oPartyOff = { oLivingRoomLightOff, oStereoOff, oHotTubJetsOffCommand };
            var oPartyOnMacro = new MacroCommand(oPartyOn);
            var oPartyOffMacro = new MacroCommand(oPartyOff);

            voRemote.SetCommand(0, oLivingRoomLightOn, oLivingRoomLightOff);
            voRemote.SetCommand(1, oKitchenLightOn, oKitchenLightOff);
            voRemote.SetCommand(2, oStereoOnCD, oStereoOff);
            voRemote.SetCommand(3, oCeilngFanMediumCommand, oCeilngFanOffCommand);
            voRemote.SetCommand(4, oCeilngFanHighCommand, oCeilngFanOffCommand);
            voRemote.SetCommand(5, oPartyOnMacro, oPartyOffMacro);
        }
    }
}
