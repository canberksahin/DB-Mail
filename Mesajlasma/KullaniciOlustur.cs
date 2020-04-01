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
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbMesajlasma;Integrated Security=True");
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            con.Open();
            bool kullanılıyorMu = false;
            SqlCommand cmd1 = new SqlCommand("select Numara from tblKisiler", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (mtxtNumara.Text == dr[0].ToString())
                {
                    MessageBox.Show("Bu Numara Kullanılıyor,lütfen yeni bir Numara seçin.");
                    mtxtNumara.Clear();
                    kullanılıyorMu = true;
                    break;
                }
            }
            con.Close();
            if (txtSifre.Text.Length > 7)
            {
                MessageBox.Show("Şifre en fazla 7 haneli olabilir.");
            }
            else if (!kullanılıyorMu)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblKisiler (Ad,Soyad,Numara,Sifre) values(@p1,@p2,@p3,@p4)", con);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", mtxtNumara.Text);
                cmd.Parameters.AddWithValue("@p4", txtSifre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAd.Clear();
                txtSifre.Clear();
                txtSoyad.Clear();
                mtxtNumara.Clear();
                con.Close();
            }



        }
    }
}
