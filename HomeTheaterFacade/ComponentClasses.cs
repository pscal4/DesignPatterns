using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterFacade
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen is up");
        }
        public void Down() {
            Console.WriteLine("Screen is down");
        }
    }
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper is on");
        }
        public void Off()
        {
            Console.WriteLine("Popcorn popper is off");
        }
        public void Pop()
        {
            Console.WriteLine("Popping");
        }
    }
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater ceiling lights on");
        }
        public void Off()
        {
            Console.WriteLine("Theater Lights off");
        }
        public void Dim(int viPercent)
        {
            Console.WriteLine(String.Format("Theater Lights dimmed to {0} percent",viPercent));
        }        
    }
    public class Projector
    {
        DvdPlayer moDvdPlayer;
        public void On()
        {
            Console.WriteLine("Projector on");
        }
        public void Off()
        {
            Console.WriteLine("Projector off");
        }
        public void TvMode()
        {
            Console.WriteLine("Projector in TV mode");
        }
        public void WideScreenMode()
        {
            Console.WriteLine("Projector wide screen mode");
        }
    }
    public class Amplifier
    {
        private DvdPlayer moDvdPlayer;
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }
        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetDvd(DvdPlayer voDvdPlayer)
        {
            moDvdPlayer = voDvdPlayer;
            Console.WriteLine("Amplifier setting Dvd Player");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier setting surround sound on 5 speakers, 1 subwoofer");
        }
        public void SetVolume(int viVolume)
        {
            Console.WriteLine(String.Format("Amplifier setting volume to {0}",viVolume));
        }
    }
    public class DvdPlayer
    {
  
        public void On()
        {
            Console.WriteLine("Dvd Player on");
        }
        public void Off()
        {
            Console.WriteLine("Dvd Player off");
        }
        public void Eject()
        {
            Console.WriteLine("Dvd Player eject Dvd");
        }
        public void Stop()
        {
            Console.WriteLine("Dvd Player stop Dvd");
        }
        public void Play(string vsMovie)
        {
            Console.WriteLine("Dvd Player playing Dvd " + vsMovie);
        }
        // TODO more methods
    }
    public class Tuner
    {
        Amplifier moAmplifier;
        public void On()
        {
            Console.WriteLine("Tuner on");
        }
        public void Off()
        {
            Console.WriteLine("Tuner off");
        }
        // TODO more methods

    }
    public class CdPlayer
    {
        Amplifier moAmplifier;
        public CdPlayer(Amplifier voAmplifier)
        {
            moAmplifier = voAmplifier;
        }
        public void On()
        {
            Console.WriteLine("Cd Player on");
        }
        public void Off()
        {
            Console.WriteLine("Cd Player off");
        }
        public void Eject()
        {
            Console.WriteLine("Eject Cd");
        }
        public void Play()
        {
            Console.WriteLine("Play Cd");
        }
        // TODO more methods
    }
}
