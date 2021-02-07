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
using View.Helpers;
using Domain;
using View.Controller;

namespace View.UserControls
{
    public partial class UCNovaUsluga : UserControl
    {
       
        KontrolerKI ki;
        public UCNovaUsluga()
        {
            InitializeComponent();
        }

      

        public UCNovaUsluga(KontrolerKI kontrolerKI)
        {

            InitializeComponent();
            ki = kontrolerKI;
        }

        private void UCNovaUsluga_Load(object sender, EventArgs e)
        {
            ki.LoadZaUsluge(dgvusluge, cbTipUsluge);
            
            
        }

        

        private void btndodaj_Click(object sender, EventArgs e)
        {

            ki.dodajUsluguUListu(dgvusluge, txtNaziv, txtCena, txtOpis, cbTipUsluge, btnSacuvaj,btnObrisi);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
           
            ki.obrisiUsluguIzListe(dgvusluge,btnSacuvaj);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            ki.unesiNovuUslugu(txtNaziv, txtOpis, txtCena);
            this.Dispose();
        }
    }
    }

