using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class NoCommand : ICommand
    {

        public void Execute() {}
    }
    public class LightOnCommand : ICommand
    {
        Light moLight;
        public LightOnCommand(Light voLight)
        {
            moLight = voLight;
        }


        public void Execute()
        {
            moLight.On();
        }
    }
    public class LightOffCommand : ICommand
    {
        Light moLight;
        public LightOffCommand(Light voLight)
        {
            moLight = voLight;
        }


        public void Execute()
        {
            moLight.Off();
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
    }
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo moStereo;
        public StereoOnWithCDCommand(Stereo voStereo)
        {
            moStereo = voStereo;
        }


        public void Execute()
        {
            moStereo.On();
            moStereo.SetCD();
            moStereo.SetVolume(11);
        }
    }
    public class StereOffCommand : ICommand
    {
        Stereo moStereo;
        public StereOffCommand(Stereo voStereo)
        {
            moStereo = voStereo;
        }


        public void Execute()
        {
            moStereo.Off();
        }
    }

}
