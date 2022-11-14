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
            this.nmrSu = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEkle = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnÇıkart = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSu)).BeginInit();
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
            // nmrSu
            // 
            this.nmrSu.Location = new System.Drawing.Point(211, 53);
            this.nmrSu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmrSu.Name = "nmrSu";
            this.nmrSu.Size = new System.Drawing.Size(150, 26);
            this.nmrSu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 77);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(861, 166);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // SuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 380);
            this.Controls.Add(this.btnÇıkart);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.nmrSu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SuEkle";
            this.Text = "SuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrSu;
        private System.Windows.Forms.Button button1;
        private CustomControls.RJControls.RJButton btnEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton btnÇıkart;
    }
}