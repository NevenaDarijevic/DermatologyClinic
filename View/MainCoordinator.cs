using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Controller;

namespace View
{
    public class MainCoordinator
    {
       
        private FrmLogin frmLogin;
        private FrmMain frmMain;
        private MainController mainController = new MainController();
        private LoginController loginController = new LoginController();

        //singlton patern

        //instanca
        private static MainCoordinator instance;
        //konstruktor
        private MainCoordinator() { }
        //geter
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }
        //metoda za otvaranje login forme
        public void OpenLoginForm()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }

        //metoda za otvaranje glavne forme
        public void OpenMainForm()
        {
            frmLogin.Dispose();
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
   public Zaposleni Zaposleni { get; set; }
}
}
