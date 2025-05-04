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

            // Add a link column instead of a button column
            DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.Name = "DeleteButton";
            deleteColumn.Text = "Remove";
            deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;    
            deleteColumn.UseColumnTextForLinkValue = true;
            deleteColumn.Width = 30;
            deleteColumn.LinkColor = Color.Red;
            deleteColumn.VisitedLinkColor = Color.Red;
            deleteColumn.ActiveLinkColor = Color.Red;
            deleteColumn.LinkBehavior = LinkBehavior.NeverUnderline;
            deleteColumn.DefaultCellStyle.BackColor = grid.BackColor;
            deleteColumn.DefaultCellStyle.SelectionBackColor = grid.BackColor;
            grid.Columns.Add(deleteColumn);

            // Add sample data
            for (int i = 0; i < 50; i++)
            {
                grid.Rows.Add(i, "Item " + i, (10 + i));
            }

            // Disable selection highlighting for the grid
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;

            // Handle cell formatting to ensure consistent appearance
            grid.CellFormatting += Grid_CellFormatting;
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                e.CellStyle.BackColor = grid.BackColor;
                e.CellStyle.SelectionBackColor = grid.BackColor;
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the delete link column
            if (e.ColumnIndex == grid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the row
                    grid.Rows.RemoveAt(e.RowIndex);
                }
            }
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
            panel3.Visible = false;
            AddButton.Enabled = true;
            grid.Enabled = true;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteButton.Enabled = true;
            grid.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteButton.Enabled = true;
            grid.Enabled = true;
        }

    }
}
