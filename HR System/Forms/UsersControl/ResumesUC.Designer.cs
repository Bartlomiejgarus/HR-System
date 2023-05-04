namespace HR_System.Forms.UsersControl
{
    partial class ResumesUC
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
            this.UMOWY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UMOWY
            // 
            this.UMOWY.AutoSize = true;
            this.UMOWY.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UMOWY.Location = new System.Drawing.Point(249, 125);
            this.UMOWY.Name = "UMOWY";
            this.UMOWY.Size = new System.Drawing.Size(289, 73);
            this.UMOWY.TabIndex = 1;
            this.UMOWY.Text = "UMOWY";
            // 
            // ResumesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UMOWY);
            this.Name = "ResumesUC";
            this.Size = new System.Drawing.Size(800, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UMOWY;
    }
}
