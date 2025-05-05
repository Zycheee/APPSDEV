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
    public partial class FilteredSalesReport : Form
    {
        public FilteredSalesReport()
        {
            InitializeComponent();
            for (int i = 0; i < 55; i++)
            {
                // Use current date instead of future date
                DateTime currentDate = DateTime.Now.AddDays(-i % 30); // Use dates within the last 30 days
                dailySales.Rows.Add(i, "Item " + i, i * 54, currentDate.ToShortDateString());
            }
        }

        private void dailySales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No action needed for cell clicks
        }
    }
}
