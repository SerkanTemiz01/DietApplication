using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Diyet_Programi_Querry
{
    public partial class EgzersizForm : Form
    {
        public EgzersizForm()
        { 
            InitializeComponent(); 
            db = new DietQueryDBContext(); 
            _egzersizlerRepository = new EgzersizlerRepository(db);
        }
        DietQueryDBContext db; EgzersizlerRepository _egzersizlerRepository;

        private void Egzersiz_Load(object sender, EventArgs e)
        {
            cmbEgzersiz.DataSource = Enum.GetValues(typeof(EgzersizEnum));
        }

        private void btnEgzersizEkle_Click_1(object sender, EventArgs e)
        {
            Egzersizler egzersizler = new Egzersizler(); 
            egzersizler.KullaniciId = GirisYap.gelenID; 
            egzersizler.Sure = (int)nmrSure.Value; 
            egzersizler.HarcananKaloriHesaplama();
            _egzersizlerRepository.Add(egzersizler);
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }
    }
}

