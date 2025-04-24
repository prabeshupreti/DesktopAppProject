using DesktopAppProject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboMart.WindowsForms.Products;

namespace TurboMart
{
    public partial class Dashboard : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public Dashboard()
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
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(1, 224, 224, 202);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();

            TotalProducts.Text = appDbContext.Product.AsNoTracking().Count().ToString();

            TotalSales.Text = appDbContext.Order.AsNoTracking().Count().ToString();

            SalesToday.Text = appDbContext.Order.AsNoTracking()
                .Where(x => x.OrderDateTime.Equals(DateTime.Today))
                .Count().ToString();

            TotalUsers.Text = appDbContext.ApplicationUser.AsNoTracking().Count().ToString();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Products().Show();
        }
    }
}
