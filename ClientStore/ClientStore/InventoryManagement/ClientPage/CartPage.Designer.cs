namespace InventoryManagement
{
    partial class CartPage
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            grid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            addItem = new CuoreUI.Controls.cuiButton();
            panel1 = new CuoreUI.Controls.cuiPanel();
            totalAmount = new CuoreUI.Controls.cuiLabel();
            discountAmount = new CuoreUI.Controls.cuiLabel();
            subTotal = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(111, 137, 217);
            grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(111, 137, 217);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            grid.ColumnHeadersHeight = 30;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(136, 165, 253);
            dataGridViewCellStyle9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(194, 208, 249);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle9;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.White;
            grid.Location = new Point(28, 116);
            grid.Name = "grid";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 50;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(562, 503);
            grid.TabIndex = 2;
            grid.CellContentClick += grid_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Item Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantity";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle8;
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FlatStyle = FlatStyle.Flat;
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Text = "Delete";
            Column4.UseColumnTextForButtonValue = true;
            // 
            // addItem
            // 
            addItem.BackColor = Color.Transparent;
            addItem.BackgroundImageLayout = ImageLayout.None;
            addItem.CheckButton = false;
            addItem.Checked = false;
            addItem.CheckedBackground = Color.Transparent;
            addItem.CheckedForeColor = Color.Transparent;
            addItem.CheckedImageTint = Color.Transparent;
            addItem.CheckedOutline = Color.Transparent;
            addItem.Content = "Place Order";
            addItem.Cursor = Cursors.Hand;
            addItem.DialogResult = DialogResult.None;
            addItem.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItem.ForeColor = Color.WhiteSmoke;
            addItem.HoverBackground = Color.FromArgb(2, 44, 120);
            addItem.HoveredImageTint = Color.Firebrick;
            addItem.HoverForeColor = Color.WhiteSmoke;
            addItem.HoverOutline = Color.Transparent;
            addItem.Image = null;
            addItem.ImageAutoCenter = true;
            addItem.ImageExpand = new Point(7, 7);
            addItem.ImageOffset = new Point(-20, 0);
            addItem.Location = new Point(93, 302);
            addItem.Name = "addItem";
            addItem.NormalBackground = Color.FromArgb(44, 50, 58);
            addItem.NormalForeColor = Color.WhiteSmoke;
            addItem.NormalImageTint = Color.White;
            addItem.NormalOutline = Color.Transparent;
            addItem.OutlineThickness = 1F;
            addItem.PressedBackground = Color.FromArgb(0, 2, 6);
            addItem.PressedForeColor = Color.WhiteSmoke;
            addItem.PressedImageTint = Color.Firebrick;
            addItem.PressedOutline = Color.Transparent;
            addItem.Rounding = new Padding(8);
            addItem.Size = new Size(198, 68);
            addItem.TabIndex = 3;
            addItem.TextAlignment = StringAlignment.Center;
            addItem.TextOffset = new Point(0, 0);
            addItem.Click += addItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(totalAmount);
            panel1.Controls.Add(discountAmount);
            panel1.Controls.Add(subTotal);
            panel1.Controls.Add(cuiPanel2);
            panel1.Controls.Add(cuiPanel1);
            panel1.Controls.Add(cuiLabel4);
            panel1.Controls.Add(cuiLabel3);
            panel1.Controls.Add(cuiLabel2);
            panel1.Controls.Add(addItem);
            panel1.Controls.Add(cuiLabel1);
            panel1.Location = new Point(605, 172);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.FromArgb(65, 66, 85);
            panel1.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(388, 405);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // totalAmount
            // 
            totalAmount.AutoValidate = AutoValidate.EnablePreventFocusChange;
            totalAmount.BackgroundImageLayout = ImageLayout.None;
            totalAmount.Content = "\\$1999999\\.99";
            totalAmount.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.ForeColor = Color.White;
            totalAmount.HorizontalAlignment = StringAlignment.Center;
            totalAmount.Location = new Point(219, 256);
            totalAmount.Margin = new Padding(4, 3, 4, 3);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(146, 40);
            totalAmount.TabIndex = 28;
            totalAmount.VerticalAlignment = StringAlignment.Center;
            // 
            // discountAmount
            // 
            discountAmount.AutoValidate = AutoValidate.EnablePreventFocusChange;
            discountAmount.BackgroundImageLayout = ImageLayout.None;
            discountAmount.Content = "\\$1999999\\.99";
            discountAmount.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountAmount.ForeColor = Color.White;
            discountAmount.HorizontalAlignment = StringAlignment.Center;
            discountAmount.Location = new Point(219, 158);
            discountAmount.Margin = new Padding(4, 3, 4, 3);
            discountAmount.Name = "discountAmount";
            discountAmount.Size = new Size(146, 40);
            discountAmount.TabIndex = 27;
            discountAmount.VerticalAlignment = StringAlignment.Center;
            // 
            // subTotal
            // 
            subTotal.AutoValidate = AutoValidate.EnablePreventFocusChange;
            subTotal.BackgroundImageLayout = ImageLayout.None;
            subTotal.Content = "\\$1999999\\.99";
            subTotal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.White;
            subTotal.HorizontalAlignment = StringAlignment.Center;
            subTotal.Location = new Point(219, 100);
            subTotal.Margin = new Padding(4, 3, 4, 3);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(146, 40);
            subTotal.TabIndex = 26;
            subTotal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(28, 240);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(65, 66, 85);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            cuiPanel2.Rounding = new Padding(4);
            cuiPanel2.Size = new Size(337, 10);
            cuiPanel2.TabIndex = 25;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Location = new Point(28, 235);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.PanelOutlineColor = Color.Silver;
            cuiPanel1.Rounding = new Padding(4);
            cuiPanel1.Size = new Size(337, 9);
            cuiPanel1.TabIndex = 23;
            // 
            // cuiLabel4
            // 
            cuiLabel4.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel4.BackgroundImageLayout = ImageLayout.None;
            cuiLabel4.Content = "Total\\ amount:";
            cuiLabel4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.White;
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(28, 256);
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
            cuiLabel3.ForeColor = Color.White;
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(28, 158);
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
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(28, 100);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(92, 40);
            cuiLabel2.TabIndex = 20;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            cuiLabel2.Load += cuiLabel2_Load;
            // 
            // cuiLabel1
            // 
            cuiLabel1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel1.BackgroundImageLayout = ImageLayout.None;
            cuiLabel1.Content = "Total";
            cuiLabel1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(127, 15);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(135, 60);
            cuiLabel1.TabIndex = 19;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            cuiLabel8.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel8.BackgroundImageLayout = ImageLayout.None;
            cuiLabel8.Content = "Cart";
            cuiLabel8.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel8.ForeColor = Color.White;
            cuiLabel8.HorizontalAlignment = StringAlignment.Center;
            cuiLabel8.Location = new Point(329, 22);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(373, 60);
            cuiLabel8.TabIndex = 18;
            cuiLabel8.VerticalAlignment = StringAlignment.Center;
            cuiLabel8.Load += cuiLabel8_Load;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1019, 679);
            Controls.Add(cuiLabel8);
            Controls.Add(panel1);
            Controls.Add(grid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CartPage";
            Text = "ItemPage";
            Load += CartPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private CuoreUI.Controls.cuiButton addItem;
        private CuoreUI.Controls.cuiPanel panel1;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel discountAmount;
        private CuoreUI.Controls.cuiLabel subTotal;
        private CuoreUI.Controls.cuiLabel totalAmount;
    }
}