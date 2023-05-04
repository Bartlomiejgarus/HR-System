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
    public partial class ResumesUC : UserControl
    {
        private static ResumesUC _instance;

        private ResumesUC()
        {
            InitializeComponent();
        }

        public static ResumesUC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ResumesUC();
            }
            return _instance;
        }
    }
}
