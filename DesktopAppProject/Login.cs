using TurboMart.Services;

namespace TurboMart
{
    public partial class Login : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public Login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginEventClick(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new RegisterUser().ShowDialog();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MakeAccountLabel.Font = new Font(MakeAccountLabel.Font, MakeAccountLabel.Font.Style | FontStyle.Underline);
        }

        private void MakeAccountLabel_MouseLeave(object sender, EventArgs e)
        {
            MakeAccountLabel.Font = new Font(MakeAccountLabel.Font, MakeAccountLabel.Font.Style & ~FontStyle.Underline);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.WhiteSmoke;
        }

        private void LoginEventClick(object sender, EventArgs e)
        {
            LoginService loginService = new();

            if (string.IsNullOrEmpty(InfoBox.Text.Trim()))
            {
                MessageBox.Show("Full name cannot be empty.", "Full name is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(InfoBox.Text.Trim()))
            {
                MessageBox.Show("Username cannot be empty.", "Username is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool Exists = loginService.IsLoggedIn(InfoBox.Text, PasswordBox.Text);

            if (Exists)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("We coudn't find you.\nPlease, check your credentials.", "Invalid credential",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEventClick(sender, e);
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEventClick(sender, e);
            }
        }
    }
}
