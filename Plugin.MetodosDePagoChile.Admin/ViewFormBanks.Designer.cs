namespace Plugin.MetodosDePagoChile.Admin
{
    partial class ViewFormBanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFormBanks));
            this.status = new TCPOS.Admin.Components.DbCheckEdit();
            this.description = new TCPOS.Admin.Components.DbTextEdit();
            this.lbldescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.status);
            this.pnlControls.Controls.Add(this.description);
            this.pnlControls.Controls.Add(this.lbldescription);
            // 
            // dbController
            // 
            this.dbController.DbTableName = "BES_BANKS";
            this.dbController.SearchColumnNames = new string[] {
        "Description"};
            this.dbController.SearchStatement = new string[] {
        "SELECT id,description",
        "from bes_banks",
        "order by id"};
            // 
            // status
            // 
            this.status.DbController = this.dbController;
            this.status.DbFieldName = "STATUS";
            this.status.DefaultValue = true;
            this.status.Location = new System.Drawing.Point(373, 35);
            this.status.Name = "status";
            this.status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.status.Properties.Appearance.Options.UseBackColor = true;
            this.status.Properties.Appearance.Options.UseFont = true;
            this.status.Properties.Caption = "Disabled";
            this.status.SearchMode = TCPOS.Admin.Components.DbSearchMode.Equal;
            this.status.Size = new System.Drawing.Size(157, 19);
            this.status.TabIndex = 26;
            // 
            // description
            // 
            this.description.DbController = this.dbController;
            this.description.DbFieldName = "DESCRIPTION";
            this.description.Label = this.lbldescription;
            this.description.Location = new System.Drawing.Point(161, 34);
            this.description.Name = "description";
            this.description.SearchMode = TCPOS.Admin.Components.DbSearchMode.Like;
            this.description.Size = new System.Drawing.Size(206, 20);
            this.description.TabIndex = 24;
            // 
            // lbldescription
            // 
            this.lbldescription.BackColor = System.Drawing.Color.Transparent;
            this.lbldescription.Location = new System.Drawing.Point(46, 33);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(106, 20);
            this.lbldescription.TabIndex = 25;
            this.lbldescription.Text = "Description";
            this.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewFormBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 601);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MenuText = "Banks";
            this.Name = "ViewFormBanks";
            this.RibbonBigButton = true;
            this.RibbonPageGroupName = "Settlements";
            this.RibbonPageName = "Sale items";
            this.Text = "Banks";
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected TCPOS.Admin.Components.DbCheckEdit status;
        protected TCPOS.Admin.Components.DbTextEdit description;
        protected System.Windows.Forms.Label lbldescription;
    }
}