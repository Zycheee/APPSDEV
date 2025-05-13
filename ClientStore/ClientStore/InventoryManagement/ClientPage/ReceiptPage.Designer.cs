namespace InventoryManagement
{
    partial class ReceiptPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptPage));
            receiptPanel = new CuoreUI.Controls.cuiPanel();
            paymentDate = new CuoreUI.Controls.cuiLabel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            cuiLabel9 = new CuoreUI.Controls.cuiLabel();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            subTotal = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            backButton = new CuoreUI.Controls.cuiButton();
            receiptPanel.SuspendLayout();
            SuspendLayout();
            // 
            // receiptPanel
            // 
            receiptPanel.BackColor = Color.Transparent;
            receiptPanel.Controls.Add(paymentDate);
            receiptPanel.Controls.Add(cuiPanel3);
            receiptPanel.Controls.Add(cuiPanel4);
            receiptPanel.Controls.Add(cuiLabel9);
            receiptPanel.Controls.Add(cuiLabel8);
            receiptPanel.Controls.Add(cuiLabel7);
            receiptPanel.Controls.Add(cuiLabel6);
            receiptPanel.Controls.Add(cuiLabel5);
            receiptPanel.Controls.Add(subTotal);
            receiptPanel.Controls.Add(cuiPanel2);
            receiptPanel.Controls.Add(cuiPanel1);
            receiptPanel.Controls.Add(cuiLabel4);
            receiptPanel.Controls.Add(cuiLabel3);
            receiptPanel.Controls.Add(cuiLabel2);
            receiptPanel.Controls.Add(cuiLabel1);
            receiptPanel.Location = new Point(265, 24);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.OutlineThickness = 1F;
            receiptPanel.PanelColor = Color.FromArgb(65, 66, 85);
            receiptPanel.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            receiptPanel.Rounding = new Padding(8);
            receiptPanel.Size = new Size(523, 521);
            receiptPanel.TabIndex = 23;
            // 
            // paymentDate
            // 
            paymentDate.AutoValidate = AutoValidate.EnablePreventFocusChange;
            paymentDate.BackgroundImageLayout = ImageLayout.None;
            paymentDate.Content = "12/2/2024";
            paymentDate.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentDate.ForeColor = Color.White;
            paymentDate.HorizontalAlignment = StringAlignment.Center;
            paymentDate.Location = new Point(351, 226);
            paymentDate.Margin = new Padding(4, 3, 4, 3);
            paymentDate.Name = "paymentDate";
            paymentDate.Size = new Size(146, 40);
            paymentDate.TabIndex = 32;
            paymentDate.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Location = new Point(28, 195);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(65, 66, 85);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            cuiPanel3.Rounding = new Padding(4);
            cuiPanel3.Size = new Size(469, 10);
            cuiPanel3.TabIndex = 27;
            // 
            // cuiPanel4
            // 
            cuiPanel4.Location = new Point(28, 185);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.FromArgb(224, 224, 224);
            cuiPanel4.PanelOutlineColor = Color.Silver;
            cuiPanel4.Rounding = new Padding(4);
            cuiPanel4.Size = new Size(469, 9);
            cuiPanel4.TabIndex = 26;
            // 
            // cuiLabel9
            // 
            cuiLabel9.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel9.BackgroundImageLayout = ImageLayout.None;
            cuiLabel9.Content = "Payment\\ Date:";
            cuiLabel9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel9.ForeColor = Color.Gainsboro;
            cuiLabel9.HorizontalAlignment = StringAlignment.Center;
            cuiLabel9.Location = new Point(28, 226);
            cuiLabel9.Margin = new Padding(4, 3, 4, 3);
            cuiLabel9.Name = "cuiLabel9";
            cuiLabel9.Size = new Size(143, 40);
            cuiLabel9.TabIndex = 31;
            cuiLabel9.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            cuiLabel8.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel8.BackgroundImageLayout = ImageLayout.None;
            cuiLabel8.Content = "Your\\ payment\\ has\\ been\\ successfully\\ done";
            cuiLabel8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel8.ForeColor = Color.Gainsboro;
            cuiLabel8.HorizontalAlignment = StringAlignment.Center;
            cuiLabel8.Location = new Point(28, 129);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(469, 60);
            cuiLabel8.TabIndex = 30;
            cuiLabel8.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel7
            // 
            cuiLabel7.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel7.BackgroundImage = (Image)resources.GetObject("cuiLabel7.BackgroundImage");
            cuiLabel7.BackgroundImageLayout = ImageLayout.None;
            cuiLabel7.Content = "";
            cuiLabel7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel7.ForeColor = Color.White;
            cuiLabel7.HorizontalAlignment = StringAlignment.Center;
            cuiLabel7.Location = new Point(244, 13);
            cuiLabel7.Margin = new Padding(4, 3, 4, 3);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(70, 70);
            cuiLabel7.TabIndex = 29;
            cuiLabel7.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel6
            // 
            cuiLabel6.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel6.BackgroundImageLayout = ImageLayout.None;
            cuiLabel6.Content = "\\$1999999\\.99";
            cuiLabel6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel6.ForeColor = Color.White;
            cuiLabel6.HorizontalAlignment = StringAlignment.Center;
            cuiLabel6.Location = new Point(351, 448);
            cuiLabel6.Margin = new Padding(4, 3, 4, 3);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(146, 40);
            cuiLabel6.TabIndex = 28;
            cuiLabel6.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            cuiLabel5.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel5.BackgroundImageLayout = ImageLayout.None;
            cuiLabel5.Content = "\\$1999999\\.99";
            cuiLabel5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.ForeColor = Color.White;
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(351, 350);
            cuiLabel5.Margin = new Padding(4, 3, 4, 3);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(146, 40);
            cuiLabel5.TabIndex = 27;
            cuiLabel5.VerticalAlignment = StringAlignment.Center;
            // 
            // subTotal
            // 
            subTotal.AutoValidate = AutoValidate.EnablePreventFocusChange;
            subTotal.BackgroundImageLayout = ImageLayout.None;
            subTotal.Content = "\\$1999999\\.99";
            subTotal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.White;
            subTotal.HorizontalAlignment = StringAlignment.Center;
            subTotal.Location = new Point(351, 285);
            subTotal.Margin = new Padding(4, 3, 4, 3);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(146, 40);
            subTotal.TabIndex = 26;
            subTotal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(28, 432);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(65, 66, 85);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            cuiPanel2.Rounding = new Padding(4);
            cuiPanel2.Size = new Size(469, 10);
            cuiPanel2.TabIndex = 25;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Location = new Point(28, 422);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.PanelOutlineColor = Color.Silver;
            cuiPanel1.Rounding = new Padding(4);
            cuiPanel1.Size = new Size(469, 9);
            cuiPanel1.TabIndex = 23;
            // 
            // cuiLabel4
            // 
            cuiLabel4.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel4.BackgroundImageLayout = ImageLayout.None;
            cuiLabel4.Content = "Total\\ amount:";
            cuiLabel4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.Gainsboro;
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(28, 448);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(135, 40);
            cuiLabel4.TabIndex = 22;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel3
            // 
            cuiLabel3.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel3.BackgroundImageLayout = ImageLayout.None;
            cuiLabel3.Content = "Discount\\ amount:";
            cuiLabel3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.Gainsboro;
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(28, 350);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(174, 40);
            cuiLabel3.TabIndex = 21;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel2.BackgroundImageLayout = ImageLayout.None;
            cuiLabel2.Content = "Subtotal:";
            cuiLabel2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.Gainsboro;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(28, 285);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(92, 40);
            cuiLabel2.TabIndex = 20;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            cuiLabel1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel1.BackgroundImageLayout = ImageLayout.None;
            cuiLabel1.Content = "Payment\\ Success!";
            cuiLabel1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(88, 81);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(360, 60);
            cuiLabel1.TabIndex = 19;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.CheckButton = false;
            backButton.Checked = false;
            backButton.CheckedBackground = Color.Transparent;
            backButton.CheckedForeColor = Color.Transparent;
            backButton.CheckedImageTint = Color.Transparent;
            backButton.CheckedOutline = Color.Transparent;
            backButton.Content = "Go Back";
            backButton.DialogResult = DialogResult.None;
            backButton.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.HoverBackground = Color.FromArgb(55, 55, 56);
            backButton.HoveredImageTint = Color.FromArgb(96, 138, 227);
            backButton.HoverForeColor = Color.White;
            backButton.HoverOutline = Color.Transparent;
            backButton.Image = null;
            backButton.ImageAutoCenter = true;
            backButton.ImageExpand = new Point(7, 7);
            backButton.ImageOffset = new Point(-20, 0);
            backButton.Location = new Point(381, 574);
            backButton.Name = "backButton";
            backButton.NormalBackground = Color.FromArgb(44, 50, 58);
            backButton.NormalForeColor = Color.White;
            backButton.NormalImageTint = Color.White;
            backButton.NormalOutline = Color.Transparent;
            backButton.OutlineThickness = 1F;
            backButton.PressedBackground = Color.FromArgb(22, 24, 26);
            backButton.PressedForeColor = Color.White;
            backButton.PressedImageTint = Color.FromArgb(96, 138, 227);
            backButton.PressedOutline = Color.Transparent;
            backButton.Rounding = new Padding(8);
            backButton.Size = new Size(268, 76);
            backButton.TabIndex = 33;
            backButton.TextAlignment = StringAlignment.Center;
            backButton.TextOffset = new Point(0, 0);
            backButton.Click += backButton_Click;
            // 
            // ReceiptPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1019, 679);
            Controls.Add(backButton);
            Controls.Add(receiptPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceiptPage";
            Text = "ReportPage";
            Load += ReceiptPage_Load;
            receiptPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel dailySales;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel dailySalesBar;
        private CuoreUI.Controls.cuiButton salesReppo;
        private CuoreUI.Controls.cuiButton monthlySalesButton;
        private CuoreUI.Controls.cuiPanel monthlySalesBar;
        private CuoreUI.Controls.cuiButton annualSalesButton;
        private CuoreUI.Controls.cuiPanel annualSalesBar;
        private CuoreUI.Controls.cuiPanel receiptPanel;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel subTotal;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiLabel paymentDate;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiLabel cuiLabel9;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiButton backButton;
    }
}