using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proje
{
    public partial class calışanform : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");

        DataSet datasetcalisanlar = new DataSet();
        DataSet datasetcalisanlarana = new DataSet();

        DataTable dt = new DataTable();
        DataTable dtt = new DataTable();
        public calışanform(string calisanid) : this()
        {
            görünüm(calisanid);
            string calisanid1 = calisanid;

        }
        public calışanform()
        {
            InitializeComponent();
            calışanlartabloGetir();
            sehirGetir();
            gorevGetir();
 

        }
        public void görünüm(string calisanid)
        {
            label2.Text = calisanid;

            if (calisanid == "1")
            {

            }
            else if (calisanid == "2")
            {

            }
            else if (calisanid == "3")
            {
                textbox_sifre.Visible= false;
                textbox_kullaniciadi.Visible= false;
                btn_ekle.Enabled= false;
                btn_sil.Enabled= false;
                btn_güncelle.Enabled= false;
            }
            else
            {
                MessageBox.Show("Bilinmeyen Kullanıcı");
            }
        }
        public void calışanlartabloGetir()
        {

            datasetcalisanlar = new DataSet();



            Database.dbAdapter("SELECT * FROM calisan_view ORDER BY calisan_id").Fill(datasetcalisanlar);
            datagridcalışanlar.DataSource = datasetcalisanlar.Tables[0];
        }
        public void sehirGetir()
        {

            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM sehirler").Fill(dt);
            cb_sehir.DisplayMember = "sehir_ad";
            cb_sehir.ValueMember = "plaka";
            cb_sehir.DataSource = dt;

        }
        public void ilceGetir()
        {

            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM ilceler where sehir="+cb_sehir.SelectedValue).Fill(dt);
            cb_ilce.DisplayMember = "ilce_ad";
            cb_ilce.ValueMember = "ilce_id";
            cb_ilce.DataSource = dt;

        }
        public void gorevGetir()
        {
            DataTable dt = new DataTable();
            Database.dbAdapter("SELECT * FROM gorevler").Fill(dt);
            cb_gorev.DisplayMember = "gorev_ad";
            cb_gorev.ValueMember = "gorev_id";
            cb_gorev.DataSource = dt;
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
        }
 

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into adres (sehir,ilce,detay) values (@t1,@t2,@t3)", baglanti);
                komut2.Parameters.AddWithValue("@t1", int.Parse(cb_sehir.SelectedValue.ToString()));
                komut2.Parameters.AddWithValue("@t2", int.Parse(cb_ilce.SelectedValue.ToString()));
                komut2.Parameters.AddWithValue("@t3", richTextBox1.Text);
                komut2.ExecuteNonQuery();



                string lastadres_id = Database.dbCommand("select max(adres_id) from adres").ExecuteScalar().ToString();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into calisanlar (ad,soyad,gorevi,telefon,adres,kullaniciadi,sifre) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);

                komut1.Parameters.AddWithValue("@p2", textbox_calisanad.Text);
                komut1.Parameters.AddWithValue("@p3", textbox_calisansoyad.Text);
                komut1.Parameters.AddWithValue("@p4", int.Parse(cb_gorev.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p5", textbox_calisantelefon.Text);
                komut1.Parameters.AddWithValue("@p6", int.Parse(lastadres_id));
                komut1.Parameters.AddWithValue("@p7", textbox_kullaniciadi.Text);
                komut1.Parameters.AddWithValue("@p8", textbox_sifre.Text);

                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Yeni Çalışan Başarılı Bir Şekilde Eklendi");
                sıfırla();
            }
            catch(NpgsqlException ex) {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());
            }
        }

        private void datagridcalışanlar_Click(object sender, EventArgs e)
        {
            try
            {
                ;
                text_calisanid.Text = datagridcalışanlar.CurrentRow.Cells[0].Value.ToString();
                textbox_calisanad.Text = datagridcalışanlar.CurrentRow.Cells[1].Value.ToString();
                textbox_calisansoyad.Text = datagridcalışanlar.CurrentRow.Cells[2].Value.ToString();
                cb_gorev.Text = datagridcalışanlar.CurrentRow.Cells[3].Value.ToString();
                textbox_calisantelefon.Text = datagridcalışanlar.CurrentRow.Cells[4].Value.ToString();
                cb_sehir.Text = datagridcalışanlar.CurrentRow.Cells[5].Value.ToString();
                cb_ilce.Text = datagridcalışanlar.CurrentRow.Cells[6].Value.ToString();
                richTextBox1.Text = datagridcalışanlar.CurrentRow.Cells[7].Value.ToString();
                textbox_kullaniciadi.Text = datagridcalışanlar.CurrentRow.Cells[8].Value.ToString();
                textbox_sifre.Text = datagridcalışanlar.CurrentRow.Cells[9].Value.ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());

            }


        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
            Font myfont = new Font("Arial", 10);
            richTextBox1.Font = myfont;
        }

        private void sıfırla()
        {
            calışanlartabloGetir();
            textbox_calisanad.Clear();
            textbox_calisansoyad.Clear();
            textbox_calisantelefon.Clear();
            textbox_kullaniciadi.Clear();
            textbox_sifre.Clear();
            cb_gorev.Text=string.Empty;
            cb_ilce.Text=string.Empty;
            cb_sehir.Text=string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm adminForm= new AdminForm();

            this.Hide();
            adminForm.Show();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {

                NpgsqlCommand komut3 = new NpgsqlCommand("SELECT adres from calisanlar where calisan_id="+text_calisanid.Text, baglanti);
                string calisanadres = komut3.ExecuteScalar().ToString();
                NpgsqlCommand komut2 = new NpgsqlCommand("UPDATE adres SET sehir=@t1, ilce=@t2, detay=@t3 where adres_id=@t6", baglanti);
                komut2.Parameters.AddWithValue("@t1", int.Parse(cb_sehir.SelectedValue.ToString()));
                komut2.Parameters.AddWithValue("@t2", int.Parse(cb_ilce.SelectedValue.ToString()));
                komut2.Parameters.AddWithValue("@t3", richTextBox1.Text);
                komut2.Parameters.AddWithValue("@t4", int.Parse(text_calisanid.Text));
                komut2.Parameters.AddWithValue("@t6", int.Parse(calisanadres));

                komut2.ExecuteNonQuery();
                



                NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE calisanlar SET ad=@p2,soyad=@p3,gorevi=@p4,telefon=@p5,kullaniciadi=@p7,sifre=@p8 WHERE calisan_id=@p1", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(text_calisanid.Text));
                komut1.Parameters.AddWithValue("@p2", textbox_calisanad.Text);
                komut1.Parameters.AddWithValue("@p3", textbox_calisansoyad.Text);
                komut1.Parameters.AddWithValue("@p4", int.Parse(cb_gorev.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p5", textbox_calisantelefon.Text);
                komut1.Parameters.AddWithValue("@p7", textbox_kullaniciadi.Text);
                komut1.Parameters.AddWithValue("@p8", textbox_sifre.Text);

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

        private void btn_sil_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                NpgsqlCommand komut1 = new NpgsqlCommand("DELETE FROM calisanlar WHERE calisan_id=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(text_calisanid.Text));
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("SİLME işlemi Başarılı Bir Şekilde Yapıldı");
                sıfırla();

            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show("Veri Tabanı Hatası" + ex.ToString());

            }


        }

        private void datagridcalışanlar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (datagridcalışanlar.CurrentCell.ColumnIndex == 8)//select target column
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
            var txtBox = e.Control as System.Windows.Forms.TextBox;
            txtBox.KeyDown -= new KeyEventHandler(textbox_sifre_KeyDown);
            txtBox.KeyDown += new KeyEventHandler(textbox_sifre_KeyDown);
        }

        private void datagridcalışanlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.Value != null)
            {
                datagridcalışanlar.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void textbox_sifre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calışanlartabloGetir();
            sehirGetir();
            gorevGetir();

        }
    }
}
