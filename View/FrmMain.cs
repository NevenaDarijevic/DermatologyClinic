using ControllerAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using View.UserControls;

namespace View
{
    public partial class FrmMain : Form
    {
        private readonly MainController mainController;
        public FrmMain()
        {
            ControllerAL.Controller controller = ControllerAL.Controller.Instance;
            InitializeComponent();
            lblWelcome.Text = $"Trenutno ulogovan zaposleni:  {ControllerAL.Controller.Instance.Zaposleni.ImePrezime}";
        }

        public FrmMain(MainController mainController)
        {
            this.mainController = mainController;
            ControllerAL.Controller controller = ControllerAL.Controller.Instance;
            InitializeComponent();
            lblWelcome.Text = $"Trenutno ulogovan zaposleni:  {MainCoordinator.Instance.Zaposleni.ImePrezime}";
        }

        private void unosNovogKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mainController.OpenUCNoviKorisnik(this);
        }

        public void SetPanel(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Parent = panel1;
            userControl.Dock = DockStyle.Fill;
        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCPretragaKorisnika(this);
        }

        private void brisanjeKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCBrisanjeKorisnika(this);
        }

        private void izmenaPostojećegKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCIzmenaKorisnika(this);
        }

        private void FrmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainCoordinator.Instance.OpenLoginForm();
        }

        private void unosNoveUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCNovaUsluga(this);
        }

        private void pretragaUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCPretragaUsluge(this);
        }

        private void brisanjeUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCBrisanjeUsluge(this);
        }

        private void zakazivanjeTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCZakazivanjeTermina(this);
        }

        private void pretraživanjeTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCPretrazivanjeTermina(this);
        }
    }
}
