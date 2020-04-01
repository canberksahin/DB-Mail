using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mesajlasma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbMesajlasma;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblKisiler where Numara=@p1 and Sifre=@p2",con);
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.numara = maskedTextBox1.Text;
                frm.Show();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi!","Hata",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void kullanıcıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciOlustur frm = new KullaniciOlustur();
            frm.Show();
        }

        private void kullaniciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici_Listesi frm = new Kullanici_Listesi();
            frm.Show();
        }
    }
}
