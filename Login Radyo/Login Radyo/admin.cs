using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Radyo
{
    public partial class admin : Form
    {
        baglanti bg = new baglanti();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public string isim, yetki;

        public admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void admin_Load(object sender, EventArgs e)
        {
            //MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd='';");
            //bg.cnn.Open();
            //cmd.CommandText = "select * from iletisim";
            //dr =cmd.ExecuteReader();
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd.ToString(), baglanti);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //bg.cnn.Close();

            yukleme();
         
        }       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            contact don = new contact();
            don.Show();
            this.Close();
        }

        public void yukleme()
        {     
            for (int i = 0; i < 200; i++)
            {

                bg.cnn.Open();

                MySqlCommand komut = new MySqlCommand("select * from iletisim where id='" + i.ToString() + "'", bg.cnn);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    label1.Text = oku.FieldCount.ToString();
                    isim = oku["baslik"].ToString();
                    yetki = oku["mesaj"].ToString();
                    listBox1.Items.Add(oku["baslik"].ToString());
                    listBox1.Items.Add(oku["mesaj"].ToString());


                }
                bg.cnn.Close();

            }
            //bg.cnn.Open();
            //MySqlCommand komut = new MySqlCommand("select * from iletisim where id=10 ", bg.cnn);
            //MySqlDataReader oku = komut.ExecuteReader();
            //listBox1.Items.Add(oku["baslik"].ToString());
            //bg.cnn.Close();
        }

    }
}
