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
    public partial class SalaryUC : UserControl
    {
        private static SalaryUC _instance;

        private SalaryUC()
        {
            InitializeComponent();
        }

        public static SalaryUC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SalaryUC();
            }
            return _instance;
        }
    }
}
