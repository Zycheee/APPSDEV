using CuoreUI.Components;
using System;
using System.Windows.Forms;
using CuoreUI;


namespace InventoryManagement
{
    public partial class ItemPage : Form
    {
        public ItemPage()
        {
            InitializeComponent();

            // Example: Add rows to DataGridView
            for (int i = 0; i < 50; i++)
            {
                grid.Rows.Add(i, "Item " + i, (10 + i));
            }
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            DeleteButton.Enabled = false;
            grid.Enabled = false;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteButton.Enabled = true;
            grid.Enabled = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteButton.Enabled = true;
            grid.Enabled = true;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            AddButton.Enabled = false;
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

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            AddButton.Enabled = true;
            grid.Enabled = true;
        }
    }
}
