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
            panel1 = new Panel();
            checkoutButton = new Button();
            exitButton = new Button();
            productButton = new Button();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(checkoutButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(productButton);
            panel1.Location = new Point(30, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 641);
            panel1.TabIndex = 1;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = Color.Transparent;
            checkoutButton.Cursor = Cursors.Hand;
            checkoutButton.FlatStyle = FlatStyle.Flat;
            checkoutButton.Font = new Font("Arial", 15F);
            checkoutButton.ForeColor = Color.White;
            checkoutButton.Location = new Point(12, 122);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(243, 59);
            checkoutButton.TabIndex = 3;
            checkoutButton.TabStop = false;
            checkoutButton.Text = "Shopping Cart";
            checkoutButton.UseVisualStyleBackColor = false;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 15F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(12, 562);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(243, 59);
            exitButton.TabIndex = 3;
            exitButton.TabStop = false;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // productButton
            // 
            productButton.BackColor = Color.Transparent;
            productButton.Cursor = Cursors.Hand;
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Arial", 15F);
            productButton.ForeColor = Color.White;
            productButton.Location = new Point(12, 43);
            productButton.Name = "productButton";
            productButton.Size = new Size(243, 59);
            productButton.TabIndex = 3;
            productButton.TabStop = false;
            productButton.Text = "Products";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
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
            panel2.Location = new Point(406, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 518);
            panel2.TabIndex = 3;
            // 
            // productTable
            // 
            productTable.ColumnCount = 4;
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8823547F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.1176453F));
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
            label7.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(719, 28);
            label7.Name = "label7";
            label7.Size = new Size(332, 55);
            label7.TabIndex = 2;
            label7.Text = "Shopping Cart";
            // 
            // ShoppingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 50, 58);
            ClientSize = new Size(1386, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShoppingList";
            Text = "ShoppingList";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button checkoutButton;
        private Button exitButton;
        private Button productButton;
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
    }
}