namespace Huisarts_app
{
    partial class PatiëntForm
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
            this.TbVoornaam = new System.Windows.Forms.TextBox();
            this.TbAchternaam = new System.Windows.Forms.TextBox();
            this.TbAdres = new System.Windows.Forms.TextBox();
            this.TbHuisnummer = new System.Windows.Forms.TextBox();
            this.TbPostcode = new System.Windows.Forms.TextBox();
            this.TbPlaats = new System.Windows.Forms.TextBox();
            this.TbTelefoonnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNoteMin = new System.Windows.Forms.Button();
            this.BtnNotePlus = new System.Windows.Forms.Button();
            this.LblAdd = new System.Windows.Forms.Label();
            this.notitieDisplay = new Huisarts_app.Notitie();
            this.NoteAdd = new Huisarts_app.Notitie();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbVoornaam
            // 
            this.TbVoornaam.Location = new System.Drawing.Point(12, 33);
            this.TbVoornaam.Name = "TbVoornaam";
            this.TbVoornaam.Size = new System.Drawing.Size(100, 22);
            this.TbVoornaam.TabIndex = 0;
            // 
            // TbAchternaam
            // 
            this.TbAchternaam.Location = new System.Drawing.Point(118, 33);
            this.TbAchternaam.Name = "TbAchternaam";
            this.TbAchternaam.Size = new System.Drawing.Size(100, 22);
            this.TbAchternaam.TabIndex = 1;
            // 
            // TbAdres
            // 
            this.TbAdres.Location = new System.Drawing.Point(225, 33);
            this.TbAdres.Name = "TbAdres";
            this.TbAdres.Size = new System.Drawing.Size(123, 22);
            this.TbAdres.TabIndex = 2;
            // 
            // TbHuisnummer
            // 
            this.TbHuisnummer.Location = new System.Drawing.Point(358, 33);
            this.TbHuisnummer.Name = "TbHuisnummer";
            this.TbHuisnummer.Size = new System.Drawing.Size(100, 22);
            this.TbHuisnummer.TabIndex = 3;
            // 
            // TbPostcode
            // 
            this.TbPostcode.Location = new System.Drawing.Point(464, 32);
            this.TbPostcode.Name = "TbPostcode";
            this.TbPostcode.Size = new System.Drawing.Size(100, 22);
            this.TbPostcode.TabIndex = 4;
            // 
            // TbPlaats
            // 
            this.TbPlaats.Location = new System.Drawing.Point(570, 33);
            this.TbPlaats.Name = "TbPlaats";
            this.TbPlaats.Size = new System.Drawing.Size(100, 22);
            this.TbPlaats.TabIndex = 5;
            // 
            // TbTelefoonnummer
            // 
            this.TbTelefoonnummer.Location = new System.Drawing.Point(676, 32);
            this.TbTelefoonnummer.Name = "TbTelefoonnummer";
            this.TbTelefoonnummer.Size = new System.Drawing.Size(132, 22);
            this.TbTelefoonnummer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Tag = "";
            this.label3.Text = "adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Huisnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "postcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "plaats:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefoonnummer:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(705, 73);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 38);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Opslaan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(562, 73);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(137, 38);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Verwijder patiënt";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnNoteMin);
            this.groupBox1.Controls.Add(this.BtnNotePlus);
            this.groupBox1.Controls.Add(this.notitieDisplay);
            this.groupBox1.Controls.Add(this.LblAdd);
            this.groupBox1.Controls.Add(this.NoteAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 584);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "notities";
            // 
            // BtnNoteMin
            // 
            this.BtnNoteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNoteMin.Location = new System.Drawing.Point(710, 17);
            this.BtnNoteMin.Name = "BtnNoteMin";
            this.BtnNoteMin.Size = new System.Drawing.Size(37, 35);
            this.BtnNoteMin.TabIndex = 12;
            this.BtnNoteMin.Tag = "min";
            this.BtnNoteMin.Text = "<";
            this.BtnNoteMin.UseVisualStyleBackColor = true;
            this.BtnNoteMin.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // BtnNotePlus
            // 
            this.BtnNotePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotePlus.Location = new System.Drawing.Point(753, 17);
            this.BtnNotePlus.Name = "BtnNotePlus";
            this.BtnNotePlus.Size = new System.Drawing.Size(37, 35);
            this.BtnNotePlus.TabIndex = 11;
            this.BtnNotePlus.Tag = "plus";
            this.BtnNotePlus.Text = ">";
            this.BtnNotePlus.UseVisualStyleBackColor = true;
            this.BtnNotePlus.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdd.Location = new System.Drawing.Point(7, 305);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(152, 22);
            this.LblAdd.TabIndex = 9;
            this.LblAdd.Text = "notitie toevoegen:";
            // 
            // notitieDisplay
            // 
            this.notitieDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notitieDisplay.id = null;
            this.notitieDisplay.Location = new System.Drawing.Point(11, 58);
            this.notitieDisplay.Name = "notitieDisplay";
            this.notitieDisplay.Size = new System.Drawing.Size(784, 244);
            this.notitieDisplay.TabIndex = 10;
            this.notitieDisplay.text = "";
            this.notitieDisplay.title = "";
            this.notitieDisplay.updateDate = new System.DateTime(2025, 11, 20, 13, 55, 58, 898);
            // 
            // NoteAdd
            // 
            this.NoteAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteAdd.id = null;
            this.NoteAdd.Location = new System.Drawing.Point(11, 334);
            this.NoteAdd.Name = "NoteAdd";
            this.NoteAdd.Size = new System.Drawing.Size(784, 244);
            this.NoteAdd.TabIndex = 8;
            this.NoteAdd.text = "";
            this.NoteAdd.title = "";
            this.NoteAdd.updateDate = new System.DateTime(2025, 11, 20, 13, 55, 58, 910);
            // 
            // PatiëntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbTelefoonnummer);
            this.Controls.Add(this.TbPlaats);
            this.Controls.Add(this.TbPostcode);
            this.Controls.Add(this.TbHuisnummer);
            this.Controls.Add(this.TbAdres);
            this.Controls.Add(this.TbAchternaam);
            this.Controls.Add(this.TbVoornaam);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(843, 800);
            this.MinimumSize = new System.Drawing.Size(843, 570);
            this.Name = "PatiëntForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PatiëntForm";
            this.Load += new System.EventHandler(this.PatiëntForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbVoornaam;
        private System.Windows.Forms.TextBox TbAchternaam;
        private System.Windows.Forms.TextBox TbAdres;
        private System.Windows.Forms.TextBox TbHuisnummer;
        private System.Windows.Forms.TextBox TbPostcode;
        private System.Windows.Forms.TextBox TbPlaats;
        private System.Windows.Forms.TextBox TbTelefoonnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdd;
        private Notitie NoteAdd;
        private System.Windows.Forms.Button BtnNoteMin;
        private System.Windows.Forms.Button BtnNotePlus;
        private Notitie notitieDisplay;
    }
}