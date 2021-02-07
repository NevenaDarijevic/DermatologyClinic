using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace View.Communication
{
    public class Communication
    {

        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {
            
        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            client = new CommunicationClient(socket);

        }

        internal Zaposleni Login(Zaposleni z)
        {
            Request request = new Request()
            {
                Operacija = Operation.PronadjiZaposlenog,
                Objekat = z
            };
            client.SendRequest(request);
            return (Zaposleni)client.GetResponseResult();
        }

        internal int ZapamtiKorisnika(Korisnik k)
        {
            Request request = new Request() { Operacija = Operation.ZapamtiKorisnika, Objekat = k };
            client.SendRequest(request);
            return (int)client.GetResponseResult();
        }

        

        internal List<Korisnik> PronadjiKorisnike(Korisnik k)
        {
            Request request = new Request() { Operacija = Operation.PronadjiKorisnike, Objekat = k };
            client.SendRequest(request);
            return (List<Korisnik>)client.GetResponseResult();
        }

        internal List<Zaposleni> VratiSveZaposlene()
        {
            Request request = new Request() { Operacija = Operation.VratiListuZaposlenih };
            client.SendRequest(request);
            return (List<Zaposleni>)client.GetResponseResult();
        }

        internal object vratiListuTipova()
        {
            Request request = new Request() { Operacija = Operation.VratiListuTipova };
            client.SendRequest(request);
            return (List<TipUsluge>)client.GetResponseResult();
        }

        internal  bool SacuvajUsluge(List<Usluga> usluge)
        {

            Request request = new Request() { Operacija = Operation.SacuvajUslugu, Objekat = usluge};
            client.SendRequest(request);
            return (bool)client.GetResponseResult();
        }

        internal List<Usluga> PronadjiUsluge(Usluga u)
        {
            Request request = new Request() { Operacija = Operation.PronadjiUsluge, Objekat = u };
            client.SendRequest(request);
            return (List<Usluga>)client.GetResponseResult();
        }

        internal int ObrisiKorisnika(Korisnik k)
        {
            Request request = new Request() { Operacija = Operation.ObrisiKorisnika, Objekat = k };
            client.SendRequest(request);
            return (int)client.GetResponseResult();
        }

        internal int ObrisiUslugu(Usluga u)
        {

            Request request = new Request() { Operacija = Operation.ObrisiUslugu, Objekat = u };
            client.SendRequest(request);
            return (int)client.GetResponseResult();
        }

        internal List<Korisnik> VratiSveKorisnike()
        {
            Request request = new Request() { Operacija = Operation.VratiListuKorisnika };
            client.SendRequest(request);
            return (List<Korisnik>)client.GetResponseResult();
        }

        internal List<Termin> PronadjiTermine(Termin t)
        {
            Request request = new Request() { Operacija = Operation.PronadjiTermine, Objekat = t };
            client.SendRequest(request);
            return (List<Termin>)client.GetResponseResult();
        }

        internal Korisnik PrikaziKorisnika(Korisnik k)
        {
            Request request = new Request() { Operacija = Operation.PrikaziKorisnika, Objekat = k };
            client.SendRequest(request);
            return (Korisnik)client.GetResponseResult();
        }

        internal int IzmeniKorisnika(Korisnik novi)
        {
           
            Request request = new Request() { Operacija = Operation.IzmeniKorisnika, Objekat = novi};
            client.SendRequest(request);
            return (int)client.GetResponseResult();
        }

        internal bool SacuvajTermine(List<Termin> termini)
        {
            Request request = new Request() { Operacija = Operation.SacuvajTermin, Objekat = termini };
            client.SendRequest(request);
            return (bool)client.GetResponseResult();
        }

        internal Usluga PrikaziUslugu(Usluga u)
        {
            Request request = new Request() { Operacija = Operation.PrikaziUslugu, Objekat = u};
            client.SendRequest(request);
            return (Usluga)client.GetResponseResult();
        }

        internal Termin PrikaziTermin(Termin t)
        {

            Request request = new Request() { Operacija = Operation.PrikaziTermin, Objekat = t };
            client.SendRequest(request);
            return (Termin)client.GetResponseResult();
        }
    }
 }
