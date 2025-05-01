using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();


        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ItemPage itemPage = new ItemPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(itemPage);
            itemPage.Show();

            SideHomePage.Visible = false;
            SideInventoryPage.Visible = false;
            SideItemPage.Visible = true;
            SideSalesPage.Visible = false;
            SideReportPage.Visible = false;
        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            SideHomePage.Visible = true;
            SideInventoryPage.Visible = false;
            SideItemPage.Visible = false;
            SideSalesPage.Visible = false;
            SideReportPage.Visible = false;

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            InventoryPage inventoryPage = new InventoryPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(inventoryPage);
            inventoryPage.Show();

            SideHomePage.Visible = false;
            SideInventoryPage.Visible = true;
            SideItemPage.Visible = false;
            SideSalesPage.Visible = false;
            SideReportPage.Visible = false;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            SalesPage salesPage = new SalesPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(salesPage);
            salesPage.Show();

            SideHomePage.Visible = false;
            SideInventoryPage.Visible = false;
            SideItemPage.Visible = false;
            SideSalesPage.Visible = true;
            SideReportPage.Visible = false;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ReportPage reportPage = new ReportPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(reportPage);
            reportPage.Show();

            SideHomePage.Visible = false;
            SideInventoryPage.Visible = false;
            SideItemPage.Visible = false;
            SideSalesPage.Visible = false;
            SideReportPage.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
