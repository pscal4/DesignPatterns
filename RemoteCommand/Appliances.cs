using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class Light
    {
        string msRoom;
        public Light(string vsRoom)
        {
            msRoom = vsRoom;
        }
        public void On()
        {
            Console.WriteLine(String.Format("{0} light is On",msRoom));
        }
        public void Off()
        {
            Console.WriteLine(String.Format("{0} light is Off", msRoom));
        }
    }
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
            Console.WriteLine(String.Format("{0} stereo is off",msRoom));
        }
        public void SetCD()
        {
            Console.WriteLine(String.Format("{0} stereo is set for CD",msRoom));
        }
        public void SetDvd()
        {
            Console.WriteLine(String.Format("stereo {0} is set for DVD",msRoom));
        }
        public void SetRadio()
        {
            Console.WriteLine(String.Format("{0} stereo is set for Radio",msRoom));
        }
        public void SetVolume(int viVolume)
        {
            Console.WriteLine(String.Format("{1} stereo volune is {0}",viVolume,msRoom));
        }
    }
}
