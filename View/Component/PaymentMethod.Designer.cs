namespace OSMS.View.Component
{
    partial class PaymentMethod
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
            label1 = new Label();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(211, 34);
            label1.TabIndex = 14;
            label1.Text = "Pay on Deliver";
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
            guna2Button4.Location = new Point(594, 48);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(127, 36);
            guna2Button4.TabIndex = 21;
            guna2Button4.Text = "Select";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // PaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button4);
            Controls.Add(label1);
            Name = "PaymentMethod";
            Size = new Size(755, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
