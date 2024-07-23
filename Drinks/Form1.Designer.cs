namespace Drinks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DrinkNameLA = new Label();
            DrinkNameTB = new TextBox();
            ShugerCB = new ComboBox();
            ShugerLA = new Label();
            CofeeLA = new Label();
            CofeeCB = new ComboBox();
            MilkLA = new Label();
            MilkCB = new ComboBox();
            CocoaLA = new Label();
            CocoaCB = new ComboBox();
            PriceNUP = new NumericUpDown();
            PriceLA = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PriceNUP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DrinkNameLA
            // 
            DrinkNameLA.AutoSize = true;
            DrinkNameLA.Location = new Point(671, 50);
            DrinkNameLA.Name = "DrinkNameLA";
            DrinkNameLA.Size = new Size(60, 15);
            DrinkNameLA.TabIndex = 0;
            DrinkNameLA.Text = "שם משקה";
            // 
            // DrinkNameTB
            // 
            DrinkNameTB.Location = new Point(467, 47);
            DrinkNameTB.Name = "DrinkNameTB";
            DrinkNameTB.Size = new Size(184, 23);
            DrinkNameTB.TabIndex = 1;
            // 
            // ShugerCB
            // 
            ShugerCB.FormattingEnabled = true;
            ShugerCB.Location = new Point(671, 117);
            ShugerCB.Name = "ShugerCB";
            ShugerCB.Size = new Size(81, 23);
            ShugerCB.TabIndex = 2;
            // 
            // ShugerLA
            // 
            ShugerLA.AutoSize = true;
            ShugerLA.Location = new Point(682, 88);
            ShugerLA.Name = "ShugerLA";
            ShugerLA.Size = new Size(44, 15);
            ShugerLA.TabIndex = 3;
            ShugerLA.Text = "Shuger";
            // 
            // CofeeLA
            // 
            CofeeLA.AutoSize = true;
            CofeeLA.Location = new Point(568, 88);
            CofeeLA.Name = "CofeeLA";
            CofeeLA.Size = new Size(38, 15);
            CofeeLA.TabIndex = 5;
            CofeeLA.Text = "Cofee";
            // 
            // CofeeCB
            // 
            CofeeCB.FormattingEnabled = true;
            CofeeCB.Location = new Point(557, 117);
            CofeeCB.Name = "CofeeCB";
            CofeeCB.Size = new Size(81, 23);
            CofeeCB.TabIndex = 4;
            // 
            // MilkLA
            // 
            MilkLA.AutoSize = true;
            MilkLA.Location = new Point(339, 88);
            MilkLA.Name = "MilkLA";
            MilkLA.Size = new Size(30, 15);
            MilkLA.TabIndex = 9;
            MilkLA.Text = "Milk";
            // 
            // MilkCB
            // 
            MilkCB.FormattingEnabled = true;
            MilkCB.Location = new Point(328, 117);
            MilkCB.Name = "MilkCB";
            MilkCB.Size = new Size(81, 23);
            MilkCB.TabIndex = 8;
            // 
            // CocoaLA
            // 
            CocoaLA.AutoSize = true;
            CocoaLA.Location = new Point(453, 88);
            CocoaLA.Name = "CocoaLA";
            CocoaLA.Size = new Size(41, 15);
            CocoaLA.TabIndex = 7;
            CocoaLA.Text = "Cocoa";
            // 
            // CocoaCB
            // 
            CocoaCB.FormattingEnabled = true;
            CocoaCB.Location = new Point(442, 117);
            CocoaCB.Name = "CocoaCB";
            CocoaCB.Size = new Size(81, 23);
            CocoaCB.TabIndex = 6;
            // 
            // PriceNUP
            // 
            PriceNUP.Location = new Point(202, 119);
            PriceNUP.Name = "PriceNUP";
            PriceNUP.Size = new Size(113, 23);
            PriceNUP.TabIndex = 10;
            // 
            // PriceLA
            // 
            PriceLA.AutoSize = true;
            PriceLA.Location = new Point(245, 88);
            PriceLA.Name = "PriceLA";
            PriceLA.Size = new Size(33, 15);
            PriceLA.TabIndex = 11;
            PriceLA.Text = "Price";
            // 
            // button1
            // 
            button1.Location = new Point(78, 193);
            button1.Name = "button1";
            button1.Size = new Size(90, 51);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 117);
            button2.Name = "button2";
            button2.Size = new Size(90, 51);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(78, 47);
            button3.Name = "button3";
            button3.Size = new Size(90, 51);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(339, 150);
            button4.Name = "button4";
            button4.Size = new Size(90, 51);
            button4.TabIndex = 15;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(202, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 210);
            dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PriceLA);
            Controls.Add(PriceNUP);
            Controls.Add(MilkLA);
            Controls.Add(MilkCB);
            Controls.Add(CocoaLA);
            Controls.Add(CocoaCB);
            Controls.Add(CofeeLA);
            Controls.Add(CofeeCB);
            Controls.Add(ShugerLA);
            Controls.Add(ShugerCB);
            Controls.Add(DrinkNameTB);
            Controls.Add(DrinkNameLA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PriceNUP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DrinkNameLA;
        private TextBox DrinkNameTB;
        private ComboBox ShugerCB;
        private Label ShugerLA;
        private Label CofeeLA;
        private ComboBox CofeeCB;
        private Label MilkLA;
        private ComboBox MilkCB;
        private Label CocoaLA;
        private ComboBox CocoaCB;
        private NumericUpDown PriceNUP;
        private Label PriceLA;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}
