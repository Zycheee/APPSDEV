namespace GroceryCalculatorDiscountApp.Pages
{
    partial class SelectMenu
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
            label1 = new Label();
            titleText = new Label();
            button1 = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.FlatStyle = FlatStyle.Flat;
            titleText.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.ForeColor = Color.White;
            titleText.Location = new Point(241, 255);
            titleText.Name = "titleText";
            titleText.Size = new Size(987, 75);
            titleText.TabIndex = 1;
            titleText.Text = "Welcome to Grocery Calculator";
            titleText.Click += titleText_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(480, 374);
            button1.Name = "button1";
            button1.Size = new Size(234, 68);
            button1.TabIndex = 2;
            button1.Text = "Add a product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(741, 374);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(234, 68);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit App";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseLeave;
            // 
            // SelectMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 50, 58);
            ClientSize = new Size(1424, 681);
            Controls.Add(exitButton);
            Controls.Add(button1);
            Controls.Add(titleText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectMenu";
            Text = "SelectMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titleText;
        private Button button1;
        private Button exitButton;
    }
}