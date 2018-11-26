namespace GUI
{
    partial class CreateAdvokatTester
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
            this.btn_CreateAdvokat = new System.Windows.Forms.Button();
            this.btn_AddSpecialToAdvokat = new System.Windows.Forms.Button();
            this.txt_AdvokatNavn = new System.Windows.Forms.TextBox();
            this.label_AdvokatNavn = new System.Windows.Forms.Label();
            this.Label_AdvokatId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdvokatId = new System.Windows.Forms.TextBox();
            this.txt_SpecialeNavn = new System.Windows.Forms.TextBox();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateAdvokat
            // 
            this.btn_CreateAdvokat.Location = new System.Drawing.Point(9, 17);
            this.btn_CreateAdvokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateAdvokat.Name = "btn_CreateAdvokat";
            this.btn_CreateAdvokat.Size = new System.Drawing.Size(104, 58);
            this.btn_CreateAdvokat.TabIndex = 0;
            this.btn_CreateAdvokat.Text = "Opret Advokat";
            this.btn_CreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_CreateAdvokat.Click += new System.EventHandler(this.btn_CreateAdvokat_Click);
            // 
            // btn_AddSpecialToAdvokat
            // 
            this.btn_AddSpecialToAdvokat.Location = new System.Drawing.Point(14, 158);
            this.btn_AddSpecialToAdvokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddSpecialToAdvokat.Name = "btn_AddSpecialToAdvokat";
            this.btn_AddSpecialToAdvokat.Size = new System.Drawing.Size(100, 62);
            this.btn_AddSpecialToAdvokat.TabIndex = 1;
            this.btn_AddSpecialToAdvokat.Text = "Tilføj Speciale";
            this.btn_AddSpecialToAdvokat.UseVisualStyleBackColor = true;
            this.btn_AddSpecialToAdvokat.Click += new System.EventHandler(this.btn_AddSpecialToAdvokat_Click);
            // 
            // txt_AdvokatNavn
            // 
            this.txt_AdvokatNavn.Location = new System.Drawing.Point(208, 37);
            this.txt_AdvokatNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AdvokatNavn.Name = "txt_AdvokatNavn";
            this.txt_AdvokatNavn.Size = new System.Drawing.Size(76, 20);
            this.txt_AdvokatNavn.TabIndex = 2;
            // 
            // label_AdvokatNavn
            // 
            this.label_AdvokatNavn.AutoSize = true;
            this.label_AdvokatNavn.Location = new System.Drawing.Point(128, 40);
            this.label_AdvokatNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AdvokatNavn.Name = "label_AdvokatNavn";
            this.label_AdvokatNavn.Size = new System.Drawing.Size(79, 13);
            this.label_AdvokatNavn.TabIndex = 3;
            this.label_AdvokatNavn.Text = "Advokat Navn:";
            // 
            // Label_AdvokatId
            // 
            this.Label_AdvokatId.AutoSize = true;
            this.Label_AdvokatId.Location = new System.Drawing.Point(149, 158);
            this.Label_AdvokatId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_AdvokatId.Name = "Label_AdvokatId";
            this.Label_AdvokatId.Size = new System.Drawing.Size(62, 13);
            this.Label_AdvokatId.TabIndex = 4;
            this.Label_AdvokatId.Text = "Advokat Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speciale Navn:";
            // 
            // txt_AdvokatId
            // 
            this.txt_AdvokatId.Location = new System.Drawing.Point(212, 158);
            this.txt_AdvokatId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AdvokatId.Name = "txt_AdvokatId";
            this.txt_AdvokatId.Size = new System.Drawing.Size(76, 20);
            this.txt_AdvokatId.TabIndex = 6;
            // 
            // txt_SpecialeNavn
            // 
            this.txt_SpecialeNavn.Location = new System.Drawing.Point(212, 191);
            this.txt_SpecialeNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SpecialeNavn.Name = "txt_SpecialeNavn";
            this.txt_SpecialeNavn.Size = new System.Drawing.Size(76, 20);
            this.txt_SpecialeNavn.TabIndex = 7;
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(9, 105);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(75, 23);
            this.Btn_Help.TabIndex = 8;
            this.Btn_Help.Text = "?";
            this.Btn_Help.UseVisualStyleBackColor = true;
            this.Btn_Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAdvokatTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 255);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.txt_SpecialeNavn);
            this.Controls.Add(this.txt_AdvokatId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_AdvokatId);
            this.Controls.Add(this.label_AdvokatNavn);
            this.Controls.Add(this.txt_AdvokatNavn);
            this.Controls.Add(this.btn_AddSpecialToAdvokat);
            this.Controls.Add(this.btn_CreateAdvokat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateAdvokatTester";
            this.Text = "CreateAdvokatTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateAdvokat;
        private System.Windows.Forms.Button btn_AddSpecialToAdvokat;
        private System.Windows.Forms.TextBox txt_AdvokatNavn;
        private System.Windows.Forms.Label label_AdvokatNavn;
        private System.Windows.Forms.Label Label_AdvokatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AdvokatId;
        private System.Windows.Forms.TextBox txt_SpecialeNavn;
        private System.Windows.Forms.Button Btn_Help;
    }
}