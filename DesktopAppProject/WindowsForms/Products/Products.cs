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

        int ProductId;

        public Products()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            EditButton.Hide();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            FetchProducts();
        }

        private void FetchProducts()
        {
            AppDbContext appDbContext = new AppDbContext();

            ProductTable.DataSource = Enumerable.Empty<Product>();
            ProductTable.DataSource = appDbContext.Product.ToArray();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProductId == 0)
            {
                MessageBox.Show("No Product is selected to edit.", "No Product Selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = new EditProduct(ProductId).ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    FetchProducts();
                }
            }
        }

        private void ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = int.Parse(ProductTable.Rows[e.RowIndex].Cells[0].Value.ToString());

                EditButton.Show();

                ProductId = Id;
            }
        }
    }
}
