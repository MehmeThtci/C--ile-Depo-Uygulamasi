using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class markaekle : Form
    {
        DataSet markalar = new DataSet();

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");

        public markaekle()
        {
            InitializeComponent();
            tabloGetir();
        }

        public void tabloGetir()
        {

            markalar = new DataSet();



            Database.dbAdapter("SELECT * FROM markalar ORDER BY marka_id").Fill(markalar);
            datagridmarkalar.DataSource = markalar.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into markalar (marka_id,marka_adi,marka_telefon,marka_temsilcisi) values (@p1,@p2,@p3,@p4)",baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);
            komut1.Parameters.AddWithValue("@p4", textBox4.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Marka Başarılı Bir Şekilde Eklendi");




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            markalar = new DataSet();
            Database.dbAdapter("SELECT * FROM markalar ORDER BY marka_id").Fill(markalar);
            datagridmarkalar.DataSource = markalar.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
           
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = datagridmarkalar;
            string marka_id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            this.markasil(marka_id);

        }
        private void markasil(string marka_id)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from markalar where marka_id=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(marka_id));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Başarılı Bir Şekilde Silindi");

        }
    }
}
