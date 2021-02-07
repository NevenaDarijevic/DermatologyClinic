using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new FrmLogin());
            //pozvali smo preko ovog maincoordinatora
            while (true)
            {
                try
                {
                    MainCoordinator.Instance.OpenLoginForm();

                    Application.Run();
                }
                catch (ServerException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
