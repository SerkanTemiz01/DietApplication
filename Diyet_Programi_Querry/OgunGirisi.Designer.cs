namespace Diyet_Programi_Querry
{
    partial class OgunGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgunGirisi));
            this.cmbOgunSec = new System.Windows.Forms.ComboBox();
            this.dgwliste = new System.Windows.Forms.DataGridView();
            this.dgwTuketilenListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrGram = new System.Windows.Forms.NumericUpDown();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new CustomControls.RJControls.RJButton();
            this.btnYeniÖgun = new CustomControls.RJControls.RJButton();
            this.btnSil = new CustomControls.RJControls.RJButton();
            this.txtBesinArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTuketilenListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGram)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgunSec
            // 
            this.cmbOgunSec.FormattingEnabled = true;
            this.cmbOgunSec.Location = new System.Drawing.Point(13, 273);
            this.cmbOgunSec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOgunSec.Name = "cmbOgunSec";
            this.cmbOgunSec.Size = new System.Drawing.Size(249, 27);
            this.cmbOgunSec.TabIndex = 0;
            // 
            // dgwliste
            // 
            this.dgwliste.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwliste.Location = new System.Drawing.Point(13, 62);
            this.dgwliste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwliste.Name = "dgwliste";
            this.dgwliste.RowHeadersWidth = 51;
            this.dgwliste.Size = new System.Drawing.Size(391, 205);
            this.dgwliste.TabIndex = 1;
            this.dgwliste.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwliste_CellMouseClick_1);
            // 
            // dgwTuketilenListesi
            // 
            this.dgwTuketilenListesi.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwTuketilenListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTuketilenListesi.Location = new System.Drawing.Point(447, 62);
            this.dgwTuketilenListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwTuketilenListesi.Name = "dgwTuketilenListesi";
            this.dgwTuketilenListesi.RowHeadersWidth = 51;
            this.dgwTuketilenListesi.Size = new System.Drawing.Size(400, 205);
            this.dgwTuketilenListesi.TabIndex = 1;
            this.dgwTuketilenListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTuketilenListesi_CellMouseClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(158, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(350, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gr.";
            // 
            // nmrGram
            // 
            this.nmrGram.Location = new System.Drawing.Point(228, 314);
            this.nmrGram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmrGram.Name = "nmrGram";
            this.nmrGram.Size = new System.Drawing.Size(115, 26);
            this.nmrGram.TabIndex = 5;
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
            this.btnGeri.Location = new System.Drawing.Point(745, 342);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(102, 77);
            this.btnGeri.TabIndex = 6;
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
            this.btnEkle.Location = new System.Drawing.Point(12, 305);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 47);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Öğün Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.White;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnYeniÖgun
            // 
            this.btnYeniÖgun.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYeniÖgun.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYeniÖgun.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYeniÖgun.BorderRadius = 20;
            this.btnYeniÖgun.BorderSize = 0;
            this.btnYeniÖgun.FlatAppearance.BorderSize = 0;
            this.btnYeniÖgun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniÖgun.ForeColor = System.Drawing.Color.White;
            this.btnYeniÖgun.Location = new System.Drawing.Point(13, 358);
            this.btnYeniÖgun.Name = "btnYeniÖgun";
            this.btnYeniÖgun.Size = new System.Drawing.Size(207, 48);
            this.btnYeniÖgun.TabIndex = 7;
            this.btnYeniÖgun.Text = "Listeye Yeni Öğün Ekle";
            this.btnYeniÖgun.TextColor = System.Drawing.Color.White;
            this.btnYeniÖgun.UseVisualStyleBackColor = false;
            this.btnYeniÖgun.Click += new System.EventHandler(this.btnYeniÖgun_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSil.BorderRadius = 20;
            this.btnSil.BorderSize = 0;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(447, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 47);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Öğün Çıkar";
            this.btnSil.TextColor = System.Drawing.Color.White;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // txtBesinArama
            // 
            this.txtBesinArama.Location = new System.Drawing.Point(120, 30);
            this.txtBesinArama.Name = "txtBesinArama";
            this.txtBesinArama.Size = new System.Drawing.Size(209, 26);
            this.txtBesinArama.TabIndex = 8;
            this.txtBesinArama.TextChanged += new System.EventHandler(this.txtBesinArama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Besin Arama";
            // 
            // OgunGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBesinArama);
            this.Controls.Add(this.btnYeniÖgun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.nmrGram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwTuketilenListesi);
            this.Controls.Add(this.dgwliste);
            this.Controls.Add(this.cmbOgunSec);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgunGirisi";
            this.Text = "OgunGirisi";
            this.Load += new System.EventHandler(this.OgunGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTuketilenListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOgunSec;
        private System.Windows.Forms.DataGridView dgwliste;
        private System.Windows.Forms.DataGridView dgwTuketilenListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrGram;
        private System.Windows.Forms.Button btnGeri;
        private CustomControls.RJControls.RJButton btnEkle;
        private CustomControls.RJControls.RJButton btnYeniÖgun;
        private CustomControls.RJControls.RJButton btnSil;
        private System.Windows.Forms.TextBox txtBesinArama;
        private System.Windows.Forms.Label label3;
    }
}