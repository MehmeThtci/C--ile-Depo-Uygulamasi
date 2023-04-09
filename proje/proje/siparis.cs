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
    public partial class siparis : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");
        DataSet datasetsiparisler = new DataSet();
        DataTable dt = new DataTable();
        public siparis()
        {
            InitializeComponent();
            ürünlertabloGetir();
            sehirGetir();
            DatagridviewSetting(datagridürünler);
        }
        public void ürünlertabloGetir()
        {

            datasetsiparisler = new DataSet();



            Database.dbAdapter("SELECT * FROM depo_urun_view ORDER BY depo_urun_id").Fill(datasetsiparisler);
            datagridürünler.DataSource = datasetsiparisler.Tables[0];
        }
        public void ilceGetir()
        {

            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM ilceler where sehir=" + cb_sehir.SelectedValue).Fill(dt);
            cb_ilce.DisplayMember = "ilce_ad";
            cb_ilce.ValueMember = "ilce_id";
            cb_ilce.DataSource = dt;

        }
        public void sehirGetir()
        {

            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM sehirler").Fill(dt);
            cb_sehir.DisplayMember = "sehir_ad";
            cb_sehir.ValueMember = "plaka";
            cb_sehir.DataSource = dt;

        }
    

        private void datagridürünler_Click(object sender, EventArgs e)
        {
            try
            {
                text_depo_urun_id.Text = datagridürünler.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());

            }
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(text_depo_urun_id.Text)) { MessageBox.Show("LÜTFEN ÜRÜN SEÇİNİZ"); }
            else { 
                    baglanti.Open();
                    try
                    {
                        NpgsqlCommand komut2 = new NpgsqlCommand("insert into adres (sehir,ilce,detay) values (@t1,@t2,@t3)", baglanti);
                        komut2.Parameters.AddWithValue("@t1", int.Parse(cb_sehir.SelectedValue.ToString()));
                        komut2.Parameters.AddWithValue("@t2", int.Parse(cb_ilce.SelectedValue.ToString()));
                        komut2.Parameters.AddWithValue("@t3", richTextBox1.Text);
                        komut2.ExecuteNonQuery();
                        string lastadres_id = Database.dbCommand("select max(adres_id) from adres").ExecuteScalar().ToString();


                        NpgsqlCommand komut3 = new NpgsqlCommand("insert into musteri (musteri_ad,musteri_soyad,musteri_telefon,musteri_adres) values (@a1,@a2,@a3,@a4)", baglanti);
                        komut3.Parameters.AddWithValue("@a1", textbox_müsteri_ad.Text);
                        komut3.Parameters.AddWithValue("@a2", textbox_müsteri_soyad.Text);
                        komut3.Parameters.AddWithValue("@a3", textbox_muteri_telefon.Text);
                        komut3.Parameters.AddWithValue("@a4", int.Parse(lastadres_id));
                        komut3.ExecuteNonQuery();

                        string lastmusteri_id = Database.dbCommand("select max(musteri_id) from musteri").ExecuteScalar().ToString();

                        string birim_fiyat = Database.dbCommand("select satisfiyatı from depo_urun_view where depo_urun_id = "+text_depo_urun_id.Text).ExecuteScalar().ToString();
                        int adet = int.Parse(textbox_adet.Text);
                        double birimf = double.Parse(birim_fiyat);
                        double tutar = adet * birimf;
                        textbox_tutar.Text = tutar.ToString();
                        NpgsqlCommand komut1 = new NpgsqlCommand("insert into urun_satis (satilan_urun_id,satilan_adet,ödenen_tutar,musteri_id) values (@p2,@p3,@p4,@p5)", baglanti);

                        komut1.Parameters.AddWithValue("@p2", int.Parse(text_depo_urun_id.Text));
                        komut1.Parameters.AddWithValue("@p3", int.Parse(textbox_adet.Text));
                        komut1.Parameters.AddWithValue("@p4", double.Parse(textbox_tutar.Text));
                        komut1.Parameters.AddWithValue("@p5", int.Parse(lastmusteri_id));


                        komut1.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("Sipariş Başarılı Bir Şekilde Oluşturuldu");

                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());
                    }
            }

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            ürünlertabloGetir();
            sehirGetir();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            
                richTextBox1.Clear();
                Font myfont = new Font("Arial", 10);
                richTextBox1.Font = myfont;
        }

        private void textbox_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa= new anasayfa();
            this.Close();
            anasayfa.Show();

        }
        public void DatagridviewSetting(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
