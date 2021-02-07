using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
   public class Server
    {
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        public BindingList<Zaposleni> Zaposleni { get; set; } = new BindingList<Zaposleni>();

     

        private Socket listener;

        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Start()
        {
            
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"])));
        }

        public void Listen()
        {
            listener.Listen(5);
            bool kraj = false;
            try
            {
                while (!kraj)
                {
                    Socket client = listener.Accept();
                    ClientHandler handler = new ClientHandler(client,this);
                    klijenti.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (SocketException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                kraj = true;
            }
            
        }

        internal void zaustaviServer()
        {
            listener.Close();
            foreach(ClientHandler c in klijenti)
            {
                c.close();
            }
            klijenti.Clear();
        }
    }
}
