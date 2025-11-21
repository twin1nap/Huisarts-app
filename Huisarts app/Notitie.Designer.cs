namespace Huisarts_app
{
    partial class Notitie
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblUpdate = new System.Windows.Forms.Label();
            this.TbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(662, 202);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(113, 34);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "opslaan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblUpdate
            // 
            this.LblUpdate.Location = new System.Drawing.Point(405, 3);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(370, 30);
            this.LblUpdate.TabIndex = 8;
            this.LblUpdate.Text = "laatste update: ----";
            this.LblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbNote
            // 
            this.TbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNote.Location = new System.Drawing.Point(3, 36);
            this.TbNote.Multiline = true;
            this.TbNote.Name = "TbNote";
            this.TbNote.Size = new System.Drawing.Size(772, 160);
            this.TbNote.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titel:";
            // 
            // TbTitle
            // 
            this.TbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitle.Location = new System.Drawing.Point(55, 5);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(344, 28);
            this.TbTitle.TabIndex = 5;
            // 
            // Notitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblUpdate);
            this.Controls.Add(this.TbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbTitle);
            this.Name = "Notitie";
            this.Size = new System.Drawing.Size(784, 244);
            this.Load += new System.EventHandler(this.Notitie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblUpdate;
        private System.Windows.Forms.TextBox TbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTitle;
    }
}
