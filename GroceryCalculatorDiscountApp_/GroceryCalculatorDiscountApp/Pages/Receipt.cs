using System;
using System.Linq;
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
                    Text = "$" + item.Price.ToString("0.00"),
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

            // Calculate and display subtotal, discount amount, and total payment
            DisplayCalculations();
        }

        private void DisplayCalculations()
        {
            // Calculate subtotal (total cost before discount)
            decimal subtotal = productData.ShoppingCart.Items.Sum(item => item.Price * item.PurchasedQuantity);

            // Calculate discount based on subtotal
            decimal discountPercentage = 0;
            if (subtotal >= 500)
            {
                discountPercentage = 0.20m; // 20%
            }
            else if (subtotal >= 200)
            {
                discountPercentage = 0.15m; // 15%
            }
            else if (subtotal >= 100)
            {
                discountPercentage = 0.10m; // 10%
            }

            // Calculate discount amount
            decimal discountAmountValue = subtotal * discountPercentage;

            // Calculate total payment (final amount after discount)
            decimal totalPayment = subtotal - discountAmountValue;

            // Display results in labels
            sub_Total.Text = $"${subtotal.ToString("0.00")}";
            discountAmount.Text = $"${discountAmountValue.ToString("0.00")} ({discountPercentage * 100}%)";
            totalAmount.Text = $"${totalPayment.ToString("0.00")}";
        }

        private void newPurchaseButton_Click(object sender, EventArgs e)
        {
            CalculateMenu calc = new CalculateMenu();
            calc.Dock = DockStyle.Fill;
            calc.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(calc);
            calc.Show();
            productData.ShoppingCart.Items.Clear();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void discountAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void totalAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void sub_Total_Click(object sender, EventArgs e)
        {
            
        }
    }
}