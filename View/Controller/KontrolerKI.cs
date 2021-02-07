using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;
using View.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace View.Controller
{
    public class KontrolerKI
    {

        BindingList<Korisnik> lista = new BindingList<Korisnik>();

        BindingList<Korisnik> lista1 = new BindingList<Korisnik>();
        BindingList<Korisnik> lista2 = new BindingList<Korisnik>();
        BindingList<Usluga> usluge = new BindingList<Usluga>();
        BindingList<Usluga> lista3 = new BindingList<Usluga>();

        BindingList<Usluga> lista4 = new BindingList<Usluga>();
        BindingList<Termin> termini = new BindingList<Termin>();
        BindingList<Termin> termini1 = new BindingList<Termin>();
        internal void LoadZakazivanjeTermina(System.Windows.Forms.ComboBox cbKorisnici, System.Windows.Forms.ComboBox cbZaposleni, DataGridView dgvTermini)
        {
            cbKorisnici.DataSource = this.VratiListuKorisnika();
            cbZaposleni.DataSource = this.VratiListuZaposlenih();
            cbZaposleni.Text = "Izaberite zaposlenog";
            cbKorisnici.Text = "Izaberite korisnika";
            cbKorisnici.SelectedItem = null;
            cbZaposleni.SelectedItem = null;
            dgvTermini.DataSource = termini1;
        }

        internal void DodajTerminUListu(System.Windows.Forms.ComboBox cbZaposleni, System.Windows.Forms.ComboBox cbKorisnici, TextBox txtDatumTermina, DataGridView dgvTermini, System.Windows.Forms.Button btnSacuvaj, System.Windows.Forms.Button btnObrisi)
        {
            try
            {
                DateTime datum = Convert.ToDateTime(txtDatumTermina.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nesto nije dobro u datumu. Pogledajte zadatu formu");
                return;
            }

            if (cbKorisnici.SelectedItem == null || cbZaposleni.SelectedItem == null)
            {
                MessageBox.Show("Proverite da li ste izabrali korisnika i zaposlenog");
                return;
            }
         

            try { 
            Zaposleni z = (Zaposleni)cbZaposleni.SelectedItem;
            }catch(Exception)
            {
                MessageBox.Show("Morati izabrati zaposlenog");
                return;
            }

            try
            {
                Korisnik k = (Korisnik)cbKorisnici.SelectedItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Morati izabrati korisnika");
                return;
            }

           

            if (Convert.ToDateTime(DateTime.Now) > Convert.ToDateTime(txtDatumTermina.Text))
            {
                MessageBox.Show("Datum termina mora biti nakon datuma zakazivanja(danasnjeg datuma)");
                return;
            }
            Termin t = new Termin()
            {
                DatumZakazivanja1 = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                DatumTermina1 = Convert.ToDateTime(txtDatumTermina.Text),
                Korisnik = (Korisnik)cbKorisnici.SelectedItem,
                Zaposleni = (Zaposleni)cbZaposleni.SelectedItem
            };

            termini1.Add(t);
            dgvTermini.DataSource = termini1;
            btnSacuvaj.Enabled = true;
            btnObrisi.Enabled = true;
        }

        internal void ObrisiTerminIzListe(DataGridView dgvTermini, System.Windows.Forms.Button btnSacuvaj)
        {
            if (dgvTermini.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow red in dgvTermini.SelectedRows)
                {
                    termini1.Remove((Termin)red.DataBoundItem);
                }
            }
            if (termini1.Count == 0)
            {
                MessageBox.Show("Lista je prazna i nema elemenata za brisanje");
                btnSacuvaj.Enabled = false;
                return;
            }
            if (dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati pre brisanja");
                return;
            }
            
            if (termini1.Count == 0)
            {

                btnSacuvaj.Enabled = false;
                return;
            }
        }

        
        internal void unesiNovogKorisnika(TextBox txtImePrezime, TextBox txtBrojTelefona, TextBox txtAdresa)
        {
           
            
                if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime)
                    | !UserControlHelpers.EmptyFieldValidation(txtBrojTelefona)
                    | !UserControlHelpers.EmptyFieldValidation(txtAdresa))
                {
                    MessageBox.Show("Sva polja su obavezna!");
                    return;

                }
                if(txtImePrezime.Text.Contains(' ') == false)
                    {
                        MessageBox.Show("Morate uneti i ime i prezime");
                        return;
                    }
                if (txtBrojTelefona.Text.Length != 10)
                {
                    MessageBox.Show("Broj telefona mora sadrzati 10 cifara");
                    return;
                }
                if (txtBrojTelefona.Text[0] != '0')
                {
                    MessageBox.Show("Broj telefona mora pocinjati  sa 0");
                    return;
                }
                if (txtBrojTelefona.Text[1] != '6')
                {
                    MessageBox.Show("Broj telefona na drugom mestu mora imati 6!");
                    return;
                }
            foreach (char c in txtImePrezime.Text)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Ima i prezime korisnika sadrze cifru,a to nije dozvoljeno");
                        return;
                    }
                }
            foreach (char c in txtBrojTelefona.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Broj telefona sadrzi slovo,a to nije dozvoljeno");
                    return;
                }
            }
            Korisnik k = new Korisnik()
            {
                ImePrezime = txtImePrezime.Text.ToString(),
                BrojTelefona = txtBrojTelefona.Text.ToString(),
                Adresa = txtAdresa.Text.ToString()
            };
            try
            {

               
                int rez = Communication.Communication.Instance.ZapamtiKorisnika(k);
                if (rez==1)
                {
                    MessageBox.Show("Sistem je uspešno zapamtio podatke o korisniku!");
                    txtImePrezime.Focus();
                    txtAdresa.Text = "";
                    txtImePrezime.Text = "";
                    txtBrojTelefona.Text = "";
                    
                    }
                else
                {
                    MessageBox.Show("Sistem nije uspeo da zapamti korisnika");
                        txtImePrezime.Focus();
                        txtAdresa.Text = "";
                        txtImePrezime.Text = "";
                        txtBrojTelefona.Text = "";
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void obrisiUsluguIzListe(DataGridView dgvusluge, System.Windows.Forms.Button btnSacuvaj)
        {
            if (usluge.Count == 0)
            {
                MessageBox.Show("Lista je prazna i nema elemenata za brisanje");
                btnSacuvaj.Enabled = false;
                return;
            }
            if (dgvusluge.SelectedRows.Count ==0)
            {
                MessageBox.Show("Morate izabrati pre brisanja");
                return;
            }
                if (dgvusluge.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow red in dgvusluge.SelectedRows)
                {
                    usluge.Remove((Usluga)red.DataBoundItem);
                }
            }
            if (usluge.Count == 0)
            { 
               
                btnSacuvaj.Enabled = false;
                return;
            }
        }

        internal void dodajUsluguUListu(DataGridView dgvusluge, TextBox txtNaziv, TextBox txtCena, TextBox txtOpis, System.Windows.Forms.ComboBox cbTipUsluge, System.Windows.Forms.Button btnSacuvaj, System.Windows.Forms.Button btnObrisi)
        {
           
           
            if (!UserControlHelpers.EmptyFieldValidation(txtNaziv)
               | !UserControlHelpers.EmptyFieldValidation(txtOpis)
               | !UserControlHelpers.EmptyFieldValidation(txtCena))
            {
                return;
            }

            Usluga u = new Usluga()
            {
                NazivUsluge1 = txtNaziv.Text.ToString(),
                OpisUsluge1 = txtOpis.Text.ToString()

            };

            try
            {
                u.CenaUsluge1 = Convert.ToInt32(txtCena.Text.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Nesto nije okej sa cenom, mora biti ceo broj");
                return;
            }
            if (Convert.ToInt32(txtCena.Text.ToString()) <= 0){
                MessageBox.Show("Cena mora biti veca od 0");
                return;
            }
           // TipUsluge tip = (TipUsluge)cbTipUsluge.SelectedItem;
            if ((TipUsluge)cbTipUsluge.SelectedItem==null)
            {
                MessageBox.Show("Niste selektovali tip usluge");
                return;
            }
            TipUsluge tip = (TipUsluge)cbTipUsluge.SelectedItem;
            u.Tip = tip;
            foreach(Usluga us in usluge)
            {
                if (us.NazivUsluge1 == u.NazivUsluge1)
                {
                    MessageBox.Show("Ne mogu postojati usluge sa istim nazivom");
                    return;
                }
            }
            if (usluge.ToList().Contains(u)==false)
            {
                usluge.Add(u);
                dgvusluge.DataSource = usluge;
                btnSacuvaj.Enabled = true;
                btnObrisi.Enabled = true;
            }
           
        
        
        }

        internal void LoadZaUsluge(DataGridView dgvusluge, System.Windows.Forms.ComboBox cbTipUsluge)
        {
            cbTipUsluge.DataSource =Communication.Communication.Instance.vratiListuTipova();
            cbTipUsluge.Text = "Izaberite tip";
            dgvusluge.DataSource = usluge;
            cbTipUsluge.SelectedItem = null;
        }

        internal void LoadZaIzmenu(Panel panel1, DataGridView dataGridView1)
        {
          
            try
            {
                panel1.Hide();
                List<Korisnik> listaKor = this.VratiListuKorisnika();
                if (listaKor == null)
                {
                    MessageBox.Show("Doslo je do greske kod servera");
                    return;
                }
                try
                {
                    foreach (Korisnik k in listaKor)
                    {
                        lista1.Add(k);
                    }

                    dataGridView1.DataSource = lista1;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal List<Zaposleni> VratiListuZaposlenih()
        {
            try
            {

                List<Zaposleni> lista= Communication.Communication.Instance.VratiSveZaposlene();
                return lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal List<Korisnik> VratiListuKorisnika()
        {
            try
            {

                return Communication.Communication.Instance.VratiSveKorisnike();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

           
        }

        internal void pronadjiUsluge(TextBox txtNaziv, DataGridView dataGridView1, System.Windows.Forms.Button btnObrisiUslugu)
        {
            dataGridView1.DataSource = null;
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Morate uneti naziv usluge radi pretrage!");
                return;
            }
            try
            {
                Usluga u = new Usluga { NazivUsluge1=txtNaziv.Text , USLOV=txtNaziv.Text};

                List<Usluga> rez = Communication.Communication.Instance.PronadjiUsluge(u);

                if (rez.Count==0)
                {
                    MessageBox.Show("Sistem nije uspeo da pronadje usluge na osnovu zadatog kriterijuma");
                    btnObrisiUslugu.Enabled = false;
                    return;
                }
                btnObrisiUslugu.Enabled = true;
                List<Usluga> lista = new List<Usluga>();
                foreach (Usluga usluga in rez)
                {
                    lista.Add(usluga);
                }
                dataGridView1.DataSource = lista;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void pronadjiTermin(TextBox txtImePrezime, DataGridView dataGridView1, System.Windows.Forms.Button btnPrikaziTermin, GroupBox groupBox1)
        {
            dataGridView1.DataSource = null;
            groupBox1.Visible = false;

            if (txtImePrezime.Text == "")
            {
                MessageBox.Show("Morate uneti ime i prezime korisnika koji je zakazao termin radi pretrage!");
                return;
            }

            try
            {
                string krit = txtImePrezime.Text;
                Termin t = new Termin
                {
                    USLOV = txtImePrezime.Text
                };
                List<Termin> rez = Communication.Communication.Instance.PronadjiTermine(t);

                if (rez.Count==0)
                {
                    MessageBox.Show("Sistem nije uspeo da pronadje termine na osnovu zadatog kriterijuma");
                    
                    return;
                }
                foreach (Termin termin in rez)
                {
                    termini.Add(termin);
                }
                dataGridView1.DataSource = termini;
                btnPrikaziTermin.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void unesiNoviTermin()
        {
            try
            {
                bool rez = Communication.Communication.Instance.SacuvajTermine(termini1.ToList());
                if (rez == false)
                {
                    MessageBox.Show("Sistem ne moze da zapamti termine");
                }
                else
                {
                    MessageBox.Show("Sistem je zapamtio termine");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zapamti termine. Doslo je do greske! Moguce da je server iskljucen.");
            }
        }

        internal void PronadjiKorisnike(TextBox txtImePrezime,DataGridView dataGridView, System.Windows.Forms.Button button)
        {
         //   dataGridView.DataSource = null;

            if (txtImePrezime.Text == "")
            {
                MessageBox.Show("Morate uneti ime i prezime korisnika radi pretrage!");
                return;
            }

            try
            {
                Korisnik k = new Korisnik { USLOV = txtImePrezime.Text };
               

                List<Korisnik> rez = Communication.Communication.Instance.PronadjiKorisnike(k);

                if (rez.Count==0)
                {
                    MessageBox.Show("Sistem nije uspeo da pronadje korisnike");
                    if (button.Text == "Obrisi korisnika")
                    {


                        dataGridView.DataSource = null;
                    }
                    button.Enabled = false;

                    return;
                }
                List<Korisnik> lista = new List<Korisnik>();
                foreach (Korisnik kor in rez)
                {
                    lista.Add(kor);
                }
                dataGridView.DataSource = lista;
                button.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void PrikaziTermin( TextBox txtdatumtermina, TextBox txtdatumzakazivanja, TextBox txtkorisnik, TextBox txtzaposleni, DataGridView dataGridView1, GroupBox groupBox1)
        {
            Termin t = new Termin();
            groupBox1.Visible = true;
            try
            {
                t = (Termin)dataGridView1.CurrentRow.DataBoundItem;



            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali termin ");
            }
            try
            {
                groupBox1.Visible = true;
                t = Communication.Communication.Instance.PrikaziTermin(t);
                txtdatumzakazivanja.Text = t.DatumZakazivanja1.ToShortDateString();
                txtdatumtermina.Text = t.DatumTermina1.ToShortDateString();
                txtkorisnik.Text = t.Korisnik.ImePrezime;
                txtzaposleni.Text = t.Zaposleni.ImePrezime;
                MessageBox.Show("Sistem je prikazao podatke o izabranom terminu");
            }
            catch (Exception)
            {

                MessageBox.Show("Ne postoje podaci o izabranom terminu");
            }
        }

        internal void PrikaziUslugu(TextBox txtNazivv, TextBox txtopis, TextBox txtcena, TextBox txtTip, DataGridView dataGridView1, GroupBox groupBox1)
        {
            Usluga u = new Usluga();
            // groupBox1.Visible = true;
            if (dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Niste odabrali element iz liste ili je moguce da je lista prazna");
                return;
            }
            try
            {
                u = (Usluga)dataGridView1.CurrentRow.DataBoundItem;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali element liste za prikaz");
            }
            try
            {
                u = Communication.Communication.Instance.PrikaziUslugu(u);
                groupBox1.Visible = true;
                txtNazivv.Text = u.NazivUsluge1;
                txtopis.Text = u.OpisUsluge1;
                txtcena.Text = u.CenaUsluge1.ToString();
                txtTip.Text = u.Tip.ToString();
                MessageBox.Show("Sistem je pronasao podatke o  usluzi");
            }
            catch (Exception)
            {
                groupBox1.Visible = false;
                MessageBox.Show("Sistem nije pronasao podatke o izabranoj usluzi");
                txtNazivv.Text = "";
                txtopis.Text = "";
                txtcena.Text = "";
                txtTip.Text = "";
            }
        }

        internal void PrikaziKorisnika(Panel panel1, DataGridView dataGridView1, TextBox txtimeiprezime, TextBox txtadresa, TextBox txtbrojtelefona)
        {
            panel1.Show();
            Korisnik k = new Korisnik();

            try
            {
                k = (Korisnik)dataGridView1.CurrentRow.DataBoundItem;


            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali element liste za prikaz i izmenu.");
            }
            try
            {
                k = Communication.Communication.Instance.PrikaziKorisnika(k);
                txtimeiprezime.Text = k.ImePrezime;
                txtbrojtelefona.Text = k.BrojTelefona;
                txtadresa.Text = k.Adresa;
                MessageBox.Show("Sistem je pronasao podatke o  korisniku");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem nije pronasao podatke o izabranom korisniku");
            }
        }

        internal void ObrisiUslugu(TextBox txtNaziv, DataGridView dataGridView1)
        {
            Usluga u = new Usluga();
            try
            {
                u = (Usluga)dataGridView1.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali element liste za brisanje");
            }
            try
            {
                int rez = Communication.Communication.Instance.ObrisiUslugu(u);
                if (rez == 1)
                {
                    MessageBox.Show("Usluga je uspesno obrisana");
                    lista3.Clear();
                    txtNaziv.Text = "";
                    dataGridView1.DataSource = lista3;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije uspeo da obrise uslugu!");
            }
        }

        internal void IzmeniKorisnika( TextBox txtimeiprezime, TextBox txtbrojtelefona, TextBox txtadresa,  DataGridView dataGridView1, TextBox txtImePrezime)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtimeiprezime)
               | !UserControlHelpers.EmptyFieldValidation(txtbrojtelefona)
               | !UserControlHelpers.EmptyFieldValidation(txtadresa))
            {
                return;
            }
            if (dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Niste izabrali korisnika za izmenu");
                return;
            }
            Korisnik k = (Korisnik)dataGridView1.CurrentRow.DataBoundItem;
            Korisnik novi = new Korisnik();
           
        
                if(txtimeiprezime.Text.Contains(' ') == false)
                    {
                        MessageBox.Show("Morate uneti i ime i prezime");
                        return;
                    }
                if (txtbrojtelefona.Text.Length != 10)
                {
                    MessageBox.Show("Broj telefona mora sadrzati 10 cifara");
                    return;
                }
                if (txtbrojtelefona.Text[0] != '0')
                {
                    MessageBox.Show("Broj telefona mora pocinjati  sa 0");
                    return;
                }
                if (txtbrojtelefona.Text[1] != '6')
                {
                    MessageBox.Show("Broj telefona na drugom mestu mora imati 6!");
                    return;
                }
                foreach (char c in txtimeiprezime.Text)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Ima i prezime korisnika sadrze cifru,a to nije dozvoljeno");
                        return;
                    }
                }
                foreach (char c in txtbrojtelefona.Text)
                {
                    if (char.IsLetter(c))
                    {
                        MessageBox.Show("Broj telefona sadrzi slovo,a to nije dozvoljeno");
                        return;
                    }
                }
            novi.IDKorisnika = k.IDKorisnika;
            novi.ImePrezime = txtimeiprezime.Text;
            novi.BrojTelefona = txtbrojtelefona.Text;
            novi.Adresa = txtadresa.Text;
            novi.USLOVINT = k.IDKorisnika;

            try
            {
                int rez =Communication.Communication.Instance.IzmeniKorisnika(novi);
                if (rez == 1)
                {
                    MessageBox.Show("Sistem je uspesno izmenio podatke o korisniku");
                   
                    txtimeiprezime.Text = "";
                    txtbrojtelefona.Text = "";
                    txtadresa.Text = "";
                    lista.Clear();
                    dataGridView1.DataSource = lista;
                    txtImePrezime.Text = "";
                    
                }
                else
                {

                    MessageBox.Show("Sistem ne moze da izmeni korisnika");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da izmeni korisnika");
            }
        }

        internal void unesiNovuUslugu(TextBox txtNaziv,TextBox txtOpis,TextBox txtCena)
        {
           
            try
            {
                bool rez=Communication.Communication.Instance.SacuvajUsluge(usluge.ToList());
                if (rez==false)
                {
                    MessageBox.Show("Test");
                    MessageBox.Show("Sistem nije uspeo da zapamti usluge");
                }
                else
                {

                    MessageBox.Show("Sistem je uspešno zapamtio podatke o uslugama!");

                    txtNaziv.Focus();
                    txtNaziv.Text = "";
                    txtOpis.Text = "";
                    txtCena.Text = "";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Sistem nije uspeo da zapamti uslugu");
            }
        }

        internal void ObrisiKorisnika(TextBox txtImePrezime, DataGridView dataGridView1)
        {
            Korisnik k = new Korisnik();
            try
            {
                k = (Korisnik)dataGridView1.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali element liste za brisanje");
            }
            try
            {
               
                int rez = Communication.Communication.Instance.ObrisiKorisnika(k);
                if (rez == 1)
                {
                    MessageBox.Show("Korisnik je uspesno obrisan");
                    txtImePrezime.Text = "";
                    lista.Clear();
                    dataGridView1.DataSource = lista;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije uspeo da obrise korisnika!");
            }
        }
    }
}
