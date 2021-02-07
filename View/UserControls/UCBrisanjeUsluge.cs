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
    public partial class UCBrisanjeUsluge : UserControl
    {
     
        KontrolerKI ki;
        public UCBrisanjeUsluge()
        {
            InitializeComponent();
        }

      

        public UCBrisanjeUsluge(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnPretraziUsluge_Click(object sender, EventArgs e)
        {
           
           
            ki.pronadjiUsluge(txtNaziv, dataGridView1,btnObrisiUslugu);
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
           
            
            ki.ObrisiUslugu(txtNaziv, dataGridView1);
            this.Dispose();
        }
    }
}
