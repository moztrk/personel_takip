namespace Personel_Takip
{
    partial class MaasIsleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaasIsleri));
            this.panelNormal = new System.Windows.Forms.Panel();
            this.btnNormalCıkar = new System.Windows.Forms.Button();
            this.btnNormalEkle = new System.Windows.Forms.Button();
            this.labelNormalMaas = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNormalPersonel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButtonYuzde = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.panelYuzde = new System.Windows.Forms.Panel();
            this.labelYuzde = new System.Windows.Forms.Label();
            this.labelYuzdePersonel = new System.Windows.Forms.Label();
            this.btnMaasGuncelleYuzde = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelNormal.SuspendLayout();
            this.panelYuzde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNormal
            // 
            this.panelNormal.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.panelNormal.Controls.Add(this.btnNormalCıkar);
            this.panelNormal.Controls.Add(this.btnNormalEkle);
            this.panelNormal.Controls.Add(this.labelNormalMaas);
            this.panelNormal.Controls.Add(this.textBox2);
            this.panelNormal.Controls.Add(this.labelNormalPersonel);
            this.panelNormal.Controls.Add(this.comboBox2);
            this.panelNormal.Location = new System.Drawing.Point(576, 45);
            this.panelNormal.Name = "panelNormal";
            this.panelNormal.Size = new System.Drawing.Size(454, 396);
            this.panelNormal.TabIndex = 1;
            // 
            // btnNormalCıkar
            // 
            this.btnNormalCıkar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormalCıkar.Location = new System.Drawing.Point(236, 285);
            this.btnNormalCıkar.Name = "btnNormalCıkar";
            this.btnNormalCıkar.Size = new System.Drawing.Size(174, 85);
            this.btnNormalCıkar.TabIndex = 5;
            this.btnNormalCıkar.Text = "Net Maaşdan Düş";
            this.btnNormalCıkar.UseVisualStyleBackColor = true;
            // 
            // btnNormalEkle
            // 
            this.btnNormalEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormalEkle.Location = new System.Drawing.Point(37, 285);
            this.btnNormalEkle.Name = "btnNormalEkle";
            this.btnNormalEkle.Size = new System.Drawing.Size(152, 85);
            this.btnNormalEkle.TabIndex = 4;
            this.btnNormalEkle.Text = "Net Maaşa Ekle";
            this.btnNormalEkle.UseVisualStyleBackColor = true;
            // 
            // labelNormalMaas
            // 
            this.labelNormalMaas.BackColor = System.Drawing.Color.Transparent;
            this.labelNormalMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNormalMaas.Location = new System.Drawing.Point(7, 141);
            this.labelNormalMaas.Name = "labelNormalMaas";
            this.labelNormalMaas.Size = new System.Drawing.Size(253, 81);
            this.labelNormalMaas.TabIndex = 3;
            this.labelNormalMaas.Text = "Eklemek\\Çıkarmak İstediğiniz  Miktar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 2;
            // 
            // labelNormalPersonel
            // 
            this.labelNormalPersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelNormalPersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNormalPersonel.Location = new System.Drawing.Point(11, 70);
            this.labelNormalPersonel.Name = "labelNormalPersonel";
            this.labelNormalPersonel.Size = new System.Drawing.Size(227, 38);
            this.labelNormalPersonel.TabIndex = 1;
            this.labelNormalPersonel.Text = "Personeli Seçiniz:";
            this.labelNormalPersonel.Click += new System.EventHandler(this.labelNormalPersonel_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(289, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // radioButtonYuzde
            // 
            this.radioButtonYuzde.AutoSize = true;
            this.radioButtonYuzde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonYuzde.Location = new System.Drawing.Point(44, 12);
            this.radioButtonYuzde.Name = "radioButtonYuzde";
            this.radioButtonYuzde.Size = new System.Drawing.Size(222, 27);
            this.radioButtonYuzde.TabIndex = 2;
            this.radioButtonYuzde.TabStop = true;
            this.radioButtonYuzde.Text = "Yüzde  İle Maaş Güncelle";
            this.radioButtonYuzde.UseVisualStyleBackColor = true;
            this.radioButtonYuzde.CheckedChanged += new System.EventHandler(this.radioButtonYuzde_CheckedChanged_1);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonNormal.Location = new System.Drawing.Point(576, 12);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(205, 27);
            this.radioButtonNormal.TabIndex = 3;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal Maaş Güncelle";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged_1);
            // 
            // panelYuzde
            // 
            this.panelYuzde.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.panelYuzde.Controls.Add(this.labelYuzde);
            this.panelYuzde.Controls.Add(this.labelYuzdePersonel);
            this.panelYuzde.Controls.Add(this.btnMaasGuncelleYuzde);
            this.panelYuzde.Controls.Add(this.textBox1);
            this.panelYuzde.Controls.Add(this.comboBox1);
            this.panelYuzde.Location = new System.Drawing.Point(44, 45);
            this.panelYuzde.Name = "panelYuzde";
            this.panelYuzde.Size = new System.Drawing.Size(461, 396);
            this.panelYuzde.TabIndex = 0;
            // 
            // labelYuzde
            // 
            this.labelYuzde.BackColor = System.Drawing.Color.Transparent;
            this.labelYuzde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYuzde.Location = new System.Drawing.Point(26, 136);
            this.labelYuzde.Name = "labelYuzde";
            this.labelYuzde.Size = new System.Drawing.Size(229, 50);
            this.labelYuzde.TabIndex = 4;
            this.labelYuzde.Text = " % Kaç zam ?";
            // 
            // labelYuzdePersonel
            // 
            this.labelYuzdePersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYuzdePersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelYuzdePersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYuzdePersonel.Location = new System.Drawing.Point(26, 70);
            this.labelYuzdePersonel.Name = "labelYuzdePersonel";
            this.labelYuzdePersonel.Size = new System.Drawing.Size(229, 47);
            this.labelYuzdePersonel.TabIndex = 3;
            this.labelYuzdePersonel.Text = "Personeli Seçiniz:";
            // 
            // btnMaasGuncelleYuzde
            // 
            this.btnMaasGuncelleYuzde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasGuncelleYuzde.Location = new System.Drawing.Point(122, 285);
            this.btnMaasGuncelleYuzde.Name = "btnMaasGuncelleYuzde";
            this.btnMaasGuncelleYuzde.Size = new System.Drawing.Size(189, 54);
            this.btnMaasGuncelleYuzde.TabIndex = 2;
            this.btnMaasGuncelleYuzde.Text = "Güncelle";
            this.btnMaasGuncelleYuzde.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // MaasIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1042, 467);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.radioButtonYuzde);
            this.Controls.Add(this.panelNormal);
            this.Controls.Add(this.panelYuzde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaasIsleri";
            this.Text = "Maaş Güncelleme";
            this.Load += new System.EventHandler(this.MaasIsleri_Load);
            this.panelNormal.ResumeLayout(false);
            this.panelNormal.PerformLayout();
            this.panelYuzde.ResumeLayout(false);
            this.panelYuzde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelYuzde;
        private System.Windows.Forms.Panel panelNormal;
        private System.Windows.Forms.RadioButton radioButtonYuzde;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Label labelYuzde;
        private System.Windows.Forms.Label labelYuzdePersonel;
        private System.Windows.Forms.Button btnMaasGuncelleYuzde;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNormalCıkar;
        private System.Windows.Forms.Button btnNormalEkle;
        private System.Windows.Forms.Label labelNormalMaas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNormalPersonel;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}