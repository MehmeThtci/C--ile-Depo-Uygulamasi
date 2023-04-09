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
    public partial class anasayfa : Form
    {
        public anasayfa(string calisanid) : this()
        {
           
            görünüm(calisanid);
            string calisanid1 = calisanid;

        }
            public anasayfa()
        {
            InitializeComponent();
            

        }
        public void görünüm(string calisanid)
        {
 
            textBox1.Text= calisanid;
            if (calisanid == "1")
            {
                label2.Text = "ADMİN";
            }

            else if (calisanid == "2")
            {
                label2.Text = "MÜDÜR";
            }
            else if (calisanid == "3")
            {
                
                label2.Text = "YAZILIMCI";
            }
            else if (calisanid == "4")
            {

                label2.Text = "İŞÇİ";
                btn_router_admin.Enabled = false;
                btn_router_siparis.Enabled = false;
            }
            else if (calisanid == "5")
            {
                label2.Text = "MÜŞTERİ";
                btn_router_admin.Enabled = false;
                label2.Enabled = false;
                btn_router_ürünler.Enabled = false;
                label22.Enabled = false;

            }
            else
            {
                MessageBox.Show("Bilinmeyen Kullanıcı");
            }
        }

        private void btn_router_dashboard_Click(object sender, EventArgs e)
        {
            ürünler ürünler= new ürünler();
            this.Hide();
            ürünler.Show();
        }

        private void btn_router_admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(textBox1.Text);
            adminForm.label2.Text = textBox1.Text;
            this.Hide();
            adminForm.Show();
        }

        private void btn_router_record_Click(object sender, EventArgs e)
        {
            siparis siparis = new siparis();
            this.Hide();
            siparis.Show();

        }
    }
}
