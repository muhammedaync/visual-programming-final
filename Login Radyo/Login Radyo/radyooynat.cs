using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Radyo
{
    public partial class radyooynat : Form
    {
        public radyooynat()
        {
            InitializeComponent();
        }
        
        private void radyooynat_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.hangisiacik=="karadeniz")
            {
                radyocal("https://wowza1.radyotvonline.com/unitedmedia/karadenizfm.stream/playlist.m3u8");
            }
            if (Settings1.Default.hangisiacik == "metro")
            {
                radyocal("https://live.powerapp.com.tr/powerfm/abr/playlist.m3u8");
            }
            if (Settings1.Default.hangisiacik == "best")
            {
                radyocal("http://46.20.7.126/bestfmmp3");
            }
            if (Settings1.Default.hangisiacik == "kral")
            {
                radyocal("https://ssldyg.radyotvonline.com/smil/smil:kralfm.smil/playlist.m3u8");
            }



        }



        public void radyocal(string adres)
        {
            axWindowsMediaPlayer1.URL = adres;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
