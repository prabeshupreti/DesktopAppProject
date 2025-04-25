namespace TurboMart.WindowsForms.Products
{
    partial class EditProduct
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
            EditButton = new Button();
            label6 = new Label();
            LogoButton = new PictureBox();
            label5 = new Label();
            PriceBox = new TextBox();
            label4 = new Label();
            QuantityBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            TypeBox = new TextBox();
            label2 = new Label();
            ProductNameBox = new TextBox();
            panel1 = new Panel();
            DescriptionBox = new RichTextBox();
            pictureBox3 = new PictureBox();
            CloseButton = new PictureBox();
            Minimize = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.MidnightBlue;
            EditButton.Cursor = Cursors.Hand;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = SystemColors.Control;
            EditButton.Location = new Point(531, 730);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(119, 43);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += RegisterButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(300, 95);
            label6.Name = "label6";
            label6.Size = new Size(203, 41);
            label6.TabIndex = 18;
            label6.Text = "Edit a Product";
            // 
            // LogoButton
            // 
            LogoButton.Image = Properties.Resources.box;
            LogoButton.Location = new Point(327, 149);
            LogoButton.Name = "LogoButton";
            LogoButton.Size = new Size(140, 139);
            LogoButton.SizeMode = PictureBoxSizeMode.Zoom;
            LogoButton.TabIndex = 17;
            LogoButton.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(117, 656);
            label5.Name = "label5";
            label5.Size = new Size(154, 31);
            label5.TabIndex = 16;
            label5.Text = "Price Per Item";
            // 
            // PriceBox
            // 
            PriceBox.Cursor = Cursors.IBeam;
            PriceBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceBox.Location = new Point(299, 649);
            PriceBox.Margin = new Padding(3, 5, 3, 5);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(351, 38);
            PriceBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 580);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 14;
            label4.Text = "Quantity";
            // 
            // QuantityBox
            // 
            QuantityBox.Cursor = Cursors.IBeam;
            QuantityBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityBox.Location = new Point(299, 577);
            QuantityBox.Margin = new Padding(3, 5, 3, 5);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(351, 38);
            QuantityBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 490);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 390);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 10;
            label1.Text = "Type";
            // 
            // TypeBox
            // 
            TypeBox.Cursor = Cursors.IBeam;
            TypeBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeBox.Location = new Point(299, 383);
            TypeBox.Margin = new Padding(3, 5, 3, 5);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(351, 38);
            TypeBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 314);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Cursor = Cursors.IBeam;
            ProductNameBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameBox.Location = new Point(299, 314);
            ProductNameBox.Margin = new Padding(3, 5, 3, 5);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(351, 38);
            ProductNameBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 200);
            panel1.Controls.Add(DescriptionBox);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LogoButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PriceBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(QuantityBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TypeBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ProductNameBox);
            panel1.Location = new Point(-89, -38);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 839);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // DescriptionBox
            // 
            DescriptionBox.BorderStyle = BorderStyle.None;
            DescriptionBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionBox.Location = new Point(298, 457);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(352, 95);
            DescriptionBox.TabIndex = 3;
            DescriptionBox.Text = "";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 202);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.BackIcon;
            pictureBox3.Location = new Point(101, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(224, 224, 202);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Improved;
            CloseButton.Location = new Point(554, 60);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 34);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 25;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Minimize
            // 
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = Properties.Resources.line;
            Minimize.Location = new Point(630, 60);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(70, 34);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 24;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 796);
            Controls.Add(panel1);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add a Product";
            ((System.ComponentModel.ISupportInitialize)LogoButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button EditButton;
        private Label label6;
        private PictureBox LogoButton;
        private Label label5;
        private TextBox PriceBox;
        private Label label4;
        private TextBox QuantityBox;
        private Label label3;
        private Label label1;
        private TextBox TypeBox;
        private Label label2;
        private TextBox ProductNameBox;
        private Panel panel1;
        private PictureBox CloseButton;
        private PictureBox Minimize;
        private PictureBox pictureBox3;
        private RichTextBox DescriptionBox;
    }
}