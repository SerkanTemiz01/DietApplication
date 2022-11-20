namespace Diyet_Programi_Querry
{
    partial class EgzersizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzersizForm));
            this.cmbEgzersiz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.nmrSure = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEgzersizEkle = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSure)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEgzersiz
            // 
            this.cmbEgzersiz.FormattingEnabled = true;
            this.cmbEgzersiz.Location = new System.Drawing.Point(233, 30);
            this.cmbEgzersiz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEgzersiz.Name = "cmbEgzersiz";
            this.cmbEgzersiz.Size = new System.Drawing.Size(162, 27);
            this.cmbEgzersiz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yaptığınız Egzersizi Seçiniz:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.Location = new System.Drawing.Point(13, 241);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(85, 57);
            this.btnGeri.TabIndex = 73;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // nmrSure
            // 
            this.nmrSure.Location = new System.Drawing.Point(233, 78);
            this.nmrSure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmrSure.Name = "nmrSure";
            this.nmrSure.Size = new System.Drawing.Size(162, 26);
            this.nmrSure.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kaç Dakika Spor Yaptınız:";
            // 
            // btnEgzersizEkle
            // 
            this.btnEgzersizEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEgzersizEkle.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEgzersizEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEgzersizEkle.BorderRadius = 10;
            this.btnEgzersizEkle.BorderSize = 0;
            this.btnEgzersizEkle.FlatAppearance.BorderSize = 0;
            this.btnEgzersizEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersizEkle.ForeColor = System.Drawing.Color.White;
            this.btnEgzersizEkle.Location = new System.Drawing.Point(233, 135);
            this.btnEgzersizEkle.Name = "btnEgzersizEkle";
            this.btnEgzersizEkle.Size = new System.Drawing.Size(162, 43);
            this.btnEgzersizEkle.TabIndex = 75;
            this.btnEgzersizEkle.Text = "Ekle";
            this.btnEgzersizEkle.TextColor = System.Drawing.Color.White;
            this.btnEgzersizEkle.UseVisualStyleBackColor = false;
            this.btnEgzersizEkle.Click += new System.EventHandler(this.btnEgzersizEkle_Click_1);
            // 
            // EgzersizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 342);
            this.Controls.Add(this.btnEgzersizEkle);
            this.Controls.Add(this.nmrSure);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEgzersiz);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EgzersizForm";
            this.Text = "Egzersiz";
            this.Load += new System.EventHandler(this.Egzersiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEgzersiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.NumericUpDown nmrSure;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnEgzersizEkle;
    }
}