using System;
using System.Windows.Forms;
using Mp3Example.Mp3;

namespace Mp3Example
{
    public partial class Form1 : Form
    {
        Mp3Player mp3;

        public Form1()
        {
            InitializeComponent();
            mp3 = new Mp3Player();
        }

        private void Browsebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = mp3.BrowseMP3File();
                FilePathtxt.Text = path;
                mp3.LoadSong(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "cant open file", MessageBoxButtons.OK);
            }
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mp3.Play() == 1)
                {
                    MessageBox.Show("No song loaded");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "cant play file", MessageBoxButtons.OK);
            }
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            try
            {
                mp3.Stop();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "cant stop", MessageBoxButtons.OK);
            }
        }
    }
}
