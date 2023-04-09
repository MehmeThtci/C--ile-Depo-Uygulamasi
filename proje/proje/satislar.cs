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
    public partial class satislar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; database=proje; user ID=postgres; password=Memoolii26");

        DataSet datasetsatislar = new DataSet();
        public satislar()
        {
            InitializeComponent();
            tablogetir();
        }
        public void tablogetir()
        {
            datasetsatislar = new DataSet();



            Database.dbAdapter("SELECT * FROM satislar_view ORDER BY satisno").Fill(datasetsatislar);
            datagridsatislar.DataSource = datasetsatislar.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm adminForm= new AdminForm();
            this.Close();
            adminForm.Show();

        }
    }
}
