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
    public partial class UCPretrazivanjeTermina : UserControl
    {
       
        KontrolerKI ki;
        public UCPretrazivanjeTermina()
        {
            InitializeComponent();
        }



        public UCPretrazivanjeTermina(KontrolerKI kontrolerKI)
        {
            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnPretraziTermine_Click(object sender, EventArgs e)
        {
           
            ki.pronadjiTermin(txtImePrezime, dataGridView1,btnPrikaziTermin,groupBox1);
        }

        private void btnPrikaziTermin_Click(object sender, EventArgs e)
        {
            ki.PrikaziTermin( txtdatumtermina, txtdatumzakazivanja, txtkorisnik, txtzaposleni,dataGridView1,groupBox1);
        }
    } 
}

