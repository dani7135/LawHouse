﻿namespace GUI
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
            this.txt2_AdvokatId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_CreateAdvokat
            // 
            this.btn_CreateAdvokat.Location = new System.Drawing.Point(12, 21);
            this.btn_CreateAdvokat.Name = "btn_CreateAdvokat";
            this.btn_CreateAdvokat.Size = new System.Drawing.Size(139, 71);
            this.btn_CreateAdvokat.TabIndex = 0;
            this.btn_CreateAdvokat.Text = "Opret Advokat";
            this.btn_CreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_CreateAdvokat.Click += new System.EventHandler(this.btn_CreateAdvokat_Click);
            // 
            // btn_AddSpecialToAdvokat
            // 
            this.btn_AddSpecialToAdvokat.Location = new System.Drawing.Point(18, 195);
            this.btn_AddSpecialToAdvokat.Name = "btn_AddSpecialToAdvokat";
            this.btn_AddSpecialToAdvokat.Size = new System.Drawing.Size(133, 76);
            this.btn_AddSpecialToAdvokat.TabIndex = 1;
            this.btn_AddSpecialToAdvokat.Text = "Tilføj Speciale";
            this.btn_AddSpecialToAdvokat.UseVisualStyleBackColor = true;
            this.btn_AddSpecialToAdvokat.Click += new System.EventHandler(this.btn_AddSpecialToAdvokat_Click);
            // 
            // txt_AdvokatNavn
            // 
            this.txt_AdvokatNavn.Location = new System.Drawing.Point(277, 46);
            this.txt_AdvokatNavn.Name = "txt_AdvokatNavn";
            this.txt_AdvokatNavn.Size = new System.Drawing.Size(100, 22);
            this.txt_AdvokatNavn.TabIndex = 2;
            // 
            // label_AdvokatNavn
            // 
            this.label_AdvokatNavn.AutoSize = true;
            this.label_AdvokatNavn.Location = new System.Drawing.Point(171, 49);
            this.label_AdvokatNavn.Name = "label_AdvokatNavn";
            this.label_AdvokatNavn.Size = new System.Drawing.Size(100, 17);
            this.label_AdvokatNavn.TabIndex = 3;
            this.label_AdvokatNavn.Text = "Advokat Navn:";
            // 
            // Label_AdvokatId
            // 
            this.Label_AdvokatId.AutoSize = true;
            this.Label_AdvokatId.Location = new System.Drawing.Point(199, 195);
            this.Label_AdvokatId.Name = "Label_AdvokatId";
            this.Label_AdvokatId.Size = new System.Drawing.Size(78, 17);
            this.Label_AdvokatId.TabIndex = 4;
            this.Label_AdvokatId.Text = "Advokat Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speciale Navn:";
            // 
            // txt_AdvokatId
            // 
            this.txt_AdvokatId.Location = new System.Drawing.Point(283, 195);
            this.txt_AdvokatId.Name = "txt_AdvokatId";
            this.txt_AdvokatId.Size = new System.Drawing.Size(100, 22);
            this.txt_AdvokatId.TabIndex = 6;
            // 
            // txt_SpecialeNavn
            // 
            this.txt_SpecialeNavn.Location = new System.Drawing.Point(283, 235);
            this.txt_SpecialeNavn.Name = "txt_SpecialeNavn";
            this.txt_SpecialeNavn.Size = new System.Drawing.Size(100, 22);
            this.txt_SpecialeNavn.TabIndex = 7;
            // 
            // txt2_AdvokatId
            // 
            this.txt2_AdvokatId.Location = new System.Drawing.Point(277, 21);
            this.txt2_AdvokatId.Name = "txt2_AdvokatId";
            this.txt2_AdvokatId.Size = new System.Drawing.Size(100, 22);
            this.txt2_AdvokatId.TabIndex = 8;
            // 
            // CreateAdvokatTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 314);
            this.Controls.Add(this.txt2_AdvokatId);
            this.Controls.Add(this.txt_SpecialeNavn);
            this.Controls.Add(this.txt_AdvokatId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_AdvokatId);
            this.Controls.Add(this.label_AdvokatNavn);
            this.Controls.Add(this.txt_AdvokatNavn);
            this.Controls.Add(this.btn_AddSpecialToAdvokat);
            this.Controls.Add(this.btn_CreateAdvokat);
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
        private System.Windows.Forms.TextBox txt2_AdvokatId;
    }
}