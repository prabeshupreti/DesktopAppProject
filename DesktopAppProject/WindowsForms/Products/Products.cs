using DesktopAppProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboMart.Entitites;

namespace TurboMart.WindowsForms.Products
{
    public partial class Products : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public Products()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            FetchProducts();
        }

        private void FetchProducts()
        {
            AppDbContext appDbContext = new AppDbContext();

            ProductDataGridView.DataSource = Enumerable.Empty<Product>();
            ProductDataGridView.DataSource = appDbContext.Product.ToArray();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(1, 224, 224, 202);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Dashboard().Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new AddProduct().ShowDialog();

            if (dialogResult == DialogResult.OK) 
            {
                FetchProducts();
            }
        }
    }
}
