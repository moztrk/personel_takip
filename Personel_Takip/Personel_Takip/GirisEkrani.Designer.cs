namespace Personel_Takip
{
    partial class GirisEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tkullanıcı = new System.Windows.Forms.TextBox();
            this.tsifre = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikisButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // tkullanıcı
            // 
            this.tkullanıcı.BackColor = System.Drawing.SystemColors.Info;
            this.tkullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkullanıcı.Location = new System.Drawing.Point(175, 167);
            this.tkullanıcı.Name = "tkullanıcı";
            this.tkullanıcı.Size = new System.Drawing.Size(166, 27);
            this.tkullanıcı.TabIndex = 2;
            // 
            // tsifre
            // 
            this.tsifre.BackColor = System.Drawing.SystemColors.Info;
            this.tsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsifre.Location = new System.Drawing.Point(175, 231);
            this.tsifre.Name = "tsifre";
            this.tsifre.Size = new System.Drawing.Size(166, 27);
            this.tsifre.TabIndex = 3;
            this.tsifre.UseSystemPasswordChar = true;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.Transparent;
            this.girisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisButton.ImageKey = "verified.png";
            this.girisButton.ImageList = this.ımageList1;
            this.girisButton.Location = new System.Drawing.Point(175, 275);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(119, 46);
            this.girisButton.TabIndex = 4;
            this.girisButton.Text = "Giriş";
            this.girisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "verified.png");
            // 
            // sifremiUnuttum
            // 
            this.sifremiUnuttum.AutoSize = true;
            this.sifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttum.Location = new System.Drawing.Point(171, 374);
            this.sifremiUnuttum.Name = "sifremiUnuttum";
            this.sifremiUnuttum.Size = new System.Drawing.Size(104, 16);
            this.sifremiUnuttum.TabIndex = 5;
            this.sifremiUnuttum.TabStop = true;
            this.sifremiUnuttum.Text = "şifremi unuttum ?";
            this.sifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Personel_Takip.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(400, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 138);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Coral;
            this.cikisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikisButton.Location = new System.Drawing.Point(565, 366);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(94, 45);
            this.cikisButton.TabIndex = 8;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifremiUnuttum);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.tkullanıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tkullanıcı;
        private System.Windows.Forms.TextBox tsifre;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.LinkLabel sifremiUnuttum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikisButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

