using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryCalculatorDiscountApp.Pages
{
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
            //For the sidebars coloring shaders
            panel1.BackColor = Color.FromArgb(85, 255, 255, 255);

            // Ensure table has correct column count
            productTable.ColumnCount = 4;
            productTable.AutoSize = true;

            // Fixed width for proper alignment
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150)); // Product Name
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Price
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));  // Quantity
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));  //X button
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            RefreshProductTable();

            // Shows what product has been added 
            // Loop through the product list and add them to the table
            // Creating new product name, product price and input quantity box based on the list
        }
        private void RefreshProductTable()
        {
            productTable.Controls.Clear(); // Clear all existing UI components
            productTable.RowCount = 1;     // Reset row count

            // Re-add products after removing one
            foreach (var item in productData.ShoppingCart.Items)
            {
                Label nameLabel = new Label
                {
                    Text = item.Name,
                    AutoSize = false,
                    Width = 150,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 14.25F, FontStyle.Regular),
                };

                Label priceLabel = new Label
                {
                    Text = "$" + item.Price.ToString(),
                    AutoSize = true,
                    Font = new Font("Arial", 14.25F, FontStyle.Regular)
                };

                TextBox quantityBox = new TextBox
                {
                    Text = item.PurchasedQuantity.ToString(),
                    Width = 74,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                };

                Button removeButton = new Button
                {
                    Text = "X",
                    Width = 30,
                    Height = 25,
                    ForeColor = Color.White,
                    BackColor = Color.Red,
                    FlatStyle = FlatStyle.Flat,
                };

                removeButton.FlatAppearance.BorderSize = 0;
                removeButton.FlatAppearance.MouseOverBackColor = Color.DarkRed;
                removeButton.Click += (s, e) =>
                {
                    productData.ShoppingCart.Items.Remove(item);
                    RefreshProductTable(); // Refresh after removing item
                };

                int rowIndex = productTable.RowCount++;
                productTable.Controls.Add(nameLabel, 0, rowIndex);
                productTable.Controls.Add(priceLabel, 1, rowIndex);
                productTable.Controls.Add(quantityBox, 2, rowIndex);
                productTable.Controls.Add(removeButton, 3, rowIndex);
            }
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            // Transitions to calculateMenu or the Selection of product page.
            CalculateMenu calc = new CalculateMenu();
            calc.Dock = DockStyle.Fill;
            calc.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(calc);
            calc.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // The form or application exits
            Application.Exit();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            // Define stock limits for each product
            /*
            Dictionary<string, int> stockLimits = new Dictionary<string, int>
            {
            {"Apple", 99999999}, // Product Name and Product Available Stocks
            {"Banana", 99999999},
            {"Orange", 99999999},
            {"Milk", 99999999},
            {"Bread", 99999999}
            };
            */
            //For Error Handling
            // Checks if the shopping cart is empty
            if (productData.ShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("The shopping cart is empty, Please add products to proceed.", "No products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Iterate through productTable controls
            for (int i = 0; i < productData.ShoppingCart.Items.Count; i++)
            {
                // Get the product name
                string productName = productData.ShoppingCart.Items[i].Name;
                int enteredQuantity; //Stores the value of the quantity

                // Get the TextBox (quantity input)
                Control quantityControl = productTable.GetControlFromPosition(2, i); // Column 2, Row (i) (gi locate ang input field)
                if (quantityControl is TextBox quantityBox)
                {
                    // Check if input is a valid integer
                    if (!int.TryParse(quantityBox.Text, out enteredQuantity) || enteredQuantity < 1)
                    {
                        MessageBox.Show($"Invalid quantity for {productName}. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if entered quantity exceeds stock limit
                    /*
                    if (stockLimits.ContainsKey(productName) && enteredQuantity > stockLimits[productName])
                    {
                        MessageBox.Show($"Not enough stock for {productName}. Maximum available: {stockLimits[productName]}", "Stock Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    */

                    // Update cartItems list with new quantity
                    productData.ShoppingCart.Items[i].PurchasedQuantity = enteredQuantity;
                }
            }

            // Transitions to the receipt form if the place order button did not encounter any problems
            Receipt receipt = new Receipt();
            receipt.Dock = DockStyle.Fill;
            receipt.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(receipt);
            receipt.Show();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void productPrice_Click(object sender, EventArgs e)
        {

        }

        private void productQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void productTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void subTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
