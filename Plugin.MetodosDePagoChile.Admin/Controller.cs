using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCPOS.Admin.Plugins;
using TCPOS.Admin;
using TCPOS.Admin.Components;
using TCPOS.Translation;

namespace Plugin.MetodosDePagoChile.Admin
{
    public class Controller : IPlugin
    {
        //private TillsForm tillsForm;
        public bool Register(PluginManager PM, MainForm mainForm)
        {
            PM.OnPermissionsDefined += PM_OnPermissionsDefined;
            PM.OnFormBaseInitialized += PM_OnFormBaseInitialized;
            PM.OnKeyboardDefined += PM_OnKeyboardDefined;
            return false;
        }
        private ViewFormBanks AdminFormBesBanks = new ViewFormBanks();
        //private DbTextEdit description;

        void PM_OnFormBaseInitialized(FormBase form)
        {
            if (form is ViewFormBanks) { /*TCPOSMessageBox.Show("Hello World");*/   }            
            if (form is TillsForm)
            {
                /* POSTRANSBANK PortName=COM3 BaudRate=115200 DataBits=8 RtsEnable=true DtrEnable=true ReadTimeout=150000 WriteTimeout=2000 Parity=None StopBits=One Handshake=None */
                //tillsForm = form as TillsForm;
                //FormBase.InjectControl<InjectTabTransbankTillsForm>("TabTransbank", tillsForm, "tabControl");
                //TCPOSMessageBox.Show("HW");
            }
        }               

        void PM_OnPermissionsDefined()
        {
            TCPOS.Admin.Admin.AddAdminPermission(typeof(ViewFormBanks).Name, "ViewFormBanks", true);
            //TCPOS.Admin.Admin.AddAdminPermission(typeof(ViewFormTills).Name, "ViewFormTills", true);
        }

        void PM_OnKeyboardDefined(TCPOS.Admin.ParametersList keyParameters)
        {
            CodeDescriptionList TransbankKeys = new CodeDescriptionList();
            TransbankKeys.Add(new CodeDescription(0, Trl.T("Venta - Débito / Crédito")));
            TransbankKeys.Add(new CodeDescription(1, Trl.T("Anulación - Débito / Crédito")));
            TransbankKeys.Add(new CodeDescription(2, Trl.T("Última Venta")));
            TransbankKeys.Add(new CodeDescription(3, Trl.T("Totales")));
            TransbankKeys.Add(new CodeDescription(4, Trl.T("Cierre")));
            TransbankKeys.Add(new CodeDescription(5, Trl.T("Carga Llave")));
            TransbankKeys.Add(new CodeDescription(6, Trl.T("Pooling")));
            TransbankKeys.Add(new CodeDescription(7, Trl.T("Cambio a Modo Manual")));
            TransbankKeys.Add(new CodeDescription(8, Trl.T("Detalle Venta")));
            TransbankKeys.Add(new CodeDescription(9, Trl.T("Detalle Venta desde Terminal")));
            keyParameters.Add(new KeyType("BES Consulting", 88880, Trl.T("Transbank Buttons"), null, null, TransbankKeys));
        }
    }
}
