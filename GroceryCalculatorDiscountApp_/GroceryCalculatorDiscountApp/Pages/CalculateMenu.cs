using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryCalculatorDiscountApp.Pages
{

    public partial class CalculateMenu : Form
    {
        public CalculateMenu()
        {
            InitializeComponent();
            addApple.FlatAppearance.BorderSize = 0;
            addBread.FlatAppearance.BorderSize = 0;
            bananaAdd.FlatAppearance.BorderSize = 0;
            milkAdd.FlatAppearance.BorderSize = 0;
            orangeAdd.FlatAppearance.BorderSize = 0;
            //For the sidebars coloring shaders
            panel1.BackColor = Color.FromArgb(85, 255, 255, 255);

            //Adding image for each product that is in stock
            appleImage.Image = Image.FromFile(@"C:\Users\chris\Documents\C#\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Apple.jpg");
            bananaImage.Image = Image.FromFile(@"C:\Users\chris\Documents\C#\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Banana.jpg");
            orangeImage.Image = Image.FromFile(@"C:\Users\chris\Documents\C#\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Orange.jpg");
            milkImage.Image = Image.FromFile(@"C:\Users\chris\Documents\C#\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Milk.jpg");
            breadImage.Image = Image.FromFile(@"C:\Users\chris\Documents\C#\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Bread.jpg");

            //Adjust the Size, Layout, Aspect Ratio of each product images
            appleImage.Size = new Size(228, 162);
            appleImage.Location = new Point(10, 14);
            appleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            appleQuantity.Text = "1";

            bananaImage.Size = new Size(228, 162);
            bananaImage.Location = new Point(10, 14);
            bananaImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bananaQuantity.Text = "1";

            orangeImage.Size = new Size(228, 162);
            orangeImage.Location = new Point(10, 14);
            orangeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            orangeQuantity.Text = "1";

            milkImage.Size = new Size(228, 162);
            milkImage.Location = new Point(10, 14);
            milkImage.SizeMode = PictureBoxSizeMode.StretchImage;
            milkQuantity.Text = "1";

            breadImage.Size = new Size(228, 162);
            breadImage.Location = new Point(10, 14);
            breadImage.SizeMode = PictureBoxSizeMode.StretchImage;
            breadQuantity.Text = "1";
        }
        
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            ShoppingList shoppingList = new ShoppingList();
            shoppingList.Dock = DockStyle.Fill;
            shoppingList.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(shoppingList);
            shoppingList.Show();
        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void cashOut_Click(object sender, EventArgs e)
        {

        }

        private void appleImage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void appleQuantity_Click(object sender, EventArgs e)
        {

        }
        private void CalculateMenu_Load(object sender, EventArgs e)
        {

        }

        private void addBread_Click(object sender, EventArgs e)
        {
            foreach (var item in productData.ShoppingCart.Items) // Checks if the product already exist in the List or Shopping Cart
            {
                if (item.Name == "Bread")
                {
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Bread", 2.00m, 1));
        }

        private void bananaAdd_Click(object sender, EventArgs e)
        { 
            foreach (var item in productData.ShoppingCart.Items) // Checks if the product already exist in the List or Shopping Cart
            {
                if (item.Name == "Banana")
                {
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Banana", 3.00m, 1));
        }

        private void addApple_Click(object sender, EventArgs e)
        {
            foreach (var item in productData.ShoppingCart.Items) // Checks if the product already exist in the List or Shopping Cart
            {
                if (item.Name == "Apple")
                {
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Apple", 5.00m, 1));
        }

        private void orangeAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in productData.ShoppingCart.Items) // Checks if the product already exist in the List or Shopping Cart
            {
                if (item.Name == "Orange")
                {
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Orange", 4.00m, 1));
        }

        private void milkAdd_Click(object sender, EventArgs e) // Checks if the product already exist in the List or Shopping Cart
        {
            foreach (var item in productData.ShoppingCart.Items)
            {
                if (item.Name == "Milk")
                {
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Milk", 2.50m, 1));
        }
    }
}
