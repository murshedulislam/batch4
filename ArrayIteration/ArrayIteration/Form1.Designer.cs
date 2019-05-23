namespace ArrayIteration
{
    partial class Array
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.arrayNum = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.displayBox2 = new System.Windows.Forms.RichTextBox();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.displaySum = new System.Windows.Forms.RichTextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(320, 108);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(112, 110);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(202, 100);
            this.displayBox.TabIndex = 1;
            this.displayBox.Text = "";
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // arrayNum
            // 
            this.arrayNum.Location = new System.Drawing.Point(112, 32);
            this.arrayNum.Name = "arrayNum";
            this.arrayNum.Size = new System.Drawing.Size(100, 20);
            this.arrayNum.TabIndex = 2;
            this.arrayNum.TextChanged += new System.EventHandler(this.arrayNum_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(235, 28);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // displayBox2
            // 
            this.displayBox2.Location = new System.Drawing.Point(546, 108);
            this.displayBox2.Name = "displayBox2";
            this.displayBox2.Size = new System.Drawing.Size(194, 102);
            this.displayBox2.TabIndex = 4;
            this.displayBox2.Text = "";
            this.displayBox2.TextChanged += new System.EventHandler(this.displayBox2_TextChanged);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(456, 110);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 5;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // displaySum
            // 
            this.displaySum.Location = new System.Drawing.Point(112, 303);
            this.displaySum.Name = "displaySum";
            this.displaySum.Size = new System.Drawing.Size(202, 135);
            this.displaySum.TabIndex = 6;
            this.displaySum.Text = "";
            this.displaySum.TextChanged += new System.EventHandler(this.displaySum_TextChanged);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(320, 303);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 23);
            this.SumButton.TabIndex = 7;
            this.SumButton.Text = "Sum";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(321, 333);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 8;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(321, 363);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 9;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.displaySum);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.displayBox2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.arrayNum);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.ShowButton);
            this.Name = "Array";
            this.Text = "Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.TextBox arrayNum;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RichTextBox displayBox2;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.RichTextBox displaySum;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DuplicateButton;
    }
}

