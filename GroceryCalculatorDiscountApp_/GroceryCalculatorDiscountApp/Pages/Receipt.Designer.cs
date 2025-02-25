namespace GroceryCalculatorDiscountApp.Pages
{
    partial class Receipt
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
            productLabel = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            discountAmount = new Label();
            totalAmount = new Label();
            label5 = new Label();
            label6 = new Label();
            sub_Total = new Label();
            newPurchaseButton = new Button();
            exitApp = new Button();
            productTable = new TableLayoutPanel();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Arial", 22F);
            productLabel.ForeColor = Color.FromArgb(44, 50, 58);
            productLabel.Location = new Point(67, 107);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(118, 35);
            productLabel.TabIndex = 2;
            productLabel.Text = "Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 25F);
            label7.ForeColor = Color.FromArgb(44, 50, 58);
            label7.Location = new Point(219, 30);
            label7.Name = "label7";
            label7.Size = new Size(586, 39);
            label7.TabIndex = 2;
            label7.Text = "Thanks for buying at Haggaigai's Store\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F);
            label1.ForeColor = Color.FromArgb(44, 50, 58);
            label1.Location = new Point(279, 107);
            label1.Name = "label1";
            label1.Size = new Size(83, 35);
            label1.TabIndex = 2;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F);
            label2.ForeColor = Color.FromArgb(44, 50, 58);
            label2.Location = new Point(444, 107);
            label2.Name = "label2";
            label2.Size = new Size(126, 35);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(sub_Total);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(totalAmount);
            panel3.Controls.Add(discountAmount);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(586, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(347, 308);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F);
            label3.ForeColor = Color.FromArgb(44, 50, 58);
            label3.Location = new Point(120, 8);
            label3.Name = "label3";
            label3.Size = new Size(62, 27);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 50, 58);
            label4.Location = new Point(23, 58);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 2;
            label4.Text = "Subtotal:";
            // 
            // discountAmount
            // 
            discountAmount.AutoSize = true;
            discountAmount.Font = new Font("Arial", 13F);
            discountAmount.ForeColor = Color.FromArgb(44, 50, 58);
            discountAmount.Location = new Point(196, 131);
            discountAmount.Name = "discountAmount";
            discountAmount.Size = new Size(55, 21);
            discountAmount.TabIndex = 2;
            discountAmount.Text = "$0.00";
            discountAmount.Click += discountAmount_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Arial", 13F);
            totalAmount.ForeColor = Color.FromArgb(44, 50, 58);
            totalAmount.Location = new Point(196, 201);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(55, 21);
            totalAmount.TabIndex = 2;
            totalAmount.Text = "$0.00";
            totalAmount.Click += totalAmount_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 50, 58);
            label5.Location = new Point(23, 131);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 2;
            label5.Text = "Discount amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(44, 50, 58);
            label6.Location = new Point(23, 203);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 2;
            label6.Text = "Total Payment: ";
            // 
            // sub_Total
            // 
            sub_Total.AutoSize = true;
            sub_Total.Font = new Font("Arial", 13F);
            sub_Total.ForeColor = Color.FromArgb(44, 50, 58);
            sub_Total.Location = new Point(196, 56);
            sub_Total.Name = "sub_Total";
            sub_Total.Size = new Size(55, 21);
            sub_Total.TabIndex = 3;
            sub_Total.Text = "$0.00";
            sub_Total.Click += sub_Total_Click;
            // 
            // newPurchaseButton
            // 
            newPurchaseButton.BackColor = Color.FromArgb(44, 50, 58);
            newPurchaseButton.Cursor = Cursors.Hand;
            newPurchaseButton.FlatStyle = FlatStyle.Flat;
            newPurchaseButton.Font = new Font("Arial", 15F);
            newPurchaseButton.ForeColor = Color.White;
            newPurchaseButton.Location = new Point(219, 439);
            newPurchaseButton.Name = "newPurchaseButton";
            newPurchaseButton.Size = new Size(243, 56);
            newPurchaseButton.TabIndex = 5;
            newPurchaseButton.TabStop = false;
            newPurchaseButton.Text = "Make a new purchase";
            newPurchaseButton.UseVisualStyleBackColor = false;
            newPurchaseButton.Click += newPurchaseButton_Click;
            // 
            // exitApp
            // 
            exitApp.BackColor = Color.Gray;
            exitApp.Cursor = Cursors.Hand;
            exitApp.FlatStyle = FlatStyle.Flat;
            exitApp.Font = new Font("Arial", 15F);
            exitApp.ForeColor = Color.White;
            exitApp.Location = new Point(501, 439);
            exitApp.Name = "exitApp";
            exitApp.Size = new Size(243, 56);
            exitApp.TabIndex = 5;
            exitApp.TabStop = false;
            exitApp.Text = "Exit app";
            exitApp.UseVisualStyleBackColor = false;
            exitApp.Click += exitApp_Click;
            // 
            // productTable
            // 
            productTable.ColumnCount = 3;
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.6717567F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.3282433F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            productTable.Location = new Point(75, 162);
            productTable.Name = "productTable";
            productTable.RowCount = 1;
            productTable.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            productTable.Size = new Size(495, 34);
            productTable.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(productTable);
            panel2.Controls.Add(exitApp);
            panel2.Controls.Add(newPurchaseButton);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(productLabel);
            panel2.Location = new Point(238, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 518);
            panel2.TabIndex = 4;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 50, 58);
            ClientSize = new Size(1386, 681);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            Text = "Receipt";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label productLabel;
        private Label label7;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label sub_Total;
        private Label label6;
        private Label label5;
        private Label totalAmount;
        private Label discountAmount;
        private Label label4;
        private Label label3;
        private Button newPurchaseButton;
        private Button exitApp;
        private TableLayoutPanel productTable;
        private Panel panel2;
    }
}