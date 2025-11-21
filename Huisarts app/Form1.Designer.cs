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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.TbZoek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupPatiënten.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPatiënten
            // 
            this.GroupPatiënten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupPatiënten.Controls.Add(this.label1);
            this.GroupPatiënten.Controls.Add(this.TbZoek);
            this.GroupPatiënten.Controls.Add(this.BtnReload);
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
            this.FlpPatiënten.AutoScroll = true;
            this.FlpPatiënten.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpPatiënten.Location = new System.Drawing.Point(6, 50);
            this.FlpPatiënten.Name = "FlpPatiënten";
            this.FlpPatiënten.Size = new System.Drawing.Size(780, 353);
            this.FlpPatiënten.TabIndex = 0;
            this.FlpPatiënten.WrapContents = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(626, 415);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 32);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Patiënt toevoegen";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReload.Location = new System.Drawing.Point(672, 10);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(114, 34);
            this.BtnReload.TabIndex = 2;
            this.BtnReload.Text = "refresh patiënts";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // TbZoek
            // 
            this.TbZoek.Location = new System.Drawing.Point(67, 21);
            this.TbZoek.Name = "TbZoek";
            this.TbZoek.Size = new System.Drawing.Size(326, 22);
            this.TbZoek.TabIndex = 3;
            this.TbZoek.TextChanged += new System.EventHandler(this.TbZoek_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "zoeken:";
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
            this.Load += new System.EventHandler(this.FormPatiënten_Load);
            this.GroupPatiënten.ResumeLayout(false);
            this.GroupPatiënten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPatiënten;
        private System.Windows.Forms.FlowLayoutPanel FlpPatiënten;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.TextBox TbZoek;
        private System.Windows.Forms.Label label1;
    }
}

