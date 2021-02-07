using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Server
{
    public partial class FrmServer : Form
    {
       private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
          
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            this.Text = "Server nije pokrenut";
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
               
                s.Zaposleni.ListChanged += Zaposleni_ListChanged;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                this.Text = "Server je pokrenut";
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Zaposleni_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvZaposleni.Invoke(new Action(() => dgvZaposleni.DataSource = s.Zaposleni.ToList()));
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.zaustaviServer();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            this.Text = "Server nije pokrenut";
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            return;
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            return;
        }
    }
}
