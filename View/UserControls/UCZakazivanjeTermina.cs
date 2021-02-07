using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerAL;
using Domain;
using System.Globalization;
using View.Controller;

namespace View.UserControls
{
    public partial class UCZakazivanjeTermina : UserControl
    {
        KontrolerKI ki;
        public UCZakazivanjeTermina()
        {
            InitializeComponent();
        }


        public UCZakazivanjeTermina(KontrolerKI kontrolerKI)
        {
            ki = kontrolerKI;

            InitializeComponent();

        }

        private void UCZakazivanjeTermina_Load(object sender, EventArgs e)
        {
            ki.LoadZakazivanjeTermina(cbKorisnici,cbZaposleni,dgvTermini);
          
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            ki.DodajTerminUListu(cbZaposleni,cbKorisnici,txtDatumTermina,dgvTermini,btnSacuvaj,btnObrisi);
           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ki.ObrisiTerminIzListe(dgvTermini,btnSacuvaj);
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            ki.unesiNoviTermin();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
