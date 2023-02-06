namespace Inlämningsuppgift_3_Skiss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxPersonnr = new System.Windows.Forms.TextBox();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblPersonnr = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.lblVälkommen = new System.Windows.Forms.Label();
            this.lblAnge = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lbxVälj = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(394, 368);
            this.tbxEfternamn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(210, 43);
            this.tbxEfternamn.TabIndex = 1;
            this.tbxEfternamn.TextChanged += new System.EventHandler(this.tbxEfternamn_TextChanged);
            // 
            // tbxPersonnr
            // 
            this.tbxPersonnr.Location = new System.Drawing.Point(394, 482);
            this.tbxPersonnr.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbxPersonnr.Name = "tbxPersonnr";
            this.tbxPersonnr.Size = new System.Drawing.Size(210, 43);
            this.tbxPersonnr.TabIndex = 2;
            this.tbxPersonnr.TextChanged += new System.EventHandler(this.tbxPersonnr_TextChanged);
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(251, 252);
            this.lblFörnamn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(128, 37);
            this.lblFörnamn.TabIndex = 3;
            this.lblFörnamn.Text = "Förnamn:";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(236, 375);
            this.lblEfternamn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(144, 37);
            this.lblEfternamn.TabIndex = 4;
            this.lblEfternamn.Text = "Efternamn:";
            // 
            // lblPersonnr
            // 
            this.lblPersonnr.AutoSize = true;
            this.lblPersonnr.Location = new System.Drawing.Point(259, 488);
            this.lblPersonnr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonnr.Name = "lblPersonnr";
            this.lblPersonnr.Size = new System.Drawing.Size(126, 37);
            this.lblPersonnr.TabIndex = 5;
            this.lblPersonnr.Text = "Personnr:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(699, 468);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 57);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Location = new System.Drawing.Point(699, 548);
            this.btnAvsluta.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(161, 57);
            this.btnAvsluta.TabIndex = 7;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(176, 619);
            this.tbxResultat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(662, 416);
            this.tbxResultat.TabIndex = 8;
            // 
            // lblVälkommen
            // 
            this.lblVälkommen.AutoSize = true;
            this.lblVälkommen.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblVälkommen.ForeColor = System.Drawing.Color.Red;
            this.lblVälkommen.Location = new System.Drawing.Point(341, 22);
            this.lblVälkommen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVälkommen.Name = "lblVälkommen";
            this.lblVälkommen.Size = new System.Drawing.Size(366, 64);
            this.lblVälkommen.TabIndex = 9;
            this.lblVälkommen.Text = "VÄLKOMMEN!";
            // 
            // lblAnge
            // 
            this.lblAnge.AutoSize = true;
            this.lblAnge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnge.Location = new System.Drawing.Point(341, 143);
            this.lblAnge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnge.Name = "lblAnge";
            this.lblAnge.Size = new System.Drawing.Size(564, 48);
            this.lblAnge.TabIndex = 10;
            this.lblAnge.Text = "Ange namn och personnummer:";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(394, 244);
            this.tbxFörnamn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(210, 43);
            this.tbxFörnamn.TabIndex = 11;
            this.tbxFörnamn.TextChanged += new System.EventHandler(this.tbxFörnamn_TextChanged);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResultat.Location = new System.Drawing.Point(176, 565);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(204, 43);
            this.lblResultat.TabIndex = 12;
            this.lblResultat.Text = "RESULTAT:";
            // 
            // lbxVälj
            // 
            this.lbxVälj.FormattingEnabled = true;
            this.lbxVälj.ItemHeight = 37;
            this.lbxVälj.Items.AddRange(new object[] {
            "Registrera",
            "Avsluta"});
            this.lbxVälj.Location = new System.Drawing.Point(699, 328);
            this.lbxVälj.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbxVälj.Name = "lbxVälj";
            this.lbxVälj.Size = new System.Drawing.Size(154, 78);
            this.lbxVälj.TabIndex = 13;
            this.lbxVälj.SelectedIndexChanged += new System.EventHandler(this.lbxVälj_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 1127);
            this.Controls.Add(this.lbxVälj);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.lblAnge);
            this.Controls.Add(this.lblVälkommen);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPersonnr);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblFörnamn);
            this.Controls.Add(this.tbxPersonnr);
            this.Controls.Add(this.tbxEfternamn);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxFörnamn;
        private TextBox tbxEfternamn;
        private TextBox tbxPersonnr;
        private Label lblFörnamn;
        private Label lblEfternamn;
        private Label lblPersonnr;
        private Button btnOK;
        private Button btnAvsluta;
        private TextBox tbxResultat;
        private Label lblVälkommen;
        private Label lblAnge;
        private Label lblResultat;
        private ListBox lbxVälj;
    }
}