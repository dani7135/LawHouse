namespace GUI
{
    partial class Overblik
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.SagsNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Arbejdstitel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StartDato = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SlutDato = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Kørselstimer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TimeEstimat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SagsBeskrivelse = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InterneNoter = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.KlientNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.MedarbejderNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_slet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.SagsNr);
            this.objectListView1.AllColumns.Add(this.Arbejdstitel);
            this.objectListView1.AllColumns.Add(this.StartDato);
            this.objectListView1.AllColumns.Add(this.SlutDato);
            this.objectListView1.AllColumns.Add(this.Kørselstimer);
            this.objectListView1.AllColumns.Add(this.TimeEstimat);
            this.objectListView1.AllColumns.Add(this.SagsBeskrivelse);
            this.objectListView1.AllColumns.Add(this.InterneNoter);
            this.objectListView1.AllColumns.Add(this.KlientNr);
            this.objectListView1.AllColumns.Add(this.MedarbejderNr);
            this.objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SagsNr,
            this.Arbejdstitel,
            this.StartDato,
            this.SlutDato,
            this.Kørselstimer,
            this.TimeEstimat,
            this.SagsBeskrivelse,
            this.InterneNoter,
            this.KlientNr,
            this.MedarbejderNr});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.Location = new System.Drawing.Point(44, 77);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowImagesOnSubItems = true;
            this.objectListView1.Size = new System.Drawing.Size(912, 348);
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // SagsNr
            // 
            this.SagsNr.AspectName = "SagsNr";
            this.SagsNr.Text = "SagsNr";
            // 
            // Arbejdstitel
            // 
            this.Arbejdstitel.AspectName = "Arbejdstitel";
            this.Arbejdstitel.Text = "Arbejdstitel";
            // 
            // StartDato
            // 
            this.StartDato.AspectName = "StartDato";
            this.StartDato.Text = "StartDato";
            // 
            // SlutDato
            // 
            this.SlutDato.AspectName = "SlutDato";
            this.SlutDato.Text = "SlutDato";
            // 
            // Kørselstimer
            // 
            this.Kørselstimer.AspectName = "Kørselstimer";
            this.Kørselstimer.Text = "Kørselstimer";
            // 
            // TimeEstimat
            // 
            this.TimeEstimat.AspectName = "TimeEstimat";
            this.TimeEstimat.Text = "TimeEstimat";
            // 
            // SagsBeskrivelse
            // 
            this.SagsBeskrivelse.AspectName = "SagsBeskrivelse";
            this.SagsBeskrivelse.Text = "SagsBeskrivelse";
            // 
            // InterneNoter
            // 
            this.InterneNoter.AspectName = "InterneNoter";
            this.InterneNoter.Text = "InterneNoter";
            // 
            // KlientNr
            // 
            this.KlientNr.AspectName = "KlientNr";
            this.KlientNr.Text = "KlientNr";
            // 
            // MedarbejderNr
            // 
            this.MedarbejderNr.AspectName = "AdvokatId";
            this.MedarbejderNr.Text = "MedarbejderNr";
            this.MedarbejderNr.Width = 107;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(44, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(124, 25);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Opdater sag";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_slet
            // 
            this.btn_slet.Location = new System.Drawing.Point(44, 48);
            this.btn_slet.Name = "btn_slet";
            this.btn_slet.Size = new System.Drawing.Size(124, 23);
            this.btn_slet.TabIndex = 2;
            this.btn_slet.Text = "Slet sag";
            this.btn_slet.UseVisualStyleBackColor = true;
            // 
            // Overblik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.btn_slet);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.objectListView1);
            this.Name = "Overblik";
            this.Text = "Overblik";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn SagsNr;
        private BrightIdeasSoftware.OLVColumn Arbejdstitel;
        private BrightIdeasSoftware.OLVColumn StartDato;
        private BrightIdeasSoftware.OLVColumn SlutDato;
        private BrightIdeasSoftware.OLVColumn Kørselstimer;
        private BrightIdeasSoftware.OLVColumn TimeEstimat;
        private BrightIdeasSoftware.OLVColumn SagsBeskrivelse;
        private BrightIdeasSoftware.OLVColumn InterneNoter;
        private BrightIdeasSoftware.OLVColumn KlientNr;
        private BrightIdeasSoftware.OLVColumn MedarbejderNr;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_slet;
    }
}