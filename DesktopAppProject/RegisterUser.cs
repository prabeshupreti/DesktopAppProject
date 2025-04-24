
using DesktopAppProject;
using TurboMart.Entitites;

namespace TurboMart
{
    public partial class RegisterUser : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public RegisterUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.WhiteSmoke;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();

            if (string.IsNullOrEmpty(FullNameBox.Text))
            {
                MessageBox.Show("Full name cannot be empty.", "Full name is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(UserNameBox.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Username is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(EmailAddressBox.Text))
            {
                MessageBox.Show("Email Address cannot be empty.", "Email address is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Password is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if (PasswordBox.Text.Trim() != ConfirmPasswordBox.Text.Trim())
            {
                MessageBox.Show("Password and confirm password do not match.", "Password do not match.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (PasswordBox.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password must be of 8 length.", "Pasword length not enough.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ApplicationUser applicationUser = new ApplicationUser
            {
                CreationDate = DateTime.Now,
                Email = EmailAddressBox.Text.Trim(),
                FullName = FullNameBox.Text.Trim(),
                Password = PasswordBox.Text.Trim(),
                UserName = UserNameBox.Text.Trim()
            };

            appDbContext.ApplicationUser.Add(applicationUser);

            appDbContext.SaveChanges();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
