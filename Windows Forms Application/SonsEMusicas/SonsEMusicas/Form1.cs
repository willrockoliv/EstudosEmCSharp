using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SonsEMusicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Windows\Media\ir_begin.wav";
            player.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv";
            //axWindowsMediaPlayer1.play


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dica: https://msdn.microsoft.com/pt-br/library/windows/desktop/dd562851(v=vs.85).aspx
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("minhaPlayList");
            WMPLib.IWMPMedia media;

            string arquivo = @"C:\Windows\Media\ir_begin.wav";
            media = axWindowsMediaPlayer1.newMedia(arquivo);
            playlist.appendItem(media);

            arquivo = @"C:\Windows\Media\ir_end.wav";
            media = axWindowsMediaPlayer1.newMedia(arquivo);
            playlist.appendItem(media);

            axWindowsMediaPlayer1.currentPlaylist = playlist;
            axWindowsMediaPlayer1.Ctlcontrols.play();                
            
        }
    }
}
