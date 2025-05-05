namespace InventoryManagement
{
    partial class FilteredSalesReport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dailySales = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dailySales).BeginInit();
            SuspendLayout();
            //
            // dailySales
            //
            dailySales.AllowUserToAddRows = false;
            dailySales.AllowUserToDeleteRows = false;
            dailySales.AllowUserToResizeColumns = false;
            dailySales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(111, 137, 217);
            dailySales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dailySales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dailySales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dailySales.BackgroundColor = Color.FromArgb(111, 137, 217);
            dailySales.BorderStyle = BorderStyle.None;
            dailySales.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dailySales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 91, 137);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dailySales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dailySales.ColumnHeadersHeight = 30;
            dailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dailySales.Columns.AddRange(new DataGridViewColumn[] { Column3, Column6, Column4, Column1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(136, 165, 253);
            dataGridViewCellStyle4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(194, 208, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dailySales.DefaultCellStyle = dataGridViewCellStyle4;
            dailySales.EnableHeadersVisualStyles = false;
            dailySales.Location = new Point(17, 19);
            dailySales.Name = "dailySales";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dailySales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dailySales.RowHeadersVisible = false;
            dailySales.RowTemplate.Height = 50;
            dailySales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dailySales.Size = new Size(980, 547);
            dailySales.TabIndex = 5;
            dailySales.CellContentClick += dailySales_CellContentClick;
            //
            // Column3
            //
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Id";
            Column3.Name = "Column3";
            //
            // Column6
            //
            Column6.FillWeight = 70F;
            Column6.HeaderText = "Item";
            Column6.Name = "Column6";
            //
            // Column4
            //
            Column4.HeaderText = "Daily Sales";
            Column4.Name = "Column4";
            //
            // Column1
            //
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "Date of Daily Sales";
            Column1.Name = "Column1";
            //
            // DailySalesReport
            //
            // FilteredSalesReport
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 137, 217);
            ClientSize = new Size(1018, 582);
            Controls.Add(dailySales);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilteredSalesReport";
            Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)dailySales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dailySales;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
    }
}