namespace Plugin.MetodosDePagoChile.Admin
{
    partial class InjectTabTransbankTillsForm
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
            this.xtraChileTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabTransbank = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraChileTabControl1)).BeginInit();
            this.xtraChileTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.xtraChileTabControl1);
            // 
            // xtraChileTabControl1
            // 
            this.xtraChileTabControl1.Location = new System.Drawing.Point(9, 12);
            this.xtraChileTabControl1.Name = "xtraChileTabControl1";
            this.xtraChileTabControl1.SelectedTabPage = this.TabTransbank;
            this.xtraChileTabControl1.Size = new System.Drawing.Size(759, 577);
            this.xtraChileTabControl1.TabIndex = 33;
            this.xtraChileTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabTransbank});
            // 
            // TabTransbank
            // 
            this.TabTransbank.Name = "TabTransbank";
            this.TabTransbank.Size = new System.Drawing.Size(753, 549);
            this.TabTransbank.Text = "Transbank";
            // 
            // InjectTabTransbankTillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 601);
            this.Name = "InjectTabTransbankTillsForm";
            this.Text = "InjectTabTransbankTillsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraChileTabControl1)).EndInit();
            this.xtraChileTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraChileTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabTransbank;

    }
}