﻿namespace Personel_Takip
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
            this.textBoxNormalEkle = new System.Windows.Forms.TextBox();
            this.labelNormalPersonel = new System.Windows.Forms.Label();
            this.comboBoxNormal = new System.Windows.Forms.ComboBox();
            this.radioButtonYuzde = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.panelYuzde = new System.Windows.Forms.Panel();
            this.labelYuzde = new System.Windows.Forms.Label();
            this.labelYuzdePersonel = new System.Windows.Forms.Label();
            this.btnMaasGuncelleYuzde = new System.Windows.Forms.Button();
            this.txtYuzdeMaas = new System.Windows.Forms.TextBox();
            this.comboBoxYuzde = new System.Windows.Forms.ComboBox();
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
            this.panelNormal.Controls.Add(this.textBoxNormalEkle);
            this.panelNormal.Controls.Add(this.labelNormalPersonel);
            this.panelNormal.Controls.Add(this.comboBoxNormal);
            this.panelNormal.Location = new System.Drawing.Point(576, 45);
            this.panelNormal.Name = "panelNormal";
            this.panelNormal.Size = new System.Drawing.Size(454, 396);
            this.panelNormal.TabIndex = 1;
            // 
            // btnNormalCıkar
            // 
            this.btnNormalCıkar.BackColor = System.Drawing.Color.Gold;
            this.btnNormalCıkar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormalCıkar.Location = new System.Drawing.Point(236, 285);
            this.btnNormalCıkar.Name = "btnNormalCıkar";
            this.btnNormalCıkar.Size = new System.Drawing.Size(174, 85);
            this.btnNormalCıkar.TabIndex = 5;
            this.btnNormalCıkar.Text = "Net Maaşdan Düş";
            this.btnNormalCıkar.UseVisualStyleBackColor = false;
            this.btnNormalCıkar.Click += new System.EventHandler(this.btnNormalCıkar_Click);
            // 
            // btnNormalEkle
            // 
            this.btnNormalEkle.BackColor = System.Drawing.Color.Gold;
            this.btnNormalEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormalEkle.Location = new System.Drawing.Point(37, 285);
            this.btnNormalEkle.Name = "btnNormalEkle";
            this.btnNormalEkle.Size = new System.Drawing.Size(152, 85);
            this.btnNormalEkle.TabIndex = 4;
            this.btnNormalEkle.Text = "Net Maaşa Ekle";
            this.btnNormalEkle.UseVisualStyleBackColor = false;
            this.btnNormalEkle.Click += new System.EventHandler(this.btnNormalEkle_Click);
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
            // textBoxNormalEkle
            // 
            this.textBoxNormalEkle.Location = new System.Drawing.Point(289, 154);
            this.textBoxNormalEkle.Name = "textBoxNormalEkle";
            this.textBoxNormalEkle.Size = new System.Drawing.Size(150, 22);
            this.textBoxNormalEkle.TabIndex = 2;
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
            // 
            // comboBoxNormal
            // 
            this.comboBoxNormal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNormal.FormattingEnabled = true;
            this.comboBoxNormal.Location = new System.Drawing.Point(289, 84);
            this.comboBoxNormal.Name = "comboBoxNormal";
            this.comboBoxNormal.Size = new System.Drawing.Size(150, 24);
            this.comboBoxNormal.TabIndex = 0;
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
            this.radioButtonYuzde.CheckedChanged += new System.EventHandler(this.radioButtonYuzde_CheckedChanged);
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
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // panelYuzde
            // 
            this.panelYuzde.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.panelYuzde.Controls.Add(this.labelYuzde);
            this.panelYuzde.Controls.Add(this.labelYuzdePersonel);
            this.panelYuzde.Controls.Add(this.btnMaasGuncelleYuzde);
            this.panelYuzde.Controls.Add(this.txtYuzdeMaas);
            this.panelYuzde.Controls.Add(this.comboBoxYuzde);
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
            this.btnMaasGuncelleYuzde.BackColor = System.Drawing.Color.Gold;
            this.btnMaasGuncelleYuzde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasGuncelleYuzde.Location = new System.Drawing.Point(122, 285);
            this.btnMaasGuncelleYuzde.Name = "btnMaasGuncelleYuzde";
            this.btnMaasGuncelleYuzde.Size = new System.Drawing.Size(189, 54);
            this.btnMaasGuncelleYuzde.TabIndex = 2;
            this.btnMaasGuncelleYuzde.Text = "Güncelle";
            this.btnMaasGuncelleYuzde.UseVisualStyleBackColor = false;
            this.btnMaasGuncelleYuzde.Click += new System.EventHandler(this.btnMaasGuncelleYuzde_Click);
            // 
            // txtYuzdeMaas
            // 
            this.txtYuzdeMaas.Location = new System.Drawing.Point(281, 143);
            this.txtYuzdeMaas.Name = "txtYuzdeMaas";
            this.txtYuzdeMaas.Size = new System.Drawing.Size(159, 22);
            this.txtYuzdeMaas.TabIndex = 1;
            // 
            // comboBoxYuzde
            // 
            this.comboBoxYuzde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYuzde.FormattingEnabled = true;
            this.comboBoxYuzde.Location = new System.Drawing.Point(281, 72);
            this.comboBoxYuzde.Name = "comboBoxYuzde";
            this.comboBoxYuzde.Size = new System.Drawing.Size(159, 24);
            this.comboBoxYuzde.TabIndex = 0;
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
        private System.Windows.Forms.TextBox txtYuzdeMaas;
        private System.Windows.Forms.ComboBox comboBoxYuzde;
        private System.Windows.Forms.Button btnNormalCıkar;
        private System.Windows.Forms.Button btnNormalEkle;
        private System.Windows.Forms.Label labelNormalMaas;
        private System.Windows.Forms.TextBox textBoxNormalEkle;
        private System.Windows.Forms.Label labelNormalPersonel;
        private System.Windows.Forms.ComboBox comboBoxNormal;
    }
}