namespace TurboMart.WindowsForms.Products
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CloseButton = new PictureBox();
            Minimize = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            EditButton = new Button();
            ProductDataGridView = new DataGridView();
            AddProductButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 202);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 121);
            panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(224, 224, 202);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Improved;
            CloseButton.Location = new Point(1079, 15);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 34);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 6;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Minimize
            // 
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = Properties.Resources.line;
            Minimize.Location = new Point(1155, 15);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(70, 34);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 5;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 202);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.BackIcon;
            pictureBox3.Location = new Point(17, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box;
            pictureBox1.Location = new Point(337, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(143, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 50);
            label1.TabIndex = 11;
            label1.Text = "Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 200);
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(ProductDataGridView);
            panel2.Controls.Add(AddProductButton);
            panel2.Location = new Point(-4, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1245, 576);
            panel2.TabIndex = 1;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.MidnightBlue;
            EditButton.Cursor = Cursors.Hand;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = SystemColors.Control;
            EditButton.Location = new Point(228, 37);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(164, 43);
            EditButton.TabIndex = 25;
            EditButton.Text = "Edit a Product";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AllowUserToOrderColumns = true;
            ProductDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            ProductDataGridView.BackgroundColor = SystemColors.HighlightText;
            ProductDataGridView.ColumnHeadersHeight = 34;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new Padding(2, 3, 2, 3);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            ProductDataGridView.GridColor = Color.DeepSkyBlue;
            ProductDataGridView.Location = new Point(32, 122);
            ProductDataGridView.MultiSelect = false;
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersWidth = 50;
            ProductDataGridView.RowTemplate.Height = 50;
            ProductDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            ProductDataGridView.ShowCellToolTips = false;
            ProductDataGridView.Size = new Size(1179, 419);
            ProductDataGridView.TabIndex = 24;
            ProductDataGridView.TabStop = false;
            // 
            // AddProductButton
            // 
            AddProductButton.BackColor = Color.MidnightBlue;
            AddProductButton.Cursor = Cursors.Hand;
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductButton.ForeColor = SystemColors.Control;
            AddProductButton.Location = new Point(32, 37);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(164, 43);
            AddProductButton.TabIndex = 23;
            AddProductButton.Text = "Add a Product";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 687);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox CloseButton;
        private PictureBox Minimize;
        private Button AddProductButton;
        private Button EditButton;
        private DataGridView ProductDataGridView;
    }
}