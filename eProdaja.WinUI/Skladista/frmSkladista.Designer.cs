namespace eProdaja.WinUI.Skladista
{
    partial class frmSkladista
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
            this.txtSkladistaPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSkladista = new System.Windows.Forms.DataGridView();
            this.SkladisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSkladistaPretraga
            // 
            this.txtSkladistaPretraga.Location = new System.Drawing.Point(12, 25);
            this.txtSkladistaPretraga.Name = "txtSkladistaPretraga";
            this.txtSkladistaPretraga.Size = new System.Drawing.Size(324, 22);
            this.txtSkladistaPretraga.TabIndex = 0;
            this.txtSkladistaPretraga.TextChanged += new System.EventHandler(this.txtSkladistaPretraga_TextChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(454, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prlkazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSkladista);
            this.groupBox1.Location = new System.Drawing.Point(2, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvSkladista
            // 
            this.dgvSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkladisteID,
            this.Naziv,
            this.Adresa,
            this.Opis});
            this.dgvSkladista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkladista.Location = new System.Drawing.Point(3, 18);
            this.dgvSkladista.Name = "dgvSkladista";
            this.dgvSkladista.RowTemplate.Height = 24;
            this.dgvSkladista.Size = new System.Drawing.Size(586, 275);
            this.dgvSkladista.TabIndex = 0;
            this.dgvSkladista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladista_CellContentClick);
            this.dgvSkladista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSkladista_MouseDoubleClick);
            // 
            // SkladisteID
            // 
            this.SkladisteID.DataPropertyName = "SkladisteID";
            this.SkladisteID.HeaderText = "SkladisteID";
            this.SkladisteID.Name = "SkladisteID";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // frmSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtSkladistaPretraga);
            this.Name = "frmSkladista";
            this.Text = "frmSkladista";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSkladistaPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSkladista;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkladisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}