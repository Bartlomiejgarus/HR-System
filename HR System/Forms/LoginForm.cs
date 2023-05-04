using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string password => passwordTextBox.Text;

        private string login => loginTextBox.Text;


        private void loginButton_Click(object sender, EventArgs e)
        {
            if(password == "")
            {

            }
        }
    }
}
