using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class ürünekleForm : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");

        DataSet datasetürünler = new DataSet();
        DataTable dt = new DataTable();
        DataTable dtt = new DataTable();


        public ürünekleForm()
        {
            InitializeComponent();
            sıfırla();

        }
        public void kategorigetir()
        {
            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM kategoriler").Fill(dt);
            cb_kategori.DisplayMember = "kategori_ad";
            cb_kategori.ValueMember = "kategori_id";
            cb_kategori.DataSource = dt;
        }
        public void markaigetir()
        {
            DataTable dtt = new DataTable();
            Database.dbAdapter("SELECT * FROM markalar").Fill(dtt);
            cb_marka.DisplayMember = "marka_adi";
            cb_marka.ValueMember = "marka_id";
            cb_marka.DataSource = dtt;

        }
        public void ürünlertabloGetir()
        {

            datasetürünler = new DataSet();



            Database.dbAdapter("SELECT * FROM urunler_view ORDER BY urun_id").Fill(datasetürünler);
            datagridurunlerekle.DataSource = datasetürünler.Tables[0];


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            markaekle markamodelekle = new markaekle();

 
            markamodelekle.Show();
            
        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into urunler (urun_ad,urun_kodu,marka,model,kategori,birim_fiyat) values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
           // komut1.Parameters.AddWithValue("@p1", int.Parse(textboxürünid.Text));
            komut1.Parameters.AddWithValue("@p2", textürünadı.Text);
            komut1.Parameters.AddWithValue("@p3", textürünkodu.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(cb_marka.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p5", textürünmodel.Text);
            komut1.Parameters.AddWithValue("@p6", int.Parse(cb_kategori.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p7", double.Parse(textürünfiyatı.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi");
            sıfırla();
        }
        public void sıfırla()
        {
            textboxürünid.Text = string.Empty;
            textürünadı.Text = string.Empty;
            textürünkodu.Text = string.Empty;
            textürünmodel.Text = string.Empty;
            textürünfiyatı.Text = string.Empty;
            ürünlertabloGetir();
            markaigetir();
            kategorigetir();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            kategoriekle kategoriekle = new kategoriekle();

 
            kategoriekle.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = datagridurunlerekle;
            string ürün_id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            this.ürünsil(ürün_id);
        }
        private void ürünsil(string ürün_id)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from urunler where urun_id =@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(ürün_id));
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Başarılı Bir Şekilde Silindi");
                sıfırla();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ÜRÜN SİLME SIRASINDA HATA OLUŞTU");

            }


        }
        private void datagridurunlerekle_Click(object sender, EventArgs e)
        {
            try
            {
                textboxürünid.Text = datagridurunlerekle.CurrentRow.Cells[0].Value.ToString();
                textürünadı.Text = datagridurunlerekle.CurrentRow.Cells[1].Value.ToString();
                textürünkodu.Text = datagridurunlerekle.CurrentRow.Cells[2].Value.ToString();
                cb_marka.Text = datagridurunlerekle.CurrentRow.Cells[3].Value.ToString();
                textürünmodel.Text = datagridurunlerekle.CurrentRow.Cells[4].Value.ToString();
                cb_kategori.Text = datagridurunlerekle.CurrentRow.Cells[5].Value.ToString();
                textürünfiyatı.Text = datagridurunlerekle.CurrentRow.Cells[6].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();

            this.Hide();
            adminForm.Show();
        }

        private void btn_güncelle_Click_1(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE urunler SET urun_id=@p1,urun_ad=@p2,urun_kodu=@p3,marka=@p4,model=@p5,kategori=@p7,birim_fiyat=@p8 WHERE urun_id=@p1", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(textboxürünid.Text));
                komut1.Parameters.AddWithValue("@p2", textürünadı.Text);
                komut1.Parameters.AddWithValue("@p3", textürünkodu.Text);
                komut1.Parameters.AddWithValue("@p4", int.Parse(cb_marka.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p5", textürünmodel.Text);
                komut1.Parameters.AddWithValue("@p7", int.Parse(cb_kategori.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p8", double.Parse(textürünfiyatı.Text));

                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("GÜNCELLEME Başarılı Bir Şekilde Yapıldı");
                sıfırla();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString()); 
        }

        }

        private void cb_marka_Click(object sender, EventArgs e)
        {
            markaigetir();
        }

        private void cb_kategori_Click(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
