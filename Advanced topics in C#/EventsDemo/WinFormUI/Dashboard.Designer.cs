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
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkingTransactions = new System.Windows.Forms.ListBox();
            this.savingsTransactions = new System.Windows.Forms.ListBox();
            this.recordTransactionsButton = new System.Windows.Forms.Button();
            this.customerText = new System.Windows.Forms.Label();
            this.checkingBalanceValue = new System.Windows.Forms.Label();
            this.savingsBalanceValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking Demo";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(386, 63);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(358, 20);
            this.errorMessage.TabIndex = 1;
            this.errorMessage.Text = "You had an overdraft protection transfer of 0,00 €";
            this.errorMessage.Visible = false;
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Checking Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saving Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Checking Transactions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Savings Transactions";
            // 
            // checkingTransactions
            // 
            this.checkingTransactions.FormattingEnabled = true;
            this.checkingTransactions.Location = new System.Drawing.Point(390, 139);
            this.checkingTransactions.Name = "checkingTransactions";
            this.checkingTransactions.Size = new System.Drawing.Size(231, 277);
            this.checkingTransactions.TabIndex = 10;
            // 
            // savingsTransactions
            // 
            this.savingsTransactions.FormattingEnabled = true;
            this.savingsTransactions.Location = new System.Drawing.Point(639, 139);
            this.savingsTransactions.Name = "savingsTransactions";
            this.savingsTransactions.Size = new System.Drawing.Size(231, 277);
            this.savingsTransactions.TabIndex = 11;
            // 
            // recordTransactionsButton
            // 
            this.recordTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordTransactionsButton.Location = new System.Drawing.Point(97, 326);
            this.recordTransactionsButton.Name = "recordTransactionsButton";
            this.recordTransactionsButton.Size = new System.Drawing.Size(155, 77);
            this.recordTransactionsButton.TabIndex = 12;
            this.recordTransactionsButton.Text = "Record Transactions";
            this.recordTransactionsButton.UseVisualStyleBackColor = true;
            this.recordTransactionsButton.Click += new System.EventHandler(this.recordTransactionsButton_Click);
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerText.Location = new System.Drawing.Point(282, 159);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(54, 20);
            this.customerText.TabIndex = 13;
            this.customerText.Text = "<non>";
            // 
            // checkingBalanceValue
            // 
            this.checkingBalanceValue.AutoSize = true;
            this.checkingBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingBalanceValue.Location = new System.Drawing.Point(282, 213);
            this.checkingBalanceValue.Name = "checkingBalanceValue";
            this.checkingBalanceValue.Size = new System.Drawing.Size(53, 20);
            this.checkingBalanceValue.TabIndex = 14;
            this.checkingBalanceValue.Text = "0,00 €";
            // 
            // savingsBalanceValue
            // 
            this.savingsBalanceValue.AutoSize = true;
            this.savingsBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsBalanceValue.Location = new System.Drawing.Point(282, 269);
            this.savingsBalanceValue.Name = "savingsBalanceValue";
            this.savingsBalanceValue.Size = new System.Drawing.Size(53, 20);
            this.savingsBalanceValue.TabIndex = 15;
            this.savingsBalanceValue.Text = "0,00 €";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.savingsBalanceValue);
            this.Controls.Add(this.checkingBalanceValue);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.recordTransactionsButton);
            this.Controls.Add(this.savingsTransactions);
            this.Controls.Add(this.checkingTransactions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Banking Demo - A C# Events Demo by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox checkingTransactions;
        private System.Windows.Forms.ListBox savingsTransactions;
        private System.Windows.Forms.Button recordTransactionsButton;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label checkingBalanceValue;
        private System.Windows.Forms.Label savingsBalanceValue;
    }
}

