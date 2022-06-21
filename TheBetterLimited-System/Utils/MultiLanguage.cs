using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.Utils
{
    internal class MultiLanguage
    {
        public static string DefaultLanguage = "en-US";

        public static void SetDefaultLanguage(string lang)
        {
            DefaultLanguage = lang;
            Properties.Settings.Default.DefaultLanguage = lang;
            Properties.Settings.Default.Save();
        }

        public static void LoadLanguage(Form form, Type formType)
        {
            if (form != null)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(formType);
                resources.ApplyResources(form, "$this");
                Loading(form, resources);
            }
        }
        private static void Loading(Control control, System.ComponentModel.ComponentResourceManager resources)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Name == "txtUsername" || c.Name == "txtJobTitle") continue;
                resources.ApplyResources(c, c.Name);
                Loading(c, resources);
            }
        }
    }
}
