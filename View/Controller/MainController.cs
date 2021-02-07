using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {

        internal void OpenUCBrisanjeKorisnika(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCBrisanjeKorisnika(new Controller.KontrolerKI()));
        }

        internal void OpenUCBrisanjeUsluge(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCBrisanjeUsluge(new Controller.KontrolerKI()));
        }

        internal void OpenUCIzmenaKorisnika(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCIzmenaKorisnika(new Controller.KontrolerKI()));
        }

        internal void OpenUCNovaUsluga(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCNovaUsluga(new Controller.KontrolerKI()));
        }

        internal void OpenUCNoviKorisnik(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCNoviKorisnik(new Controller.KontrolerKI()));
        }
        internal void OpenUCPretragaKorisnika(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCPretragaKorisnika(new Controller.KontrolerKI()));
        }

        internal void OpenUCPretragaUsluge(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCPretragaUsluge(new Controller.KontrolerKI()));
        }

        internal void OpenUCPretrazivanjeTermina(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCPretrazivanjeTermina(new Controller.KontrolerKI()));
        }
        internal void OpenUCZakazivanjeTermina(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCZakazivanjeTermina(new Controller.KontrolerKI()));
        }
    }
}
