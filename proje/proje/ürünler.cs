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

    public partial class ürünler : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");

        DataSet datasetdepodakiürünler = new DataSet();
        DataSet datasetürünler = new DataSet();
        DataTable dt = new DataTable();
        public ürünler(string calisanid) : this()
        {


        }
        public ürünler()
        {
            InitializeComponent();
            tabloGetir();
            ürünlertabloGetir();
            kategoriDoldur(cb_kategori);
            kategoriDoldur(cb_kategori2);
            markaDoldur(cb_marka);
            markaDoldur(cb_urunlerde_marka_arama);



        }
        public void kategoriDoldur(ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM kategoriler").Fill(dt);
            comboBox.DisplayMember = "kategori_ad";
            comboBox.ValueMember = "kategori_id";
            comboBox.DataSource = dt;
        }
        public void markaDoldur(ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM markalar").Fill(dt);
            comboBox.DisplayMember = "marka_adi";
            comboBox.ValueMember = "marka_id";
            comboBox.DataSource = dt;
        }
 

        public void tabloGetir()
        {

            datasetdepodakiürünler = new DataSet();



            Database.dbAdapter("SELECT * FROM depo_urun_view ORDER BY depo_urun_id").Fill(datasetdepodakiürünler);
            datagrid_depodaki_ürünler.DataSource = datasetdepodakiürünler.Tables[0];


        }
        public void ürünlertabloGetir()
        {

            datasetürünler = new DataSet();



            Database.dbAdapter("SELECT * FROM urunler_view ORDER BY urun_id").Fill(datasetürünler);
            dataGridÜrünlerListe.DataSource = datasetürünler.Tables[0];


        }

        private void text_depo_ürün_kodu_TextChanged(object sender, EventArgs e)
        {
            datasetdepodakiürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM depo_urun_view where urun_ad ILIKE '%" + text_ürün_adıile.Text + "%'" +
             " and urun_kodu ILIKE '%" + text_depo_ürün_kodu.Text + "%'" +
             " and model ILIKE '%" + text_depo_model_arama.Text + "%' ORDER BY depo_urun_id").Fill(datasetdepodakiürünler);
            datagrid_depodaki_ürünler.DataSource = datasetdepodakiürünler.Tables[0];
        }

        private string aramaStringi(String[] kolonlar, String[] degerler)
        {

            string result = " ";

            for (int i = 0; i < kolonlar.Length; i++)
            {
                result += kolonlar[i] + " LIKE '%" + degerler[i] + "%' ";
            }
            return result;

        }



        private void btn_supply_update_Click(object sender, EventArgs e)
        {

            datasetdepodakiürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM depo_urun_view where kategori like '%" + cb_kategori.Text + "%'" +
           " and urun_ad like '%" + text_ürün_adıile.Text + "%'" +
           " and urun_kodu like '%" + text_depo_ürün_kodu.Text + "%'" +
           " and marka like '%" + cb_marka.Text + "%'" +
           " and model like '%" + text_depo_model_arama.Text + "%' ORDER BY depo_urun_id").Fill(datasetdepodakiürünler);
            datagrid_depodaki_ürünler.DataSource = datasetdepodakiürünler.Tables[0];
        }

        private void btn_supply_clear_Click(object sender, EventArgs e)
        {
            text_depo_model_arama.Text = string.Empty;
            cb_kategori.Text= string.Empty;
            text_depo_ürün_kodu.Text= string.Empty;
            text_depo_model_arama.Text= string.Empty;
            text_ürün_adıile.Text= string.Empty;
            tabloGetir();
        }

 

        private void btn_intake_insert_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = dataGridÜrünlerListe;
            string urun_id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            this.depoyaUrunEkle(urun_id);

        }

        private void depoyaUrunEkle(string urun_id)
        {
            string adet = textBoxUrunlerAdet.Text;
            if (adet != null && int.TryParse(adet.Trim(), out int adetOut) && adetOut != 0)
            {
                string sql = "";
                string mesaj = "";
                string ürünAdi = dataGridÜrünlerListe.CurrentRow.Cells[1].Value.ToString();
                string depodakiUrunAdetCount = Database.dbCommand("SELECT COUNT(adet) from depodaki_urunler WHERE depodaki_urun = " + urun_id).ExecuteScalar().ToString();
                if (int.Parse(depodakiUrunAdetCount) == 1)
                {
                    string depodakiUrunAdet = Database.dbCommand("SELECT adet from depodaki_urunler WHERE depodaki_urun = " + urun_id).ExecuteScalar().ToString();
                    int adetInt = adetOut + int.Parse(depodakiUrunAdet);
                    sql = "UPDATE depodaki_urunler SET adet = " + adetInt + " WHERE depodaki_urun = " + urun_id;
                    mesaj = "Depoya " + adet + " Kadar DAHA " + ürünAdi + " Ürünü Eklendi";
                }
                else
                {
                    string columns = "depodaki_urun, adet";
                    string values = urun_id + ", " + adet;
                    sql = "INSERT INTO depodaki_urunler (" + columns + ") VALUES( " + values + ")";
                    mesaj = "Depoya " + adet + " Kadar " + ürünAdi + "  Ürünü Eklendi";
                }
                Database.dbCommand(sql).ExecuteNonQuery();
                MessageBox.Show(mesaj);
            }
            else
            {
                MessageBox.Show("Sayı Girin");
            }

        }

        private void text_urunlerde_urun_arama_TextChanged(object sender, EventArgs e)
        {
            datasetürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM urunler_view where urun_ad like '%" + text_urunlerde_urun_arama.Text + "%'" +
             " and model like '%" + text_urunlerde_model_arama.Text + "%'" +
             " and urun_kodu like '%" + text_urunlerde_urun_kod_arama.Text +
             "%' ORDER BY urun_id").Fill(datasetürünler);
            dataGridÜrünlerListe.DataSource = datasetürünler.Tables[0];

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            datasetürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM urunler_view where urun_ad ILIKE '%" + text_urunlerde_urun_arama.Text + "%'" +
             " and model like '%" + text_urunlerde_model_arama.Text + "%'" +
             " and urun_kodu like '%" + text_urunlerde_urun_kod_arama.Text +
             "%' ORDER BY urun_id").Fill(datasetürünler);
            dataGridÜrünlerListe.DataSource = datasetürünler.Tables[0];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage3.Hide();
            tabPage2.Show();
            tabloGetir();
        }

        public void btn_router_transfer_Click(object sender, EventArgs e)
        {
           
            tabPage2.Hide();
            tabPage3.Show();
            ürünlertabloGetir();
            kategoriDoldur(cb_kategori2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void dataGridÜrünlerListe_Click(object sender, EventArgs e)
        {
            try
            {
                text_urunlerde_urun_arama.Text = dataGridÜrünlerListe.CurrentRow.Cells[1].Value.ToString();
                text_urunlerde_urun_kod_arama.Text = dataGridÜrünlerListe.CurrentRow.Cells[2].Value.ToString();
                text_urunlerde_model_arama.Text = dataGridÜrünlerListe.CurrentRow.Cells[4].Value.ToString();
                cb_urunlerde_marka_arama.Text = dataGridÜrünlerListe.CurrentRow.Cells[3].Value.ToString();
                cb_kategori2.Text = dataGridÜrünlerListe.CurrentRow.Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());

            }
        }

        private void text_ürün_adıile_TextChanged(object sender, EventArgs e)
        {
            datasetdepodakiürünler = new DataSet();

            datasetdepodakiürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM depo_urun_view WHERE urun_ad ILIKE '%" + text_ürün_adıile.Text + "%'" +
             " and urun_kodu like '%" + text_depo_ürün_kodu.Text + "%'" +
             " and model like '%" + text_depo_model_arama.Text + "%' ORDER BY depo_urun_id").Fill(datasetdepodakiürünler);
            datagrid_depodaki_ürünler.DataSource = datasetdepodakiürünler.Tables[0];

        }

        private void text_depo_model_arama_TextChanged(object sender, EventArgs e)
        {
            datasetdepodakiürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM depo_urun_view where urun_ad ILIKE '%" + text_ürün_adıile.Text + "%'" +
             " and urun_kodu ILIKE '%" + text_depo_ürün_kodu.Text + "%'" +
             " and model ILIKE '%" + text_depo_model_arama.Text + "%' ORDER BY depo_urun_id").Fill(datasetdepodakiürünler);
            datagrid_depodaki_ürünler.DataSource = datasetdepodakiürünler.Tables[0];
        }

        private void btn_urunlerde_ara_Click(object sender, EventArgs e)
        {
            datasetürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM urunler_view where kategori like '%" + cb_kategori2.Text + "%'" +
           " and urun_ad like '%" + text_urunlerde_urun_arama.Text + "%'" +
           " and urun_kodu like '%" + text_urunlerde_urun_kod_arama.Text + "%'" +
           " and marka like '%" + cb_urunlerde_marka_arama.Text + "%'" +
           " and model like '%" + text_urunlerde_model_arama.Text + "%' ORDER BY urun_id").Fill(datasetürünler);
            dataGridÜrünlerListe.DataSource = datasetürünler.Tables[0];


        }

        private void text_urunlerde_model_arama_TextChanged(object sender, EventArgs e)
        {
            datasetürünler = new DataSet();

            Database.dbAdapter("SELECT * FROM urunler_view where urun_ad like '%" + text_urunlerde_urun_arama.Text + "%'" +
             " and model like '%" + text_urunlerde_model_arama.Text + "%'" +
             " and urun_kodu like '%" + text_urunlerde_urun_kod_arama.Text +
             "%' ORDER BY urun_id").Fill(datasetürünler);
            dataGridÜrünlerListe.DataSource = datasetürünler.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_urunlerde_model_arama.Text = string.Empty;
            cb_kategori2.Text = string.Empty;
            text_urunlerde_urun_arama.Text = string.Empty;
            text_urunlerde_urun_kod_arama.Text = string.Empty;
            cb_urunlerde_marka_arama.Text = string.Empty;
            ürünlertabloGetir();

        }

    }
}
