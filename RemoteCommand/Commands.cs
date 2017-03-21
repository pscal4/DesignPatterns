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
        public void Undo() { }
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
        public void Undo()
        {
            moLight.Off();
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
        public void Undo()
        {
            moLight.On();
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
        public void Undo()
        {
            moStereo.Off();
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
        public void Undo()
        {
            moStereo.On();
            // Need more here?
        }
    }
    public class CeilngFanOffCommand : ICommand
    {
        CeilingFan moCeilngFan;
        int miPrevSpeed;

        public CeilngFanOffCommand(CeilingFan voCeilingFan)
        {
            moCeilngFan = voCeilingFan;
        }
        public void Execute()
        {
            miPrevSpeed = moCeilngFan.GetSpeed();
            moCeilngFan.Off();
        }
        public void Undo()
        {
            if (miPrevSpeed == CeilingFan.HIGH)
            {
                moCeilngFan.High();
            }
            else if (miPrevSpeed == CeilingFan.MEDIUM)
            {
                moCeilngFan.Medium();
            }
            else if (miPrevSpeed == CeilingFan.LOW)
            {
                moCeilngFan.Low();
            }
            else if (miPrevSpeed == CeilingFan.OFF)
            {
                moCeilngFan.Off();
            }
        }
    }
    public class CeilngFanHighCommand : ICommand
    {
        CeilingFan moCeilngFan;
        int miPrevSpeed;
        public CeilngFanHighCommand(CeilingFan voCeilingFan)
        {
            moCeilngFan = voCeilingFan;
        }
        public void Execute()
        {
            miPrevSpeed = moCeilngFan.GetSpeed();
            moCeilngFan.High();
        }
        public void Undo()
        {
            if (miPrevSpeed == CeilingFan.HIGH)
            {
                moCeilngFan.High();
            }
            else if (miPrevSpeed == CeilingFan.MEDIUM)
            {
                moCeilngFan.Medium();
            }
            else if (miPrevSpeed == CeilingFan.LOW)
            {
                moCeilngFan.Low();
            }
            else if (miPrevSpeed == CeilingFan.OFF)
            {
                moCeilngFan.Off();
            }
        }
    }
    public class CeilngFanMediumCommand : ICommand
    {
        CeilingFan moCeilngFan;
        int miPrevSpeed;
        public CeilngFanMediumCommand(CeilingFan voCeilingFan)
        {
            moCeilngFan = voCeilingFan;
        }
        public void Execute()
        {
            miPrevSpeed = moCeilngFan.GetSpeed();
            moCeilngFan.Medium();
        }
        public void Undo()
        {
            if (miPrevSpeed == CeilingFan.HIGH)
            {
                moCeilngFan.High();
            }
            else if (miPrevSpeed == CeilingFan.MEDIUM)
            {
                moCeilngFan.Medium();
            }
            else if (miPrevSpeed == CeilingFan.LOW)
            {
                moCeilngFan.Low();
            }
            else if (miPrevSpeed == CeilingFan.OFF)
            {
                moCeilngFan.Off();
            }
        }
    }
    public class CeilngFanLowCommand : ICommand
    {
        CeilingFan moCeilngFan;
        int miPrevSpeed;
        public CeilngFanLowCommand(CeilingFan voCeilingFan)
        {
            moCeilngFan = voCeilingFan;
        }
        public void Execute()
        {
            miPrevSpeed = moCeilngFan.GetSpeed();
            moCeilngFan.Low();
        }
        public void Undo()
        {
            if (miPrevSpeed == CeilingFan.HIGH)
            {
                moCeilngFan.High();
            }
            else if (miPrevSpeed == CeilingFan.MEDIUM)
            {
                moCeilngFan.Medium();
            }
            else if (miPrevSpeed == CeilingFan.LOW)
            {
                moCeilngFan.Low();
            }
            else if (miPrevSpeed == CeilingFan.OFF)
            {
                moCeilngFan.Off();
            }
        }
    }

}
