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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;


        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbMesajlasma;Integrated Security=True");

        void GelenKutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select m2.Ad,m1.Baslik,m1.Icerik from tblMesajlar m1 join tblKisiler m2 on m1.Gonderen=m2.Numara   where Alici =" + numara,con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvGelen.DataSource = dt1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            GelenKutusu();
            GidenKutusu();

            con.Open();
            SqlCommand cmd = new SqlCommand("select Ad,Soyad from tblKisiler where Numara="+numara,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString() +" "+ dr[1].ToString();
            }
            con.Close();
        }

        private void GidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select m2.Ad,m1.Baslik,m1.Icerik from tblMesajlar m1 join tblKisiler m2 on m1.Alici=m2.Numara   where Gonderen=" + numara, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvGiden.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblMesajlar (Gonderen,Alici,Baslik,Icerik)  values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1", numara);
            cmd.Parameters.AddWithValue("@p2", mtxtAlici.Text);
            cmd.Parameters.AddWithValue("@p3", txtBaslik.Text);
            cmd.Parameters.AddWithValue("@p4", rtxtMesaj.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            mtxtAlici.Clear();
            txtBaslik.Clear();
            rtxtMesaj.Clear();
            MessageBox.Show("Mesajınız iletildi");
            GidenKutusu();
        }

        private void dgvGiden_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGiden.SelectedRows.Count >0)
            {
            int secilen = dgvGelen.SelectedRows[0].Index;
            string gonderen=dgvGelen.SelectedRows[0].Cells[0].Value.ToString();
            string baslik=dgvGelen.SelectedRows[0].Cells[1].Value.ToString();
            string mesaj=dgvGelen.SelectedRows[0].Cells[2].Value.ToString();
            string alici = lblAdSoyad.Text;
            MesajDetay frm = new MesajDetay(alici,baslik,mesaj,gonderen);
            frm.Show();
            }
        }

        private void dgvGiden_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvGelen.SelectedRows.Count >0)
            {
            int secilen = dgvGiden.SelectedRows[0].Index;
            string alici = dgvGiden.SelectedRows[0].Cells[0].Value.ToString();
            string baslik = dgvGiden.SelectedRows[0].Cells[1].Value.ToString();
            string mesaj = dgvGiden.SelectedRows[0].Cells[2].Value.ToString();
            string gonderen = lblAdSoyad.Text;
            MesajDetay frm = new MesajDetay(alici, baslik, mesaj, gonderen);
            frm.Show();
            }
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir frm = new SifreDegistir(lblNumara.Text);
            frm.Show();
        }
    }
}
