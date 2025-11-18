namespace Huisarts_app
{
    partial class FormPatiënten
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
            this.GroupPatiënten = new System.Windows.Forms.GroupBox();
            this.FlpPatiënten = new System.Windows.Forms.FlowLayoutPanel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GroupPatiënten.SuspendLayout();
            this.FlpPatiënten.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPatiënten
            // 
            this.GroupPatiënten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupPatiënten.Controls.Add(this.FlpPatiënten);
            this.GroupPatiënten.Location = new System.Drawing.Point(2, 2);
            this.GroupPatiënten.Name = "GroupPatiënten";
            this.GroupPatiënten.Size = new System.Drawing.Size(794, 409);
            this.GroupPatiënten.TabIndex = 0;
            this.GroupPatiënten.TabStop = false;
            this.GroupPatiënten.Text = "patiënten";
            // 
            // FlpPatiënten
            // 
            this.FlpPatiënten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpPatiënten.Controls.Add(this.domainUpDown1);
            this.FlpPatiënten.Location = new System.Drawing.Point(6, 21);
            this.FlpPatiënten.Name = "FlpPatiënten";
            this.FlpPatiënten.Size = new System.Drawing.Size(780, 382);
            this.FlpPatiënten.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(3, 3);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(658, 415);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(129, 32);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Patiënt toevoegen";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPatiënten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GroupPatiënten);
            this.Name = "FormPatiënten";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Patiënten";
            this.GroupPatiënten.ResumeLayout(false);
            this.FlpPatiënten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPatiënten;
        private System.Windows.Forms.FlowLayoutPanel FlpPatiënten;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button BtnAdd;
    }
}

