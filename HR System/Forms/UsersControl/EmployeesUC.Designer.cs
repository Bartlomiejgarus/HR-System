namespace HR_System.Forms.UsersControl
{
    partial class EmployeesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Empoloyyes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Empoloyyes
            // 
            this.Empoloyyes.AutoSize = true;
            this.Empoloyyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Empoloyyes.Location = new System.Drawing.Point(189, 108);
            this.Empoloyyes.Name = "Empoloyyes";
            this.Empoloyyes.Size = new System.Drawing.Size(392, 73);
            this.Empoloyyes.TabIndex = 0;
            this.Empoloyyes.Text = "Empoloyyes";
            // 
            // EmployeesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Empoloyyes);
            this.Name = "EmployeesUC";
            this.Size = new System.Drawing.Size(800, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Empoloyyes;
    }
}
