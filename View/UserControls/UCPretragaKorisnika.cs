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
    public partial class UCPretragaKorisnika : UserControl
    {
       
        KontrolerKI ki;
        public UCPretragaKorisnika()
        {
            InitializeComponent();
            
        }

      

        public UCPretragaKorisnika(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void btnPretraziKorisnike_Click(object sender, EventArgs e)
        {
            
         
            ki.PronadjiKorisnike(txtImePrezime, dataGridView1, btnPrikaziKorisnika);
           
        }
       
        private void btnPrikaziKorisnika_Click(object sender, EventArgs e)
        {
          
                
                ki.PrikaziKorisnika(panel1,dataGridView1,txtimeiprezime, txtadresa, txtbrojtelefona);
          
        }
    }
}
