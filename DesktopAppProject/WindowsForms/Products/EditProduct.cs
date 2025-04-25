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
    public partial class EditProduct : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        int ProductId = 0;

        public EditProduct(int ProductId)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            this.ProductId = ProductId;

            AppDbContext appDbContext = new AppDbContext();

            var Product = appDbContext.Product.Find(ProductId);

            ProductNameBox.Text = Product.Name;
            TypeBox.Text = Product.Type;
            DescriptionBox.Text = Product.Description;
            QuantityBox.Text = Product.Quantity.ToString();
            PriceBox.Text = Product.Price.ToString();

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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();

            if (string.IsNullOrEmpty(ProductNameBox.Text))
            {
                MessageBox.Show("Product name cannot be empty.", "product name is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(TypeBox.Text))
            {
                MessageBox.Show("Product type cannot be empty.", "Product type is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(QuantityBox.Text))
            {
                MessageBox.Show("Quantity cannot be empty.", "Quantity is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(PriceBox.Text))
            {
                MessageBox.Show("Price cannot be empty.", "Price is empty.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!float.TryParse(PriceBox.Text, out float Price) && Price >= 0)
            {
                MessageBox.Show("Price can only content positive number or decimal values.", "Price is may contain letters",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!int.TryParse(QuantityBox.Text, out int Quantity) && Quantity >= 0)
            {
                MessageBox.Show("Quantity can only content positive number greater than zero.", "Quantity is may contain letters",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Product product = new Product 
            {
                Id = ProductId,
                Name = ProductNameBox.Text.Trim(),
                Price = float.Parse(PriceBox.Text.Trim()),
                Quantity = int.Parse(QuantityBox.Text.Trim()),
                Type = TypeBox.Text.Trim(),
                Description = DescriptionBox.Text.Trim() ?? "",
            };

            appDbContext.Product.Update(product);

            appDbContext.SaveChanges();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
