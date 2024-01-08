namespace Personel_Takip
{
    partial class HesapIsleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapIsleri));
            this.comboBoxHesap = new System.Windows.Forms.ComboBox();
            this.buttonRaporla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGider = new System.Windows.Forms.TextBox();
            this.textBoxGelir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonHesap = new System.Windows.Forms.RadioButton();
            this.panelHesap = new System.Windows.Forms.Panel();
            this.buttonGeridon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxHesap
            // 
            this.comboBoxHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHesap.FormattingEnabled = true;
            this.comboBoxHesap.Location = new System.Drawing.Point(405, 122);
            this.comboBoxHesap.Name = "comboBoxHesap";
            this.comboBoxHesap.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHesap.TabIndex = 0;
            // 
            // buttonRaporla
            // 
            this.buttonRaporla.BackColor = System.Drawing.Color.Gold;
            this.buttonRaporla.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporla.Location = new System.Drawing.Point(2, 400);
            this.buttonRaporla.Name = "buttonRaporla";
            this.buttonRaporla.Size = new System.Drawing.Size(418, 54);
            this.buttonRaporla.TabIndex = 2;
            this.buttonRaporla.Text = "Raporla";
            this.buttonRaporla.UseVisualStyleBackColor = false;
            this.buttonRaporla.Click += new System.EventHandler(this.buttonRaporla_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Rapor Oluşturmak İstediğiniz Ayı Seçin:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGider
            // 
            this.textBoxGider.Location = new System.Drawing.Point(405, 188);
            this.textBoxGider.Name = "textBoxGider";
            this.textBoxGider.Size = new System.Drawing.Size(121, 22);
            this.textBoxGider.TabIndex = 4;
            // 
            // textBoxGelir
            // 
            this.textBoxGelir.Location = new System.Drawing.Point(405, 265);
            this.textBoxGelir.Name = "textBoxGelir";
            this.textBoxGelir.Size = new System.Drawing.Size(121, 22);
            this.textBoxGelir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eklenecek Diğer Gider:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonHesap
            // 
            this.radioButtonHesap.AutoSize = true;
            this.radioButtonHesap.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHesap.Location = new System.Drawing.Point(732, 43);
            this.radioButtonHesap.Name = "radioButtonHesap";
            this.radioButtonHesap.Size = new System.Drawing.Size(143, 20);
            this.radioButtonHesap.TabIndex = 8;
            this.radioButtonHesap.TabStop = true;
            this.radioButtonHesap.Text = "Kar Zarar Görüntüle";
            this.radioButtonHesap.UseVisualStyleBackColor = false;
            // 
            // panelHesap
            // 
            this.panelHesap.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelHesap.Location = new System.Drawing.Point(732, 69);
            this.panelHesap.Name = "panelHesap";
            this.panelHesap.Size = new System.Drawing.Size(578, 282);
            this.panelHesap.TabIndex = 9;
            // 
            // buttonGeridon
            // 
            this.buttonGeridon.BackColor = System.Drawing.Color.Thistle;
            this.buttonGeridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeridon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeridon.Location = new System.Drawing.Point(85, 460);
            this.buttonGeridon.Name = "buttonGeridon";
            this.buttonGeridon.Size = new System.Drawing.Size(267, 45);
            this.buttonGeridon.TabIndex = 10;
            this.buttonGeridon.Text = "Geri Dön";
            this.buttonGeridon.UseVisualStyleBackColor = false;
            this.buttonGeridon.Click += new System.EventHandler(this.buttonGeridon_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eklenecek Diğer Gider:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HesapIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1322, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGeridon);
            this.Controls.Add(this.panelHesap);
            this.Controls.Add(this.radioButtonHesap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGelir);
            this.Controls.Add(this.textBoxGider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaporla);
            this.Controls.Add(this.comboBoxHesap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HesapIsleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap İşleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHesap;
        private System.Windows.Forms.Button buttonRaporla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGider;
        private System.Windows.Forms.TextBox textBoxGelir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonHesap;
        private System.Windows.Forms.Panel panelHesap;
        private System.Windows.Forms.Button buttonGeridon;
        private System.Windows.Forms.Label label2;
    }
}