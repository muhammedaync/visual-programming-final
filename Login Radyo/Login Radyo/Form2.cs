using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Radyo
{
    public partial class Form2 : Form
    {
        baglanti baglan = new baglanti();
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox5.Text == textBox6.Text)
            {
                baglan.üyeolustur(textBox3.Text, textBox5.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Hatalı veya Boş bırakılamaz.");
             
            }
            MessageBox.Show("Kayıt olundu.");
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
