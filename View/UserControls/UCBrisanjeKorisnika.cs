using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using ControllerAL;
using View.Controller;

namespace View.UserControls
{
    public partial class UCBrisanjeKorisnika : UserControl
    {

        KontrolerKI ki;
        public UCBrisanjeKorisnika()
        {
            InitializeComponent();
        }


        public UCBrisanjeKorisnika(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnPretraziKorisnike_Click(object sender, EventArgs e)
        {
            ki.PronadjiKorisnike(txtImePrezime,dataGridView1,btnObrisiKorisnika);
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            
            ki.ObrisiKorisnika(txtImePrezime, dataGridView1);
            this.Dispose();
        }
    }
}
