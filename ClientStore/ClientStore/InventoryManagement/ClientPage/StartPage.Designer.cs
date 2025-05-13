namespace InventoryManagement
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            productButton = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            exitButton = new CuoreUI.Controls.cuiButton();
            SideHomePage = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            viewCartButton = new CuoreUI.Controls.cuiButton();
            panel2 = new Panel();
            SideItemPage = new CuoreUI.Controls.cuiPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productButton
            // 
            productButton.BackColor = Color.Transparent;
            productButton.BackgroundImageLayout = ImageLayout.None;
            productButton.CheckButton = false;
            productButton.Checked = false;
            productButton.CheckedBackground = Color.Transparent;
            productButton.CheckedForeColor = Color.Transparent;
            productButton.CheckedImageTint = Color.Transparent;
            productButton.CheckedOutline = Color.Transparent;
            productButton.Content = "Products";
            productButton.DialogResult = DialogResult.None;
            productButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productButton.ForeColor = Color.White;
            productButton.HoverBackground = Color.FromArgb(96, 138, 227);
            productButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            productButton.HoverForeColor = Color.White;
            productButton.HoverOutline = Color.Transparent;
            productButton.Image = (Image)resources.GetObject("productButton.Image");
            productButton.ImageAutoCenter = true;
            productButton.ImageExpand = new Point(7, 7);
            productButton.ImageOffset = new Point(-20, 0);
            productButton.Location = new Point(23, 129);
            productButton.Name = "productButton";
            productButton.NormalBackground = Color.Transparent;
            productButton.NormalForeColor = Color.White;
            productButton.NormalImageTint = Color.White;
            productButton.NormalOutline = Color.Transparent;
            productButton.OutlineThickness = 1F;
            productButton.PressedBackground = Color.FromArgb(103, 152, 255);
            productButton.PressedForeColor = Color.White;
            productButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            productButton.PressedOutline = Color.Transparent;
            productButton.Rounding = new Padding(8);
            productButton.Size = new Size(194, 74);
            productButton.TabIndex = 1;
            productButton.TextAlignment = StringAlignment.Center;
            productButton.TextOffset = new Point(0, 3);
            productButton.Click += HomeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 79, 115);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(SideHomePage);
            panel1.Controls.Add(cuiLabel1);
            panel1.Controls.Add(viewCartButton);
            panel1.Controls.Add(productButton);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 697);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.CheckButton = false;
            exitButton.Checked = false;
            exitButton.CheckedBackground = Color.Transparent;
            exitButton.CheckedForeColor = Color.Transparent;
            exitButton.CheckedImageTint = Color.Transparent;
            exitButton.CheckedOutline = Color.Transparent;
            exitButton.Content = "Exit";
            exitButton.DialogResult = DialogResult.None;
            exitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.HoverBackground = Color.FromArgb(96, 138, 227);
            exitButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            exitButton.HoverForeColor = Color.White;
            exitButton.HoverOutline = Color.Transparent;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.ImageAutoCenter = true;
            exitButton.ImageExpand = new Point(9, 9);
            exitButton.ImageOffset = new Point(-40, 0);
            exitButton.Location = new Point(23, 584);
            exitButton.Name = "exitButton";
            exitButton.NormalBackground = Color.Transparent;
            exitButton.NormalForeColor = Color.White;
            exitButton.NormalImageTint = Color.White;
            exitButton.NormalOutline = Color.Transparent;
            exitButton.OutlineThickness = 1F;
            exitButton.PressedBackground = Color.FromArgb(103, 152, 255);
            exitButton.PressedForeColor = Color.White;
            exitButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            exitButton.PressedOutline = Color.Transparent;
            exitButton.Rounding = new Padding(8);
            exitButton.Size = new Size(194, 74);
            exitButton.TabIndex = 3;
            exitButton.TextAlignment = StringAlignment.Center;
            exitButton.TextOffset = new Point(-20, 3);
            exitButton.Click += exitButton_Click;
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
            // cuiLabel1
            // 
            cuiLabel1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel1.BackgroundImage = ClientStore.Properties.Resources.icons8_grid_100;
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
            // viewCartButton
            // 
            viewCartButton.BackColor = Color.Transparent;
            viewCartButton.BackgroundImageLayout = ImageLayout.None;
            viewCartButton.CheckButton = false;
            viewCartButton.Checked = false;
            viewCartButton.CheckedBackground = Color.Transparent;
            viewCartButton.CheckedForeColor = Color.Transparent;
            viewCartButton.CheckedImageTint = Color.Transparent;
            viewCartButton.CheckedOutline = Color.Transparent;
            viewCartButton.Content = "Cart";
            viewCartButton.DialogResult = DialogResult.None;
            viewCartButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewCartButton.ForeColor = Color.White;
            viewCartButton.HoverBackground = Color.FromArgb(96, 138, 227);
            viewCartButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            viewCartButton.HoverForeColor = Color.White;
            viewCartButton.HoverOutline = Color.Transparent;
            viewCartButton.Image = (Image)resources.GetObject("viewCartButton.Image");
            viewCartButton.ImageAutoCenter = true;
            viewCartButton.ImageExpand = new Point(9, 9);
            viewCartButton.ImageOffset = new Point(-40, 0);
            viewCartButton.Location = new Point(23, 211);
            viewCartButton.Name = "viewCartButton";
            viewCartButton.NormalBackground = Color.Transparent;
            viewCartButton.NormalForeColor = Color.White;
            viewCartButton.NormalImageTint = Color.White;
            viewCartButton.NormalOutline = Color.Transparent;
            viewCartButton.OutlineThickness = 1F;
            viewCartButton.PressedBackground = Color.FromArgb(103, 152, 255);
            viewCartButton.PressedForeColor = Color.White;
            viewCartButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            viewCartButton.PressedOutline = Color.Transparent;
            viewCartButton.Rounding = new Padding(8);
            viewCartButton.Size = new Size(194, 74);
            viewCartButton.TabIndex = 1;
            viewCartButton.TextAlignment = StringAlignment.Center;
            viewCartButton.TextOffset = new Point(-17, 3);
            viewCartButton.Click += ItemButton_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 683);
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
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1264, 681);
            Controls.Add(SideItemPage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load_2;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CuoreUI.Controls.cuiButton productButton;
        private CuoreUI.Controls.cuiButton viewCartButton;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel2;
        private CuoreUI.Controls.cuiPanel SideItemPage;
        private CuoreUI.Controls.cuiPanel SideHomePage;
        private CuoreUI.Controls.cuiButton exitButton;
    }
}