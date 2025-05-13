namespace InventoryManagement
{
    partial class ReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            panel1 = new Panel();
            datePicker2 = new CuoreUI.Controls.cuiCalendarDatePicker();
            label1 = new Label();
            submitButton = new CuoreUI.Controls.cuiButton();
            salesText = new Label();
            datePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.FromArgb(111, 137, 217);
            panel1.Location = new Point(-2, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 416);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            //
            // datePicker2
            //
            datePicker2.BackColor = Color.Transparent;
            datePicker2.EnableThemeChangeButton = true;
            datePicker2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePicker2.ForeColor = Color.WhiteSmoke;
            datePicker2.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            datePicker2.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            datePicker2.Icon = (Image)resources.GetObject("datePicker2.Icon");
            datePicker2.IconTint = Color.WhiteSmoke;
            datePicker2.Location = new Point(535, 103);
            datePicker2.Margin = new Padding(7, 4, 7, 4);
            datePicker2.Name = "datePicker2";
            datePicker2.NormalBackground = Color.FromArgb(65, 66, 85);
            datePicker2.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            datePicker2.OutlineThickness = 1.5F;
            datePicker2.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            datePicker2.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            datePicker2.Rounding = 8;
            datePicker2.ShowIcon = true;
            datePicker2.Size = new Size(260, 78);
            datePicker2.TabIndex = 0;
            datePicker2.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            datePicker2.Value = DateTime.Now;
            datePicker2.Load += datePicker2_Load;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(485, 103);
            label1.Name = "label1";
            label1.Size = new Size(40, 56);
            label1.TabIndex = 1;
            label1.Text = "-";
            //
            // submitButton
            //
            submitButton.BackColor = Color.Transparent;
            submitButton.BackgroundImageLayout = ImageLayout.None;
            submitButton.CheckButton = false;
            submitButton.Checked = false;
            submitButton.CheckedBackground = Color.Transparent;
            submitButton.CheckedForeColor = Color.Transparent;
            submitButton.CheckedImageTint = Color.Transparent;
            submitButton.CheckedOutline = Color.Transparent;
            submitButton.Content = "Submit";
            submitButton.Cursor = Cursors.Hand;
            submitButton.DialogResult = DialogResult.None;
            submitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.WhiteSmoke;
            submitButton.HoverBackground = Color.FromArgb(2, 44, 120);
            submitButton.HoveredImageTint = Color.Firebrick;
            submitButton.HoverForeColor = Color.WhiteSmoke;
            submitButton.HoverOutline = Color.Transparent;
            submitButton.Image = null;
            submitButton.ImageAutoCenter = true;
            submitButton.ImageExpand = new Point(7, 7);
            submitButton.ImageOffset = new Point(-20, 0);
            submitButton.Location = new Point(443, 194);
            submitButton.Name = "submitButton";
            submitButton.NormalBackground = Color.FromArgb(37, 53, 76);
            submitButton.NormalForeColor = Color.WhiteSmoke;
            submitButton.NormalImageTint = Color.White;
            submitButton.NormalOutline = Color.Transparent;
            submitButton.OutlineThickness = 1F;
            submitButton.PressedBackground = Color.FromArgb(0, 2, 6);
            submitButton.PressedForeColor = Color.WhiteSmoke;
            submitButton.PressedImageTint = Color.Firebrick;
            submitButton.PressedOutline = Color.Transparent;
            submitButton.Rounding = new Padding(8);
            submitButton.Size = new Size(131, 57);
            submitButton.TabIndex = 5;
            submitButton.TextAlignment = StringAlignment.Center;
            submitButton.TextOffset = new Point(0, 0);
            submitButton.Click += submitButton_Click_1;
            //
            // salesText
            //
            salesText.AutoSize = true;
            salesText.Font = new Font("Arial", 36F, FontStyle.Bold);
            salesText.ForeColor = Color.White;
            salesText.Location = new Point(343, 21);
            salesText.Name = "salesText";
            salesText.Size = new Size(318, 56);
            salesText.TabIndex = 22;
            salesText.Text = "Sales Report";
            salesText.Click += salesText_Click;
            //
            // datePicker1
            //
            datePicker1.BackColor = Color.Transparent;
            datePicker1.EnableThemeChangeButton = true;
            datePicker1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePicker1.ForeColor = Color.WhiteSmoke;
            datePicker1.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            datePicker1.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            datePicker1.Icon = (Image)resources.GetObject("datePicker1.Icon");
            datePicker1.IconTint = Color.WhiteSmoke;
            datePicker1.Location = new Point(215, 103);
            datePicker1.Margin = new Padding(7, 4, 7, 4);
            datePicker1.Name = "datePicker1";
            datePicker1.NormalBackground = Color.FromArgb(65, 66, 85);
            datePicker1.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            datePicker1.OutlineThickness = 1.5F;
            datePicker1.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            datePicker1.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            datePicker1.Rounding = 8;
            datePicker1.ShowIcon = true;
            datePicker1.Size = new Size(260, 78);
            datePicker1.TabIndex = 23;
            datePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            datePicker1.Value = DateTime.Now.AddDays(-30); // Default to 30 days ago
            datePicker1.Load += datePicker1_Load_1;
            //
            // ReportPage
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1019, 679);
            Controls.Add(datePicker1);
            Controls.Add(salesText);
            Controls.Add(submitButton);
            Controls.Add(label1);
            Controls.Add(datePicker2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportPage";
            Text = "ReportPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiLabel dailySales;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel1;
        private CuoreUI.Controls.cuiPanel dailySalesBar;
        private CuoreUI.Controls.cuiButton salesReppo;
        private CuoreUI.Controls.cuiButton monthlySalesButton;
        private CuoreUI.Controls.cuiPanel monthlySalesBar;
        private CuoreUI.Controls.cuiButton annualSalesButton;
        private CuoreUI.Controls.cuiPanel annualSalesBar;
        private CuoreUI.Controls.cuiCalendarDatePicker datePicker2;
        private Label label1;
        private CuoreUI.Controls.cuiButton submitButton;
        private Label salesText;
        private CuoreUI.Controls.cuiCalendarDatePicker datePicker1;
    }
}