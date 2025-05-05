using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class InventoryPage : Form
    {
        public InventoryPage()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                grid.Rows.Add(i, "Item " + i, (10 + i));
            }

            // Set EditMode to EditOnF2 to prevent editing on single click (requires double-click or F2)
            grid.EditMode = DataGridViewEditMode.EditOnF2;

            // Register the event handlers for validation
            this.grid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_CellValidating);
            this.grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {

        }

        private void cuiLabel4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            DeleteButton.Enabled = false;
            grid.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            AddButton.Enabled = false;
            grid.Enabled = false;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Validation Start ---
                string itemIdStr = cuiTextBox4.Content.Trim();

                // Validate ID
                if (string.IsNullOrWhiteSpace(itemIdStr))
                {
                    MessageBox.Show("Item ID cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox4.Focus();
                    return; // Stop processing
                }

                if (!int.TryParse(itemIdStr, out int itemId))
                {
                    MessageBox.Show("Please enter a valid numeric Item ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox4.Focus();
                    return;
                }

                if (itemId < 0)
                {
                    MessageBox.Show("Item ID cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox4.Focus();
                    return;
                }
                // --- Validation End ---

                // Find and remove the item from the grid
                DataGridViewRow rowToRemove = null;
                string itemName = "";
                int quantity = 0;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[0].Value != null &&
                        int.TryParse(row.Cells[0].Value.ToString(), out int id) &&
                        id == itemId)
                    {
                        rowToRemove = row;
                        if (row.Cells[1].Value != null)
                        {
                            itemName = row.Cells[1].Value.ToString();
                        }
                        if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int qty))
                        {
                            quantity = qty;
                        }
                        break;
                    }
                }

                if (rowToRemove != null)
                {
                    // Ask for confirmation before deleting
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete item '{itemName}' with ID {itemId} and quantity {quantity}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        grid.Rows.Remove(rowToRemove);
                        MessageBox.Show($"Item '{itemName}' with ID {itemId} has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // User canceled the delete operation
                        MessageBox.Show("Delete operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Item with ID {itemId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                panel3.Visible = false;
                AddButton.Enabled = true;
                grid.Enabled = true;

                // Clear input field after delete attempt
                cuiTextBox4.Content = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Validation Start ---
                string itemIdStr = cuiTextBox1.Content.Trim();
                string itemName = cuiTextBox2.Content.Trim();
                string quantityStr = cuiTextBox2.Content.Trim();

                // Validate ID
                if (string.IsNullOrWhiteSpace(itemIdStr))
                {
                    MessageBox.Show("Item ID cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox1.Focus();
                    return;
                }

                if (!int.TryParse(itemIdStr, out int itemId))
                {
                    MessageBox.Show("Please enter a valid numeric Item ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox1.Focus();
                    return;
                }

                if (itemId < 0)
                {
                    MessageBox.Show("Item ID cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox1.Focus();
                    return;
                }

                // Check if ID already exists
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[0].Value != null &&
                        int.TryParse(row.Cells[0].Value.ToString(), out int existingId) &&
                        existingId == itemId)
                    {
                        MessageBox.Show($"Item with ID {itemId} already exists. Please use a different ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cuiTextBox1.Focus();
                        return;
                    }
                }

                // Validate Name
                if (string.IsNullOrWhiteSpace(itemName))
                {
                    MessageBox.Show("Item Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }

                if (itemName.Length > 50)
                {
                    MessageBox.Show("Item Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }

                // Validate Quantity
                if (string.IsNullOrWhiteSpace(quantityStr))
                {
                    MessageBox.Show("Quantity cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }

                if (!int.TryParse(quantityStr, out int quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }

                if (quantity < 0)
                {
                    MessageBox.Show("Quantity cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }

                if (quantity > 10000)
                {
                    MessageBox.Show("Quantity is too high. Maximum allowed is 10,000.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuiTextBox2.Focus();
                    return;
                }
                // --- Validation End ---

                // Add the new item to the grid
                grid.Rows.Add(itemId, itemName, quantity);

                // Show success message
                MessageBox.Show($"Item '{itemName}' added successfully with ID: {itemId} and quantity: {quantity}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the panel and restore UI state
                panel1.Visible = false;
                DeleteButton.Enabled = true;
                grid.Enabled = true;

                // Clear input fields after successful add
                cuiTextBox1.Content = "";
                cuiTextBox2.Content = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteButton.Enabled = true;
            grid.Enabled = true;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is a button cell
                if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // Get item details for confirmation message
                    string itemId = grid.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "Unknown";
                    string itemName = grid.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "Unknown";
                    string quantity = grid.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "Unknown";

                    // Ask for confirmation before deleting
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete item '{itemName}' with ID {itemId} and quantity {quantity}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the row
                        grid.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show($"Item '{itemName}' has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- DataGridView Validation ---
        private void grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = grid.Columns[e.ColumnIndex].HeaderText;
            string columnName = grid.Columns[e.ColumnIndex].Name; // Assuming names like ItemID, ItemName, ItemPrice

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

                // Validate Item Name (Using actual column name "Column2" or header is "Item Name")
                if (columnName == "Column2" || headerText == "Name" || headerText == "Item Name") // Check both name and header for robustness
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
                // Validate Item Quantity (Using actual column name "Column3" or header is "Quantity")
                else if (columnName == "Column3" || headerText == "Quantity")
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
                    else if (quantity < 0)
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Quantity cannot be negative.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Quantity cannot be negative.";
                        MessageBox.Show("Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (quantity > 10000) // Add reasonable upper limit
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Quantity is too high.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Quantity is too high.";
                        MessageBox.Show("Quantity is too high. Maximum allowed is 10,000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Validate Item ID (Using actual column name "Column1" or header is "Id")
                else if (columnName == "Column1" || headerText == "ID" || headerText == "Id")
                {
                    if (string.IsNullOrWhiteSpace(valueToValidate))
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Item ID cannot be empty.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Item ID cannot be empty.";
                        MessageBox.Show("Item ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!int.TryParse(valueToValidate, out int id)) // Assuming ID is integer
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Please enter a valid numeric Item ID.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Please enter a valid numeric Item ID.";
                        MessageBox.Show("Please enter a valid numeric Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (id < 0) // Ensure positive ID
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "Item ID cannot be negative.";
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Item ID cannot be negative.";
                        MessageBox.Show("Item ID cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
