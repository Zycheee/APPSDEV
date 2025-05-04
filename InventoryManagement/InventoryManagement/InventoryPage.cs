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
