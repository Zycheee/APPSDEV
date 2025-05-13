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
    public partial class SalesPage : Form
    {
        public SalesPage()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                grid.Rows.Add(i, "Haggai " + i, (10 * i), i);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
