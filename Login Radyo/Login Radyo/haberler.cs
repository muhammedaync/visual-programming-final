using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Radyo
{
    
    public partial class haberler : Form
    {
        baglanti bg = new baglanti();





        private void haberler_Load(object sender, EventArgs e)
        {
            button1.Visible = Settings1.Default.yetki;
            richTextBox1.Visible = Settings1.Default.yetki;
            textBox1.Visible = Settings1.Default.yetki;
            label3.Visible = Settings1.Default.yetki;
            label4.Visible = Settings1.Default.yetki;
            label5.Visible = Settings1.Default.yetki;
            textBox2.Visible = Settings1.Default.yetki;

            bg.cnn.Open();
            MySqlCommand ekle = new MySqlCommand("select * from haberler where id ='1'", bg.cnn);
            MySqlDataReader reader = ekle.ExecuteReader();

             
            if (reader.Read())
            {
                label1.Text = reader["baslik"].ToString();
                label2.Text = reader["haber"].ToString();

                try{ webBrowser1.Url = new Uri(reader["resim"].ToString()); }
                catch (Exception){throw;}
               

            }
            bg.cnn.Close();
        
        }

        
        public haberler()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            bg.haberbaslik(textBox1.Text);
            bg.haberyazi(richTextBox1.Text);
            bg.resimguncelle(textBox2.Text);

            bg.cnn.Open();
            MySqlCommand ekle = new MySqlCommand("select * from haberler where id ='1'", bg.cnn);
            MySqlDataReader reader = ekle.ExecuteReader();


            if (reader.Read())
            {
                label1.Text = reader["baslik"].ToString();
                label2.Text = reader["haber"].ToString();
                try { webBrowser1.Url = new Uri(reader["resim"].ToString()); }
                catch (Exception) { throw; }

            }
            bg.cnn.Close();
            MessageBox.Show("Haber Başarıyla Güncellenmiştir.", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            havadurumu hava = new havadurumu();
            hava.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            para hava = new para();
            hava.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 don = new Form3();
            don.Show();
            this.Close();
        }
    }
}
