using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var oAmp = new Amplifier();
            var oTuner = new Tuner();
            var oDvdPlayer = new DvdPlayer();
            var oCdPlayer = new CdPlayer(oAmp);
            var oProjector = new Projector();
            var oTheaterLights = new TheaterLights();
            var oScreen = new Screen();
            var oPopcornPopper = new PopcornPopper();

            var oHomeTheaterFacade = new HomeTheaterFacade(oAmp, oTuner, oDvdPlayer, oCdPlayer, 
                oProjector, oTheaterLights, oScreen, oPopcornPopper);
            oHomeTheaterFacade.WatchMovie("Raiders of the Lost Ark");
            Console.WriteLine("");
            oHomeTheaterFacade.EndMovie();
            Console.ReadLine();
;
        }
    }
}
