namespace View.UserControls
{
    partial class UCIzmenaKorisnika
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPretraziKorisnike = new System.Windows.Forms.Button();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.btnPrikaziInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnizmeni = new System.Windows.Forms.Button();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.txtbrojtelefona = new System.Windows.Forms.TextBox();
            this.txtimeiprezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Korisnici";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 186);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnPretraziKorisnike
            // 
            this.btnPretraziKorisnike.Location = new System.Drawing.Point(477, 93);
            this.btnPretraziKorisnike.Name = "btnPretraziKorisnike";
            this.btnPretraziKorisnike.Size = new System.Drawing.Size(136, 49);
            this.btnPretraziKorisnike.TabIndex = 9;
            this.btnPretraziKorisnike.Text = "Pronadji korisnike prema kriterijumu";
            this.btnPretraziKorisnike.UseVisualStyleBackColor = true;
            this.btnPretraziKorisnike.Click += new System.EventHandler(this.btnPretraziKorisnike_Click);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(366, 65);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(247, 22);
            this.txtImePrezime.TabIndex = 8;
            // 
            // btnPrikaziInfo
            // 
            this.btnPrikaziInfo.Enabled = false;
            this.btnPrikaziInfo.Location = new System.Drawing.Point(477, 183);
            this.btnPrikaziInfo.Name = "btnPrikaziInfo";
            this.btnPrikaziInfo.Size = new System.Drawing.Size(136, 42);
            this.btnPrikaziInfo.TabIndex = 13;
            this.btnPrikaziInfo.Text = "Prikazi podatke o korisniku";
            this.btnPrikaziInfo.UseVisualStyleBackColor = true;
            this.btnPrikaziInfo.Click += new System.EventHandler(this.btnPrikaziInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Unesite ime i prezime korisnika:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnizmeni);
            this.groupBox1.Controls.Add(this.txtadresa);
            this.groupBox1.Controls.Add(this.txtbrojtelefona);
            this.groupBox1.Controls.Add(this.txtimeiprezime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o izabranom korisniku";
            // 
            // btnizmeni
            // 
            this.btnizmeni.Location = new System.Drawing.Point(337, 119);
            this.btnizmeni.Name = "btnizmeni";
            this.btnizmeni.Size = new System.Drawing.Size(152, 37);
            this.btnizmeni.TabIndex = 6;
            this.btnizmeni.Text = "Izmeni korisnika";
            this.btnizmeni.UseVisualStyleBackColor = true;
            this.btnizmeni.Click += new System.EventHandler(this.btnizmeni_Click);
            // 
            // txtadresa
            // 
            this.txtadresa.Location = new System.Drawing.Point(125, 123);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(161, 28);
            this.txtadresa.TabIndex = 5;
            // 
            // txtbrojtelefona
            // 
            this.txtbrojtelefona.Location = new System.Drawing.Point(125, 76);
            this.txtbrojtelefona.Name = "txtbrojtelefona";
            this.txtbrojtelefona.Size = new System.Drawing.Size(161, 28);
            this.txtbrojtelefona.TabIndex = 4;
            // 
            // txtimeiprezime
            // 
            this.txtimeiprezime.Location = new System.Drawing.Point(125, 34);
            this.txtimeiprezime.Name = "txtimeiprezime";
            this.txtimeiprezime.Size = new System.Drawing.Size(161, 28);
            this.txtimeiprezime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj telefona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(52, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 239);
            this.panel1.TabIndex = 16;
            // 
            // UCIzmenaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrikaziInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraziKorisnike);
            this.Controls.Add(this.txtImePrezime);
            this.Name = "UCIzmenaKorisnika";
            this.Size = new System.Drawing.Size(630, 566);
            this.Load += new System.EventHandler(this.UCIzmenaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPretraziKorisnike;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button btnPrikaziInfo;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnizmeni;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.TextBox txtbrojtelefona;
        private System.Windows.Forms.TextBox txtimeiprezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
