namespace WinFormUI
{
    partial class Dashboard
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
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.messageBoxDemo = new System.Windows.Forms.Button();
            this.textBoxDemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(272, 43);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(170, 20);
            this.subTotalTextBox.TabIndex = 0;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(272, 98);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(170, 20);
            this.totalTextBox.TabIndex = 1;
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(272, 24);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(46, 13);
            this.subTotal.TabIndex = 2;
            this.subTotal.Text = "Subtotal";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(272, 82);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 3;
            this.total.Text = "Total";
            // 
            // messageBoxDemo
            // 
            this.messageBoxDemo.Location = new System.Drawing.Point(82, 156);
            this.messageBoxDemo.Name = "messageBoxDemo";
            this.messageBoxDemo.Size = new System.Drawing.Size(167, 88);
            this.messageBoxDemo.TabIndex = 4;
            this.messageBoxDemo.Text = "MessageBox Demo";
            this.messageBoxDemo.UseVisualStyleBackColor = true;
            this.messageBoxDemo.Click += new System.EventHandler(this.messageBoxDemo_Click);
            // 
            // textBoxDemoButton
            // 
            this.textBoxDemoButton.Location = new System.Drawing.Point(275, 156);
            this.textBoxDemoButton.Name = "textBoxDemoButton";
            this.textBoxDemoButton.Size = new System.Drawing.Size(167, 88);
            this.textBoxDemoButton.TabIndex = 5;
            this.textBoxDemoButton.Text = "TextBox Demo";
            this.textBoxDemoButton.UseVisualStyleBackColor = true;
            this.textBoxDemoButton.Click += new System.EventHandler(this.textBoxDemoButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 284);
            this.Controls.Add(this.textBoxDemoButton);
            this.Controls.Add(this.messageBoxDemo);
            this.Controls.Add(this.total);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Name = "Dashboard";
            this.Text = "Delegates Demo by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button messageBoxDemo;
        private System.Windows.Forms.Button textBoxDemoButton;
    }
}

