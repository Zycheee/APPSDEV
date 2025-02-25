namespace GroceryCalculatorDiscountApp.Pages
{
    partial class CalculateMenu
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
            label2 = new Label();
            applePanel = new Panel();
            addApple = new Button();
            appleImage = new PictureBox();
            applePrice = new Label();
            label3 = new Label();
            productAdded = new Panel();
            productOK = new Button();
            label12 = new Label();
            label1 = new Label();
            bananaPanel = new Panel();
            bananaAdd = new Button();
            bananaImage = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            orangePanel = new Panel();
            orangeAdd = new Button();
            orangeImage = new PictureBox();
            label9 = new Label();
            label5 = new Label();
            milkPanel = new Panel();
            milkAdd = new Button();
            milkImage = new PictureBox();
            label10 = new Label();
            label6 = new Label();
            breadPanel = new Panel();
            addBread = new Button();
            breadImage = new PictureBox();
            label11 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            applePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appleImage).BeginInit();
            productAdded.SuspendLayout();
            bananaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bananaImage).BeginInit();
            orangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orangeImage).BeginInit();
            milkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)milkImage).BeginInit();
            breadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)breadImage).BeginInit();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            exitButton.Click += exitButton_Click_1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(742, 19);
            label2.Name = "label2";
            label2.Size = new Size(226, 62);
            label2.TabIndex = 2;
            label2.Text = "In stock";
            // 
            // applePanel
            // 
            applePanel.BackColor = Color.FromArgb(224, 224, 224);
            applePanel.Controls.Add(addApple);
            applePanel.Controls.Add(appleImage);
            applePanel.Controls.Add(applePrice);
            applePanel.Controls.Add(label3);
            applePanel.Location = new Point(410, 99);
            applePanel.Name = "applePanel";
            applePanel.Size = new Size(249, 258);
            applePanel.TabIndex = 7;
            // 
            // addApple
            // 
            addApple.BackColor = Color.FromArgb(44, 50, 58);
            addApple.Cursor = Cursors.Hand;
            addApple.FlatStyle = FlatStyle.Flat;
            addApple.Font = new Font("Arial", 15F);
            addApple.ForeColor = Color.White;
            addApple.Location = new Point(16, 215);
            addApple.Name = "addApple";
            addApple.Size = new Size(207, 37);
            addApple.TabIndex = 3;
            addApple.TabStop = false;
            addApple.Text = "Add";
            addApple.UseVisualStyleBackColor = false;
            addApple.Click += addApple_Click;
            // 
            // appleImage
            // 
            appleImage.Location = new Point(10, 14);
            appleImage.Name = "appleImage";
            appleImage.Padding = new Padding(5);
            appleImage.Size = new Size(228, 162);
            appleImage.TabIndex = 0;
            appleImage.TabStop = false;
            appleImage.Click += appleImage_Click;
            // 
            // applePrice
            // 
            applePrice.AutoSize = true;
            applePrice.BackColor = Color.Transparent;
            applePrice.Font = new Font("Arial", 16F);
            applePrice.ForeColor = Color.FromArgb(44, 50, 58);
            applePrice.Location = new Point(157, 187);
            applePrice.Name = "applePrice";
            applePrice.Size = new Size(66, 25);
            applePrice.TabIndex = 2;
            applePrice.Text = "$5.00";
            applePrice.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = Color.FromArgb(44, 50, 58);
            label3.Location = new Point(16, 185);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Apple";
            label3.Click += label3_Click;
            // 
            // productAdded
            // 
            productAdded.Controls.Add(productOK);
            productAdded.Controls.Add(label12);
            productAdded.Controls.Add(label1);
            productAdded.Location = new Point(1054, 402);
            productAdded.Name = "productAdded";
            productAdded.Size = new Size(427, 241);
            productAdded.TabIndex = 9;
            // 
            // productOK
            // 
            productOK.BackColor = Color.White;
            productOK.Cursor = Cursors.Hand;
            productOK.FlatStyle = FlatStyle.Flat;
            productOK.Font = new Font("Arial", 15F);
            productOK.ForeColor = Color.Black;
            productOK.Location = new Point(137, 185);
            productOK.Name = "productOK";
            productOK.Size = new Size(140, 45);
            productOK.TabIndex = 1;
            productOK.Text = "OK";
            productOK.UseVisualStyleBackColor = false;
            productOK.Click += productOK_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 192, 0);
            label12.Location = new Point(168, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 107);
            label12.TabIndex = 0;
            label12.Text = "✓";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 118);
            label1.Name = "label1";
            label1.Size = new Size(378, 64);
            label1.TabIndex = 0;
            label1.Text = "The product has been added  \r\n              to the cart";
            // 
            // bananaPanel
            // 
            bananaPanel.BackColor = Color.FromArgb(224, 224, 224);
            bananaPanel.Controls.Add(bananaAdd);
            bananaPanel.Controls.Add(bananaImage);
            bananaPanel.Controls.Add(label8);
            bananaPanel.Controls.Add(label4);
            bananaPanel.Location = new Point(742, 99);
            bananaPanel.Name = "bananaPanel";
            bananaPanel.Size = new Size(249, 261);
            bananaPanel.TabIndex = 8;
            // 
            // bananaAdd
            // 
            bananaAdd.BackColor = Color.FromArgb(44, 50, 58);
            bananaAdd.Cursor = Cursors.Hand;
            bananaAdd.FlatStyle = FlatStyle.Flat;
            bananaAdd.Font = new Font("Arial", 15F);
            bananaAdd.ForeColor = Color.White;
            bananaAdd.Location = new Point(24, 217);
            bananaAdd.Name = "bananaAdd";
            bananaAdd.Size = new Size(199, 37);
            bananaAdd.TabIndex = 3;
            bananaAdd.TabStop = false;
            bananaAdd.Text = "Add";
            bananaAdd.UseVisualStyleBackColor = false;
            bananaAdd.Click += bananaAdd_Click;
            // 
            // bananaImage
            // 
            bananaImage.Location = new Point(10, 14);
            bananaImage.Name = "bananaImage";
            bananaImage.Size = new Size(228, 162);
            bananaImage.TabIndex = 0;
            bananaImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 16F);
            label8.ForeColor = Color.FromArgb(44, 50, 58);
            label8.Location = new Point(135, 185);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 2;
            label8.Text = "$3.00";
            label8.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 16F);
            label4.ForeColor = Color.FromArgb(44, 50, 58);
            label4.Location = new Point(20, 185);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 2;
            label4.Text = "Banana";
            label4.Click += label3_Click;
            // 
            // orangePanel
            // 
            orangePanel.BackColor = Color.FromArgb(224, 224, 224);
            orangePanel.Controls.Add(orangeAdd);
            orangePanel.Controls.Add(orangeImage);
            orangePanel.Controls.Add(label9);
            orangePanel.Controls.Add(label5);
            orangePanel.Location = new Point(1069, 99);
            orangePanel.Name = "orangePanel";
            orangePanel.Size = new Size(249, 261);
            orangePanel.TabIndex = 8;
            // 
            // orangeAdd
            // 
            orangeAdd.BackColor = Color.FromArgb(44, 50, 58);
            orangeAdd.Cursor = Cursors.Hand;
            orangeAdd.FlatStyle = FlatStyle.Flat;
            orangeAdd.Font = new Font("Arial", 15F);
            orangeAdd.ForeColor = Color.White;
            orangeAdd.Location = new Point(18, 219);
            orangeAdd.Name = "orangeAdd";
            orangeAdd.Size = new Size(205, 37);
            orangeAdd.TabIndex = 3;
            orangeAdd.TabStop = false;
            orangeAdd.Text = "Add";
            orangeAdd.UseVisualStyleBackColor = false;
            orangeAdd.Click += orangeAdd_Click;
            // 
            // orangeImage
            // 
            orangeImage.Location = new Point(10, 14);
            orangeImage.Name = "orangeImage";
            orangeImage.Size = new Size(228, 162);
            orangeImage.TabIndex = 0;
            orangeImage.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 16F);
            label9.ForeColor = Color.FromArgb(44, 50, 58);
            label9.Location = new Point(138, 185);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 2;
            label9.Text = "$4.00";
            label9.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 16F);
            label5.ForeColor = Color.FromArgb(44, 50, 58);
            label5.Location = new Point(22, 185);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 2;
            label5.Text = "Orange";
            label5.Click += label3_Click;
            // 
            // milkPanel
            // 
            milkPanel.BackColor = Color.FromArgb(224, 224, 224);
            milkPanel.Controls.Add(milkAdd);
            milkPanel.Controls.Add(milkImage);
            milkPanel.Controls.Add(label10);
            milkPanel.Controls.Add(label6);
            milkPanel.Location = new Point(410, 388);
            milkPanel.Name = "milkPanel";
            milkPanel.Size = new Size(249, 258);
            milkPanel.TabIndex = 7;
            // 
            // milkAdd
            // 
            milkAdd.BackColor = Color.FromArgb(44, 50, 58);
            milkAdd.Cursor = Cursors.Hand;
            milkAdd.FlatStyle = FlatStyle.Flat;
            milkAdd.Font = new Font("Arial", 15F);
            milkAdd.ForeColor = Color.White;
            milkAdd.Location = new Point(24, 214);
            milkAdd.Name = "milkAdd";
            milkAdd.Size = new Size(199, 37);
            milkAdd.TabIndex = 3;
            milkAdd.TabStop = false;
            milkAdd.Text = "Add";
            milkAdd.UseVisualStyleBackColor = false;
            milkAdd.Click += milkAdd_Click;
            // 
            // milkImage
            // 
            milkImage.Location = new Point(10, 14);
            milkImage.Name = "milkImage";
            milkImage.Padding = new Padding(5);
            milkImage.Size = new Size(228, 162);
            milkImage.TabIndex = 0;
            milkImage.TabStop = false;
            milkImage.Click += appleImage_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 16F);
            label10.ForeColor = Color.FromArgb(44, 50, 58);
            label10.Location = new Point(138, 185);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 2;
            label10.Text = "$2.50";
            label10.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 16F);
            label6.ForeColor = Color.FromArgb(44, 50, 58);
            label6.Location = new Point(24, 188);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 2;
            label6.Text = "Milk";
            label6.Click += label3_Click;
            // 
            // breadPanel
            // 
            breadPanel.BackColor = Color.FromArgb(224, 224, 224);
            breadPanel.Controls.Add(addBread);
            breadPanel.Controls.Add(breadImage);
            breadPanel.Controls.Add(label11);
            breadPanel.Controls.Add(label7);
            breadPanel.Location = new Point(742, 388);
            breadPanel.Name = "breadPanel";
            breadPanel.Size = new Size(249, 258);
            breadPanel.TabIndex = 7;
            // 
            // addBread
            // 
            addBread.BackColor = Color.FromArgb(44, 50, 58);
            addBread.Cursor = Cursors.Hand;
            addBread.FlatStyle = FlatStyle.Flat;
            addBread.Font = new Font("Arial", 15F);
            addBread.ForeColor = Color.White;
            addBread.Location = new Point(24, 215);
            addBread.Name = "addBread";
            addBread.Size = new Size(199, 37);
            addBread.TabIndex = 3;
            addBread.TabStop = false;
            addBread.Text = "Add";
            addBread.UseVisualStyleBackColor = false;
            addBread.Click += addBread_Click;
            // 
            // breadImage
            // 
            breadImage.Location = new Point(10, 14);
            breadImage.Name = "breadImage";
            breadImage.Padding = new Padding(5);
            breadImage.Size = new Size(228, 162);
            breadImage.TabIndex = 0;
            breadImage.TabStop = false;
            breadImage.Click += appleImage_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 16F);
            label11.ForeColor = Color.FromArgb(44, 50, 58);
            label11.Location = new Point(135, 186);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 2;
            label11.Text = "$2.00";
            label11.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 16F);
            label7.ForeColor = Color.FromArgb(44, 50, 58);
            label7.Location = new Point(24, 185);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 2;
            label7.Text = "Bread";
            label7.Click += label3_Click;
            // 
            // CalculateMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 50, 58);
            ClientSize = new Size(1424, 681);
            Controls.Add(productAdded);
            Controls.Add(orangePanel);
            Controls.Add(bananaPanel);
            Controls.Add(breadPanel);
            Controls.Add(milkPanel);
            Controls.Add(applePanel);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculateMenu";
            Text = "v";
            Load += CalculateMenu_Load;
            panel1.ResumeLayout(false);
            applePanel.ResumeLayout(false);
            applePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appleImage).EndInit();
            productAdded.ResumeLayout(false);
            productAdded.PerformLayout();
            bananaPanel.ResumeLayout(false);
            bananaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bananaImage).EndInit();
            orangePanel.ResumeLayout(false);
            orangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orangeImage).EndInit();
            milkPanel.ResumeLayout(false);
            milkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)milkImage).EndInit();
            breadPanel.ResumeLayout(false);
            breadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)breadImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel applePanel;
        private PictureBox appleImage;
        private Label label3;
        private Button addApple;
        private Panel bananaPanel;
        private PictureBox bananaImage;
        private Label label4;
        private Button bananaAdd;
        private Panel orangePanel;
        private Button orangeAdd;
        private PictureBox orangeImage;
        private Label label5;
        private Panel milkPanel;
        private Button milkAdd;
        private PictureBox milkImage;
        private Label label6;
        private Panel breadPanel;
        private Button addBread;
        private PictureBox breadImage;
        private Label label7;
        private Label applePrice;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button checkoutButton;
        private Button productButton;
        private Button exitButton;
        private Label label1;
        private Label label12;
        private Panel productAdded;
        private Button productOK;
    }
}