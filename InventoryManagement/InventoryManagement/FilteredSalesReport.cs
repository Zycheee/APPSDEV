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
                dailySales.Rows.Add(i, "Item " + i, i * 54, (i + 1) + "/" + (i * 2) + "/2025");


            }
        }

        private void dailySales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
