using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterFacade
{
    class HomeTheaterFacade
    {
        Amplifier moAmp;
        Tuner moTuner;
        DvdPlayer moDvdPlayer;
        CdPlayer moCdPlayer;
        Projector moProjector;
        TheaterLights moTheaterLights;
        Screen moScreen;
        PopcornPopper moPopcornPopper;
        public HomeTheaterFacade(
            Amplifier voAmp,
            Tuner voTuner,
            DvdPlayer voDvdPlayer,
            CdPlayer voCdPlayer,
            Projector voProjector,
            TheaterLights voTheaterLights,
            Screen voScreen,
            PopcornPopper voPopcornPopper
            )
        {
            moAmp = voAmp;
            moTuner = voTuner;
            moDvdPlayer = voDvdPlayer;
            moCdPlayer = voCdPlayer;
            moProjector = voProjector;
            moTheaterLights = voTheaterLights;
            moScreen = voScreen;
            moPopcornPopper = voPopcornPopper;
        }

        public void WatchMovie(string vsMovie)
        {
            Console.WriteLine("Getting ready to watch a movie");
            moPopcornPopper.On();
            moPopcornPopper.Pop();
            moTheaterLights.Dim(10);
            moScreen.Down();
            moProjector.On();
            moProjector.WideScreenMode();
            moAmp.On();
            moAmp.SetDvd(moDvdPlayer);
            moAmp.SetSurroundSound();
            moAmp.SetVolume(5);
            moDvdPlayer.On();
            moDvdPlayer.Play(vsMovie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down");
            moPopcornPopper.Off();
            moTheaterLights.On();
            moScreen.Up();
            moProjector.Off();
            moAmp.Off();
            moDvdPlayer.Stop();
            moDvdPlayer.Eject();
            moDvdPlayer.Off();
        }

    }
}
