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
            Console.WriteLine(String.Format("{0} light is On", msRoom));
        }
        public void Off()
        {
            Console.WriteLine(String.Format("{0} light is Off", msRoom));
        }
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

}
