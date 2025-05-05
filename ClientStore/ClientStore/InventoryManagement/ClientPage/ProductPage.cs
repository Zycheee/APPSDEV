using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryManagement
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
            AddProductPanels();
        }

        private void AddProductPanels()
        {
            // Create a FlowLayoutPanel to hold the product panels
            productGrid.AutoScroll = true;  // Enable scrollbars when content overflows
            productGrid.WrapContents = true;  // Wrap contents when needed

            // Create multiple product panels
            for (int i = 0; i < 100; i++)
            {
                //Panel of the product or Displayer of a product
                cuiPanel newProductPanel = new cuiPanel();
                newProductPanel.Size = new Size(242, 300); // Set the size of the panel
                newProductPanel.BackColor = Color.Transparent; // Set background color (optional)
                newProductPanel.PanelColor = Color.FromArgb(75, 91, 137); // Set background color (optional)
                newProductPanel.PanelOutlineColor = Color.FromArgb(75, 91, 137); // Set background color (optional)
                newProductPanel.Margin = new Padding(40); // Add margin for spacing


                //Picture of the product
                cuiPictureBox productPicture = new cuiPictureBox();
                productPicture.Size = new Size(177, 143);
                productPicture.BackColor = Color.WhiteSmoke;
                productPicture.Location = new Point(33, 17);
                newProductPanel.Controls.Add(productPicture);


                //Name of the product
                Label productLabel = new Label();
                productLabel.BackColor = Color.Transparent;
                productLabel.Text = $"Orange Juice {i + 1}";
                productLabel.TextAlign = ContentAlignment.TopLeft;
                productLabel.Size = new Size(210, 35);
                productLabel.ForeColor = Color.White;
                productLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                productLabel.Location = new Point(28, 168);  // Set label position
                newProductPanel.Controls.Add(productLabel);

                //Price of the product
                Label productPrice = new Label();
                decimal price = i + 10;
                productPrice.Text = $"${price:0.00}";
                productPrice.Size = new Size(133, 32);
                productPrice.ForeColor = Color.White;
                productPrice.Font = new Font("Arial", 14, FontStyle.Bold);
                productPrice.Location = new Point(30, 200);
                newProductPanel.Controls.Add(productPrice);

                //Button of the product
                cuiButtonGroup addButton = new cuiButtonGroup();
                addButton.Font = new Font("Arial", 15, FontStyle.Bold);
                addButton.Content = "Add";
                addButton.Location = new Point(34, 232);
                addButton.Size = new Size(177, 46);
                addButton.HoverBackground = Color.FromArgb(96, 138, 227);
                addButton.PressedBackground = Color.FromArgb(37, 53, 76);
                addButton.NormalBackground = Color.FromArgb(44, 50, 58);
                addButton.HoverForeColor = Color.WhiteSmoke;
                addButton.NormalForeColor = Color.WhiteSmoke;
                addButton.PressedForeColor = Color.WhiteSmoke;
                addButton.CheckedBackground = Color.FromArgb(0, 192, 0);
                addButton.CheckedOutline = Color.Transparent;
                addButton.Cursor = Cursors.Hand;

                addButton.Click += AddButton_Click;



                newProductPanel.Controls.Add(addButton);

                // Add the new product panel to the productGrid (FlowLayoutPanel)
                productGrid.Controls.Add(newProductPanel);

                productGrid.Padding = new Padding(10);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // If the button "Add" was clicked it will turn into "In Cart"
            cuiButtonGroup btn = (cuiButtonGroup)sender;
            btn.Content = "In Cart";
        }


        private void productGrid_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

        }
    }
}
