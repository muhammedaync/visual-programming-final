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
    public partial class Favoriler : Form
    {
        public Favoriler()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            radyooynat radyooynat1 = new radyooynat();
            radyooynat1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 don = new Form3();
            don.Show();
            this.Close();
        }

        private void Favoriler_Load(object sender, EventArgs e)
        {
            panel1.Visible = Settings1.Default.karadeniz;
            panel2.Visible = Settings1.Default.best;
            panel3.Visible = Settings1.Default.kral;
            panel4.Visible = Settings1.Default.metro;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Settings1.Default.karadeniz = false;
            Settings1.Default.Save();
            panel1.Visible= Settings1.Default.karadeniz;
        }
    }
}
