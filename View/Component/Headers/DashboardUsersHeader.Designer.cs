namespace OSMS.View.Component.Headers
{
    partial class DashboardUsersHeader
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(429, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 34);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // DashboardUsersHeader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Name = "DashboardUsersHeader";
            Size = new Size(957, 52);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}
