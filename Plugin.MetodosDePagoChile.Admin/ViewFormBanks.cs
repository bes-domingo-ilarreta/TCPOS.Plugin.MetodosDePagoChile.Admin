using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCPOS.Admin.Components;
using TCPOS.Translation;

namespace Plugin.MetodosDePagoChile.Admin
{
    public partial class ViewFormBanks : FormBase
    {
        public ViewFormBanks()
        {
            InitializeComponent();
            this.Text = Trl.T("Banks");
            this.MenuText = Trl.T("Banks");
            this.RibbonPageGroupName = Trl.T("Settlements");
            this.RibbonPageName = Trl.T("Sale items");
            lbldescription.Text = Trl.T("Description");
            status.Text = Trl.T("Disabled");
        }

        private void grdSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
