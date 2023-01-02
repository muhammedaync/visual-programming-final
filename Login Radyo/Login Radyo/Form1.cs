using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Radyo
{
    public partial class Form1 : Form
    {
        baglanti db = new baglanti();  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = Settings1.Default.son_girilen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Settings1.Default.son_girilen = textBox1.Text;
            Settings1.Default.Save();


            db.cnn.Open();
            MySqlCommand ekle = new MySqlCommand("select * from login where kullanici_adi ='"+textBox1.Text+"'and password='"+textBox2.Text+"'" ,db.cnn);
            MySqlDataReader reader = ekle.ExecuteReader();

            if (reader.Read())
            {
                

                Form3 form3 = new Form3();
                form3.label9.Text = reader["yetki"].ToString();


                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Hata");
            }
            db.cnn.Close();


        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form2 uyeol= new Form2();
            uyeol.Show();
        }


    }
}
