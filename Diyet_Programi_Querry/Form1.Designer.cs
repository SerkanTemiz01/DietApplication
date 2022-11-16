namespace Diyet_Programi_Querry
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new CustomControls.RJControls.RJButton();
            this.btnKayıtOl = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOŞGELDİNİZ...";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGirisYap.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnGirisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGirisYap.BorderRadius = 12;
            this.btnGirisYap.BorderSize = 0;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(79, 281);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(246, 40);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.TextColor = System.Drawing.Color.White;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKayıtOl.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnKayıtOl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKayıtOl.BorderRadius = 12;
            this.btnKayıtOl.BorderSize = 0;
            this.btnKayıtOl.FlatAppearance.BorderSize = 0;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(79, 331);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(246, 40);
            this.btnKayıtOl.TabIndex = 4;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextColor = System.Drawing.Color.White;
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 420);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnGirisYap;
        private CustomControls.RJControls.RJButton btnKayıtOl;
    }
}

