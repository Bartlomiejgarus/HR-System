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
    public partial class EmployeesUC : UserControl
    {
        private static EmployeesUC _instance;

        private EmployeesUC()
        {
            InitializeComponent();
        }

        public static EmployeesUC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EmployeesUC();
            }
            return _instance;
        }
    }
}
