using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryCalculatorDiscountApp.Pages
{
    public partial class SelectMenu : Form
    {
        public SelectMenu()
        {
            InitializeComponent();
            exitButton.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            exitButton.BackColor = Color.Gray;


        }

        private void titleText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateMenu calc = new CalculateMenu();
            calc.Dock = DockStyle.Fill;
            calc.TopLevel = false;
            Menu.MainPanel.Controls.Clear();
            Menu.MainPanel.Controls.Add(calc);
            calc.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}
