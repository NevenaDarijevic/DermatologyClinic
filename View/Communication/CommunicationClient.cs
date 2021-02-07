using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using View.Exceptions;

namespace View.Communication
{
    public class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException)
            {

                throw new ServerException();
            }
            catch (SerializationException)
            {
                throw new ServerException();
            }
        }
        public object GetResponseResult()
        {
            try
            {

                Response response = (Response)receiver.Receive();
                if (response.Uspesno)
                {
                    return response.Rezultat;
                }
                else
                {
                    throw new SystemOperationsException(response.Greska);
                }
            }
            catch (SerializationException)
            {
                throw new ServerException();
            }
        }
    }
}
