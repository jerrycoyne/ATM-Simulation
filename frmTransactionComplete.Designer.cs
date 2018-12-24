namespace ATMBank
{
    partial class frmTransactionComplete
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
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCheckBalance = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.txtChecking = new System.Windows.Forms.TextBox();
            this.lblChecking = new System.Windows.Forms.Label();
            this.lblAnotherTransaction = new System.Windows.Forms.Label();
            this.lblNewBalance = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(339, 148);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(75, 20);
            this.btnCheckBalance.TabIndex = 0;
            this.btnCheckBalance.Text = "Yes";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(178, 296);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnNewTransaction.TabIndex = 2;
            this.btnNewTransaction.Text = "Yes";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnMoreTransactions_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "No";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btrWriteToUpdatedLine_Click);
            // 
            // lblCheckBalance
            // 
            this.lblCheckBalance.AutoSize = true;
            this.lblCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckBalance.Location = new System.Drawing.Point(12, 148);
            this.lblCheckBalance.Name = "lblCheckBalance";
            this.lblCheckBalance.Size = new System.Drawing.Size(305, 20);
            this.lblCheckBalance.TabIndex = 4;
            this.lblCheckBalance.Text = "Would you like to see your balances?";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBankName.Font = new System.Drawing.Font("Engravers MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(136, 30);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(303, 39);
            this.lblBankName.TabIndex = 5;
            this.lblBankName.Text = "Jerry Bank";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(464, 191);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(52, 13);
            this.lblSavings.TabIndex = 6;
            this.lblSavings.Text = "Savings";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(446, 216);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.Size = new System.Drawing.Size(88, 20);
            this.txtSavings.TabIndex = 7;
            // 
            // txtChecking
            // 
            this.txtChecking.Location = new System.Drawing.Point(339, 216);
            this.txtChecking.Name = "txtChecking";
            this.txtChecking.Size = new System.Drawing.Size(88, 20);
            this.txtChecking.TabIndex = 8;
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecking.Location = new System.Drawing.Point(354, 191);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(60, 13);
            this.lblChecking.TabIndex = 9;
            this.lblChecking.Text = "Checking";
            // 
            // lblAnotherTransaction
            // 
            this.lblAnotherTransaction.AutoSize = true;
            this.lblAnotherTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotherTransaction.Location = new System.Drawing.Point(126, 266);
            this.lblAnotherTransaction.Name = "lblAnotherTransaction";
            this.lblAnotherTransaction.Size = new System.Drawing.Size(313, 16);
            this.lblAnotherTransaction.TabIndex = 10;
            this.lblAnotherTransaction.Text = "Would you like to make another transaction?";
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBalance.Location = new System.Drawing.Point(35, 216);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(218, 16);
            this.lblNewBalance.TabIndex = 11;
            this.lblNewBalance.Text = "Your Bank Balances Are Now: ";
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(186, 90);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(216, 16);
            this.lblCongrats.TabIndex = 12;
            this.lblCongrats.Text = "Your Transaction Is Complete!";
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lblNewBalance);
            this.Controls.Add(this.lblAnotherTransaction);
            this.Controls.Add(this.lblChecking);
            this.Controls.Add(this.txtChecking);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.lblCheckBalance);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnCheckBalance);
            this.Name = "frmTransactionComplete";
            this.Text = "Transaction Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCheckBalance;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.TextBox txtChecking;
        private System.Windows.Forms.Label lblChecking;
        private System.Windows.Forms.Label lblAnotherTransaction;
        private System.Windows.Forms.Label lblNewBalance;
        private System.Windows.Forms.Label lblCongrats;
    }
}