using InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientStore
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            HomePage homePage = new HomePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Add(homePage);
            homePage.Show();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StartPage startPage = new StartPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Add(startPage);
            startPage.Show();
        }
    }
}
