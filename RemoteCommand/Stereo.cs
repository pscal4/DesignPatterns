using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class Stereo
    {
        string msRoom;
        public Stereo(string vsRoom)
        {
            msRoom = vsRoom;
        }
        public void On()
        {
            Console.WriteLine(String.Format("{0} stereo is on", msRoom));
        }
        public void Off()
        {
            Console.WriteLine(String.Format("{0} stereo is off", msRoom));
        }
        public void SetCD()
        {
            Console.WriteLine(String.Format("{0} stereo is set for CD", msRoom));
        }
        public void SetDvd()
        {
            Console.WriteLine(String.Format("stereo {0} is set for DVD", msRoom));
        }
        public void SetRadio()
        {
            Console.WriteLine(String.Format("{0} stereo is set for Radio", msRoom));
        }
        public void SetVolume(int viVolume)
        {
            Console.WriteLine(String.Format("{1} stereo volune is {0}", viVolume, msRoom));
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
}
