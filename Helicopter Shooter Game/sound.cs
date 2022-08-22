using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Helicopter_Shooter_Game
{
    public class sound
    {
        private WaveStream _soundplayerBgStream;
        private WaveOut _soundplayerBgOut;
        private WaveStream _soundgameoverplayerStream;
        private WaveOut _soundgameoverplayerOut;
        private WaveStream _soundlaserplayerStream;
        private WaveOut _soundlaserplayerOut;
        private WaveStream _soundexplosionplayerStream;
        private WaveOut _soundexplosionplayerOut;




        public sound()
        {
            var soundBgFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\battle.wav";
            var soundGameoverFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\gameover.wav";
            var soundLaserFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\laser.wav";
            var soundExplosionFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\explosion.wav";

            //initiate Background sound
            _soundplayerBgStream = new AudioFileReader(soundBgFile);
            _soundplayerBgOut = new WaveOut();
            _soundplayerBgOut.Init(_soundplayerBgStream);

            //initiate the shuthug
            _soundgameoverplayerStream = new AudioFileReader(soundGameoverFile);
            _soundgameoverplayerOut = new WaveOut();
            _soundgameoverplayerOut.Init(_soundgameoverplayerStream);

            //initiate the shuthug
            _soundlaserplayerStream = new AudioFileReader(soundLaserFile);
            _soundlaserplayerOut = new WaveOut();
            _soundlaserplayerOut.Init(_soundlaserplayerStream);

            //initiate the shuthug
            _soundexplosionplayerStream = new AudioFileReader(soundExplosionFile);
            _soundexplosionplayerOut = new WaveOut();
            _soundexplosionplayerOut.Init(_soundexplosionplayerStream);

            //start the sound
            _soundplayerBgOut.Play();

        }

        public void PlayGameoverSound()
        {
            //if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundgameoverplayerOut.PlaybackState is PlaybackState.Playing) _soundgameoverplayerOut.Stop();

            _soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundgameoverplayerStream.CurrentTime = new TimeSpan(0L);
            _soundgameoverplayerOut.Play();
            _soundplayerBgOut.Play();

        }

        public void PlayLaserSound()
        {
            //if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundlaserplayerOut.PlaybackState is PlaybackState.Playing) _soundlaserplayerOut.Stop();

            //_soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundlaserplayerStream.CurrentTime = new TimeSpan(0L);
            _soundlaserplayerOut.Play();
            //_soundplayerBgOut.Play();

        }

        public void PlayExplosionSound()
        {
            //if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundexplosionplayerOut.PlaybackState is PlaybackState.Playing) _soundexplosionplayerOut.Stop();

            //_soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundexplosionplayerStream.CurrentTime = new TimeSpan(0L);
            _soundexplosionplayerOut.Play();
            //_soundplayerBgOut.Play();

        }

    }
}
