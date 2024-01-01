namespace Personel_Takip
{
    partial class PersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sBtnAnamenü = new System.Windows.Forms.Button();
            this.sButonsil = new System.Windows.Forms.Button();
            this.progressBarSilme = new System.Windows.Forms.ProgressBar();
            this.labelDoluluk = new System.Windows.Forms.Label();
            this.sbuttonlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // sBtnAnamenü
            // 
            this.sBtnAnamenü.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sBtnAnamenü.Location = new System.Drawing.Point(855, 454);
            this.sBtnAnamenü.Name = "sBtnAnamenü";
            this.sBtnAnamenü.Size = new System.Drawing.Size(151, 39);
            this.sBtnAnamenü.TabIndex = 1;
            this.sBtnAnamenü.Text = "Ana Menü";
            this.sBtnAnamenü.UseVisualStyleBackColor = true;
            this.sBtnAnamenü.Click += new System.EventHandler(this.sBtnAnamenü_Click);
            // 
            // sButonsil
            // 
            this.sButonsil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sButonsil.Location = new System.Drawing.Point(12, 130);
            this.sButonsil.Name = "sButonsil";
            this.sButonsil.Size = new System.Drawing.Size(151, 38);
            this.sButonsil.TabIndex = 2;
            this.sButonsil.Text = "Sil";
            this.sButonsil.UseVisualStyleBackColor = true;
            this.sButonsil.Click += new System.EventHandler(this.sButonsil_Click);
            // 
            // progressBarSilme
            // 
            this.progressBarSilme.Location = new System.Drawing.Point(23, 397);
            this.progressBarSilme.Name = "progressBarSilme";
            this.progressBarSilme.Size = new System.Drawing.Size(224, 49);
            this.progressBarSilme.TabIndex = 3;
            // 
            // labelDoluluk
            // 
            this.labelDoluluk.BackColor = System.Drawing.Color.Transparent;
            this.labelDoluluk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoluluk.Location = new System.Drawing.Point(301, 397);
            this.labelDoluluk.Name = "labelDoluluk";
            this.labelDoluluk.Size = new System.Drawing.Size(303, 49);
            this.labelDoluluk.TabIndex = 4;
          
            // 
            // sbuttonlistele
            // 
            this.sbuttonlistele.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbuttonlistele.Location = new System.Drawing.Point(12, 58);
            this.sbuttonlistele.Name = "sbuttonlistele";
            this.sbuttonlistele.Size = new System.Drawing.Size(151, 42);
            this.sbuttonlistele.TabIndex = 5;
            this.sbuttonlistele.Text = "Listele";
            this.sbuttonlistele.UseVisualStyleBackColor = true;
            this.sbuttonlistele.Click += new System.EventHandler(this.sbuttonlistele_Click);
            // 
            // PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1111, 544);
            this.Controls.Add(this.sbuttonlistele);
            this.Controls.Add(this.labelDoluluk);
            this.Controls.Add(this.progressBarSilme);
            this.Controls.Add(this.sButonsil);
            this.Controls.Add(this.sBtnAnamenü);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Silme";
            this.Load += new System.EventHandler(this.PersonelSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sBtnAnamenü;
        private System.Windows.Forms.Button sButonsil;
        private System.Windows.Forms.ProgressBar progressBarSilme;
        private System.Windows.Forms.Label labelDoluluk;
        private System.Windows.Forms.Button sbuttonlistele;
    }
}