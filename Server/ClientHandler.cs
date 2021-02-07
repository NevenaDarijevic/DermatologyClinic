using Common;
using ControllerAL;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private readonly Server server;
        public ClientHandler(Socket client, Server server)
        {
            this.client = client;
            this.server = server;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.Uspesno = false;
                        response.Greska = ex.Message;
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                server.Zaposleni.Remove(zaposleni);
            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                server.Zaposleni.Remove(zaposleni);
            }
        }
        private Zaposleni zaposleni;
        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.Uspesno = true;
            switch (request.Operacija)
            {
                case Operation.PronadjiZaposlenog:
                    zaposleni = Controller.Instance.PronadjiZaposlenog((Zaposleni)request.Objekat);
                    response.Rezultat = zaposleni;
                    if(zaposleni!=null)
                    server.Zaposleni.Add(zaposleni);
                    break;
                case Operation.ZapamtiKorisnika:
                    response.Rezultat = Controller.Instance.ZapamtiKorisnika((Korisnik)request.Objekat);
                    break;
                case Operation.VratiListuKorisnika:
                    response.Rezultat= Controller.Instance.VratiListuKorisnika();
                    break;
                case Operation.VratiListuTipova:
                    response.Rezultat = Controller.Instance.vratiListuTipova();
                    break;
                case Operation.VratiListuZaposlenih:
                    response.Rezultat=Controller.Instance.VratiListuZaposlenih();
                    break;
                case Operation.SacuvajUslugu:
                     Controller.Instance.SacuvajUsluge((List<Usluga>)request.Objekat);
                    response.Rezultat = true;
                    break;
                case Operation.ObrisiKorisnika:
                    response.Rezultat = Controller.Instance.ObrisiKorisnika((Korisnik)request.Objekat);
                    break;
                case Operation.PronadjiKorisnike:
                    response.Rezultat = Controller.Instance.PronadjiKorisnike((Korisnik)request.Objekat);
                    break;
                case Operation.PronadjiUsluge:
                    response.Rezultat = Controller.Instance.PronadjiUsluge((Usluga)request.Objekat);
                    break;
                case Operation.ObrisiUslugu:
                    response.Rezultat = Controller.Instance.ObrisiUslugu((Usluga)request.Objekat);
                    break;
                case Operation.PrikaziKorisnika:
                    response.Rezultat = Controller.Instance.PrikaziKorisnika((Korisnik)request.Objekat);
                    break;
                case Operation.IzmeniKorisnika:
                   
                    response.Rezultat = Controller.Instance.IzmeniKorisnika((Korisnik)request.Objekat);
                    break;
                case Operation.PrikaziUslugu:
                    response.Rezultat = Controller.Instance.PrikaziUslugu((Usluga)request.Objekat);
                    break;
                case Operation.PronadjiTermine:
                    response.Rezultat = Controller.Instance.PronadjiTermine((Termin)request.Objekat);
                    break;
                case Operation.PrikaziTermin:
                    response.Rezultat = Controller.Instance.PrikaziTermin((Termin)request.Objekat);
                    break;
                case Operation.SacuvajTermin:
                    Controller.Instance.SacuvajTermine((List<Termin>)request.Objekat);
                    response.Rezultat = true;
                    break;
            }
            return response;
        }

        internal void close()
        {
            client.Close();
        }
    }
}
