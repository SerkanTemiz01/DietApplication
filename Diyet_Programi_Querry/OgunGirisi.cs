using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet_Programi_Querry
{
    public partial class OgunGirisi : Form
    {
        public OgunGirisi()
        {
            InitializeComponent();
        }

        private void OgunGirisi_Load(object sender, EventArgs e)
        {
            dgwliste.BackgroundColor = Color.Snow;
            dgwYenilen.BackgroundColor = Color.Snow;
        }
    }
}
