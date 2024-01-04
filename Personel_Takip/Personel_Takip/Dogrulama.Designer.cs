namespace Personel_Takip
{
    partial class Dogrulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dogrulama));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcButton = new System.Windows.Forms.Button();
            this.tkimlik = new System.Windows.Forms.TextBox();
            this.giriseDnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(87, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC kimlik numaranızı giriniz:";
            // 
            // tcButton
            // 
            this.tcButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcButton.Location = new System.Drawing.Point(311, 200);
            this.tcButton.Name = "tcButton";
            this.tcButton.Size = new System.Drawing.Size(170, 56);
            this.tcButton.TabIndex = 2;
            this.tcButton.Text = "Onayla";
            this.tcButton.UseVisualStyleBackColor = true;
            this.tcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tkimlik
            // 
            this.tkimlik.Location = new System.Drawing.Point(465, 98);
            this.tkimlik.MaxLength = 11;
            this.tkimlik.Name = "tkimlik";
            this.tkimlik.Size = new System.Drawing.Size(188, 22);
            this.tkimlik.TabIndex = 3;
            // 
            // giriseDnButton
            // 
            this.giriseDnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.giriseDnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriseDnButton.Location = new System.Drawing.Point(311, 317);
            this.giriseDnButton.Name = "giriseDnButton";
            this.giriseDnButton.Size = new System.Drawing.Size(170, 78);
            this.giriseDnButton.TabIndex = 4;
            this.giriseDnButton.Text = "Giriş ekranına dön";
            this.giriseDnButton.UseVisualStyleBackColor = true;
            this.giriseDnButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dogrulama
            // 
            this.AcceptButton = this.tcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.CancelButton = this.giriseDnButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giriseDnButton);
            this.Controls.Add(this.tkimlik);
            this.Controls.Add(this.tcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogrulama";
            this.Load += new System.EventHandler(this.Dogrulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tcButton;
        private System.Windows.Forms.TextBox tkimlik;
        private System.Windows.Forms.Button giriseDnButton;
    }
}