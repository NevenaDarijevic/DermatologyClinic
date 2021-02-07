namespace View
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radSaKorisnicimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPostojećegKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radSaUslugamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNoveUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radSaTerminimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazivanjeTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraživanjeTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(286, 620);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 24);
            this.lblWelcome.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radSaKorisnicimaToolStripMenuItem,
            this.radSaUslugamaToolStripMenuItem,
            this.radSaTerminimaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radSaKorisnicimaToolStripMenuItem
            // 
            this.radSaKorisnicimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogKorisnikaToolStripMenuItem,
            this.pretragaKorisnikaToolStripMenuItem,
            this.izmenaPostojećegKorisnikaToolStripMenuItem,
            this.brisanjeKorisnikaToolStripMenuItem});
            this.radSaKorisnicimaToolStripMenuItem.Name = "radSaKorisnicimaToolStripMenuItem";
            this.radSaKorisnicimaToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.radSaKorisnicimaToolStripMenuItem.Text = "Rad sa korisnicima";
            // 
            // unosNovogKorisnikaToolStripMenuItem
            // 
            this.unosNovogKorisnikaToolStripMenuItem.Name = "unosNovogKorisnikaToolStripMenuItem";
            this.unosNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.unosNovogKorisnikaToolStripMenuItem.Text = "Unos novog korisnika";
            this.unosNovogKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogKorisnikaToolStripMenuItem_Click);
            // 
            // pretragaKorisnikaToolStripMenuItem
            // 
            this.pretragaKorisnikaToolStripMenuItem.Name = "pretragaKorisnikaToolStripMenuItem";
            this.pretragaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.pretragaKorisnikaToolStripMenuItem.Text = "Pretraga korisnika";
            this.pretragaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKorisnikaToolStripMenuItem_Click);
            // 
            // izmenaPostojećegKorisnikaToolStripMenuItem
            // 
            this.izmenaPostojećegKorisnikaToolStripMenuItem.Name = "izmenaPostojećegKorisnikaToolStripMenuItem";
            this.izmenaPostojećegKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.izmenaPostojećegKorisnikaToolStripMenuItem.Text = "Izmena postojećeg korisnika";
            this.izmenaPostojećegKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmenaPostojećegKorisnikaToolStripMenuItem_Click);
            // 
            // brisanjeKorisnikaToolStripMenuItem
            // 
            this.brisanjeKorisnikaToolStripMenuItem.Name = "brisanjeKorisnikaToolStripMenuItem";
            this.brisanjeKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.brisanjeKorisnikaToolStripMenuItem.Text = "Brisanje korisnika";
            this.brisanjeKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeKorisnikaToolStripMenuItem_Click);
            // 
            // radSaUslugamaToolStripMenuItem
            // 
            this.radSaUslugamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNoveUslugeToolStripMenuItem,
            this.pretragaUslugeToolStripMenuItem,
            this.brisanjeUslugeToolStripMenuItem});
            this.radSaUslugamaToolStripMenuItem.Name = "radSaUslugamaToolStripMenuItem";
            this.radSaUslugamaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.radSaUslugamaToolStripMenuItem.Text = "Rad sa uslugama";
            // 
            // unosNoveUslugeToolStripMenuItem
            // 
            this.unosNoveUslugeToolStripMenuItem.Name = "unosNoveUslugeToolStripMenuItem";
            this.unosNoveUslugeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.unosNoveUslugeToolStripMenuItem.Text = "Unos nove usluge";
            this.unosNoveUslugeToolStripMenuItem.Click += new System.EventHandler(this.unosNoveUslugeToolStripMenuItem_Click);
            // 
            // pretragaUslugeToolStripMenuItem
            // 
            this.pretragaUslugeToolStripMenuItem.Name = "pretragaUslugeToolStripMenuItem";
            this.pretragaUslugeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.pretragaUslugeToolStripMenuItem.Text = "Pretraga usluge";
            this.pretragaUslugeToolStripMenuItem.Click += new System.EventHandler(this.pretragaUslugeToolStripMenuItem_Click);
            // 
            // brisanjeUslugeToolStripMenuItem
            // 
            this.brisanjeUslugeToolStripMenuItem.Name = "brisanjeUslugeToolStripMenuItem";
            this.brisanjeUslugeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.brisanjeUslugeToolStripMenuItem.Text = "Brisanje usluge";
            this.brisanjeUslugeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeUslugeToolStripMenuItem_Click);
            // 
            // radSaTerminimaToolStripMenuItem
            // 
            this.radSaTerminimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakazivanjeTerminaToolStripMenuItem,
            this.pretraživanjeTerminaToolStripMenuItem});
            this.radSaTerminimaToolStripMenuItem.Name = "radSaTerminimaToolStripMenuItem";
            this.radSaTerminimaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.radSaTerminimaToolStripMenuItem.Text = "Rad sa terminima";
            // 
            // zakazivanjeTerminaToolStripMenuItem
            // 
            this.zakazivanjeTerminaToolStripMenuItem.Name = "zakazivanjeTerminaToolStripMenuItem";
            this.zakazivanjeTerminaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zakazivanjeTerminaToolStripMenuItem.Text = "Zakazivanje termina";
            this.zakazivanjeTerminaToolStripMenuItem.Click += new System.EventHandler(this.zakazivanjeTerminaToolStripMenuItem_Click);
            // 
            // pretraživanjeTerminaToolStripMenuItem
            // 
            this.pretraživanjeTerminaToolStripMenuItem.Name = "pretraživanjeTerminaToolStripMenuItem";
            this.pretraživanjeTerminaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pretraživanjeTerminaToolStripMenuItem.Text = "Pretraživanje termina";
            this.pretraživanjeTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretraživanjeTerminaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 528);
            this.panel1.TabIndex = 2;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(776, 715);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGlavna_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem radSaKorisnicimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radSaUslugamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radSaTerminimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPostojećegKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNoveUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazivanjeTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraživanjeTerminaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}