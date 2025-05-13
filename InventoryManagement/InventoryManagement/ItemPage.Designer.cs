namespace InventoryManagement
{
    partial class ItemPage
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grid = new DataGridView();
            AddButton = new CuoreUI.Controls.cuiButton();
            addItem = new CuoreUI.Controls.cuiButton();
            panel1 = new CuoreUI.Controls.cuiPanel();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cancel = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            panel3 = new CuoreUI.Controls.cuiPanel();
            deleteItem = new CuoreUI.Controls.cuiButton();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiTextBox4 = new CuoreUI.Controls.cuiTextBox();
            DeleteButton = new CuoreUI.Controls.cuiButton();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            cuiColorPicker1 = new CuoreUI.Components.cuiColorPicker(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(111, 137, 217);
            grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(111, 137, 217);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid.ColumnHeadersHeight = 30;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(136, 165, 253);
            dataGridViewCellStyle4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(194, 208, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle4;
            grid.EnableHeadersVisualStyles = false;
            grid.Location = new Point(28, 116);
            grid.Name = "grid";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 50;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(963, 416);
            grid.TabIndex = 2;
            grid.CellContentClick += grid_CellContentClick;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.BackgroundImageLayout = ImageLayout.None;
            AddButton.CheckButton = false;
            AddButton.Checked = false;
            AddButton.CheckedBackground = Color.Transparent;
            AddButton.CheckedForeColor = Color.Transparent;
            AddButton.CheckedImageTint = Color.Transparent;
            AddButton.CheckedOutline = Color.Transparent;
            AddButton.Content = "Add";
            AddButton.Cursor = Cursors.Hand;
            AddButton.DialogResult = DialogResult.None;
            AddButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.WhiteSmoke;
            AddButton.HoverBackground = Color.FromArgb(58, 140, 255);
            AddButton.HoveredImageTint = Color.LightGreen;
            AddButton.HoverForeColor = Color.WhiteSmoke;
            AddButton.HoverOutline = Color.Transparent;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAutoCenter = true;
            AddButton.ImageExpand = new Point(15, 15);
            AddButton.ImageOffset = new Point(-20, 0);
            AddButton.Location = new Point(275, 558);
            AddButton.Name = "AddButton";
            AddButton.NormalBackground = Color.FromArgb(42, 106, 196);
            AddButton.NormalForeColor = Color.WhiteSmoke;
            AddButton.NormalImageTint = Color.White;
            AddButton.NormalOutline = Color.Transparent;
            AddButton.OutlineThickness = 1F;
            AddButton.PressedBackground = Color.FromArgb(5, 32, 70);
            AddButton.PressedForeColor = Color.White;
            AddButton.PressedImageTint = Color.LightGreen;
            AddButton.PressedOutline = Color.Transparent;
            AddButton.Rounding = new Padding(8);
            AddButton.Size = new Size(195, 77);
            AddButton.TabIndex = 3;
            AddButton.TextAlignment = StringAlignment.Center;
            AddButton.TextOffset = new Point(0, 0);
            AddButton.Click += AddButton_Click;
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
            addItem.Content = "Add";
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
            addItem.Location = new Point(102, 206);
            addItem.Name = "addItem";
            addItem.NormalBackground = Color.FromArgb(37, 53, 76);
            addItem.NormalForeColor = Color.WhiteSmoke;
            addItem.NormalImageTint = Color.White;
            addItem.NormalOutline = Color.Transparent;
            addItem.OutlineThickness = 1F;
            addItem.PressedBackground = Color.FromArgb(0, 2, 6);
            addItem.PressedForeColor = Color.WhiteSmoke;
            addItem.PressedImageTint = Color.Firebrick;
            addItem.PressedOutline = Color.Transparent;
            addItem.Rounding = new Padding(8);
            addItem.Size = new Size(131, 57);
            addItem.TabIndex = 3;
            addItem.TextAlignment = StringAlignment.Center;
            addItem.TextOffset = new Point(0, 0);
            addItem.Click += addItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(cuiTextBox1);
            panel1.Controls.Add(cancel);
            panel1.Controls.Add(addItem);
            panel1.Controls.Add(cuiLabel1);
            panel1.Controls.Add(cuiLabel2);
            panel1.Controls.Add(cuiTextBox2);
            panel1.Location = new Point(258, 198);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.FromArgb(65, 66, 85);
            panel1.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(503, 284);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BackgroundImageLayout = ImageLayout.None;
            cuiTextBox1.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.FromArgb(64, 64, 64);
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(46, 73);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(19, 8, 19, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(414, 34);
            cuiTextBox1.TabIndex = 6;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // cancel
            // 
            cancel.BackColor = Color.Transparent;
            cancel.BackgroundImageLayout = ImageLayout.None;
            cancel.CheckButton = false;
            cancel.Checked = false;
            cancel.CheckedBackground = Color.Transparent;
            cancel.CheckedForeColor = Color.Transparent;
            cancel.CheckedImageTint = Color.Transparent;
            cancel.CheckedOutline = Color.Transparent;
            cancel.Content = "Cancel";
            cancel.Cursor = Cursors.Hand;
            cancel.DialogResult = DialogResult.None;
            cancel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = Color.WhiteSmoke;
            cancel.HoverBackground = Color.FromArgb(58, 140, 255);
            cancel.HoveredImageTint = Color.LightGreen;
            cancel.HoverForeColor = Color.WhiteSmoke;
            cancel.HoverOutline = Color.Transparent;
            cancel.Image = null;
            cancel.ImageAutoCenter = true;
            cancel.ImageExpand = new Point(15, 15);
            cancel.ImageOffset = new Point(-20, 0);
            cancel.Location = new Point(276, 206);
            cancel.Name = "cancel";
            cancel.NormalBackground = Color.FromArgb(42, 106, 196);
            cancel.NormalForeColor = Color.WhiteSmoke;
            cancel.NormalImageTint = Color.White;
            cancel.NormalOutline = Color.Transparent;
            cancel.OutlineThickness = 1F;
            cancel.PressedBackground = Color.FromArgb(5, 32, 70);
            cancel.PressedForeColor = Color.White;
            cancel.PressedImageTint = Color.LightGreen;
            cancel.PressedOutline = Color.Transparent;
            cancel.Rounding = new Padding(8);
            cancel.Size = new Size(131, 57);
            cancel.TabIndex = 5;
            cancel.TextAlignment = StringAlignment.Center;
            cancel.TextOffset = new Point(0, 0);
            cancel.Click += cancel_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Enter\\ product\\ name";
            cuiLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(0, 46);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(252, 20);
            cuiLabel1.TabIndex = 5;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Enter\\ price";
            cuiLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(-7, 123);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(192, 20);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.BackgroundImageLayout = ImageLayout.None;
            cuiTextBox2.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.FromArgb(64, 64, 64);
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(46, 150);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(19, 8, 19, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox2.PlaceholderText = "";
            cuiTextBox2.Rounding = new Padding(8);
            cuiTextBox2.Size = new Size(414, 34);
            cuiTextBox2.TabIndex = 2;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.CausesValidation = false;
            panel3.Controls.Add(deleteItem);
            panel3.Controls.Add(cuiLabel3);
            panel3.Controls.Add(cuiLabel4);
            panel3.Controls.Add(cuiTextBox4);
            panel3.Location = new Point(309, 231);
            panel3.Name = "panel3";
            panel3.OutlineThickness = 1F;
            panel3.PanelColor = Color.FromArgb(65, 66, 85);
            panel3.PanelOutlineColor = Color.FromArgb(65, 66, 85);
            panel3.Rounding = new Padding(8);
            panel3.Size = new Size(404, 222);
            panel3.TabIndex = 4;
            panel3.Visible = false;
            panel3.Paint += panel3_Paint;
            // 
            // deleteItem
            // 
            deleteItem.BackColor = Color.Transparent;
            deleteItem.BackgroundImageLayout = ImageLayout.None;
            deleteItem.CheckButton = false;
            deleteItem.Checked = false;
            deleteItem.CheckedBackground = Color.Transparent;
            deleteItem.CheckedForeColor = Color.Transparent;
            deleteItem.CheckedImageTint = Color.Transparent;
            deleteItem.CheckedOutline = Color.Transparent;
            deleteItem.Content = "Delete";
            deleteItem.Cursor = Cursors.Hand;
            deleteItem.DialogResult = DialogResult.None;
            deleteItem.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteItem.ForeColor = Color.WhiteSmoke;
            deleteItem.HoverBackground = Color.FromArgb(2, 44, 120);
            deleteItem.HoveredImageTint = Color.Firebrick;
            deleteItem.HoverForeColor = Color.WhiteSmoke;
            deleteItem.HoverOutline = Color.Transparent;
            deleteItem.Image = null;
            deleteItem.ImageAutoCenter = true;
            deleteItem.ImageExpand = new Point(7, 7);
            deleteItem.ImageOffset = new Point(-20, 0);
            deleteItem.Location = new Point(135, 152);
            deleteItem.Name = "deleteItem";
            deleteItem.NormalBackground = Color.FromArgb(37, 53, 76);
            deleteItem.NormalForeColor = Color.WhiteSmoke;
            deleteItem.NormalImageTint = Color.White;
            deleteItem.NormalOutline = Color.Transparent;
            deleteItem.OutlineThickness = 1F;
            deleteItem.PressedBackground = Color.FromArgb(0, 2, 6);
            deleteItem.PressedForeColor = Color.WhiteSmoke;
            deleteItem.PressedImageTint = Color.Firebrick;
            deleteItem.PressedOutline = Color.Transparent;
            deleteItem.Rounding = new Padding(8);
            deleteItem.Size = new Size(131, 57);
            deleteItem.TabIndex = 4;
            deleteItem.TextAlignment = StringAlignment.Center;
            deleteItem.TextOffset = new Point(0, 0);
            deleteItem.Click += deleteItem_Click;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Delete\\ a\\ Item";
            cuiLabel3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.White;
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(115, 27);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(193, 38);
            cuiLabel3.TabIndex = 3;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            cuiLabel3.Load += cuiLabel4_Load;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Enter\\ product\\ ID";
            cuiLabel4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.White;
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(-4, 79);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(193, 20);
            cuiLabel4.TabIndex = 3;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            cuiLabel4.Load += cuiLabel4_Load;
            // 
            // cuiTextBox4
            // 
            cuiTextBox4.BackgroundColor = Color.White;
            cuiTextBox4.BackgroundImageLayout = ImageLayout.None;
            cuiTextBox4.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox4.Content = "";
            cuiTextBox4.FocusBackgroundColor = Color.White;
            cuiTextBox4.FocusBorderColor = Color.FromArgb(64, 64, 64);
            cuiTextBox4.FocusImageTint = Color.White;
            cuiTextBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox4.ForeColor = Color.Black;
            cuiTextBox4.Image = null;
            cuiTextBox4.ImageExpand = new Point(0, 0);
            cuiTextBox4.ImageOffset = new Point(0, 0);
            cuiTextBox4.Location = new Point(23, 103);
            cuiTextBox4.Margin = new Padding(4);
            cuiTextBox4.Multiline = false;
            cuiTextBox4.Name = "cuiTextBox4";
            cuiTextBox4.NormalImageTint = Color.White;
            cuiTextBox4.Padding = new Padding(19, 8, 19, 0);
            cuiTextBox4.PasswordChar = false;
            cuiTextBox4.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox4.PlaceholderText = "";
            cuiTextBox4.Rounding = new Padding(8);
            cuiTextBox4.Size = new Size(352, 34);
            cuiTextBox4.TabIndex = 2;
            cuiTextBox4.TextOffset = new Size(0, 0);
            cuiTextBox4.UnderlinedStyle = true;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.BackgroundImageLayout = ImageLayout.None;
            DeleteButton.CheckButton = false;
            DeleteButton.Checked = false;
            DeleteButton.CheckedBackground = Color.Transparent;
            DeleteButton.CheckedForeColor = Color.Transparent;
            DeleteButton.CheckedImageTint = Color.Transparent;
            DeleteButton.CheckedOutline = Color.Transparent;
            DeleteButton.Content = "Delete";
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.DialogResult = DialogResult.None;
            DeleteButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.WhiteSmoke;
            DeleteButton.HoverBackground = Color.FromArgb(2, 44, 120);
            DeleteButton.HoveredImageTint = Color.Firebrick;
            DeleteButton.HoverForeColor = Color.WhiteSmoke;
            DeleteButton.HoverOutline = Color.Transparent;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageAutoCenter = true;
            DeleteButton.ImageExpand = new Point(7, 7);
            DeleteButton.ImageOffset = new Point(-20, 0);
            DeleteButton.Location = new Point(561, 558);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.FromArgb(37, 53, 76);
            DeleteButton.NormalForeColor = Color.WhiteSmoke;
            DeleteButton.NormalImageTint = Color.White;
            DeleteButton.NormalOutline = Color.Transparent;
            DeleteButton.OutlineThickness = 1F;
            DeleteButton.PressedBackground = Color.FromArgb(0, 2, 6);
            DeleteButton.PressedForeColor = Color.WhiteSmoke;
            DeleteButton.PressedImageTint = Color.Firebrick;
            DeleteButton.PressedOutline = Color.Transparent;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(195, 77);
            DeleteButton.TabIndex = 3;
            DeleteButton.TextAlignment = StringAlignment.Center;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // cuiLabel8
            // 
            cuiLabel8.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiLabel8.BackgroundImageLayout = ImageLayout.None;
            cuiLabel8.Content = "Items";
            cuiLabel8.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel8.ForeColor = Color.White;
            cuiLabel8.HorizontalAlignment = StringAlignment.Center;
            cuiLabel8.Location = new Point(329, 22);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(373, 60);
            cuiLabel8.TabIndex = 18;
            cuiLabel8.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiColorPicker1
            // 
            cuiColorPicker1.Color = Color.Empty;
            cuiColorPicker1.EnableThemeChangeButton = true;
            cuiColorPicker1.Theme = CuoreUI.Components.Forms.ColorPickerForm.Themes.Light;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Item Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            // 
            // ItemPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1019, 679);
            Controls.Add(cuiLabel8);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(grid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemPage";
            Text = "ItemPage";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private CuoreUI.Controls.cuiButton AddButton;
        private CuoreUI.Controls.cuiButton addItem;
        private CuoreUI.Controls.cuiPanel panel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton cancel;
        private CuoreUI.Controls.cuiButton DeleteButton;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiPanel panel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiTextBox cuiTextBox4;
        private CuoreUI.Controls.cuiButton deleteItem;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Components.cuiColorPicker cuiColorPicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}