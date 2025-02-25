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
            productOK.FlatAppearance.BorderSize = 0;
            //For the sidebars coloring shaders
            panel1.BackColor = Color.FromArgb(85, 255, 255, 255);
            productAdded.BackColor = Color.FromArgb(50, 255, 255, 255);
            productAdded.Visible = false;
            productAdded.Location = new Point(645, 224);

            // If the transition happens the button stays green if it exist in the Shopping List
            foreach (var item in productData.ShoppingCart.Items) // Checks if the product already exist in the List or Shopping Cart
            {
                if (item.Name == "Bread")
                {
                    addBread.BackColor = Color.Green;
                    addBread.Text = "Haggai";
                }
                else if (item.Name == "Apple")
                {
                    addApple.BackColor = Color.Green;
                    addApple.Text = "Haggai";
                }
                else if ( item.Name == "Orange")
                {
                    orangeAdd.BackColor = Color.Green;
                    orangeAdd.Text = "Haggai";
                }
                else if (item.Name == "Banana")
                {
                    bananaAdd.BackColor = Color.Green;
                    bananaAdd.Text = "Haggai";
                }
                else if (item.Name == "Milk")
                {
                    milkAdd.BackColor = Color.Green;
                    milkAdd.Text = "Haggai";
                }
            }

            //Adding image for each product that is in stock
            appleImage.Image = Image.FromFile(@"Z:\XX515\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Apple.jpg");
            bananaImage.Image = Image.FromFile(@"Z:\XX515\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Banana.jpg");
            orangeImage.Image = Image.FromFile(@"Z:\XX515\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Orange.jpg");
            milkImage.Image = Image.FromFile(@"Z:\XX515\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Milk.jpg");
            breadImage.Image = Image.FromFile(@"Z:\XX515\GroceryCalculatorDiscountApp_\GroceryCalculatorDiscountApp\Images\Bread.jpg");

            //Adjust the Size, Layout, Aspect Ratio of each product images
            appleImage.Size = new Size(228, 162);
            appleImage.Location = new Point(10, 14);
            appleImage.SizeMode = PictureBoxSizeMode.StretchImage;

            bananaImage.Size = new Size(228, 162);
            bananaImage.Location = new Point(10, 14);
            bananaImage.SizeMode = PictureBoxSizeMode.StretchImage;

            orangeImage.Size = new Size(228, 162);
            orangeImage.Location = new Point(10, 14);
            orangeImage.SizeMode = PictureBoxSizeMode.StretchImage;

            milkImage.Size = new Size(228, 162);
            milkImage.Location = new Point(10, 14);
            milkImage.SizeMode = PictureBoxSizeMode.StretchImage;

            breadImage.Size = new Size(228, 162);
            breadImage.Location = new Point(10, 14);
            breadImage.SizeMode = PictureBoxSizeMode.StretchImage;
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
                    addBread.BackColor = Color.Green;
                    MessageBox.Show($"The {item.Name} product already exist in Shopping Cart.", "Error of Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productData.ShoppingCart.Items.Add(new productData("Bread", 2.00m, 1));
            productAdded.Visible = true; // A message will appear if the product has been added.
            addBread.Text = "Haggai";
            addBread.BackColor = Color.Green; // Sets button into green if its added
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
            productAdded.Visible = true;
            bananaAdd.Text = "Haggai";
            bananaAdd.BackColor = Color.Green;
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
            productAdded.Visible = true;
            addApple.Text = "Haggai";
            addApple.BackColor = Color.Green;
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
            productAdded.Visible = true;
            orangeAdd.Text = "Haggai";
            orangeAdd.BackColor = Color.Green;
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
            productAdded.Visible = true;
            milkAdd.Text = "Haggai";
            milkAdd.BackColor = Color.Green;
        }

        private void productAdded_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productOK_Click(object sender, EventArgs e)
        {
            productAdded.Visible = false;
        }

        private void productButton_Click(object sender, EventArgs e)
        {

        }
    }
}