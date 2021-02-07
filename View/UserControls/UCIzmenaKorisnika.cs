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
using View.Helpers;
using View.Controller;

namespace View.UserControls
{
    public partial class UCIzmenaKorisnika : UserControl
    {
        KontrolerKI ki;
        public UCIzmenaKorisnika()
        {
            InitializeComponent();
        }

       

        public UCIzmenaKorisnika(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void UCIzmenaKorisnika_Load(object sender, EventArgs e)
        {
            ki.LoadZaIzmenu(panel1,dataGridView1);
            
        }

        private void btnPretraziKorisnike_Click(object sender, EventArgs e)
        {
          
            ki.PronadjiKorisnike(txtImePrezime, dataGridView1,btnPrikaziInfo);
          

        }
       
        private void btnPrikaziInfo_Click(object sender, EventArgs e)
        {
            
            ki.PrikaziKorisnika(panel1,dataGridView1,txtimeiprezime, txtadresa, txtbrojtelefona);

        }
       
        private void btnizmeni_Click(object sender, EventArgs e)
        {
           

            ki.IzmeniKorisnika(txtimeiprezime, txtbrojtelefona, txtadresa, dataGridView1,txtImePrezime);
            

        }
     


       
    }
}

