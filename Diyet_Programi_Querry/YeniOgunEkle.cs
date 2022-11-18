using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Enums;
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
    public partial class YeniOgunEkle : Form
    {
        DietQueryDBContext db;
        BesinlerRepository _besinlerRepository;
        public YeniOgunEkle()
        {
            InitializeComponent();
        }
        private void YeniOgunEkle_Load_1(object sender, EventArgs e)
        {
            cmbOgunAdi.DataSource = Enum.GetValues(typeof(Ogun));
            db = new DietQueryDBContext();
            _besinlerRepository = new BesinlerRepository(db);
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Besinler besinler = new Besinler();
            besinler.BesinAdi = txtBesinAdi.Text;
            besinler.Kalori = Convert.ToInt32(txtKalori.Text);
            besinler.Karbonhidrat = nmrKarbonhidrat.Value;
            besinler.Protein = nmrProtein.Value;
            besinler.Yag = nmrYag.Value;
            _besinlerRepository.Add(besinler);
            nmrKarbonhidrat.Maximum = 1000;
            nmrProtein.Maximum = 1000;
            nmrYag.Maximum = 1000;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgunGirisi ogunGirisi = new OgunGirisi();
            ogunGirisi.Show();
            this.Close();
        }
        private void txtKalori_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ayrac = ',';// buraya istediğiniz bir ayracı yazabilirsiniz.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ayrac))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ayrac) && ((sender as TextBox).Text.IndexOf(ayrac) > -1))//İlk karakterin '.' olup olmadığını kontrol ediyoruzuz
            {
                e.Handled = true;//Değilse görmezden geliyoruz.
            }
        }
    }
}