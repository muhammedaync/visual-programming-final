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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string hangisiacik;
        private void Form3_Load(object sender, EventArgs e)
        {
            label5.Visible = Settings1.Default.karadeniz;
            label6.Visible = Settings1.Default.best;
            label7.Visible = Settings1.Default.kral;
            label8.Visible = Settings1.Default.metro;
            if (label9.Text == "1")
            {
                Settings1.Default.yetki=true;
            }
            if (label9.Text == "0")
            {
                Settings1.Default.yetki = false;
            }
            label10.Text = Settings1.Default.yetki.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Settings1.Default.karadeniz = true;
            Settings1.Default.Save();
            label5.Visible = Settings1.Default.karadeniz;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings1.Default.karadeniz = false;
            Settings1.Default.Save();
            label5.Visible = Settings1.Default.karadeniz;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings1.Default.best = false;
            Settings1.Default.Save();
            label6.Visible = Settings1.Default.best;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings1.Default.best = true;
            Settings1.Default.Save();
            label6.Visible = Settings1.Default.best;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings1.Default.kral = true;
            Settings1.Default.Save();
            label7.Visible = Settings1.Default.kral;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings1.Default.kral = false;
            Settings1.Default.Save();          
            label7.Visible = Settings1.Default.kral;         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings1.Default.metro = true;
            Settings1.Default.Save();        
            label8.Visible = Settings1.Default.metro;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Settings1.Default.metro = false;
            Settings1.Default.Save();          
            label8.Visible = Settings1.Default.metro;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings1.Default.hangisiacik = "karadeniz";
            radyooynat radyooynat1 = new radyooynat();
            radyooynat1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Settings1.Default.hangisiacik = "best";
            radyooynat radyooynat1 = new radyooynat();
            radyooynat1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Settings1.Default.hangisiacik = "kral";
            radyooynat radyooynat1 = new radyooynat();
            radyooynat1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Settings1.Default.hangisiacik = "metro";
            radyooynat radyooynat1 = new radyooynat();
            radyooynat1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Favoriler fav = new Favoriler();
            fav.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            haberler hbr = new haberler();
            hbr.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            contact cont = new contact();
            cont.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            link cont = new link();
            cont.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bilgi cont = new bilgi();
            cont.Show();
            this.Hide();
        }
    }
}
