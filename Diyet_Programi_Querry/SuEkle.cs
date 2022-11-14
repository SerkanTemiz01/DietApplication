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
    public partial class SuEkle : Form
    {
        public SuEkle()
        {
            InitializeComponent();
        }
        PictureBox pictureBox;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nmrSu.Value; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 73);
                pictureBox.Image = Image.FromFile("C:\\Users\\serka\\OneDrive\\Masaüstü\\Diyet_Programi_Querry-master\\Diyet_Programi_Querry\\Resources\\Bardak.png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
            
        }

        private void btnÇıkart_Click(object sender, EventArgs e)
        {
            decimal count = nmrSu.Value;
            if(nmrSu.Value <= flowLayoutPanel1.Controls.Count)
            {
                foreach (var pictureBox in flowLayoutPanel1.Controls)
                {
                    count-- ;
                    flowLayoutPanel1.Controls.Remove((PictureBox)pictureBox);
                    if (count == 0)
                    {
                        break;
                    }

                }
            }
            

           
        }
    }
}
