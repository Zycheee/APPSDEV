using CuoreUI.Components;
using System;
using System.Windows.Forms;
using CuoreUI;


namespace InventoryManagement
{
    public partial class CartPage : Form
    {
        public CartPage()
        {
            InitializeComponent();

            // Add rows to DataGridView
            for (int i = 0; i < 40; i++)
            {
                grid.Rows.Add("Item " + i, i * 40, (10 + i));
            }
            // Editing the value of subtotal, discount, and total
            subTotal.Content = "$40.00";
            discountAmount.Content = "$20.00";
            totalAmount.Content = "$20.00";

            // Set EditMode to EditOnF2 to prevent editing on single click (requires double-click or F2)
            grid.EditMode = DataGridViewEditMode.EditOnF2;

            // Make the Price column (Column3) read-only
            grid.Columns["Column3"].ReadOnly = true;

            // Register the event handlers for validation
            this.grid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_CellValidating);
            this.grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            grid.Enabled = false;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            StartPage.MainPanel.Controls.Clear();
            ReceiptPage itemPage = new ReceiptPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            StartPage.MainPanel.Controls.Add(itemPage);
            itemPage.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            grid.Enabled = false;
        }

        private void cuiLabel4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is a button cell
                if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // Get item details for confirmation message
                    string itemName = grid.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "Unknown";
                    string quantity = grid.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "Unknown";
                    string price = grid.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "Unknown";

                    // Ask for confirmation before deleting
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to remove '{itemName}' from your cart?",
                        "Confirm Remove",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the row
                        grid.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show($"'{itemName}' has been removed from your cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recalculate totals after removing an item
                        RecalculateTotals();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to recalculate totals
        private void RecalculateTotals()
        {
            try
            {
                // Calculate new totals
                decimal total = 0;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        if (int.TryParse(row.Cells[1].Value.ToString(), out int quantity) &&
                            decimal.TryParse(row.Cells[2].Value.ToString(), out decimal price))
                        {
                            total += price * quantity;
                        }
                    }
                }

                // Update the UI with new totals
                subTotal.Content = $"${total:F2}";

                // Example discount calculation (20% discount)
                decimal discount = total * 0.2m;
                discountAmount.Content = $"${discount:F2}";

                // Final total
                totalAmount.Content = $"${(total - discount):F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating totals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }

        private void CartPage_Load(object sender, EventArgs e)
        {

        }

        private void CartPage_Load_1(object sender, EventArgs e)
        {

        }

        private void cuiLabel8_Load(object sender, EventArgs e)
        {

        }

        // --- DataGridView Validation ---
        private void grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = grid.Columns[e.ColumnIndex].HeaderText;
            string columnName = grid.Columns[e.ColumnIndex].Name; // Assuming names like ItemName, Price, Quantity

            // Skip validation for read-only columns
            if (grid.Columns[e.ColumnIndex].ReadOnly)
            {
                return;
            }

            // Clear previous errors
            grid.Rows[e.RowIndex].ErrorText = string.Empty;
            grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty; // Clear cell-specific error

            // Don't validate new rows or header clicks
            if (grid.Rows[e.RowIndex].IsNewRow) return;

            // Get the value being entered
            string valueToValidate = e.FormattedValue?.ToString() ?? string.Empty;

            try
            {
                // --- Validation Logic ---

                // Validate Item Name (Using actual column name "Column1" or header is "Item Name")
                if (columnName == "Column1" || headerText == "Item" || headerText == "Item Name") // Check both name and header for robustness
                {
                    if (string.IsNullOrWhiteSpace(valueToValidate))
                    {
                        e.Cancel = true; // Cancel the edit
                        grid.Rows[e.RowIndex].ErrorText = "Item Name cannot be empty.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Item Name cannot be empty."; // Set cell error
                        MessageBox.Show("Item Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valueToValidate.Length > 50) // Add max length validation
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Item Name cannot exceed 50 characters.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Item Name cannot exceed 50 characters.";
                        MessageBox.Show("Item Name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Validate Item Quantity (Using actual column name "Column2" or header is "Quantity")
                else if (columnName == "Column2" || headerText == "Quantity")
                {
                    if (string.IsNullOrWhiteSpace(valueToValidate))
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Quantity cannot be empty.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Quantity cannot be empty.";
                        MessageBox.Show("Quantity cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!int.TryParse(valueToValidate, out int quantity))
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Please enter a valid quantity.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Please enter a valid quantity.";
                        MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (quantity <= 0)
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Quantity must be greater than zero.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Quantity must be greater than zero.";
                        MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (quantity > 1000) // Add reasonable upper limit
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Quantity is too high.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Quantity is too high.";
                        MessageBox.Show("Quantity is too high. Maximum allowed is 1,000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // We don't need to validate the Price column anymore since it's read-only
                // The validation code for Column3 is removed to prevent any issues
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors during validation
                e.Cancel = true;
                grid.Rows[e.RowIndex].ErrorText = "An error occurred during validation.";
                grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "An error occurred during validation.";
                MessageBox.Show($"Validation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear error text when edit is complete and valid
            if (string.IsNullOrEmpty(grid.Rows[e.RowIndex].ErrorText))
            {
                // Preserve the original background color based on row index
                if (e.RowIndex % 2 == 0)
                {
                    // Even rows - use default color
                    grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = grid.DefaultCellStyle.BackColor;
                }
                else
                {
                    // Odd rows - use alternating color
                    grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = grid.AlternatingRowsDefaultCellStyle.BackColor;
                }

                // Recalculate totals if quantity changes
                if (grid.Columns[e.ColumnIndex].Name == "Column2")
                {
                    RecalculateTotals();
                }
            }
            else
            {
                // Highlight the cell with error
                grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
            }
        }
        // --- End DataGridView Validation ---
    }
}
