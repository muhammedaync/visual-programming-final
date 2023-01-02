using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Radyo
{   
    internal class baglanti
    {
        public MySqlConnection cnn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd='';");

        public void üyeolustur(string kadi,string sifre,string adsoyad)
        {
            cnn.Open();
            MySqlCommand ekle = new MySqlCommand("insert into login(kullanici_adi,password,ad_soyad)values('" + kadi + "','" + sifre + "','" + adsoyad + "')", cnn);
            ekle.ExecuteNonQuery();
            cnn.Close();
        }

        public void haberbaslik(string baslik)
        {
            cnn.Open();
            MySqlCommand guncelle = new MySqlCommand("update haberler set baslik='" + baslik + "'", cnn);
            guncelle.ExecuteNonQuery();
            cnn.Close();
        }
        public void haberyazi(string haber)
        {
            cnn.Open();
            MySqlCommand guncelle = new MySqlCommand("update haberler set haber='" + haber + "'", cnn);
            guncelle.ExecuteNonQuery();
            cnn.Close();
        }

        public void resimguncelle(string resim)
        {
            cnn.Open();
            MySqlCommand guncelle = new MySqlCommand("update haberler set resim='" + resim + "'", cnn);
            guncelle.ExecuteNonQuery();
            cnn.Close();
        }

        public void mesajberbaslik(string baslik,string mesaj)
        {
            cnn.Open();
            MySqlCommand ekle = new MySqlCommand("insert into iletisim (baslik,mesaj)values('" + baslik + "','" + mesaj + "')", cnn);
            ekle.ExecuteNonQuery();
            cnn.Close();
        }


    }
}
