namespace OSMS.View
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            label2 = new Label();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Coral;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Coral;
            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(255, 93, 34);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(337, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(44, 38);
            guna2ControlBox1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ErrorImage = (Image)resources.GetObject("guna2CirclePictureBox1.ErrorImage");
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(128, 67);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(136, 117);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 201);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 2;
            label1.Text = "Welcom";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges4;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.Coral;
            txtUsername.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.HoverState.BorderColor = Color.FromArgb(255, 93, 34);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.IconLeftSize = new Size(30, 30);
            txtUsername.Location = new Point(12, 259);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtUsername.Size = new Size(368, 56);
            txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtUsername.TabIndex = 3;
            txtUsername.TextOffset = new Point(10, 0);
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges6;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.Coral;
            txtPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(255, 93, 34);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(30, 30);
            txtPassword.Location = new Point(12, 334);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtPassword.Size = new Size(368, 56);
            txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPassword.TabIndex = 4;
            txtPassword.TextOffset = new Point(10, 0);
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 395);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 5;
            label2.Text = "ForgetPassword?";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BorderRadius = 20;
            guna2GradientButton1.CheckedState.FillColor = Color.FromArgb(255, 93, 34);
            guna2GradientButton1.CheckedState.FillColor2 = Color.Coral;
            guna2GradientButton1.CustomizableEdges = customizableEdges8;
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
            guna2GradientButton1.Location = new Point(12, 429);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GradientButton1.Size = new Size(368, 47);
            guna2GradientButton1.TabIndex = 6;
            guna2GradientButton1.Text = "Login";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 488);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 7;
            label3.Text = "Don't have an account?";
            label3.Click += label3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 519);
            Controls.Add(label3);
            Controls.Add(guna2GradientButton1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Label label2;
        private Label label3;
    }
}