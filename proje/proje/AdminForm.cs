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
    public partial class AdminForm : Form
    {
        public AdminForm(string calisanid) : this()
        {
            görünüm(calisanid);
            string calisanid1 = calisanid;

        }
        public AdminForm()
        {
            InitializeComponent();
            
        }
        public void görünüm(string calisanid)
        {
            label2.Text=calisanid;

            if (calisanid == "1")
            {
                

            }
            else if (calisanid == "2")
            {
                
            }
             else if (calisanid == "3")
            {
                
            }
            else
            {
            }
        }

        private void btn_ürün_eklesil_Click(object sender, EventArgs e)
        {
            ürünekleForm ürünekleForm = new ürünekleForm();
            this.Hide();
            ürünekleForm.Show();
        }


        private void btn_geri_Click_1(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();

        }

        private void btn_calışan_güncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_calışan_ekle_Click(object sender, EventArgs e)
        {
            calışanform calışanform = new calışanform(label2.Text);
            this.Hide();
            calışanform.Show();

        }

        private void btn_marka_detay_Click(object sender, EventArgs e)
        {
            markaekle markaekle= new markaekle();
            
            markaekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa= new anasayfa();
            this.Hide(); 
            anasayfa.Show();
        }

        private void btn_sipariş_oluştur_Click(object sender, EventArgs e)
        {
            satislar satislar= new satislar();
            this.Hide(); satislar.Show();
        }

 
    }
}
