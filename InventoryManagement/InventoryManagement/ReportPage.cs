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
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                grid.Rows.Add(i, (i + 1) + "/" + (i * 2) + "/2025", (10 * i), (i + 1) + "/" + (i * 2) + "/2025");

            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
