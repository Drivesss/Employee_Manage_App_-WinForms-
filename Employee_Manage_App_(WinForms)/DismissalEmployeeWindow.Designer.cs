namespace Employee_Manage_App__WinForms_
{
    partial class DismissalEmployeeWindow
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
            this.dataGridDismissalEmployeeView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDismissalEmployeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDismissalEmployeeView
            // 
            this.dataGridDismissalEmployeeView.AllowUserToAddRows = false;
            this.dataGridDismissalEmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDismissalEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDismissalEmployeeView.Location = new System.Drawing.Point(12, 12);
            this.dataGridDismissalEmployeeView.Name = "dataGridDismissalEmployeeView";
            this.dataGridDismissalEmployeeView.RowHeadersVisible = false;
            this.dataGridDismissalEmployeeView.Size = new System.Drawing.Size(810, 426);
            this.dataGridDismissalEmployeeView.TabIndex = 0;
            // 
            // DismissalEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.dataGridDismissalEmployeeView);
            this.Name = "DismissalEmployeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DismissalEmployeeWindow";
            this.Load += new System.EventHandler(this.DismissalEmployeeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDismissalEmployeeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDismissalEmployeeView;
    }
}