using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    public class HotTub
    {
        public void JetsOn()
        {
            Console.WriteLine("Hot tub jets are on");
        }
        public void JetsOff()
        {
            Console.WriteLine("Hot tub jets are off");
        }
    }
    public class HotTubJetsOnCommand : ICommand
    {
        HotTub moHotTub;
        public HotTubJetsOnCommand(HotTub voHotTub)
        {
            moHotTub = voHotTub;
        }
        public void Execute()
        {
            moHotTub.JetsOn();
        }
        public void Undo()
        {
            moHotTub.JetsOff();
        }
    }
    public class HotTubJetsOffCommand : ICommand
    {
        HotTub moHotTub;
        public HotTubJetsOffCommand(HotTub voHotTub)
        {
            moHotTub = voHotTub;
        }
        public void Execute()
        {
            moHotTub.JetsOff();
        }
        public void Undo()
        {
            moHotTub.JetsOn();
        }
    }
}
