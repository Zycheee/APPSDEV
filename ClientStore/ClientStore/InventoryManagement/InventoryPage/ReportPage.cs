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
            annualSalesBar.Visible = false;
            monthlySalesBar.Visible = false;
            dailySalesBar.Visible = true;

        }

        private void monthlySalesButton_Click(object sender, EventArgs e)
        {
            annualSalesBar.Visible = false;
            monthlySalesBar.Visible = true;
            dailySalesBar.Visible = false;

        }

        private void annualSalesButton_Click(object sender, EventArgs e)
        {
            annualSalesBar.Visible = true;
            monthlySalesBar.Visible = false;
            dailySalesBar.Visible = false;

        }

        private void datePicker1_Load(object sender, EventArgs e)
        {

        }

        private void datePicker2_Load(object sender, EventArgs e)
        {

        }
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            // Get the selected dates (we're not using them yet, but keeping the code for future implementation)
            String firstDate = datePicker1.Value.ToString();
            String secondDate = datePicker2.Value.ToString();

            // Clear the panel and create the filtered report
            this.panel1.Controls.Clear();
            FilteredSalesReport salesPage = new FilteredSalesReport()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel1.Controls.Add(salesPage);
            salesPage.Show();
        }

        private void salesText_Click(object sender, EventArgs e)
        {

        }

        private void datePicker1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
