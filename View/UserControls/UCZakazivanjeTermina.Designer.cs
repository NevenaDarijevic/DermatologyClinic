namespace View.UserControls
{
    partial class UCZakazivanjeTermina
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatumZakazivanja = new System.Windows.Forms.TextBox();
            this.txtDatumTermina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.cbKorisnici = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnTermin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDatumZakazivanja);
            this.groupBox1.Controls.Add(this.txtDatumTermina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbZaposleni);
            this.groupBox1.Controls.Add(this.cbKorisnici);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakazivanje termina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "[ mm.dd.yyyy. ]";
            // 
            // txtDatumZakazivanja
            // 
            this.txtDatumZakazivanja.Enabled = false;
            this.txtDatumZakazivanja.Location = new System.Drawing.Point(193, 68);
            this.txtDatumZakazivanja.Name = "txtDatumZakazivanja";
            this.txtDatumZakazivanja.Size = new System.Drawing.Size(172, 22);
            this.txtDatumZakazivanja.TabIndex = 7;
            // 
            // txtDatumTermina
            // 
            this.txtDatumTermina.Location = new System.Drawing.Point(193, 112);
            this.txtDatumTermina.Name = "txtDatumTermina";
            this.txtDatumTermina.Size = new System.Drawing.Size(172, 22);
            this.txtDatumTermina.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum zakazivanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum termina:";
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(193, 212);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(172, 24);
            this.cbZaposleni.TabIndex = 3;
            this.cbZaposleni.Text = "Izaberite zaposlenog";
            // 
            // cbKorisnici
            // 
            this.cbKorisnici.FormattingEnabled = true;
            this.cbKorisnici.Location = new System.Drawing.Point(193, 161);
            this.cbKorisnici.Name = "cbKorisnici";
            this.cbKorisnici.Size = new System.Drawing.Size(172, 24);
            this.cbKorisnici.TabIndex = 2;
            this.cbKorisnici.Text = "Izaberite korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaposleni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnik:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(204, 280);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(132, 25);
            this.btnObrisi.TabIndex = 41;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnTermin
            // 
            this.btnTermin.Location = new System.Drawing.Point(25, 281);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(172, 23);
            this.btnTermin.TabIndex = 4;
            this.btnTermin.Text = "Dodaj";
            this.btnTermin.UseVisualStyleBackColor = true;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(227, 471);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(167, 31);
            this.btnSacuvaj.TabIndex = 44;
            this.btnSacuvaj.Text = "Sacuvaj unete termine";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(29, 306);
            this.dgvTermini.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.Size = new System.Drawing.Size(534, 157);
            this.dgvTermini.TabIndex = 43;
            // 
            // UCZakazivanjeTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTermin);
            this.Name = "UCZakazivanjeTermina";
            this.Size = new System.Drawing.Size(605, 524);
            this.Load += new System.EventHandler(this.UCZakazivanjeTermina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.ComboBox cbZaposleni;
        private System.Windows.Forms.ComboBox cbKorisnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumZakazivanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDatumTermina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label5;
    }
}
