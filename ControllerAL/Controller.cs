using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using Storage.SQLServer;
using SistemskeOperacije;
using SistemskeOperacije.KorisnikSO;
using SistemskeOperacije.TerminSO;
using SistemskeOperacije.UslugaSO;
using SistemskeOperacije.ZaposleniSO;

namespace ControllerAL
{
    public class Controller
    {
       

        private InterfejsGenerickiRepozitorijum repozitorijum;
        public Zaposleni Zaposleni { get; set; }

        private static Controller instance;

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public List<Zaposleni> VratiListuZaposlenih()
        {

            VratiListuZaposlenihSO so = new VratiListuZaposlenihSO();
            so.ExecuteTemplate(new Zaposleni());
            return (List<Zaposleni>)so.Rezultat;
        }
        

        public List<Termin> PronadjiTermine(Termin t)
        {
            PronadjiTermineSO so = new PronadjiTermineSO();
            so.ExecuteTemplate(t);
            return (List<Termin>)so.Rezultat;
        }

        private Controller()
        {
            
            repozitorijum = new GenerickiRepozitorijum();
        }

        public List<Usluga> PronadjiUsluge(Usluga u)
        {
            PronadjiUslugeSO so = new PronadjiUslugeSO();
            so.ExecuteTemplate(u);
            return (List<Usluga>)so.Rezultat;
        }

        Broker broker = new Broker();

        public void SacuvajTermine(List<Termin> termini)
        {
            SacuvajTerminSO so = new SacuvajTerminSO();
           
            so.ExecuteTemplate(termini);
           
        }

        public Termin PrikaziTermin(Termin t)
        {
            PrikaziTermineSO so = new PrikaziTermineSO();
            so.ExecuteTemplate(t);
            return (Termin)so.Rezultat;
        }

        public Zaposleni PronadjiZaposlenog(Zaposleni zap)
        {
            
            PronadjiZaposlenogSO so = new PronadjiZaposlenogSO();
            so.ExecuteTemplate(zap);
            if (so.Rezultat != null)
            {
                return (Zaposleni)so.Rezultat;
            }
            else
            {
                return null;
            }
        }

        public void SacuvajUsluge(List<Usluga> usluge)
        {
            SacuvajUsluguSO so = new SacuvajUsluguSO();
             so.ExecuteTemplate(usluge);
          
        }

        public Usluga PrikaziUslugu(Usluga u)
        {
            PrikaziUsluguSO so = new PrikaziUsluguSO();
            so.ExecuteTemplate(u);
            return (Usluga)so.Rezultat;
        }

        public int ObrisiUslugu(Usluga u)
        {
            ObrisiUsluguSO so = new ObrisiUsluguSO();
            so.ExecuteTemplate(u);
            return (int)so.Rezultat;
        }

        
        public List<Korisnik> PronadjiKorisnike(Korisnik k)
        {
            PronadjiKorisnikaSO so = new PronadjiKorisnikaSO();
            so.ExecuteTemplate(k);
            return (List<Korisnik>)so.Rezultat;
        }

       
        public int ZapamtiKorisnika(Korisnik k)
        {
            
            ZapamtiKorisnikaSO operacija = new ZapamtiKorisnikaSO();
            operacija.ExecuteTemplate(k);
            return (int) operacija.Rezultat;
        }

        public Korisnik PrikaziKorisnika(Korisnik k)
        {
            PrikaziKorisnikaSO so = new PrikaziKorisnikaSO();
            so.ExecuteTemplate(k);
            return (Korisnik)so.Rezultat;
        }

        public int ObrisiKorisnika(Korisnik k)
        {
            ObrisiKorisnikaSO so = new ObrisiKorisnikaSO();
            so.ExecuteTemplate(k);
            return (int)so.Rezultat;
        }
        public List<Korisnik> VratiListuKorisnika()
        {
            SistemskeOperacije.TerminSO.VratiListuKorisnikaSO so = new SistemskeOperacije.TerminSO.VratiListuKorisnikaSO();
            so.ExecuteTemplate(new Korisnik());
            return (List<Korisnik>)so.Rezultat;

        }
        public int IzmeniKorisnika(Korisnik k)
        {
            IzmeniKorisnikaSO so = new IzmeniKorisnikaSO();
            so.ExecuteTemplate(k);
            return (int)so.Rezultat;
        }
        public List<TipUsluge> vratiListuTipova()
        {
            VratiListuTipovaSO so = new VratiListuTipovaSO();
            so.ExecuteTemplate(new TipUsluge());
            return (List<TipUsluge>)so.Rezultat;

        }
    }
}
