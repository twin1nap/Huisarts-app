namespace Huisarts_app
{
    partial class patiënten
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNaam = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblNotesCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Location = new System.Drawing.Point(4, 4);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(62, 16);
            this.LblNaam.TabIndex = 0;
            this.LblNaam.Text = "Naam: ---";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(3, 20);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(61, 16);
            this.LblAdres.TabIndex = 1;
            this.LblAdres.Text = "Adres: ---";
            // 
            // LblNotesCount
            // 
            this.LblNotesCount.Location = new System.Drawing.Point(6, 156);
            this.LblNotesCount.Name = "LblNotesCount";
            this.LblNotesCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblNotesCount.Size = new System.Drawing.Size(682, 25);
            this.LblNotesCount.TabIndex = 2;
            this.LblNotesCount.Text = "Aantal notities: 0";
            this.LblNotesCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // patiënten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.LblNotesCount);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.LblNaam);
            this.MaximumSize = new System.Drawing.Size(0, 181);
            this.Name = "patiënten";
            this.Size = new System.Drawing.Size(691, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNaam;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblNotesCount;
    }
}
