namespace OSMS.View.Component.Headers
{
    partial class DashboardProductHeader
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(guna2Button4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(957, 52);
            panel3.TabIndex = 3;
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges1;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(693, 8);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(252, 37);
            guna2Button4.TabIndex = 10;
            guna2Button4.Text = "AddProduct";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 34);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // DashboardProductHeader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "DashboardProductHeader";
            Size = new Size(957, 52);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Label label2;
    }
}
