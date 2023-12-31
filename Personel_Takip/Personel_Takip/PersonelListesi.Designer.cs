namespace Personel_Takip
{
    partial class PersonelListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListesi));
            this.menüyeDon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menüyeDon
            // 
            this.menüyeDon.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menüyeDon.Location = new System.Drawing.Point(12, 470);
            this.menüyeDon.Name = "menüyeDon";
            this.menüyeDon.Size = new System.Drawing.Size(125, 41);
            this.menüyeDon.TabIndex = 0;
            this.menüyeDon.Text = "Ana Menü";
            this.menüyeDon.UseVisualStyleBackColor = true;
            this.menüyeDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(443, 470);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(154, 38);
            this.listelebtn.TabIndex = 2;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1087, 549);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menüyeDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menüyeDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listelebtn;
    }
}