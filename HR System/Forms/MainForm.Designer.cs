namespace HR_System.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeesPanel = new System.Windows.Forms.Panel();
            this.employeesButton = new System.Windows.Forms.Button();
            this.resumesPanel = new System.Windows.Forms.Panel();
            this.resumesButton = new System.Windows.Forms.Button();
            this.jobsPanel = new System.Windows.Forms.Panel();
            this.jobsButton = new System.Windows.Forms.Button();
            this.salaryPanel = new System.Windows.Forms.Panel();
            this.salaryButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.employeesPanel.SuspendLayout();
            this.resumesPanel.SuspendLayout();
            this.jobsPanel.SuspendLayout();
            this.salaryPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.employeesPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.resumesPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.jobsPanel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.salaryPanel, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.settingsPanel, 4, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 61);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // employeesPanel
            // 
            this.employeesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.employeesPanel.Controls.Add(this.employeesButton);
            this.employeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesPanel.Location = new System.Drawing.Point(3, 3);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.employeesPanel.Size = new System.Drawing.Size(154, 55);
            this.employeesPanel.TabIndex = 0;
            // 
            // employeesButton
            // 
            this.employeesButton.BackColor = System.Drawing.Color.Salmon;
            this.employeesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.employeesButton.Location = new System.Drawing.Point(0, 0);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(154, 50);
            this.employeesButton.TabIndex = 1;
            this.employeesButton.Text = "Pracownicy";
            this.employeesButton.UseVisualStyleBackColor = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // resumesPanel
            // 
            this.resumesPanel.Controls.Add(this.resumesButton);
            this.resumesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumesPanel.Location = new System.Drawing.Point(163, 3);
            this.resumesPanel.Name = "resumesPanel";
            this.resumesPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.resumesPanel.Size = new System.Drawing.Size(154, 55);
            this.resumesPanel.TabIndex = 5;
            // 
            // resumesButton
            // 
            this.resumesButton.BackColor = System.Drawing.Color.DarkOrange;
            this.resumesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumesButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.resumesButton.Location = new System.Drawing.Point(0, 0);
            this.resumesButton.Name = "resumesButton";
            this.resumesButton.Size = new System.Drawing.Size(154, 50);
            this.resumesButton.TabIndex = 2;
            this.resumesButton.Text = "Umowy";
            this.resumesButton.UseVisualStyleBackColor = false;
            this.resumesButton.Click += new System.EventHandler(this.resumesButton_Click);
            // 
            // jobsPanel
            // 
            this.jobsPanel.Controls.Add(this.jobsButton);
            this.jobsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsPanel.Location = new System.Drawing.Point(323, 3);
            this.jobsPanel.Name = "jobsPanel";
            this.jobsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.jobsPanel.Size = new System.Drawing.Size(154, 55);
            this.jobsPanel.TabIndex = 6;
            // 
            // jobsButton
            // 
            this.jobsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.jobsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.jobsButton.Location = new System.Drawing.Point(0, 0);
            this.jobsButton.Name = "jobsButton";
            this.jobsButton.Size = new System.Drawing.Size(154, 50);
            this.jobsButton.TabIndex = 3;
            this.jobsButton.Text = "Prace";
            this.jobsButton.UseVisualStyleBackColor = false;
            this.jobsButton.Click += new System.EventHandler(this.jobsButton_Click);
            // 
            // salaryPanel
            // 
            this.salaryPanel.Controls.Add(this.salaryButton);
            this.salaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salaryPanel.Location = new System.Drawing.Point(483, 3);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.salaryPanel.Size = new System.Drawing.Size(154, 55);
            this.salaryPanel.TabIndex = 7;
            // 
            // salaryButton
            // 
            this.salaryButton.BackColor = System.Drawing.Color.LightGreen;
            this.salaryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.salaryButton.Location = new System.Drawing.Point(0, 0);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(154, 50);
            this.salaryButton.TabIndex = 4;
            this.salaryButton.Text = "Wynagrodzenia";
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(643, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.settingsPanel.Size = new System.Drawing.Size(154, 55);
            this.settingsPanel.TabIndex = 8;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.settingsButton.Location = new System.Drawing.Point(0, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(154, 50);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(320, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Human Resources Managment System";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(800, 40);
            this.titlePanel.TabIndex = 2;
            // 
            // formPanel
            // 
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 101);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(800, 349);
            this.formPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR System";
            this.tableLayoutPanel.ResumeLayout(false);
            this.employeesPanel.ResumeLayout(false);
            this.resumesPanel.ResumeLayout(false);
            this.jobsPanel.ResumeLayout(false);
            this.salaryPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel employeesPanel;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Panel resumesPanel;
        private System.Windows.Forms.Button resumesButton;
        private System.Windows.Forms.Panel jobsPanel;
        private System.Windows.Forms.Button jobsButton;
        private System.Windows.Forms.Panel salaryPanel;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button settingsButton;
    }
}