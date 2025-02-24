using GroceryCalculatorDiscountApp.Pages;


namespace GroceryCalculatorDiscountApp
{
    public partial class Menu : Form
    {
        public static Panel MainPanel;

        public Menu()
        {
            InitializeComponent();
            MainPanel = panel1;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SelectMenu select = new SelectMenu();
            select.Dock = DockStyle.Fill;
            select.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(select);
            select.Show();
        }

    }
}
