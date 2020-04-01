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
    public partial class Kullanici_Listesi : Form
    {
        public Kullanici_Listesi()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbMesajlasma;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Ad,Soyad,Numara from tblKisiler",con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKisiListesi.DataSource = dt;
        }
    }
}
