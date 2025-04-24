namespace TurboMart
{
    partial class RegisterUser
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
            HaveAccountLabel = new Label();
            RegisterButton = new Button();
            pictureBox3 = new PictureBox();
            CloseButton = new PictureBox();
            Minimize = new PictureBox();
            label6 = new Label();
            LogoButton = new PictureBox();
            label5 = new Label();
            ConfirmPasswordBox = new TextBox();
            label4 = new Label();
            PasswordBox = new TextBox();
            label3 = new Label();
            EmailAddressBox = new TextBox();
            label1 = new Label();
            UserNameBox = new TextBox();
            label2 = new Label();
            FullNameBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(HaveAccountLabel);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LogoButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ConfirmPasswordBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EmailAddressBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserNameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FullNameBox);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 802);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // HaveAccountLabel
            // 
            HaveAccountLabel.AutoSize = true;
            HaveAccountLabel.Cursor = Cursors.Hand;
            HaveAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HaveAccountLabel.ForeColor = SystemColors.MenuHighlight;
            HaveAccountLabel.Location = new Point(393, 644);
            HaveAccountLabel.Name = "HaveAccountLabel";
            HaveAccountLabel.Size = new Size(234, 28);
            HaveAccountLabel.TabIndex = 23;
            HaveAccountLabel.Text = "Already have an account?";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.MidnightBlue;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = SystemColors.Control;
            RegisterButton.Location = new Point(493, 706);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(119, 43);
            RegisterButton.TabIndex = 22;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.BackIcon;
            pictureBox3.Location = new Point(12, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.WhiteSmoke;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Improved;
            CloseButton.Location = new Point(556, 15);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 34);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 20;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Minimize
            // 
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = Properties.Resources.line;
            Minimize.Location = new Point(632, 15);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(70, 34);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 19;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 78);
            label6.Name = "label6";
            label6.Size = new Size(216, 41);
            label6.TabIndex = 18;
            label6.Text = "Register a User";
            // 
            // LogoButton
            // 
            LogoButton.Image = Properties.Resources.register;
            LogoButton.Location = new Point(300, 122);
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
            label5.Location = new Point(44, 588);
            label5.Name = "label5";
            label5.Size = new Size(197, 31);
            label5.TabIndex = 16;
            label5.Text = "Confirm Password";
            // 
            // ConfirmPasswordBox
            // 
            ConfirmPasswordBox.Cursor = Cursors.IBeam;
            ConfirmPasswordBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordBox.Location = new Point(261, 585);
            ConfirmPasswordBox.Margin = new Padding(3, 5, 3, 5);
            ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            ConfirmPasswordBox.PasswordChar = '*';
            ConfirmPasswordBox.Size = new Size(351, 38);
            ConfirmPasswordBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 516);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // PasswordBox
            // 
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(261, 513);
            PasswordBox.Margin = new Padding(3, 5, 3, 5);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(351, 38);
            PasswordBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 443);
            label3.Name = "label3";
            label3.Size = new Size(159, 31);
            label3.TabIndex = 12;
            label3.Text = "Email Address";
            // 
            // EmailAddressBox
            // 
            EmailAddressBox.Cursor = Cursors.IBeam;
            EmailAddressBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailAddressBox.Location = new Point(261, 440);
            EmailAddressBox.Margin = new Padding(3, 5, 3, 5);
            EmailAddressBox.Name = "EmailAddressBox";
            EmailAddressBox.Size = new Size(351, 38);
            EmailAddressBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 372);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // UserNameBox
            // 
            UserNameBox.Cursor = Cursors.IBeam;
            UserNameBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameBox.Location = new Point(261, 369);
            UserNameBox.Margin = new Padding(3, 5, 3, 5);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(351, 38);
            UserNameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 300);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 8;
            label2.Text = "Full Name";
            // 
            // FullNameBox
            // 
            FullNameBox.Cursor = Cursors.IBeam;
            FullNameBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullNameBox.Location = new Point(261, 300);
            FullNameBox.Margin = new Padding(3, 5, 3, 5);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(351, 38);
            FullNameBox.TabIndex = 1;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 787);
            Controls.Add(panel1);
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register a User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox FullNameBox;
        private PictureBox LogoButton;
        private Label label5;
        private TextBox ConfirmPasswordBox;
        private Label label4;
        private TextBox PasswordBox;
        private Label label3;
        private TextBox EmailAddressBox;
        private Label label1;
        private TextBox UserNameBox;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox CloseButton;
        private PictureBox Minimize;
        private Label HaveAccountLabel;
        private Button RegisterButton;
    }
}