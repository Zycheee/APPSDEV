namespace GroceryCalculatorDiscountApp.Pages
{
    partial class ShoppingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingList));
            productLabel = new Label();
            panel2 = new Panel();
            productTable = new TableLayoutPanel();
            panel3 = new Panel();
            label6 = new Label();
            placeOrderButton = new Button();
            label5 = new Label();
            totalAmount = new Label();
            discountAmount = new Label();
            subTotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            SideProductItemPage = new CuoreUI.Controls.cuiPanel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            ProductButton = new CuoreUI.Controls.cuiButton();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Arial", 22F);
            productLabel.ForeColor = Color.Black;
            productLabel.Location = new Point(42, 34);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(118, 35);
            productLabel.TabIndex = 2;
            productLabel.Text = "Product";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(productTable);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(productLabel);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(291, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 518);
            panel2.TabIndex = 3;
            // 
            // productTable
            // 
            productTable.ColumnCount = 4;
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.7647057F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.2352943F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            productTable.ForeColor = Color.Black;
            productTable.Location = new Point(42, 84);
            productTable.Name = "productTable";
            productTable.RowCount = 1;
            productTable.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            productTable.Size = new Size(448, 44);
            productTable.TabIndex = 5;
            productTable.Paint += productTable_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(placeOrderButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(totalAmount);
            panel3.Controls.Add(discountAmount);
            panel3.Controls.Add(subTotal);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(533, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 330);
            panel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(31, 190);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 2;
            label6.Text = "Total Payment: ";
            // 
            // placeOrderButton
            // 
            placeOrderButton.BackColor = Color.FromArgb(44, 50, 58);
            placeOrderButton.Cursor = Cursors.Hand;
            placeOrderButton.FlatStyle = FlatStyle.Flat;
            placeOrderButton.Font = new Font("Arial", 15F);
            placeOrderButton.ForeColor = SystemColors.Window;
            placeOrderButton.Location = new Point(65, 255);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(243, 56);
            placeOrderButton.TabIndex = 3;
            placeOrderButton.TabStop = false;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = false;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 132);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 2;
            label5.Text = "Discount amount:";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Arial", 13F);
            totalAmount.ForeColor = Color.Black;
            totalAmount.Location = new Point(253, 190);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(55, 21);
            totalAmount.TabIndex = 2;
            totalAmount.Text = "$0.00";
            // 
            // discountAmount
            // 
            discountAmount.AutoSize = true;
            discountAmount.Font = new Font("Arial", 13F);
            discountAmount.ForeColor = Color.Black;
            discountAmount.Location = new Point(253, 130);
            discountAmount.Name = "discountAmount";
            discountAmount.Size = new Size(55, 21);
            discountAmount.TabIndex = 2;
            discountAmount.Text = "$0.00";
            // 
            // subTotal
            // 
            subTotal.AutoSize = true;
            subTotal.Font = new Font("Arial", 13F);
            subTotal.ForeColor = Color.Black;
            subTotal.Location = new Point(253, 74);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(55, 21);
            subTotal.TabIndex = 2;
            subTotal.Text = "$0.00";
            subTotal.Click += subTotal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(31, 76);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 2;
            label4.Text = "Subtotal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(148, 21);
            label3.Name = "label3";
            label3.Size = new Size(62, 27);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(364, 34);
            label2.Name = "label2";
            label2.Size = new Size(126, 35);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 35);
            label1.TabIndex = 2;
            label1.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(719, 28);
            label7.Name = "label7";
            label7.Size = new Size(353, 56);
            label7.TabIndex = 2;
            label7.Text = "Shopping Cart";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 79, 115);
            panel1.Controls.Add(SideProductItemPage);
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(ProductButton);
            panel1.Controls.Add(cuiButtonGroup2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 722);
            panel1.TabIndex = 11;
            // 
            // SideProductItemPage
            // 
            SideProductItemPage.Location = new Point(-12, 170);
            SideProductItemPage.Name = "SideProductItemPage";
            SideProductItemPage.OutlineThickness = 1F;
            SideProductItemPage.PanelColor = Color.FromArgb(59, 143, 253);
            SideProductItemPage.PanelOutlineColor = Color.FromArgb(59, 143, 253);
            SideProductItemPage.Rounding = new Padding(8);
            SideProductItemPage.Size = new Size(22, 76);
            SideProductItemPage.TabIndex = 2;
            SideProductItemPage.Paint += cuiPanel1_Paint;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CausesValidation = false;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.Transparent;
            cuiButton1.CheckedForeColor = Color.Transparent;
            cuiButton1.CheckedImageTint = Color.Transparent;
            cuiButton1.CheckedOutline = Color.Transparent;
            cuiButton1.Content = "Shopping Cart";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.FromArgb(96, 138, 227);
            cuiButton1.HoveredImageTint = Color.FromArgb(96, 138, 227);
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverOutline = Color.Transparent;
            cuiButton1.Image = (Image)resources.GetObject("cuiButton1.Image");
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(7, 7);
            cuiButton1.ImageOffset = new Point(-20, 0);
            cuiButton1.Location = new Point(16, 176);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Transparent;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.Transparent;
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.FromArgb(103, 152, 255);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.FromArgb(96, 138, 227);
            cuiButton1.PressedOutline = Color.Transparent;
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(253, 74);
            cuiButton1.TabIndex = 4;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 3);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // ProductButton
            // 
            ProductButton.BackColor = Color.Transparent;
            ProductButton.BackgroundImageLayout = ImageLayout.None;
            ProductButton.CheckButton = false;
            ProductButton.Checked = false;
            ProductButton.CheckedBackground = Color.Transparent;
            ProductButton.CheckedForeColor = Color.Transparent;
            ProductButton.CheckedImageTint = Color.Transparent;
            ProductButton.CheckedOutline = Color.Transparent;
            ProductButton.Content = "Product Items";
            ProductButton.DialogResult = DialogResult.None;
            ProductButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductButton.ForeColor = Color.White;
            ProductButton.HoverBackground = Color.FromArgb(96, 138, 227);
            ProductButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            ProductButton.HoverForeColor = Color.White;
            ProductButton.HoverOutline = Color.Transparent;
            ProductButton.Image = (Image)resources.GetObject("ProductButton.Image");
            ProductButton.ImageAutoCenter = true;
            ProductButton.ImageExpand = new Point(7, 7);
            ProductButton.ImageOffset = new Point(-20, 0);
            ProductButton.Location = new Point(16, 99);
            ProductButton.Name = "ProductButton";
            ProductButton.NormalBackground = Color.Transparent;
            ProductButton.NormalForeColor = Color.White;
            ProductButton.NormalImageTint = Color.White;
            ProductButton.NormalOutline = Color.Transparent;
            ProductButton.OutlineThickness = 1F;
            ProductButton.PressedBackground = Color.FromArgb(103, 152, 255);
            ProductButton.PressedForeColor = Color.White;
            ProductButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            ProductButton.PressedOutline = Color.Transparent;
            ProductButton.Rounding = new Padding(8);
            ProductButton.Size = new Size(251, 74);
            ProductButton.TabIndex = 1;
            ProductButton.TextAlignment = StringAlignment.Center;
            ProductButton.TextOffset = new Point(0, 0);
            ProductButton.Click += ProductButton_Click_1;
            // 
            // cuiButtonGroup2
            // 
            cuiButtonGroup2.BackColor = Color.Transparent;
            cuiButtonGroup2.BackgroundImageLayout = ImageLayout.None;
            cuiButtonGroup2.CausesValidation = false;
            cuiButtonGroup2.Checked = false;
            cuiButtonGroup2.CheckedBackground = Color.Transparent;
            cuiButtonGroup2.CheckedForeColor = Color.Transparent;
            cuiButtonGroup2.CheckedImageTint = Color.Transparent;
            cuiButtonGroup2.CheckedOutline = Color.Transparent;
            cuiButtonGroup2.Content = "Exit";
            cuiButtonGroup2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButtonGroup2.ForeColor = Color.White;
            cuiButtonGroup2.Group = 0;
            cuiButtonGroup2.HoverBackground = Color.FromArgb(96, 138, 227);
            cuiButtonGroup2.HoveredImageTint = Color.FromArgb(96, 138, 227);
            cuiButtonGroup2.HoverForeColor = Color.White;
            cuiButtonGroup2.HoverOutline = Color.Transparent;
            cuiButtonGroup2.Image = (Image)resources.GetObject("cuiButtonGroup2.Image");
            cuiButtonGroup2.ImageAutoCenter = true;
            cuiButtonGroup2.ImageExpand = new Point(7, 7);
            cuiButtonGroup2.ImageOffset = new Point(-20, 0);
            cuiButtonGroup2.Location = new Point(16, 541);
            cuiButtonGroup2.Name = "cuiButtonGroup2";
            cuiButtonGroup2.NormalBackground = Color.Transparent;
            cuiButtonGroup2.NormalForeColor = Color.White;
            cuiButtonGroup2.NormalImageTint = Color.White;
            cuiButtonGroup2.NormalOutline = Color.Transparent;
            cuiButtonGroup2.OutlineThickness = 1F;
            cuiButtonGroup2.PressedBackground = Color.FromArgb(103, 152, 255);
            cuiButtonGroup2.PressedForeColor = Color.White;
            cuiButtonGroup2.PressedImageTint = Color.FromArgb(96, 138, 227);
            cuiButtonGroup2.PressedOutline = Color.Transparent;
            cuiButtonGroup2.Rounding = new Padding(8);
            cuiButtonGroup2.Size = new Size(228, 74);
            cuiButtonGroup2.TabIndex = 13;
            cuiButtonGroup2.TextAlignment = StringAlignment.Center;
            cuiButtonGroup2.TextOffset = new Point(0, 3);
            cuiButtonGroup2.Click += cuiButtonGroup2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 72);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(84, 38);
            label13.Name = "label13";
            label13.Size = new Size(160, 24);
            label13.TabIndex = 5;
            label13.Text = "Customer Mart";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(114, 77);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 4;
            // 
            // ShoppingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1386, 681);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShoppingList";
            Load += ShoppingList_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label productLabel;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button placeOrderButton;
        private Label label5;
        private Label totalAmount;
        private Label subTotal;
        private Label label4;
        private Label label3;
        private Label discountAmount;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel productTable;
        private Label label7;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton ProductButton;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label14;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel SideProductItemPage;
    }
}