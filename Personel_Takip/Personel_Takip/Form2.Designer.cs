namespace Personel_Takip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonMaas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttongirisedon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListele.ImageKey = "listeleme.png";
            this.buttonListele.ImageList = this.ımageList1;
            this.buttonListele.Location = new System.Drawing.Point(110, 55);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonListele.Size = new System.Drawing.Size(204, 57);
            this.buttonListele.TabIndex = 0;
            this.buttonListele.Text = "Personel Listele";
            this.buttonListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "listeleme.png");
            this.ımageList1.Images.SetKeyName(1, "ekleme.png");
            this.ımageList1.Images.SetKeyName(2, "sil.jpeg");
            this.ımageList1.Images.SetKeyName(3, "maaş.png");
            this.ımageList1.Images.SetKeyName(4, "istockphoto-1083025568-612x612.jpg");
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEkle.ImageKey = "ekleme.png";
            this.buttonEkle.ImageList = this.ımageList1;
            this.buttonEkle.Location = new System.Drawing.Point(110, 133);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(204, 62);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Personel Ekle";
            this.buttonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.ImageKey = "sil.jpeg";
            this.buttonSil.ImageList = this.ımageList1;
            this.buttonSil.Location = new System.Drawing.Point(110, 213);
            this.buttonSil.MinimumSize = new System.Drawing.Size(157, 41);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(204, 61);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Personel Sil";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // buttonMaas
            // 
            this.buttonMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMaas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaas.ImageKey = "maaş.png";
            this.buttonMaas.ImageList = this.ımageList1;
            this.buttonMaas.Location = new System.Drawing.Point(110, 293);
            this.buttonMaas.Name = "buttonMaas";
            this.buttonMaas.Size = new System.Drawing.Size(204, 60);
            this.buttonMaas.TabIndex = 3;
            this.buttonMaas.Text = "Maaş Düzenle";
            this.buttonMaas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMaas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Personel_Takip.Properties.Resources.istockphoto_1083025568_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(627, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttongirisedon
            // 
            this.buttongirisedon.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongirisedon.Location = new System.Drawing.Point(627, 399);
            this.buttongirisedon.Name = "buttongirisedon";
            this.buttongirisedon.Size = new System.Drawing.Size(182, 40);
            this.buttongirisedon.TabIndex = 6;
            this.buttongirisedon.Text = "Giriş Ekranına Dön";
            this.buttongirisedon.UseVisualStyleBackColor = true;
            this.buttongirisedon.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menü";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(908, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttongirisedon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMaas);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(926, 540);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonMaas;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttongirisedon;
        private System.Windows.Forms.Label label1;
    }
}