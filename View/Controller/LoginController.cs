using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
   public class LoginController
    {
        internal void Login(TextBox txtUsername, TextBox txtPassword, FrmLogin frmLogin)
        {
            if (!UserControlHelpers. EmptyFieldValidation(txtUsername)
                | !UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                return;
            }
            try
            {
                Zaposleni z = new Zaposleni
                {
                    KorisnickoIme=txtUsername.Text,Sifra=txtPassword.Text
                };
                z = Communication.Communication.Instance.Login(z);
                if (z != null)
                {
                    MainCoordinator.Instance.Zaposleni = z;
                    MessageBox.Show($"Korisnik {z.ImePrezime} se uspesno prijavio!");
                    MainCoordinator.Instance.OpenMainForm();
                    frmLogin.Dispose();
                }
                else
                {
                   
                    MessageBox.Show("Ne postoji ovakav korisnik");
                }
            }
            catch (SystemOperationsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom! Proverite da li je server pokrenut!");
                return false;
             //   Environment.Exit(0);
            }
        }
    }
}
