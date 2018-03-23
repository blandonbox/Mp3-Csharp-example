using System;
using WMPLib;
using System.Windows.Forms;

namespace Mp3Example.Mp3
{
    class Mp3Player
    {
        WindowsMediaPlayer wmp;

        public Mp3Player()
        {
            wmp = new WindowsMediaPlayer();
        }

        public string BrowseMP3File()
        {
            try
            {
                OpenFileDialog Browse = new OpenFileDialog();
                Browse.Filter = "mp3 files (*mp3)|*.mp3";
                Browse.FilterIndex = 1;
                if (Browse.ShowDialog() == DialogResult.OK)
                {
                    return Browse.FileName;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void LoadSong(string path)
        {
            try
            {
                Stop();
                wmp.URL = path;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Play()
        {
            try
            {
                if (wmp.controls.currentItem != null)
                {
                    wmp.controls.stop();
                    wmp.close();
                    wmp.controls.play();
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Stop()
        {
            try
            {
                wmp.controls.stop();
                wmp.close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
