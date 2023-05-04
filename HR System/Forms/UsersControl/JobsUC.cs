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
    public partial class JobsUC : UserControl
    {
        private static JobsUC _instance;

        private JobsUC()
        {
            InitializeComponent();
        }

        public static JobsUC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new JobsUC();
            }
            return _instance;
        }
    }
}
