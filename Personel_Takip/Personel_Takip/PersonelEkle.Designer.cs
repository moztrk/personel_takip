namespace Personel_Takip
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonListe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ekleProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelDolulukOrani = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDepartman = new System.Windows.Forms.ComboBox();
            this.labelPrim = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(216, 111);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(216, 154);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(216, 195);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 7;
            this.txtTc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTc_KeyDown);
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(216, 238);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 22);
            this.txtMaas.TabIndex = 9;
            this.txtMaas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaas_KeyDown);
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(45, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 333);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonListe
            // 
            this.buttonListe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListe.Location = new System.Drawing.Point(45, 456);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Size = new System.Drawing.Size(155, 40);
            this.buttonListe.TabIndex = 12;
            this.buttonListe.Text = "Listele";
            this.buttonListe.UseVisualStyleBackColor = true;
            this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1003, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "ANA MENÜ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ekleProgressBar
            // 
            this.ekleProgressBar.Location = new System.Drawing.Point(350, 397);
            this.ekleProgressBar.Name = "ekleProgressBar";
            this.ekleProgressBar.Size = new System.Drawing.Size(183, 36);
            this.ekleProgressBar.TabIndex = 14;
            // 
            // labelDolulukOrani
            // 
            this.labelDolulukOrani.BackColor = System.Drawing.Color.Transparent;
            this.labelDolulukOrani.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDolulukOrani.Location = new System.Drawing.Point(588, 397);
            this.labelDolulukOrani.Name = "labelDolulukOrani";
            this.labelDolulukOrani.Size = new System.Drawing.Size(283, 36);
            this.labelDolulukOrani.TabIndex = 15;
            this.labelDolulukOrani.Text = "\r\n";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departman:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDepartman
            // 
            this.comboBoxDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartman.FormattingEnabled = true;
            this.comboBoxDepartman.Location = new System.Drawing.Point(216, 307);
            this.comboBoxDepartman.Name = "comboBoxDepartman";
            this.comboBoxDepartman.Size = new System.Drawing.Size(103, 24);
            this.comboBoxDepartman.TabIndex = 18;
            // 
            // labelPrim
            // 
            this.labelPrim.BackColor = System.Drawing.Color.Transparent;
            this.labelPrim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrim.Location = new System.Drawing.Point(3, 268);
            this.labelPrim.Name = "labelPrim";
            this.labelPrim.Size = new System.Drawing.Size(184, 32);
            this.labelPrim.TabIndex = 19;
            this.labelPrim.Text = "Başlangıç Primi:";
            this.labelPrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(216, 275);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 20;
            this.textBoxP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxP_KeyDown);
            this.textBoxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxP_KeyPress);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1181, 523);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelPrim);
            this.Controls.Add(this.comboBoxDepartman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDolulukOrani);
            this.Controls.Add(this.ekleProgressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonListe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonListe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar ekleProgressBar;
        private System.Windows.Forms.Label labelDolulukOrani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDepartman;
        private System.Windows.Forms.Label labelPrim;
        private System.Windows.Forms.TextBox textBoxP;
    }
}