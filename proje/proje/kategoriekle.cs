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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class kategoriekle : Form
    {
        DataSet kategoriler = new DataSet();

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");
        public kategoriekle()
        {
            InitializeComponent();
            tabloGetir();

        }
        public void tabloGetir()
        {

            kategoriler = new DataSet();



            Database.dbAdapter("SELECT * FROM kategoriler ORDER BY kategori_id").Fill(kategoriler);
            datagridkategoriler.DataSource = kategoriler.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kategoriler (kategori_id,kategori_ad) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;


            kategoriler = new DataSet();
            Database.dbAdapter("SELECT * FROM kategoriler ORDER BY kategori_id").Fill(kategoriler);
            datagridkategoriler.DataSource = kategoriler.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ürünekleForm ürünekleForm = new ürünekleForm();
            ürünekleForm.sıfırla();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = datagridkategoriler;
            string kategori_id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            this.kategorisil(kategori_id);

        }
        private void kategorisil(string kategori_id)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from kategoriler where kategori_id =@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(kategori_id));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi");

        }
    }
}
