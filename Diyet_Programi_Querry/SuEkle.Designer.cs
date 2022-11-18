namespace Diyet_Programi_Querry
{
    partial class SuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnlTplamSu = new System.Windows.Forms.Label();
            this.btnÇıkart = new CustomControls.RJControls.RJButton();
            this.btnEkle = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç Bardak Su İçtiniz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bir Bardak Su 200 ml. Eşittir.";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btngeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(12, 298);
            this.btngeri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(102, 77);
            this.btngeri.TabIndex = 7;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(861, 166);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(481, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam İçilen Su Miktarı:";
            // 
            // lnlTplamSu
            // 
            this.lnlTplamSu.AutoSize = true;
            this.lnlTplamSu.BackColor = System.Drawing.Color.Transparent;
            this.lnlTplamSu.Location = new System.Drawing.Point(674, 327);
            this.lnlTplamSu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlTplamSu.Name = "lnlTplamSu";
            this.lnlTplamSu.Size = new System.Drawing.Size(27, 19);
            this.lnlTplamSu.TabIndex = 0;
            this.lnlTplamSu.Text = "00";
            // 
            // btnÇıkart
            // 
            this.btnÇıkart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnÇıkart.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnÇıkart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnÇıkart.BorderRadius = 12;
            this.btnÇıkart.BorderSize = 0;
            this.btnÇıkart.FlatAppearance.BorderSize = 0;
            this.btnÇıkart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkart.ForeColor = System.Drawing.Color.White;
            this.btnÇıkart.Location = new System.Drawing.Point(316, 85);
            this.btnÇıkart.Name = "btnÇıkart";
            this.btnÇıkart.Size = new System.Drawing.Size(150, 35);
            this.btnÇıkart.TabIndex = 9;
            this.btnÇıkart.Text = "ÇIKART";
            this.btnÇıkart.TextColor = System.Drawing.Color.White;
            this.btnÇıkart.UseVisualStyleBackColor = false;
            this.btnÇıkart.Click += new System.EventHandler(this.btnÇıkart_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEkle.BorderRadius = 12;
            this.btnEkle.BorderSize = 0;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(147, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 35);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextColor = System.Drawing.Color.White;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // SuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 380);
            this.Controls.Add(this.btnÇıkart);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lnlTplamSu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SuEkle";
            this.Text = "SuEkle";
            this.Load += new System.EventHandler(this.SuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeri;
        private CustomControls.RJControls.RJButton btnEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton btnÇıkart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lnlTplamSu;
    }
}