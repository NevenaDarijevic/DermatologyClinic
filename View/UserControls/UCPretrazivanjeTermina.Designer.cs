namespace View.UserControls
{
    partial class UCPretrazivanjeTermina
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtzaposleni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkorisnik = new System.Windows.Forms.TextBox();
            this.txtdatumtermina = new System.Windows.Forms.TextBox();
            this.txtdatumzakazivanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikaziTermin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPretraziTermine = new System.Windows.Forms.Button();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(40, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 189);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtzaposleni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtkorisnik);
            this.groupBox1.Controls.Add(this.txtdatumtermina);
            this.groupBox1.Controls.Add(this.txtdatumzakazivanja);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o izabranom terminu";
            this.groupBox1.Visible = false;
            // 
            // txtzaposleni
            // 
            this.txtzaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzaposleni.Location = new System.Drawing.Point(216, 116);
            this.txtzaposleni.Name = "txtzaposleni";
            this.txtzaposleni.ReadOnly = true;
            this.txtzaposleni.Size = new System.Drawing.Size(161, 22);
            this.txtzaposleni.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zaposleni";
            // 
            // txtkorisnik
            // 
            this.txtkorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkorisnik.Location = new System.Drawing.Point(216, 84);
            this.txtkorisnik.Name = "txtkorisnik";
            this.txtkorisnik.ReadOnly = true;
            this.txtkorisnik.Size = new System.Drawing.Size(161, 22);
            this.txtkorisnik.TabIndex = 5;
            // 
            // txtdatumtermina
            // 
            this.txtdatumtermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatumtermina.Location = new System.Drawing.Point(216, 54);
            this.txtdatumtermina.Name = "txtdatumtermina";
            this.txtdatumtermina.ReadOnly = true;
            this.txtdatumtermina.Size = new System.Drawing.Size(161, 22);
            this.txtdatumtermina.TabIndex = 4;
            // 
            // txtdatumzakazivanja
            // 
            this.txtdatumzakazivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatumzakazivanja.Location = new System.Drawing.Point(216, 24);
            this.txtdatumzakazivanja.Name = "txtdatumzakazivanja";
            this.txtdatumzakazivanja.ReadOnly = true;
            this.txtdatumzakazivanja.Size = new System.Drawing.Size(161, 22);
            this.txtdatumzakazivanja.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Datum termina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Korisnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum zakazivanja";
            // 
            // btnPrikaziTermin
            // 
            this.btnPrikaziTermin.Enabled = false;
            this.btnPrikaziTermin.Location = new System.Drawing.Point(364, 234);
            this.btnPrikaziTermin.Name = "btnPrikaziTermin";
            this.btnPrikaziTermin.Size = new System.Drawing.Size(155, 29);
            this.btnPrikaziTermin.TabIndex = 23;
            this.btnPrikaziTermin.Text = "Prikazi izabrani termin";
            this.btnPrikaziTermin.UseVisualStyleBackColor = true;
            this.btnPrikaziTermin.Click += new System.EventHandler(this.btnPrikaziTermin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rezultat pretrage";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(479, 112);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnPretraziTermine
            // 
            this.btnPretraziTermine.Location = new System.Drawing.Point(383, 48);
            this.btnPretraziTermine.Name = "btnPretraziTermine";
            this.btnPretraziTermine.Size = new System.Drawing.Size(136, 49);
            this.btnPretraziTermine.TabIndex = 20;
            this.btnPretraziTermine.Text = "Pronadji termine prema kriterijumu";
            this.btnPretraziTermine.UseVisualStyleBackColor = true;
            this.btnPretraziTermine.Click += new System.EventHandler(this.btnPretraziTermine_Click);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(40, 59);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(284, 22);
            this.txtImePrezime.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Unesite ime i prezime korisnika radi pretrage:";
            // 
            // UCPretrazivanjeTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrikaziTermin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraziTermine);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "UCPretrazivanjeTermina";
            this.Size = new System.Drawing.Size(562, 517);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkorisnik;
        private System.Windows.Forms.TextBox txtdatumtermina;
        private System.Windows.Forms.TextBox txtdatumzakazivanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikaziTermin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPretraziTermine;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtzaposleni;
        private System.Windows.Forms.Label label6;
    }
}
