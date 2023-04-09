using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class giris : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");
        DataSet datasetsiparisler = new DataSet();
       

        public giris()
        {
            InitializeComponent();
           

        }
        public string gorevbul()
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT gorevi FROM calisanlar where kullaniciadi=@p1 and sifre=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p1", username.Text);
            komut2.Parameters.AddWithValue("@p2", password.Text);
            string gorev = komut2.ExecuteScalar().ToString();
            return gorev;
            
        }
        


        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("DOLUM YAPIN");
                }

                else
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("SELECT gorevi FROM calisanlar where kullaniciadi=@p1 and sifre=@p2", baglanti);
                    komut2.Parameters.AddWithValue("@p1", username.Text);
                    komut2.Parameters.AddWithValue("@p2", password.Text);

                    NpgsqlDataReader dr = komut2.ExecuteReader();
                    if (dr.Read())
                    {

                        baglanti.Close();
                        anasayfa ana = new anasayfa(gorevbul());

                        this.Visible=false;
                        ana.Show();


                    }
                    else
                    {
                        MessageBox.Show("HATALI");
                        baglanti.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("VERİTABANI HATASI");
            }

        }
    }


}
