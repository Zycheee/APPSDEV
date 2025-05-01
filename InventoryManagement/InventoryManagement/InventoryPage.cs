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
                grid.Rows.Add(i, "Item " + i,  (10 + i));
            }
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
