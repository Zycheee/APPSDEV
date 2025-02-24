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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();

            // Ensure table has correct column count
            productTable.ColumnCount = 3;
            productTable.AutoSize = true;

            // Fixed width for proper alignment
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150)); // Product Name
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Price
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));  // Quantity
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            productTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            // Loop through the product list and add them to the table
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
                    Enabled = false
                };

                // Add the row to the TableLayoutPanel
                int rowIndex = productTable.RowCount++;
                productTable.Controls.Add(nameLabel, 0, rowIndex);
                productTable.Controls.Add(priceLabel, 1, rowIndex);
                productTable.Controls.Add(quantityBox, 2, rowIndex);
            }
        }
        

        private void newPurchaseButton_Click(object sender, EventArgs e)
        {
            CalculateMenu calc = new CalculateMenu();
            calc.Dock = DockStyle.Fill;
            calc.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(calc);
            calc.Show();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productQuantity_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
