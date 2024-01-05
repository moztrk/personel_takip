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
            this.tabControlM = new System.Windows.Forms.TabControl();
            this.tabPageEkle = new System.Windows.Forms.TabPage();
            this.btnMekle = new System.Windows.Forms.Button();
            this.comboBoxMsaati = new System.Windows.Forms.ComboBox();
            this.labelSaat = new System.Windows.Forms.Label();
            this.comboBoxMesai = new System.Windows.Forms.ComboBox();
            this.labelMesai = new System.Windows.Forms.Label();
            this.tabPageMesaiBilgi = new System.Windows.Forms.TabPage();
            this.btnSıfırlama = new System.Windows.Forms.Button();
            this.tabControlM.SuspendLayout();
            this.tabPageEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlM
            // 
            this.tabControlM.Controls.Add(this.tabPageEkle);
            this.tabControlM.Controls.Add(this.tabPageMesaiBilgi);
            this.tabControlM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlM.Location = new System.Drawing.Point(0, 0);
            this.tabControlM.Name = "tabControlM";
            this.tabControlM.SelectedIndex = 0;
            this.tabControlM.Size = new System.Drawing.Size(1205, 516);
            this.tabControlM.TabIndex = 0;
            // 
            // tabPageEkle
            // 
            this.tabPageEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageEkle.Controls.Add(this.btnSıfırlama);
            this.tabPageEkle.Controls.Add(this.btnMekle);
            this.tabPageEkle.Controls.Add(this.comboBoxMsaati);
            this.tabPageEkle.Controls.Add(this.labelSaat);
            this.tabPageEkle.Controls.Add(this.comboBoxMesai);
            this.tabPageEkle.Controls.Add(this.labelMesai);
            this.tabPageEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageEkle.Name = "tabPageEkle";
            this.tabPageEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEkle.Size = new System.Drawing.Size(1197, 487);
            this.tabPageEkle.TabIndex = 0;
            this.tabPageEkle.Text = "Mesai Ekle";
            // 
            // btnMekle
            // 
            this.btnMekle.Location = new System.Drawing.Point(10, 222);
            this.btnMekle.Name = "btnMekle";
            this.btnMekle.Size = new System.Drawing.Size(138, 47);
            this.btnMekle.TabIndex = 4;
            this.btnMekle.Text = "Prim Ekle";
            this.btnMekle.UseVisualStyleBackColor = true;
            this.btnMekle.Click += new System.EventHandler(this.btnMekle_Click);
            // 
            // comboBoxMsaati
            // 
            this.comboBoxMsaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMsaati.FormattingEnabled = true;
            this.comboBoxMsaati.Location = new System.Drawing.Point(267, 120);
            this.comboBoxMsaati.Name = "comboBoxMsaati";
            this.comboBoxMsaati.Size = new System.Drawing.Size(121, 31);
            this.comboBoxMsaati.TabIndex = 3;
            // 
            // labelSaat
            // 
            this.labelSaat.Location = new System.Drawing.Point(6, 120);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(187, 31);
            this.labelSaat.TabIndex = 2;
            this.labelSaat.Text = "Mesai Saati Giriniz :";
            // 
            // comboBoxMesai
            // 
            this.comboBoxMesai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesai.FormattingEnabled = true;
            this.comboBoxMesai.Location = new System.Drawing.Point(267, 39);
            this.comboBoxMesai.Name = "comboBoxMesai";
            this.comboBoxMesai.Size = new System.Drawing.Size(175, 31);
            this.comboBoxMesai.TabIndex = 1;
            // 
            // labelMesai
            // 
            this.labelMesai.Location = new System.Drawing.Point(6, 42);
            this.labelMesai.Name = "labelMesai";
            this.labelMesai.Size = new System.Drawing.Size(187, 46);
            this.labelMesai.TabIndex = 0;
            this.labelMesai.Text = "Personeli Seçiniz: ";
            // 
            // tabPageMesaiBilgi
            // 
            this.tabPageMesaiBilgi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPageMesaiBilgi.Location = new System.Drawing.Point(4, 25);
            this.tabPageMesaiBilgi.Name = "tabPageMesaiBilgi";
            this.tabPageMesaiBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMesaiBilgi.Size = new System.Drawing.Size(1197, 487);
            this.tabPageMesaiBilgi.TabIndex = 1;
            this.tabPageMesaiBilgi.Text = "Mesai Bilgileri Güncelle";
            // 
            // btnSıfırlama
            // 
            this.btnSıfırlama.BackColor = System.Drawing.Color.Gold;
            this.btnSıfırlama.Location = new System.Drawing.Point(10, 342);
            this.btnSıfırlama.Name = "btnSıfırlama";
            this.btnSıfırlama.Size = new System.Drawing.Size(351, 50);
            this.btnSıfırlama.TabIndex = 5;
            this.btnSıfırlama.Text = "Primleri bu ay için sıfırla";
            this.btnSıfırlama.UseVisualStyleBackColor = false;
            this.btnSıfırlama.Click += new System.EventHandler(this.btnSıfırlama_Click);
            // 
            // MesaiIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1205, 516);
            this.Controls.Add(this.tabControlM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesaiIsleri";
            this.Text = "Mesai İşleri";
            this.tabControlM.ResumeLayout(false);
            this.tabPageEkle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlM;
        private System.Windows.Forms.TabPage tabPageEkle;
        private System.Windows.Forms.TabPage tabPageMesaiBilgi;
        private System.Windows.Forms.ComboBox comboBoxMesai;
        private System.Windows.Forms.Label labelMesai;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Button btnMekle;
        private System.Windows.Forms.ComboBox comboBoxMsaati;
        private System.Windows.Forms.Button btnSıfırlama;
    }
}