namespace Personel_Takip
{
    partial class MesaiIsleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesaiIsleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxMsaati = new System.Windows.Forms.ComboBox();
            this.labelMesaiS = new System.Windows.Forms.Label();
            this.pMesai = new System.Windows.Forms.Panel();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.labelBilgi = new System.Windows.Forms.Label();
            this.btnMbilgiGuncelle = new System.Windows.Forms.Button();
            this.txtSaatUcretiM = new System.Windows.Forms.TextBox();
            this.lUcret = new System.Windows.Forms.Label();
            this.btnMesaiDegis = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.lblPersoenlCombo = new System.Windows.Forms.Label();
            this.comboBoxMesai = new System.Windows.Forms.ComboBox();
            this.btnMekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pMesai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBoxMsaati);
            this.panel1.Controls.Add(this.labelMesaiS);
            this.panel1.Controls.Add(this.pMesai);
            this.panel1.Controls.Add(this.btnMesaiDegis);
            this.panel1.Controls.Add(this.btnSıfırla);
            this.panel1.Controls.Add(this.lblPersoenlCombo);
            this.panel1.Controls.Add(this.comboBoxMesai);
            this.panel1.Controls.Add(this.btnMekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 516);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxMsaati
            // 
            this.comboBoxMsaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMsaati.FormattingEnabled = true;
            this.comboBoxMsaati.Location = new System.Drawing.Point(264, 154);
            this.comboBoxMsaati.Name = "comboBoxMsaati";
            this.comboBoxMsaati.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMsaati.TabIndex = 7;
            // 
            // labelMesaiS
            // 
            this.labelMesaiS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMesaiS.Location = new System.Drawing.Point(16, 139);
            this.labelMesaiS.Name = "labelMesaiS";
            this.labelMesaiS.Size = new System.Drawing.Size(220, 23);
            this.labelMesaiS.TabIndex = 6;
            this.labelMesaiS.Text = "Mesai Saati Seçiniz:";
            this.labelMesaiS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMesai
            // 
            this.pMesai.BackColor = System.Drawing.Color.Teal;
            this.pMesai.Controls.Add(this.btnYazdir);
            this.pMesai.Controls.Add(this.labelBilgi);
            this.pMesai.Controls.Add(this.btnMbilgiGuncelle);
            this.pMesai.Controls.Add(this.txtSaatUcretiM);
            this.pMesai.Controls.Add(this.lUcret);
            this.pMesai.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMesai.Location = new System.Drawing.Point(566, 0);
            this.pMesai.Name = "pMesai";
            this.pMesai.Size = new System.Drawing.Size(639, 516);
            this.pMesai.TabIndex = 5;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Peru;
            this.btnYazdir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(76, 210);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(487, 52);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Saatlik Mesai Ücretini Göster";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // labelBilgi
            // 
            this.labelBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBilgi.Location = new System.Drawing.Point(3, 381);
            this.labelBilgi.Name = "labelBilgi";
            this.labelBilgi.Size = new System.Drawing.Size(382, 82);
            this.labelBilgi.TabIndex = 3;
            this.labelBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMbilgiGuncelle
            // 
            this.btnMbilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMbilgiGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMbilgiGuncelle.Location = new System.Drawing.Point(76, 121);
            this.btnMbilgiGuncelle.Name = "btnMbilgiGuncelle";
            this.btnMbilgiGuncelle.Size = new System.Drawing.Size(487, 41);
            this.btnMbilgiGuncelle.TabIndex = 2;
            this.btnMbilgiGuncelle.Text = "Mesai Saat Ücretini Güncelle";
            this.btnMbilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnMbilgiGuncelle.Click += new System.EventHandler(this.btnMbilgiGuncelle_Click);
            // 
            // txtSaatUcretiM
            // 
            this.txtSaatUcretiM.Location = new System.Drawing.Point(392, 48);
            this.txtSaatUcretiM.Name = "txtSaatUcretiM";
            this.txtSaatUcretiM.Size = new System.Drawing.Size(113, 22);
            this.txtSaatUcretiM.TabIndex = 1;
            // 
            // lUcret
            // 
            this.lUcret.AutoSize = true;
            this.lUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUcret.Location = new System.Drawing.Point(59, 48);
            this.lUcret.Name = "lUcret";
            this.lUcret.Size = new System.Drawing.Size(217, 23);
            this.lUcret.TabIndex = 0;
            this.lUcret.Text = "Saatlik Mesai Ücreti Giriniz:";
            // 
            // btnMesaiDegis
            // 
            this.btnMesaiDegis.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMesaiDegis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiDegis.Location = new System.Drawing.Point(58, 434);
            this.btnMesaiDegis.Name = "btnMesaiDegis";
            this.btnMesaiDegis.Size = new System.Drawing.Size(387, 51);
            this.btnMesaiDegis.TabIndex = 4;
            this.btnMesaiDegis.Text = "Mesai Ücreti Güncelle";
            this.btnMesaiDegis.UseVisualStyleBackColor = false;
            this.btnMesaiDegis.Click += new System.EventHandler(this.btnMesaiDegis_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.Gold;
            this.btnSıfırla.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfırla.Location = new System.Drawing.Point(58, 315);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(387, 47);
            this.btnSıfırla.TabIndex = 3;
            this.btnSıfırla.Text = "Primleri Bu Ay İçin Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // lblPersoenlCombo
            // 
            this.lblPersoenlCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersoenlCombo.Location = new System.Drawing.Point(12, 64);
            this.lblPersoenlCombo.Name = "lblPersoenlCombo";
            this.lblPersoenlCombo.Size = new System.Drawing.Size(246, 23);
            this.lblPersoenlCombo.TabIndex = 2;
            this.lblPersoenlCombo.Text = "Personeli Seçiniz:";
            this.lblPersoenlCombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMesai
            // 
            this.comboBoxMesai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesai.FormattingEnabled = true;
            this.comboBoxMesai.Location = new System.Drawing.Point(264, 61);
            this.comboBoxMesai.Name = "comboBoxMesai";
            this.comboBoxMesai.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMesai.TabIndex = 1;
            // 
            // btnMekle
            // 
            this.btnMekle.BackColor = System.Drawing.Color.Gold;
            this.btnMekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMekle.Location = new System.Drawing.Point(58, 239);
            this.btnMekle.Name = "btnMekle";
            this.btnMekle.Size = new System.Drawing.Size(387, 43);
            this.btnMekle.TabIndex = 0;
            this.btnMekle.Text = "Prim Ekle";
            this.btnMekle.UseVisualStyleBackColor = false;
            this.btnMekle.Click += new System.EventHandler(this.btnMekle_Click_1);
            // 
            // MesaiIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1205, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesaiIsleri";
            this.Text = "Mesai İşleri";
            this.Load += new System.EventHandler(this.MesaiIsleri_Load);
            this.panel1.ResumeLayout(false);
            this.pMesai.ResumeLayout(false);
            this.pMesai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMesai;
        private System.Windows.Forms.Button btnMesaiDegis;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Label lblPersoenlCombo;
        private System.Windows.Forms.ComboBox comboBoxMesai;
        private System.Windows.Forms.Button btnMekle;
        private System.Windows.Forms.ComboBox comboBoxMsaati;
        private System.Windows.Forms.Label labelMesaiS;
        private System.Windows.Forms.TextBox txtSaatUcretiM;
        private System.Windows.Forms.Label lUcret;
        private System.Windows.Forms.Button btnMbilgiGuncelle;
        private System.Windows.Forms.Label labelBilgi;
        private System.Windows.Forms.Button btnYazdir;
    }
}