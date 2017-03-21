using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        string msRoom;
        int miSpeed;

        public CeilingFan(string vsRoom)
        {
            msRoom = vsRoom;
            miSpeed = OFF;
        }
        public void Off()
        {
            miSpeed = OFF;
            Console.WriteLine(String.Format("{0} ceiling fan set to {1}", msRoom, miSpeed));
        }
        public void High()
        {
            miSpeed = HIGH;
            Console.WriteLine(String.Format("{0} ceiling fan set to {1}", msRoom, miSpeed));
        }
        public void Medium()
        {
            miSpeed = MEDIUM;
            Console.WriteLine(String.Format("{0} ceiling fan set to {1}", msRoom, miSpeed));
        }
        public void Low()
        {
            miSpeed = LOW;
            Console.WriteLine(String.Format("{0} ceiling fan set to {1}", msRoom, miSpeed));
        }
        public int GetSpeed()
        {
            return miSpeed;
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
