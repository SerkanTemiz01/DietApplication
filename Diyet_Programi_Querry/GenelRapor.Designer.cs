namespace Diyet_Programi_Querry
{
    partial class GenelRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdbKalori = new System.Windows.Forms.RadioButton();
            this.rdbHarcananKalori = new System.Windows.Forms.RadioButton();
            this.rdbKarbonhidrat = new System.Windows.Forms.RadioButton();
            this.rdbProtein = new System.Windows.Forms.RadioButton();
            this.rdbYag = new System.Windows.Forms.RadioButton();
            this.rdbNetKalori = new System.Windows.Forms.RadioButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(74, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.Size = new System.Drawing.Size(807, 386);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // rdbKalori
            // 
            this.rdbKalori.AutoSize = true;
            this.rdbKalori.BackColor = System.Drawing.Color.Transparent;
            this.rdbKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKalori.Location = new System.Drawing.Point(93, 439);
            this.rdbKalori.Name = "rdbKalori";
            this.rdbKalori.Size = new System.Drawing.Size(143, 29);
            this.rdbKalori.TabIndex = 1;
            this.rdbKalori.TabStop = true;
            this.rdbKalori.Text = "Alınan Kalori";
            this.rdbKalori.UseVisualStyleBackColor = false;
            this.rdbKalori.CheckedChanged += new System.EventHandler(this.rdbKalori_CheckedChanged);
            // 
            // rdbHarcananKalori
            // 
            this.rdbHarcananKalori.AutoSize = true;
            this.rdbHarcananKalori.BackColor = System.Drawing.Color.Transparent;
            this.rdbHarcananKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbHarcananKalori.Location = new System.Drawing.Point(242, 439);
            this.rdbHarcananKalori.Name = "rdbHarcananKalori";
            this.rdbHarcananKalori.Size = new System.Drawing.Size(173, 29);
            this.rdbHarcananKalori.TabIndex = 1;
            this.rdbHarcananKalori.TabStop = true;
            this.rdbHarcananKalori.Text = "Harcanan Kalori";
            this.rdbHarcananKalori.UseVisualStyleBackColor = false;
            this.rdbHarcananKalori.CheckedChanged += new System.EventHandler(this.rdbHarcananKalori_CheckedChanged);
            // 
            // rdbKarbonhidrat
            // 
            this.rdbKarbonhidrat.AutoSize = true;
            this.rdbKarbonhidrat.BackColor = System.Drawing.Color.Transparent;
            this.rdbKarbonhidrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKarbonhidrat.Location = new System.Drawing.Point(430, 439);
            this.rdbKarbonhidrat.Name = "rdbKarbonhidrat";
            this.rdbKarbonhidrat.Size = new System.Drawing.Size(145, 29);
            this.rdbKarbonhidrat.TabIndex = 1;
            this.rdbKarbonhidrat.TabStop = true;
            this.rdbKarbonhidrat.Text = "Karbonhidrat";
            this.rdbKarbonhidrat.UseVisualStyleBackColor = false;
            this.rdbKarbonhidrat.CheckedChanged += new System.EventHandler(this.rdbKarbonhidrat_CheckedChanged);
            // 
            // rdbProtein
            // 
            this.rdbProtein.AutoSize = true;
            this.rdbProtein.BackColor = System.Drawing.Color.Transparent;
            this.rdbProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbProtein.Location = new System.Drawing.Point(581, 439);
            this.rdbProtein.Name = "rdbProtein";
            this.rdbProtein.Size = new System.Drawing.Size(94, 29);
            this.rdbProtein.TabIndex = 1;
            this.rdbProtein.TabStop = true;
            this.rdbProtein.Text = "Protein";
            this.rdbProtein.UseVisualStyleBackColor = false;
            this.rdbProtein.CheckedChanged += new System.EventHandler(this.rdbProtein_CheckedChanged);
            // 
            // rdbYag
            // 
            this.rdbYag.AutoSize = true;
            this.rdbYag.BackColor = System.Drawing.Color.Transparent;
            this.rdbYag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbYag.Location = new System.Drawing.Point(681, 439);
            this.rdbYag.Name = "rdbYag";
            this.rdbYag.Size = new System.Drawing.Size(68, 29);
            this.rdbYag.TabIndex = 1;
            this.rdbYag.TabStop = true;
            this.rdbYag.Text = "Yağ";
            this.rdbYag.UseVisualStyleBackColor = false;
            this.rdbYag.CheckedChanged += new System.EventHandler(this.rdbYag_CheckedChanged);
            // 
            // rdbNetKalori
            // 
            this.rdbNetKalori.AutoSize = true;
            this.rdbNetKalori.BackColor = System.Drawing.Color.Transparent;
            this.rdbNetKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbNetKalori.Location = new System.Drawing.Point(785, 439);
            this.rdbNetKalori.Name = "rdbNetKalori";
            this.rdbNetKalori.Size = new System.Drawing.Size(118, 29);
            this.rdbNetKalori.TabIndex = 2;
            this.rdbNetKalori.TabStop = true;
            this.rdbNetKalori.Text = "Net Kalori";
            this.rdbNetKalori.UseVisualStyleBackColor = false;
            this.rdbNetKalori.CheckedChanged += new System.EventHandler(this.rdbNetKalori_CheckedChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundImage = global::Diyet_Programi_Querry.Properties.Resources.undo_FILL0_wght400_GRAD0_opsz48;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(3, 462);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(85, 52);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // GenelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diyet_Programi_Querry.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rdbNetKalori);
            this.Controls.Add(this.rdbYag);
            this.Controls.Add(this.rdbProtein);
            this.Controls.Add(this.rdbKarbonhidrat);
            this.Controls.Add(this.rdbHarcananKalori);
            this.Controls.Add(this.rdbKalori);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "GenelRapor";
            this.Text = "GenelRapor";
            this.Load += new System.EventHandler(this.GenelRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rdbKalori;
        private System.Windows.Forms.RadioButton rdbHarcananKalori;
        private System.Windows.Forms.RadioButton rdbKarbonhidrat;
        private System.Windows.Forms.RadioButton rdbProtein;
        private System.Windows.Forms.RadioButton rdbYag;
        private System.Windows.Forms.RadioButton rdbNetKalori;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}