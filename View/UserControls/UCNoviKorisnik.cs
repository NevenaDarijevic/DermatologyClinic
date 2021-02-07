using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;
using Domain;
using ControllerAL;
using View.Controller;

namespace View.UserControls
{
    public partial class UCNoviKorisnik : UserControl
    {
        KontrolerKI ki;
        public UCNoviKorisnik()
        {
            InitializeComponent();
        }

       

        public UCNoviKorisnik(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnUnosNovogKorisnika_Click(object sender, EventArgs e)
        {
            ki.unesiNovogKorisnika(txtImePrezime, txtBrojTelefona, txtAdresa);
            
        }
    }
}
