namespace Programiranje
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeznamOseb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lstOsebe = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnShrani = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRojDan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriimek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnNovZapis = new System.Windows.Forms.Button();
            this.btnBrisiVse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNajdi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIskanje = new System.Windows.Forms.TextBox();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSeznamOseb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.lstOsebe);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imenik";
            // 
            // lblSeznamOseb
            // 
            this.lblSeznamOseb.AutoSize = true;
            this.lblSeznamOseb.Location = new System.Drawing.Point(11, 25);
            this.lblSeznamOseb.Name = "lblSeznamOseb";
            this.lblSeznamOseb.Size = new System.Drawing.Size(74, 13);
            this.lblSeznamOseb.TabIndex = 3;
            this.lblSeznamOseb.Text = "Seznam oseb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sortiranje:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Ime",
            "Priimek",
            "Telefon",
            "Email",
            "Roj. dan"});
            this.cbSort.Location = new System.Drawing.Point(226, 17);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(106, 21);
            this.cbSort.TabIndex = 1;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lstOsebe
            // 
            this.lstOsebe.FormattingEnabled = true;
            this.lstOsebe.Location = new System.Drawing.Point(11, 45);
            this.lstOsebe.Name = "lstOsebe";
            this.lstOsebe.Size = new System.Drawing.Size(322, 407);
            this.lstOsebe.Sorted = true;
            this.lstOsebe.TabIndex = 0;
            this.lstOsebe.SelectedIndexChanged += new System.EventHandler(this.lstOsebe_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrisanje);
            this.groupBox2.Controls.Add(this.lblNaslov);
            this.groupBox2.Controls.Add(this.btnShrani);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRojDan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPriimek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Location = new System.Drawing.Point(361, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podatki o osebi";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(12, 192);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(130, 32);
            this.btnBrisanje.TabIndex = 13;
            this.btnBrisanje.Text = "Brisanje zapisa";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Visible = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(9, 30);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(126, 13);
            this.lblNaslov.TabIndex = 12;
            this.lblNaslov.Text = "Dodajanje zapisa v bazo:";
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(200, 195);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(130, 29);
            this.btnShrani.TabIndex = 10;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Roj. dan:";
            // 
            // txtRojDan
            // 
            this.txtRojDan.Location = new System.Drawing.Point(85, 159);
            this.txtRojDan.Name = "txtRojDan";
            this.txtRojDan.Size = new System.Drawing.Size(245, 20);
            this.txtRojDan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(85, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(245, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Priimek:";
            // 
            // txtPriimek
            // 
            this.txtPriimek.Location = new System.Drawing.Point(85, 81);
            this.txtPriimek.Name = "txtPriimek";
            this.txtPriimek.Size = new System.Drawing.Size(245, 20);
            this.txtPriimek.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime *:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(85, 55);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(245, 20);
            this.txtIme.TabIndex = 0;
            // 
            // btnNovZapis
            // 
            this.btnNovZapis.Location = new System.Drawing.Point(13, 34);
            this.btnNovZapis.Name = "btnNovZapis";
            this.btnNovZapis.Size = new System.Drawing.Size(130, 29);
            this.btnNovZapis.TabIndex = 11;
            this.btnNovZapis.Text = "Nov prazen zapis";
            this.btnNovZapis.UseVisualStyleBackColor = true;
            this.btnNovZapis.Click += new System.EventHandler(this.btnNovZapis_Click);
            // 
            // btnBrisiVse
            // 
            this.btnBrisiVse.Location = new System.Drawing.Point(201, 32);
            this.btnBrisiVse.Name = "btnBrisiVse";
            this.btnBrisiVse.Size = new System.Drawing.Size(130, 32);
            this.btnBrisiVse.TabIndex = 14;
            this.btnBrisiVse.Text = "Brisanje vseh zapisov";
            this.btnBrisiVse.UseVisualStyleBackColor = true;
            this.btnBrisiVse.Click += new System.EventHandler(this.btnBrisiVse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIzpis);
            this.groupBox3.Controls.Add(this.btnBrisiVse);
            this.groupBox3.Controls.Add(this.btnNovZapis);
            this.groupBox3.Location = new System.Drawing.Point(360, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodatni ukazi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNajdi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtIskanje);
            this.groupBox4.Location = new System.Drawing.Point(361, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Iskanje";
            // 
            // btnNajdi
            // 
            this.btnNajdi.Location = new System.Drawing.Point(226, 38);
            this.btnNajdi.Name = "btnNajdi";
            this.btnNajdi.Size = new System.Drawing.Size(104, 28);
            this.btnNajdi.TabIndex = 19;
            this.btnNajdi.Text = "Najdi";
            this.btnNajdi.UseVisualStyleBackColor = true;
            this.btnNajdi.Click += new System.EventHandler(this.btnNajdi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Iskanje po zapisih:";
            // 
            // txtIskanje
            // 
            this.txtIskanje.Location = new System.Drawing.Point(12, 43);
            this.txtIskanje.Name = "txtIskanje";
            this.txtIskanje.Size = new System.Drawing.Size(193, 20);
            this.txtIskanje.TabIndex = 17;
            // 
            // btnIzpis
            // 
            this.btnIzpis.Location = new System.Drawing.Point(201, 84);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(130, 32);
            this.btnIzpis.TabIndex = 15;
            this.btnIzpis.Text = "Izpis vseh zapisov";
            this.btnIzpis.UseVisualStyleBackColor = true;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Osebni imenik";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ListBox lstOsebe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRojDan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriimek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnNovZapis;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblSeznamOseb;
        private System.Windows.Forms.Button btnBrisiVse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNajdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIskanje;
        private System.Windows.Forms.Button btnIzpis;
    }
}

