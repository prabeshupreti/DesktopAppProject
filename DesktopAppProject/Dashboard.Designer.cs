namespace TurboMart
{
    partial class Dashboard
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            CloseButton = new PictureBox();
            Minimize = new PictureBox();
            panel2 = new Panel();
            SalesButton = new Button();
            ProductButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            SalesToday = new Button();
            TotalSales = new Button();
            TotalProducts = new Button();
            TotalUsers = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 202);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Minimize);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 128);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(463, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(414, 50);
            label1.TabIndex = 9;
            label1.Text = "Welcome to Turbo Mart";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(224, 224, 202);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Improved;
            CloseButton.Location = new Point(1131, 28);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 34);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 4;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Minimize
            // 
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = Properties.Resources.line;
            Minimize.Location = new Point(1207, 28);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(70, 34);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 3;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 200);
            panel2.Controls.Add(SalesButton);
            panel2.Controls.Add(ProductButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(SalesToday);
            panel2.Controls.Add(TotalSales);
            panel2.Controls.Add(TotalProducts);
            panel2.Controls.Add(TotalUsers);
            panel2.Location = new Point(1, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 444);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel1_MouseDown;
            panel2.MouseMove += panel1_MouseMove;
            panel2.MouseUp += panel1_MouseUp;
            // 
            // SalesButton
            // 
            SalesButton.BackColor = Color.DodgerBlue;
            SalesButton.FlatAppearance.BorderSize = 0;
            SalesButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            SalesButton.FlatStyle = FlatStyle.Flat;
            SalesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalesButton.Location = new Point(90, 231);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(288, 96);
            SalesButton.TabIndex = 26;
            SalesButton.Text = "Sales";
            SalesButton.UseVisualStyleBackColor = false;
            // 
            // ProductButton
            // 
            ProductButton.BackColor = Color.DodgerBlue;
            ProductButton.FlatAppearance.BorderSize = 0;
            ProductButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            ProductButton.FlatStyle = FlatStyle.Flat;
            ProductButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductButton.Location = new Point(90, 68);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(288, 96);
            ProductButton.TabIndex = 25;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = false;
            ProductButton.Click += ProductButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(1050, 352);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 24;
            label4.Text = "Total Sales Today";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(805, 352);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 23;
            label5.Text = "Total Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(1058, 155);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 22;
            label3.Text = "Total Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(805, 155);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 21;
            label2.Text = "Total Users";
            // 
            // SalesToday
            // 
            SalesToday.BackColor = Color.Lavender;
            SalesToday.BackgroundImage = Properties.Resources.sale_per_day;
            SalesToday.BackgroundImageLayout = ImageLayout.None;
            SalesToday.FlatAppearance.BorderSize = 0;
            SalesToday.FlatStyle = FlatStyle.Flat;
            SalesToday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalesToday.Location = new Point(1033, 231);
            SalesToday.Name = "SalesToday";
            SalesToday.Size = new Size(213, 118);
            SalesToday.TabIndex = 20;
            SalesToday.UseVisualStyleBackColor = false;
            // 
            // TotalSales
            // 
            TotalSales.BackColor = Color.Lavender;
            TotalSales.BackgroundImage = Properties.Resources.revenue;
            TotalSales.BackgroundImageLayout = ImageLayout.None;
            TotalSales.FlatAppearance.BorderSize = 0;
            TotalSales.FlatStyle = FlatStyle.Flat;
            TotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalSales.Location = new Point(757, 231);
            TotalSales.Name = "TotalSales";
            TotalSales.Size = new Size(213, 118);
            TotalSales.TabIndex = 19;
            TotalSales.UseVisualStyleBackColor = false;
            // 
            // TotalProducts
            // 
            TotalProducts.BackColor = Color.Lavender;
            TotalProducts.BackgroundImage = Properties.Resources.box;
            TotalProducts.BackgroundImageLayout = ImageLayout.None;
            TotalProducts.FlatAppearance.BorderSize = 0;
            TotalProducts.FlatStyle = FlatStyle.Flat;
            TotalProducts.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalProducts.Location = new Point(1033, 34);
            TotalProducts.Name = "TotalProducts";
            TotalProducts.Size = new Size(213, 118);
            TotalProducts.TabIndex = 18;
            TotalProducts.UseVisualStyleBackColor = false;
            // 
            // TotalUsers
            // 
            TotalUsers.BackColor = Color.Lavender;
            TotalUsers.BackgroundImage = Properties.Resources.user64;
            TotalUsers.BackgroundImageLayout = ImageLayout.None;
            TotalUsers.FlatAppearance.BorderSize = 0;
            TotalUsers.FlatStyle = FlatStyle.Flat;
            TotalUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalUsers.ImageAlign = ContentAlignment.TopLeft;
            TotalUsers.Location = new Point(757, 34);
            TotalUsers.Name = "TotalUsers";
            TotalUsers.Size = new Size(213, 118);
            TotalUsers.TabIndex = 17;
            TotalUsers.TextImageRelation = TextImageRelation.TextAboveImage;
            TotalUsers.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox CloseButton;
        private PictureBox Minimize;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button SalesToday;
        private Button TotalSales;
        private Button TotalProducts;
        private Button TotalUsers;
        private PictureBox pictureBox1;
        private Button SalesButton;
        private Button ProductButton;
    }
}