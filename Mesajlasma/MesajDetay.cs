using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesajlasma
{
    public partial class MesajDetay : Form
    {
        public MesajDetay(string alici,string baslik,string mesaj,string gonderen)
        {
            InitializeComponent();
            lblAlici.Text = alici;
            lblGonderen.Text = gonderen;
            lblKonu.Text = baslik;
            rtxtMesaj.Text = mesaj;
        }
    }
}
