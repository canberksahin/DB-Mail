using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesajlasma
{
    public partial class SifreDegistir : Form
    {
        string numara;
        public SifreDegistir(string numara)
        {
            InitializeComponent();
            this.numara = numara;
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbMesajlasma;Integrated Security=True");

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            con.Open();
            string eskisifre = "";
            SqlCommand cmd = new SqlCommand("select Sifre from tblKisiler where Numara=" + numara, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                eskisifre = dr[0].ToString();
            }
            con.Close();
            if (eskisifre != txtEskiSifre.Text)
            {
                MessageBox.Show("Eski şifre doğru değil.Lütfen tekrar deneyiniz.");
            }
            else if (txtYeniSifre.Text == txtTekrar.Text)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update tblKisiler set Sifre=@p1 where Numara=" + numara, con);
                cmd1.Parameters.AddWithValue("@p1", txtTekrar.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Şifre başarılı bir şekilde güncellenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
                con.Close();
            }
        }
    }
}
