namespace TurboMart
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            MakeAccountLabel = new Label();
            LoginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordBox = new TextBox();
            InfoBox = new TextBox();
            label1 = new Label();
            CloseButton = new PictureBox();
            Minimize = new PictureBox();
            TurboMartPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurboMartPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(MakeAccountLabel);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(InfoBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(TurboMartPictureBox);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1251, 619);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // MakeAccountLabel
            // 
            MakeAccountLabel.AutoSize = true;
            MakeAccountLabel.Cursor = Cursors.Hand;
            MakeAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MakeAccountLabel.ForeColor = SystemColors.MenuHighlight;
            MakeAccountLabel.Location = new Point(978, 399);
            MakeAccountLabel.Name = "MakeAccountLabel";
            MakeAccountLabel.Size = new Size(216, 28);
            MakeAccountLabel.TabIndex = 9;
            MakeAccountLabel.Text = "Don't have an account?";
            MakeAccountLabel.Click += label4_Click;
            MakeAccountLabel.MouseEnter += label4_MouseEnter;
            MakeAccountLabel.MouseLeave += MakeAccountLabel_MouseLeave;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.MidnightBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(1078, 461);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(119, 43);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(717, 326);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 232);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 6;
            label2.Text = "Username or Email";
            // 
            // PasswordBox
            // 
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(846, 323);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(351, 38);
            PasswordBox.TabIndex = 5;
            PasswordBox.KeyDown += PasswordBox_KeyDown;
            // 
            // InfoBox
            // 
            InfoBox.Cursor = Cursors.IBeam;
            InfoBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoBox.Location = new Point(846, 229);
            InfoBox.Margin = new Padding(3, 5, 3, 5);
            InfoBox.Name = "InfoBox";
            InfoBox.Size = new Size(351, 38);
            InfoBox.TabIndex = 4;
            InfoBox.KeyDown += InfoBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(870, 133);
            label1.Name = "label1";
            label1.Size = new Size(260, 41);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Login";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.WhiteSmoke;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Improved;
            CloseButton.Location = new Point(1086, 13);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 34);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 2;
            CloseButton.TabStop = false;
            CloseButton.Click += pictureBox1_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Minimize
            // 
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = Properties.Resources.line;
            Minimize.Location = new Point(1162, 13);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(70, 34);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 1;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // TurboMartPictureBox
            // 
            TurboMartPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TurboMartPictureBox.Image = Properties.Resources.turbo;
            TurboMartPictureBox.Location = new Point(37, 71);
            TurboMartPictureBox.Name = "TurboMartPictureBox";
            TurboMartPictureBox.Size = new Size(443, 475);
            TurboMartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TurboMartPictureBox.TabIndex = 0;
            TurboMartPictureBox.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 611);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcom to Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurboMartPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox TurboMartPictureBox;
        private PictureBox Minimize;
        private PictureBox CloseButton;
        private TextBox InfoBox;
        private Label label1;
        private TextBox PasswordBox;
        private Label label3;
        private Label label2;
        private Button LoginButton;
        private Label MakeAccountLabel;
    }
}
