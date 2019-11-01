namespace eProdaja.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.Cijena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJedMjere = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proizvodiGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta proizvoda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(130, 31);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(357, 24);
            this.cmbVrsta.TabIndex = 2;
            this.cmbVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbVrsta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(130, 72);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(357, 22);
            this.txtSifra.TabIndex = 4;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(130, 114);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(357, 22);
            this.txtNaziv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(130, 182);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(117, 22);
            this.txtCijena.TabIndex = 8;
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.Location = new System.Drawing.Point(66, 187);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(51, 17);
            this.Cijena.TabIndex = 7;
            this.Cijena.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jed. mjere";
            // 
            // cmbJedMjere
            // 
            this.cmbJedMjere.FormattingEnabled = true;
            this.cmbJedMjere.Location = new System.Drawing.Point(346, 184);
            this.cmbJedMjere.Name = "cmbJedMjere";
            this.cmbJedMjere.Size = new System.Drawing.Size(141, 24);
            this.cmbJedMjere.TabIndex = 10;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(524, 155);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(704, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 112);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(730, 172);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(93, 39);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proizvodiGridView);
            this.groupBox1.Location = new System.Drawing.Point(1, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 297);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // proizvodiGridView
            // 
            this.proizvodiGridView.AllowUserToAddRows = false;
            this.proizvodiGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.proizvodiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proizvodiGridView.Location = new System.Drawing.Point(3, 18);
            this.proizvodiGridView.Name = "proizvodiGridView";
            this.proizvodiGridView.RowTemplate.Height = 24;
            this.proizvodiGridView.Size = new System.Drawing.Size(899, 276);
            this.proizvodiGridView.TabIndex = 0;
            this.proizvodiGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proizvodiGridView_CellContentClick);
            this.proizvodiGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.proizvodiGridView_DataError);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(130, 152);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(357, 22);
            this.txtSlikaInput.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Slika";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbJedMjere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJedMjere;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView proizvodiGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label5;
    }
}