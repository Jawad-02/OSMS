namespace OSMS.View
{
    partial class ShoppingCartForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 38);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 11;
            label1.Text = "ItemCount";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BorderRadius = 20;
            guna2GradientButton1.CheckedState.FillColor = Color.FromArgb(255, 93, 34);
            guna2GradientButton1.CheckedState.FillColor2 = Color.Coral;
            guna2GradientButton1.CustomizableEdges = customizableEdges1;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.Coral;
            guna2GradientButton1.FillColor2 = Color.FromArgb(255, 93, 34);
            guna2GradientButton1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.HoverState.FillColor = Color.FromArgb(255, 93, 34);
            guna2GradientButton1.HoverState.FillColor2 = Color.Coral;
            guna2GradientButton1.Location = new Point(453, 33);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1.Size = new Size(335, 42);
            guna2GradientButton1.TabIndex = 15;
            guna2GradientButton1.Text = "Checkout";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 369);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 17;
            label2.Text = "<-Back";
            label2.Click += label2_Click;
            // 
            // ShoppingCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(guna2GradientButton1);
            Controls.Add(label1);
            Name = "ShoppingCartForm";
            Text = "ShoppingCartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}