using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Diyet_Programi_Querry
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
