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
    public partial class ReceiptPage : Form
    {
        public ReceiptPage()
        {
            InitializeComponent();


        }

        private void dailySales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthlySales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthlySalesBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dailySalesButton_Click(object sender, EventArgs e)
        {


        }

        private void monthlySalesButton_Click(object sender, EventArgs e)
        {


        }

        private void annualSalesButton_Click(object sender, EventArgs e)
        {


        }

        private void datePicker1_Load(object sender, EventArgs e)
        {

        }

        private void datePicker2_Load(object sender, EventArgs e)
        {

        }
        private void submitButton_Click_1(object sender, EventArgs e)
        {



        }

        private void salesText_Click(object sender, EventArgs e)
        {

        }

        private void datePicker1_Load_1(object sender, EventArgs e)
        {

        }

        private void ReceiptPage_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartPage.MainPanel.Controls.Clear();
            ProductPage tutorialPage = new ProductPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            StartPage.MainPanel.Controls.Add(tutorialPage);
            tutorialPage.Show();

            StartPage.SideHomePage_.Visible = true;
            StartPage.SideItemPage_.Visible = false;


        }
    }
}
