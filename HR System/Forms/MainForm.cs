using HR_System.Forms.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            formPanel.Controls.Clear();
            formPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(employeesPanel);
            OpenForm(EmployeesUC.GetInstance());
        }

        private void resumesButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(resumesPanel);
            OpenForm(ResumesUC.GetInstance());
        }

        private void jobsButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(jobsPanel);
            OpenForm(JobsUC.GetInstance());
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(salaryPanel);
            OpenForm(SalaryUC.GetInstance());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(settingsPanel);
            OpenForm(SettingsUC.GetInstance());
        }

        private void OnButtonClickColorChange(Panel panel)
        {
            employeesPanel.BackColor = resumesPanel.BackColor = jobsPanel.BackColor = salaryPanel.BackColor = settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            panel.BackColor = Color.Red;
        }
    }
}
