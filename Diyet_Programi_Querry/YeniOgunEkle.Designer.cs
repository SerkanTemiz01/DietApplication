namespace Diyet_Programi_Querry
{
    partial class YeniOgunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniOgunEkle));
            this.txtBesinAdi = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.cmbOgunAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrKarbonhidrat = new System.Windows.Forms.NumericUpDown();
            this.nmrProtein = new System.Windows.Forms.NumericUpDown();
            this.nmrYag = new System.Windows.Forms.NumericUpDown();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarbonhidrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYag)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBesinAdi
            // 
            this.txtBesinAdi.Location = new System.Drawing.Point(207, 94);
            this.txtBesinAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBesinAdi.Name = "txtBesinAdi";
            this.txtBesinAdi.Size = new System.Drawing.Size(175, 26);
            this.txtBesinAdi.TabIndex = 0;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(207, 209);
            this.txtKalori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(175, 26);
            this.txtKalori.TabIndex = 0;
            this.txtKalori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKalori_KeyPress_1);
            // 
            // cmbOgunAdi
            // 
            this.cmbOgunAdi.FormattingEnabled = true;
            this.cmbOgunAdi.Location = new System.Drawing.Point(207, 63);
            this.cmbOgunAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOgunAdi.Name = "cmbOgunAdi";
            this.cmbOgunAdi.Size = new System.Drawing.Size(175, 27);
            this.cmbOgunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(108, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yemek Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(128, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "100 gram için:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Karbonhidrat Miktarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(57, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Protein Miktarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(88, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yağ Miktarı:";
            // 
            // nmrKarbonhidrat
            // 
            this.nmrKarbonhidrat.Location = new System.Drawing.Point(207, 125);
            this.nmrKarbonhidrat.Name = "nmrKarbonhidrat";
            this.nmrKarbonhidrat.Size = new System.Drawing.Size(175, 26);
            this.nmrKarbonhidrat.TabIndex = 4;
            // 
            // nmrProtein
            // 
            this.nmrProtein.Location = new System.Drawing.Point(207, 153);
            this.nmrProtein.Name = "nmrProtein";
            this.nmrProtein.Size = new System.Drawing.Size(175, 26);
            this.nmrProtein.TabIndex = 4;
            // 
            // nmrYag
            // 
            this.nmrYag.Location = new System.Drawing.Point(207, 181);
            this.nmrYag.Name = "nmrYag";
            this.nmrYag.Size = new System.Drawing.Size(175, 26);
            this.nmrYag.TabIndex = 4;
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
            this.btnGeri.Location = new System.Drawing.Point(1, 289);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(81, 67);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEkle.BorderRadius = 20;
            this.btnEkle.BorderSize = 0;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(207, 241);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 55);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.White;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // YeniOgunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 370);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.nmrYag);
            this.Controls.Add(this.nmrProtein);
            this.Controls.Add(this.nmrKarbonhidrat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOgunAdi);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtBesinAdi);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "YeniOgunEkle";
            this.Text = "YeniOgunEkle";
            this.Load += new System.EventHandler(this.YeniOgunEkle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarbonhidrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBesinAdi;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.ComboBox cmbOgunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrKarbonhidrat;
        private System.Windows.Forms.NumericUpDown nmrProtein;
        private System.Windows.Forms.NumericUpDown nmrYag;
        private System.Windows.Forms.Button btnGeri;
        private CustomControls.RJControls.RJButton btnEkle;
    }
}