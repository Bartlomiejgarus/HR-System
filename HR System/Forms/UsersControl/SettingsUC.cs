using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System.Forms.UsersControl
{
    public partial class SettingsUC : UserControl
    {
        private static SettingsUC _instance;

        private SettingsUC()
        {
            InitializeComponent();
        }

        public static SettingsUC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SettingsUC();
            }
            return _instance;
        }
    }
}
