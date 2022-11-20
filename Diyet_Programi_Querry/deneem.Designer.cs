namespace Diyet_Programi_Querry
{
    partial class deneem
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
            this.trackBarEdit1 = new ReaLTaiizor.Controls.TrackBarEdit();
            this.lostSeparator1 = new ReaLTaiizor.Controls.LostSeparator();
            this.SuspendLayout();
            // 
            // trackBarEdit1
            // 
            this.trackBarEdit1.DrawHatch = true;
            this.trackBarEdit1.DrawValueString = false;
            this.trackBarEdit1.JumpToMouse = false;
            this.trackBarEdit1.Location = new System.Drawing.Point(536, 47);
            this.trackBarEdit1.Maximum = 10;
            this.trackBarEdit1.Minimum = 0;
            this.trackBarEdit1.MinimumSize = new System.Drawing.Size(37, 22);
            this.trackBarEdit1.Name = "trackBarEdit1";
            this.trackBarEdit1.Size = new System.Drawing.Size(165, 22);
            this.trackBarEdit1.TabIndex = 0;
            this.trackBarEdit1.Text = "trackBarEdit1";
            this.trackBarEdit1.Value = 0;
            this.trackBarEdit1.ValueColour = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackBarEdit1.ValueDivison = ReaLTaiizor.Controls.TrackBarEdit.ValueDivisor.By1;
            this.trackBarEdit1.ValueToSet = 0F;
            this.trackBarEdit1.ValueChanged += new ReaLTaiizor.Controls.TrackBarEdit.ValueChangedEventHandler(this.trackBarEdit1_ValueChanged);
            // 
            // lostSeparator1
            // 
            this.lostSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostSeparator1.Horizontal = false;
            this.lostSeparator1.Location = new System.Drawing.Point(315, 173);
            this.lostSeparator1.Name = "lostSeparator1";
            this.lostSeparator1.Size = new System.Drawing.Size(322, 131);
            this.lostSeparator1.TabIndex = 1;
            this.lostSeparator1.Text = "lostSeparator1";
            // 
            // deneem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lostSeparator1);
            this.Controls.Add(this.trackBarEdit1);
            this.Name = "deneem";
            this.Text = "deneem";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.TrackBarEdit trackBarEdit1;
        private ReaLTaiizor.Controls.LostSeparator lostSeparator1;
    }
}