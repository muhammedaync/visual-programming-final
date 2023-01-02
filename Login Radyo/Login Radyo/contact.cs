using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Login_Radyo
{
    public partial class contact : Form
    {

        baglanti bg = new baglanti();
        public contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MailMessage mesajım= new MailMessage();
            //SmtpClient istemci = new SmtpClient();
            //istemci.Credentials = new System.Net.NetworkCredential("muhammedaynaci80@gmail.com","12345678C#+");
            //istemci.Port = 587;
            //istemci.Host = "smtp.live.com";
            //istemci.EnableSsl= true;
            //mesajım.To.Add(textBox1.Text);
            //mesajım.From = new MailAddress("muhammedaynaci80@gmail.com");
            //mesajım.Subject = textBox2.Text;
            //mesajım.Body= textBox3.Text;
            //istemci.Send(mesajım);

            bg.mesajberbaslik
                (textBox2.Text,
                textBox3.Text);          
            MessageBox.Show("Mesajınız Gönderilmiştir.");
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 don = new Form3();
            don.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin don = new admin();
            don.Show();
            this.Close();
        }

        private void contact_Load(object sender, EventArgs e)
        {
            button3.Visible = Settings1.Default.yetki;
        }
    }
}
