using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
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
            db = new DietQueryDBContext();
            _suTakibiRepository = new SuTakibiRepository(db);
        }
        PictureBox pictureBox;
        private DietQueryDBContext db;
        private SuTakibiRepository _suTakibiRepository;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SuTakibi suTakibi = new SuTakibi();
            suTakibi.BardakAdeti = 1;
            suTakibi.SuMiktariBulma();
            suTakibi.KullaniciID = GirisYap.gelenID;
            _suTakibiRepository.Add(suTakibi);
            FlowloyoutGuncel();
        }

        private void btnÇıkart_Click(object sender, EventArgs e)
        {
            var sonGelenSu = _suTakibiRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).LastOrDefault();
            _suTakibiRepository.Delete(sonGelenSu);
            FlowloyoutGuncel();

            lnlTplamSu.Text = (flowLayoutPanel1.Controls.Count * 200).ToString() + " ml";
            if (flowLayoutPanel1.Controls.Count < 16)
            {
                btnEkle.Enabled = true;
            }
        }

        private void FlowloyoutGuncel()
        {

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < _suTakibiRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Count(); i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 73);
                pictureBox.Image = Image.FromFile("C:\\Users\\serka\\Source\\Repos\\SerkanTe\\Diyet_Programi_Ortak\\Diyet_Programi_Querry\\Resources\\Bardak.png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
            lnlTplamSu.Text = (flowLayoutPanel1.Controls.Count * 200).ToString() + " ml";
            if (flowLayoutPanel1.Controls.Count == 16)
            {
                btnEkle.Enabled = false;
            }

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }

        private void SuEkle_Load(object sender, EventArgs e)
        {
            FlowloyoutGuncel();
        }
    }
}
