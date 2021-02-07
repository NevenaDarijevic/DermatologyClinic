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
    public partial class UCPretragaUsluge : UserControl
    {
        KontrolerKI ki;
        public UCPretragaUsluge()
        {
            InitializeComponent();
        }

        

        public UCPretragaUsluge(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnPronadjiUsluge_Click(object sender, EventArgs e)
        {
          
           
            ki.pronadjiUsluge(txtNaziv, dataGridView1,btnPrikaziUslugu);
        }

        private void btnPrikaziUslugu_Click(object sender, EventArgs e)
        {

         
            ki.PrikaziUslugu( txtNazivv, txtopis, txtcena, txtTip,dataGridView1,groupBox1);
        }
    }
}
