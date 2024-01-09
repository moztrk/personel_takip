namespace Personel_Takip
{
    partial class IzinIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzinIslemleri));
            this.comboBoxIzin = new System.Windows.Forms.ComboBox();
            this.labelIzin = new System.Windows.Forms.Label();
            this.numericUpDownIzin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIzın = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIzin)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIzin
            // 
            this.comboBoxIzin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIzin.FormattingEnabled = true;
            this.comboBoxIzin.Location = new System.Drawing.Point(311, 60);
            this.comboBoxIzin.Name = "comboBoxIzin";
            this.comboBoxIzin.Size = new System.Drawing.Size(189, 24);
            this.comboBoxIzin.TabIndex = 0;
            // 
            // labelIzin
            // 
            this.labelIzin.BackColor = System.Drawing.Color.Transparent;
            this.labelIzin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIzin.Location = new System.Drawing.Point(12, 61);
            this.labelIzin.Name = "labelIzin";
            this.labelIzin.Size = new System.Drawing.Size(263, 23);
            this.labelIzin.TabIndex = 1;
            this.labelIzin.Text = "Personel Seçiniz:";
            this.labelIzin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownIzin
            // 
            this.numericUpDownIzin.Location = new System.Drawing.Point(311, 132);
            this.numericUpDownIzin.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownIzin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIzin.Name = "numericUpDownIzin";
            this.numericUpDownIzin.Size = new System.Drawing.Size(189, 22);
            this.numericUpDownIzin.TabIndex = 2;
            this.numericUpDownIzin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gün Sayısı Seçiniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIzın
            // 
            this.buttonIzın.BackColor = System.Drawing.Color.Gold;
            this.buttonIzın.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIzın.Location = new System.Drawing.Point(66, 200);
            this.buttonIzın.Name = "buttonIzın";
            this.buttonIzın.Size = new System.Drawing.Size(434, 39);
            this.buttonIzın.TabIndex = 4;
            this.buttonIzın.Text = "İzin Oluştur";
            this.buttonIzın.UseVisualStyleBackColor = false;
            this.buttonIzın.Click += new System.EventHandler(this.buttonIzın_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.Gold;
            this.buttonM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonM.Location = new System.Drawing.Point(66, 315);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(434, 39);
            this.buttonM.TabIndex = 5;
            this.buttonM.Text = "Ana Menü";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // IzinIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personel_Takip.Properties.Resources._374296;
            this.ClientSize = new System.Drawing.Size(1343, 531);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonIzın);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownIzin);
            this.Controls.Add(this.labelIzin);
            this.Controls.Add(this.comboBoxIzin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzinIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin İşlemleri";
            this.Load += new System.EventHandler(this.IzinIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIzin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIzin;
        private System.Windows.Forms.Label labelIzin;
        private System.Windows.Forms.NumericUpDown numericUpDownIzin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIzın;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonM;
    }
}