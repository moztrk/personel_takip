namespace Personel_Takip
{
    partial class MaasDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaasDuzenle));
            this.panelButon = new System.Windows.Forms.Panel();
            this.Mbtnmenu = new System.Windows.Forms.Button();
            this.MbtnMesai = new System.Windows.Forms.Button();
            this.mbtnMaas = new System.Windows.Forms.Button();
            this.panelFormAcma = new System.Windows.Forms.Panel();
            this.panelButon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButon
            // 
            this.panelButon.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.panelButon.Controls.Add(this.Mbtnmenu);
            this.panelButon.Controls.Add(this.MbtnMesai);
            this.panelButon.Controls.Add(this.mbtnMaas);
            this.panelButon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButon.Location = new System.Drawing.Point(0, 0);
            this.panelButon.Name = "panelButon";
            this.panelButon.Size = new System.Drawing.Size(224, 561);
            this.panelButon.TabIndex = 0;
            // 
            // Mbtnmenu
            // 
            this.Mbtnmenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mbtnmenu.Location = new System.Drawing.Point(23, 490);
            this.Mbtnmenu.Name = "Mbtnmenu";
            this.Mbtnmenu.Size = new System.Drawing.Size(182, 47);
            this.Mbtnmenu.TabIndex = 2;
            this.Mbtnmenu.Text = "Ana Menü";
            this.Mbtnmenu.UseVisualStyleBackColor = true;
            this.Mbtnmenu.Click += new System.EventHandler(this.Mbtnmenu_Click);
            // 
            // MbtnMesai
            // 
            this.MbtnMesai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MbtnMesai.Location = new System.Drawing.Point(23, 118);
            this.MbtnMesai.Name = "MbtnMesai";
            this.MbtnMesai.Size = new System.Drawing.Size(182, 50);
            this.MbtnMesai.TabIndex = 1;
            this.MbtnMesai.Text = "Mesai Hesapla";
            this.MbtnMesai.UseVisualStyleBackColor = true;
            // 
            // mbtnMaas
            // 
            this.mbtnMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mbtnMaas.Location = new System.Drawing.Point(23, 35);
            this.mbtnMaas.Name = "mbtnMaas";
            this.mbtnMaas.Size = new System.Drawing.Size(182, 52);
            this.mbtnMaas.TabIndex = 0;
            this.mbtnMaas.Text = "Maaş Güncelle";
            this.mbtnMaas.UseVisualStyleBackColor = true;
            this.mbtnMaas.Click += new System.EventHandler(this.mbtnMaas_Click);
            // 
            // panelFormAcma
            // 
            this.panelFormAcma.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFormAcma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormAcma.Location = new System.Drawing.Point(224, 0);
            this.panelFormAcma.Name = "panelFormAcma";
            this.panelFormAcma.Size = new System.Drawing.Size(1112, 561);
            this.panelFormAcma.TabIndex = 1;
            // 
            // MaasDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1336, 561);
            this.Controls.Add(this.panelFormAcma);
            this.Controls.Add(this.panelButon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaasDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Düzenleme";
            this.panelButon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButon;
        private System.Windows.Forms.Button MbtnMesai;
        private System.Windows.Forms.Button mbtnMaas;
        private System.Windows.Forms.Button Mbtnmenu;
        private System.Windows.Forms.Panel panelFormAcma;
    }
}