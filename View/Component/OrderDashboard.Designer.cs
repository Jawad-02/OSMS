namespace OSMS.View.Component
{
    partial class OrderDashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            dgvOrderItems = new Guna.UI2.WinForms.Guna2DataGridView();
            colProduct = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(99, 34);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(332, 72);
            label3.Name = "label3";
            label3.Size = new Size(99, 34);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 275);
            label4.Name = "label4";
            label4.Size = new Size(99, 34);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "pending", "shipped", "delivered", "canceled" });
            guna2ComboBox1.Location = new Point(15, 324);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(175, 36);
            guna2ComboBox1.StartIndex = 0;
            guna2ComboBox1.TabIndex = 8;
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges3;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(201, 324);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button4.Size = new Size(127, 36);
            guna2Button4.TabIndex = 11;
            guna2Button4.Text = "EditStatus";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderItems.ColumnHeadersHeight = 4;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { colProduct, colQty });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderItems.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderItems.Location = new Point(15, 116);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.RowTemplate.Height = 29;
            dgvOrderItems.Size = new Size(416, 151);
            dgvOrderItems.TabIndex = 12;
            dgvOrderItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrderItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrderItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrderItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrderItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrderItems.ThemeStyle.BackColor = Color.White;
            dgvOrderItems.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrderItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrderItems.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOrderItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrderItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrderItems.ThemeStyle.HeaderStyle.Height = 4;
            dgvOrderItems.ThemeStyle.ReadOnly = true;
            dgvOrderItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrderItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrderItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOrderItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrderItems.ThemeStyle.RowsStyle.Height = 29;
            dgvOrderItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrderItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 6;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // OrderDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvOrderItems);
            Controls.Add(guna2Button4);
            Controls.Add(guna2ComboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "OrderDashboard";
            Size = new Size(448, 380);
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderItems;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQty;
    }
}
