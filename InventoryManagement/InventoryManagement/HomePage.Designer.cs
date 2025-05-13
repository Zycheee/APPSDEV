namespace InventoryManagement
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            HomeButton = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            logoutPanel = new CuoreUI.Controls.cuiPanel();
            logoutButton = new CuoreUI.Controls.cuiButton();
            settingsButton = new CuoreUI.Controls.cuiButton();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            SideHomePage = new CuoreUI.Controls.cuiPanel();
            SideReportPage = new CuoreUI.Controls.cuiPanel();
            SideSalesPage = new CuoreUI.Controls.cuiPanel();
            SideInventoryPage = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            ReportButton = new CuoreUI.Controls.cuiButton();
            SalesButton = new CuoreUI.Controls.cuiButton();
            InventoryButton = new CuoreUI.Controls.cuiButton();
            ItemButton = new CuoreUI.Controls.cuiButton();
            panel2 = new Panel();
            SideItemPage = new CuoreUI.Controls.cuiPanel();
            panel1.SuspendLayout();
            logoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Transparent;
            HomeButton.BackgroundImageLayout = ImageLayout.None;
            HomeButton.CheckButton = false;
            HomeButton.Checked = false;
            HomeButton.CheckedBackground = Color.Transparent;
            HomeButton.CheckedForeColor = Color.Transparent;
            HomeButton.CheckedImageTint = Color.Transparent;
            HomeButton.CheckedOutline = Color.Transparent;
            HomeButton.Content = "Home";
            HomeButton.DialogResult = DialogResult.None;
            HomeButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.HoverBackground = Color.FromArgb(96, 138, 227);
            HomeButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            HomeButton.HoverForeColor = Color.White;
            HomeButton.HoverOutline = Color.Transparent;
            HomeButton.Image = Properties.Resources.icons8_home_50;
            HomeButton.ImageAutoCenter = true;
            HomeButton.ImageExpand = new Point(7, 7);
            HomeButton.ImageOffset = new Point(-20, 0);
            HomeButton.Location = new Point(23, 129);
            HomeButton.Name = "HomeButton";
            HomeButton.NormalBackground = Color.Transparent;
            HomeButton.NormalForeColor = Color.White;
            HomeButton.NormalImageTint = Color.White;
            HomeButton.NormalOutline = Color.Transparent;
            HomeButton.OutlineThickness = 1F;
            HomeButton.PressedBackground = Color.FromArgb(103, 152, 255);
            HomeButton.PressedForeColor = Color.White;
            HomeButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            HomeButton.PressedOutline = Color.Transparent;
            HomeButton.Rounding = new Padding(8);
            HomeButton.Size = new Size(194, 74);
            HomeButton.TabIndex = 1;
            HomeButton.TextAlignment = StringAlignment.Center;
            HomeButton.TextOffset = new Point(0, 3);
            HomeButton.Click += HomeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 79, 115);
            panel1.Controls.Add(logoutPanel);
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(cuiLabel2);
            panel1.Controls.Add(SideHomePage);
            panel1.Controls.Add(SideReportPage);
            panel1.Controls.Add(SideSalesPage);
            panel1.Controls.Add(SideInventoryPage);
            panel1.Controls.Add(cuiLabel1);
            panel1.Controls.Add(ReportButton);
            panel1.Controls.Add(SalesButton);
            panel1.Controls.Add(InventoryButton);
            panel1.Controls.Add(ItemButton);
            panel1.Controls.Add(HomeButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 697);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutButton);
            logoutPanel.Location = new Point(118, 532);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.OutlineThickness = 1F;
            logoutPanel.PanelColor = Color.FromArgb(65, 66, 85);
            logoutPanel.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            logoutPanel.Rounding = new Padding(8);
            logoutPanel.Size = new Size(112, 77);
            logoutPanel.TabIndex = 1;
            logoutPanel.Visible = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Transparent;
            logoutButton.BackgroundImageLayout = ImageLayout.None;
            logoutButton.CheckButton = false;
            logoutButton.Checked = false;
            logoutButton.CheckedBackground = Color.Transparent;
            logoutButton.CheckedForeColor = Color.Transparent;
            logoutButton.CheckedImageTint = Color.Transparent;
            logoutButton.CheckedOutline = Color.Transparent;
            logoutButton.Content = "Logout";
            logoutButton.DialogResult = DialogResult.None;
            logoutButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.HoverBackground = Color.FromArgb(96, 138, 227);
            logoutButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            logoutButton.HoverForeColor = Color.White;
            logoutButton.HoverOutline = Color.Transparent;
            logoutButton.Image = null;
            logoutButton.ImageAutoCenter = true;
            logoutButton.ImageExpand = new Point(7, 7);
            logoutButton.ImageOffset = new Point(-20, 0);
            logoutButton.Location = new Point(11, 20);
            logoutButton.Name = "logoutButton";
            logoutButton.NormalBackground = Color.Transparent;
            logoutButton.NormalForeColor = Color.White;
            logoutButton.NormalImageTint = Color.White;
            logoutButton.NormalOutline = Color.Transparent;
            logoutButton.OutlineThickness = 1F;
            logoutButton.PressedBackground = Color.FromArgb(103, 152, 255);
            logoutButton.PressedForeColor = Color.White;
            logoutButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            logoutButton.PressedOutline = Color.Transparent;
            logoutButton.Rounding = new Padding(5);
            logoutButton.Size = new Size(93, 40);
            logoutButton.TabIndex = 2;
            logoutButton.TextAlignment = StringAlignment.Center;
            logoutButton.TextOffset = new Point(0, 0);
            logoutButton.Click += logoutButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.Transparent;
            settingsButton.BackgroundImageLayout = ImageLayout.None;
            settingsButton.CheckButton = false;
            settingsButton.Checked = false;
            settingsButton.CheckedBackground = Color.Transparent;
            settingsButton.CheckedForeColor = Color.Transparent;
            settingsButton.CheckedImageTint = Color.Transparent;
            settingsButton.CheckedOutline = Color.Transparent;
            settingsButton.Content = "";
            settingsButton.DialogResult = DialogResult.None;
            settingsButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsButton.ForeColor = Color.White;
            settingsButton.HoverBackground = Color.FromArgb(96, 138, 227);
            settingsButton.HoveredImageTint = Color.White;
            settingsButton.HoverForeColor = Color.White;
            settingsButton.HoverOutline = Color.Transparent;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.ImageAutoCenter = true;
            settingsButton.ImageExpand = new Point(1, 1);
            settingsButton.ImageOffset = new Point(0, 0);
            settingsButton.Location = new Point(188, 615);
            settingsButton.Name = "settingsButton";
            settingsButton.NormalBackground = Color.Transparent;
            settingsButton.NormalForeColor = Color.White;
            settingsButton.NormalImageTint = Color.White;
            settingsButton.NormalOutline = Color.Transparent;
            settingsButton.OutlineThickness = 1F;
            settingsButton.PressedBackground = Color.FromArgb(103, 152, 255);
            settingsButton.PressedForeColor = Color.White;
            settingsButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            settingsButton.PressedOutline = Color.Transparent;
            settingsButton.Rounding = new Padding(15);
            settingsButton.Size = new Size(42, 36);
            settingsButton.TabIndex = 7;
            settingsButton.TextAlignment = StringAlignment.Center;
            settingsButton.TextOffset = new Point(0, 3);
            settingsButton.Click += settingsButton_Click;
            // 
            // cuiLabel2
            // 
            cuiLabel2.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel2.BackgroundImage = (Image)resources.GetObject("cuiLabel2.BackgroundImage");
            cuiLabel2.BackgroundImageLayout = ImageLayout.None;
            cuiLabel2.Content = "Admin";
            cuiLabel2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(23, 598);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(232, 71);
            cuiLabel2.TabIndex = 5;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // SideHomePage
            // 
            SideHomePage.BackColor = Color.FromArgb(64, 79, 115);
            SideHomePage.Location = new Point(-15, 129);
            SideHomePage.Name = "SideHomePage";
            SideHomePage.OutlineThickness = 1F;
            SideHomePage.PanelColor = Color.FromArgb(59, 143, 253);
            SideHomePage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideHomePage.Rounding = new Padding(8);
            SideHomePage.Size = new Size(25, 76);
            SideHomePage.TabIndex = 2;
            SideHomePage.Visible = false;
            // 
            // SideReportPage
            // 
            SideReportPage.BackColor = Color.FromArgb(64, 79, 115);
            SideReportPage.Location = new Point(-15, 449);
            SideReportPage.Name = "SideReportPage";
            SideReportPage.OutlineThickness = 1F;
            SideReportPage.PanelColor = Color.FromArgb(59, 143, 253);
            SideReportPage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideReportPage.Rounding = new Padding(8);
            SideReportPage.Size = new Size(25, 74);
            SideReportPage.TabIndex = 4;
            SideReportPage.Visible = false;
            // 
            // SideSalesPage
            // 
            SideSalesPage.BackColor = Color.FromArgb(64, 79, 115);
            SideSalesPage.Location = new Point(-15, 369);
            SideSalesPage.Name = "SideSalesPage";
            SideSalesPage.OutlineThickness = 1F;
            SideSalesPage.PanelColor = Color.FromArgb(59, 143, 253);
            SideSalesPage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideSalesPage.Rounding = new Padding(8);
            SideSalesPage.Size = new Size(25, 74);
            SideSalesPage.TabIndex = 2;
            SideSalesPage.Visible = false;
            // 
            // SideInventoryPage
            // 
            SideInventoryPage.BackColor = Color.FromArgb(64, 79, 115);
            SideInventoryPage.Location = new Point(-15, 289);
            SideInventoryPage.Name = "SideInventoryPage";
            SideInventoryPage.OutlineThickness = 1F;
            SideInventoryPage.PanelColor = Color.FromArgb(59, 143, 253);
            SideInventoryPage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideInventoryPage.Rounding = new Padding(8);
            SideInventoryPage.Size = new Size(25, 74);
            SideInventoryPage.TabIndex = 2;
            SideInventoryPage.Visible = false;
            // 
            // cuiLabel1
            // 
            cuiLabel1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel1.BackgroundImage = Properties.Resources.icons8_grid_100;
            cuiLabel1.BackgroundImageLayout = ImageLayout.None;
            cuiLabel1.Content = "Stockly";
            cuiLabel1.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(0, 12);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(310, 98);
            cuiLabel1.TabIndex = 2;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // ReportButton
            // 
            ReportButton.BackColor = Color.Transparent;
            ReportButton.BackgroundImageLayout = ImageLayout.None;
            ReportButton.CheckButton = false;
            ReportButton.Checked = false;
            ReportButton.CheckedBackground = Color.Transparent;
            ReportButton.CheckedForeColor = Color.Transparent;
            ReportButton.CheckedImageTint = Color.Transparent;
            ReportButton.CheckedOutline = Color.Transparent;
            ReportButton.Content = "Report";
            ReportButton.DialogResult = DialogResult.None;
            ReportButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportButton.ForeColor = Color.White;
            ReportButton.HoverBackground = Color.FromArgb(96, 138, 227);
            ReportButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            ReportButton.HoverForeColor = Color.White;
            ReportButton.HoverOutline = Color.Transparent;
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAutoCenter = true;
            ReportButton.ImageExpand = new Point(7, 7);
            ReportButton.ImageOffset = new Point(-20, 0);
            ReportButton.Location = new Point(23, 449);
            ReportButton.Name = "ReportButton";
            ReportButton.NormalBackground = Color.Transparent;
            ReportButton.NormalForeColor = Color.White;
            ReportButton.NormalImageTint = Color.White;
            ReportButton.NormalOutline = Color.Transparent;
            ReportButton.OutlineThickness = 1F;
            ReportButton.PressedBackground = Color.FromArgb(103, 152, 255);
            ReportButton.PressedForeColor = Color.White;
            ReportButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            ReportButton.PressedOutline = Color.Transparent;
            ReportButton.Rounding = new Padding(8);
            ReportButton.Size = new Size(194, 74);
            ReportButton.TabIndex = 1;
            ReportButton.TextAlignment = StringAlignment.Center;
            ReportButton.TextOffset = new Point(0, 3);
            ReportButton.Click += ReportButton_Click;
            // 
            // SalesButton
            // 
            SalesButton.BackColor = Color.Transparent;
            SalesButton.BackgroundImageLayout = ImageLayout.None;
            SalesButton.CheckButton = false;
            SalesButton.Checked = false;
            SalesButton.CheckedBackground = Color.Transparent;
            SalesButton.CheckedForeColor = Color.Transparent;
            SalesButton.CheckedImageTint = Color.Transparent;
            SalesButton.CheckedOutline = Color.Transparent;
            SalesButton.Content = "Sales";
            SalesButton.DialogResult = DialogResult.None;
            SalesButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalesButton.ForeColor = Color.White;
            SalesButton.HoverBackground = Color.FromArgb(96, 138, 227);
            SalesButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            SalesButton.HoverForeColor = Color.White;
            SalesButton.HoverOutline = Color.Transparent;
            SalesButton.Image = Properties.Resources.icons8_sales_50;
            SalesButton.ImageAutoCenter = true;
            SalesButton.ImageExpand = new Point(7, 7);
            SalesButton.ImageOffset = new Point(-20, 0);
            SalesButton.Location = new Point(23, 369);
            SalesButton.Name = "SalesButton";
            SalesButton.NormalBackground = Color.Transparent;
            SalesButton.NormalForeColor = Color.White;
            SalesButton.NormalImageTint = Color.White;
            SalesButton.NormalOutline = Color.Transparent;
            SalesButton.OutlineThickness = 1F;
            SalesButton.PressedBackground = Color.FromArgb(103, 152, 255);
            SalesButton.PressedForeColor = Color.White;
            SalesButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            SalesButton.PressedOutline = Color.Transparent;
            SalesButton.Rounding = new Padding(8);
            SalesButton.Size = new Size(194, 74);
            SalesButton.TabIndex = 1;
            SalesButton.TextAlignment = StringAlignment.Center;
            SalesButton.TextOffset = new Point(0, 3);
            SalesButton.Click += SalesButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.Transparent;
            InventoryButton.BackgroundImageLayout = ImageLayout.None;
            InventoryButton.CheckButton = false;
            InventoryButton.Checked = false;
            InventoryButton.CheckedBackground = Color.Transparent;
            InventoryButton.CheckedForeColor = Color.Transparent;
            InventoryButton.CheckedImageTint = Color.Transparent;
            InventoryButton.CheckedOutline = Color.Transparent;
            InventoryButton.Content = "Inventory";
            InventoryButton.DialogResult = DialogResult.None;
            InventoryButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = Color.White;
            InventoryButton.HoverBackground = Color.FromArgb(96, 138, 227);
            InventoryButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            InventoryButton.HoverForeColor = Color.White;
            InventoryButton.HoverOutline = Color.Transparent;
            InventoryButton.Image = Properties.Resources.icons8_inventory_50;
            InventoryButton.ImageAutoCenter = true;
            InventoryButton.ImageExpand = new Point(7, 7);
            InventoryButton.ImageOffset = new Point(-3, 0);
            InventoryButton.Location = new Point(23, 289);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.NormalBackground = Color.Transparent;
            InventoryButton.NormalForeColor = Color.White;
            InventoryButton.NormalImageTint = Color.White;
            InventoryButton.NormalOutline = Color.Transparent;
            InventoryButton.OutlineThickness = 1F;
            InventoryButton.PressedBackground = Color.FromArgb(103, 152, 255);
            InventoryButton.PressedForeColor = Color.White;
            InventoryButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            InventoryButton.PressedOutline = Color.Transparent;
            InventoryButton.Rounding = new Padding(8);
            InventoryButton.Size = new Size(194, 74);
            InventoryButton.TabIndex = 1;
            InventoryButton.TextAlignment = StringAlignment.Center;
            InventoryButton.TextOffset = new Point(20, 0);
            InventoryButton.Click += InventoryButton_Click;
            // 
            // ItemButton
            // 
            ItemButton.BackColor = Color.Transparent;
            ItemButton.BackgroundImageLayout = ImageLayout.None;
            ItemButton.CheckButton = false;
            ItemButton.Checked = false;
            ItemButton.CheckedBackground = Color.Transparent;
            ItemButton.CheckedForeColor = Color.Transparent;
            ItemButton.CheckedImageTint = Color.Transparent;
            ItemButton.CheckedOutline = Color.Transparent;
            ItemButton.Content = "Item";
            ItemButton.DialogResult = DialogResult.None;
            ItemButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemButton.ForeColor = Color.White;
            ItemButton.HoverBackground = Color.FromArgb(96, 138, 227);
            ItemButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            ItemButton.HoverForeColor = Color.White;
            ItemButton.HoverOutline = Color.Transparent;
            ItemButton.Image = Properties.Resources.icons8_item_50;
            ItemButton.ImageAutoCenter = true;
            ItemButton.ImageExpand = new Point(7, 7);
            ItemButton.ImageOffset = new Point(-28, 0);
            ItemButton.Location = new Point(23, 211);
            ItemButton.Name = "ItemButton";
            ItemButton.NormalBackground = Color.Transparent;
            ItemButton.NormalForeColor = Color.White;
            ItemButton.NormalImageTint = Color.White;
            ItemButton.NormalOutline = Color.Transparent;
            ItemButton.OutlineThickness = 1F;
            ItemButton.PressedBackground = Color.FromArgb(103, 152, 255);
            ItemButton.PressedForeColor = Color.White;
            ItemButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            ItemButton.PressedOutline = Color.Transparent;
            ItemButton.Rounding = new Padding(8);
            ItemButton.Size = new Size(194, 74);
            ItemButton.TabIndex = 1;
            ItemButton.TextAlignment = StringAlignment.Center;
            ItemButton.TextOffset = new Point(-7, 3);
            ItemButton.Click += ItemButton_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 679);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // SideItemPage
            // 
            SideItemPage.BackColor = Color.FromArgb(64, 79, 115);
            SideItemPage.Location = new Point(-14, 211);
            SideItemPage.Name = "SideItemPage";
            SideItemPage.OutlineThickness = 1F;
            SideItemPage.PanelColor = Color.FromArgb(59, 143, 253);
            SideItemPage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideItemPage.Rounding = new Padding(8);
            SideItemPage.Size = new Size(25, 74);
            SideItemPage.TabIndex = 1;
            SideItemPage.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1264, 681);
            Controls.Add(SideItemPage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "HomePage";
            Text = "HomePage";
            panel1.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CuoreUI.Controls.cuiButton HomeButton;
        private CuoreUI.Controls.cuiButton ReportButton;
        private CuoreUI.Controls.cuiButton SalesButton;
        private CuoreUI.Controls.cuiButton InventoryButton;
        private CuoreUI.Controls.cuiButton ItemButton;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel2;
        private CuoreUI.Controls.cuiPanel SideItemPage;
        private CuoreUI.Controls.cuiPanel SideInventoryPage;
        private CuoreUI.Controls.cuiPanel SideReportPage;
        private CuoreUI.Controls.cuiPanel SideSalesPage;
        private CuoreUI.Controls.cuiPanel SideHomePage;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton settingsButton;
        private CuoreUI.Controls.cuiPanel logoutPanel;
        private CuoreUI.Controls.cuiButton logoutButton;
    }
}