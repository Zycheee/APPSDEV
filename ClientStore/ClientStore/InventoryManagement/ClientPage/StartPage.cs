using ClientStore;
using CuoreUI.Controls;
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
    public partial class StartPage : Form
    {
        public static Panel SideHomePage_;
        public static Panel MainPanel;
        public static Panel SideItemPage_;

        public StartPage()

        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            MainPanel = panel2;
            ProductPage tutorialPage = new ProductPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(tutorialPage);
            tutorialPage.Show();
            SideItemPage_ = SideItemPage;
            SideHomePage_ = SideHomePage;

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
            CartPage itemPage = new CartPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(itemPage);
            itemPage.Show();

            SideHomePage.Visible = false;
            SideItemPage.Visible = true;
        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ProductPage tutorialPage = new ProductPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(tutorialPage);
            tutorialPage.Show();

            SideHomePage.Visible = true;
            SideItemPage.Visible = false;
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ProductPage salesPage = new ProductPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(salesPage);
            salesPage.Show();

            SideHomePage.Visible = false;
            SideItemPage.Visible = false;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ReceiptPage reportPage = new ReceiptPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(reportPage);
            reportPage.Show();

            SideHomePage.Visible = false;
            SideItemPage.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuiLabel3_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load_2(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StartingPage itemPage = new StartingPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Add(itemPage);
            itemPage.Show();
        }
    }
}
