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

        private void employeesButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(employeesPanel);
        }

        private void resumesButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(resumesPanel);
        }

        private void jobsButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(jobsPanel);
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(salaryPanel);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OnButtonClickColorChange(settingsPanel);
        }

        private void OnButtonClickColorChange(Panel panel)
        {
            employeesPanel.BackColor = resumesPanel.BackColor = jobsPanel.BackColor = salaryPanel.BackColor = settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            panel.BackColor = Color.Red;
        }
    }
}
