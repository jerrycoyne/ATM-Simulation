namespace ATMBank
{
    partial class frmTransaction
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
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnCheckingDeposit = new System.Windows.Forms.Button();
            this.btnSavingWithdraw = new System.Windows.Forms.Button();
            this.btnCheckingWithdraw = new System.Windows.Forms.Button();
            this.btnCheckingToSaving = new System.Windows.Forms.Button();
            this.btnSavingtoChecking = new System.Windows.Forms.Button();
            this.BtnCheckBalances = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblTransactionHeader = new System.Windows.Forms.Label();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.txtMoneyInput = new System.Windows.Forms.TextBox();
            this.txtComfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblCheckingAmount = new System.Windows.Forms.Label();
            this.lblSavingsAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavingsDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsDeposit.Location = new System.Drawing.Point(402, 112);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(157, 40);
            this.btnSavingsDeposit.TabIndex = 3;
            this.btnSavingsDeposit.Text = "Savings Deposite";
            this.btnSavingsDeposit.UseVisualStyleBackColor = false;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // btnCheckingDeposit
            // 
            this.btnCheckingDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckingDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingDeposit.Location = new System.Drawing.Point(177, 109);
            this.btnCheckingDeposit.Name = "btnCheckingDeposit";
            this.btnCheckingDeposit.Size = new System.Drawing.Size(157, 40);
            this.btnCheckingDeposit.TabIndex = 4;
            this.btnCheckingDeposit.Text = "Checking Deposite";
            this.btnCheckingDeposit.UseVisualStyleBackColor = false;
            this.btnCheckingDeposit.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // btnSavingWithdraw
            // 
            this.btnSavingWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavingWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingWithdraw.Location = new System.Drawing.Point(402, 182);
            this.btnSavingWithdraw.Name = "btnSavingWithdraw";
            this.btnSavingWithdraw.Size = new System.Drawing.Size(157, 33);
            this.btnSavingWithdraw.TabIndex = 5;
            this.btnSavingWithdraw.Text = "Savings Withdraw";
            this.btnSavingWithdraw.UseVisualStyleBackColor = false;
            this.btnSavingWithdraw.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // btnCheckingWithdraw
            // 
            this.btnCheckingWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckingWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingWithdraw.Location = new System.Drawing.Point(177, 182);
            this.btnCheckingWithdraw.Name = "btnCheckingWithdraw";
            this.btnCheckingWithdraw.Size = new System.Drawing.Size(157, 33);
            this.btnCheckingWithdraw.TabIndex = 6;
            this.btnCheckingWithdraw.Text = "Checking Withdraw";
            this.btnCheckingWithdraw.UseVisualStyleBackColor = false;
            this.btnCheckingWithdraw.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // btnCheckingToSaving
            // 
            this.btnCheckingToSaving.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckingToSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingToSaving.Location = new System.Drawing.Point(177, 259);
            this.btnCheckingToSaving.Name = "btnCheckingToSaving";
            this.btnCheckingToSaving.Size = new System.Drawing.Size(157, 36);
            this.btnCheckingToSaving.TabIndex = 7;
            this.btnCheckingToSaving.Text = "Transfer Checking to Savings";
            this.btnCheckingToSaving.UseVisualStyleBackColor = false;
            this.btnCheckingToSaving.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // btnSavingtoChecking
            // 
            this.btnSavingtoChecking.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavingtoChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingtoChecking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavingtoChecking.Location = new System.Drawing.Point(402, 259);
            this.btnSavingtoChecking.Name = "btnSavingtoChecking";
            this.btnSavingtoChecking.Size = new System.Drawing.Size(157, 36);
            this.btnSavingtoChecking.TabIndex = 8;
            this.btnSavingtoChecking.Text = "Transfer Savings to Checking";
            this.btnSavingtoChecking.UseVisualStyleBackColor = false;
            this.btnSavingtoChecking.Click += new System.EventHandler(this.btnTransactionSelection_Click);
            // 
            // BtnCheckBalances
            // 
            this.BtnCheckBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckBalances.Location = new System.Drawing.Point(539, 319);
            this.BtnCheckBalances.Name = "BtnCheckBalances";
            this.BtnCheckBalances.Size = new System.Drawing.Size(93, 34);
            this.BtnCheckBalances.TabIndex = 9;
            this.BtnCheckBalances.Text = "Check Balances";
            this.BtnCheckBalances.UseVisualStyleBackColor = true;
            this.BtnCheckBalances.Click += new System.EventHandler(this.BtnCheckBalances_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(539, 325);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(190, 387);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(159, 33);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "Yes -  Proccess Request";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Visible = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(402, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "No - Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBankName.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(262, 19);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(230, 30);
            this.lblBankName.TabIndex = 14;
            this.lblBankName.Text = "Jerry Bank";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionHeader
            // 
            this.lblTransactionHeader.AutoSize = true;
            this.lblTransactionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHeader.Location = new System.Drawing.Point(321, 64);
            this.lblTransactionHeader.Name = "lblTransactionHeader";
            this.lblTransactionHeader.Size = new System.Drawing.Size(131, 16);
            this.lblTransactionHeader.TabIndex = 15;
            this.lblTransactionHeader.Text = "Transaction Page";
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAmount.Location = new System.Drawing.Point(38, 325);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(364, 16);
            this.lblSelectAmount.TabIndex = 16;
            this.lblSelectAmount.Text = "Select Amount Of Money In Dollars (No Punctuation)";
            this.lblSelectAmount.Visible = false;
            // 
            // txtMoneyInput
            // 
            this.txtMoneyInput.Enabled = false;
            this.txtMoneyInput.Location = new System.Drawing.Point(420, 325);
            this.txtMoneyInput.Name = "txtMoneyInput";
            this.txtMoneyInput.Size = new System.Drawing.Size(100, 20);
            this.txtMoneyInput.TabIndex = 17;
            this.txtMoneyInput.Visible = false;
            // 
            // txtComfirm
            // 
            this.txtComfirm.Location = new System.Drawing.Point(420, 358);
            this.txtComfirm.Name = "txtComfirm";
            this.txtComfirm.ReadOnly = true;
            this.txtComfirm.Size = new System.Drawing.Size(100, 20);
            this.txtComfirm.TabIndex = 18;
            this.txtComfirm.Visible = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(38, 358);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(351, 16);
            this.lblConfirm.TabIndex = 19;
            this.lblConfirm.Text = "You have selected the amount show is this correct";
            this.lblConfirm.Visible = false;
            // 
            // lblCheckingAmount
            // 
            this.lblCheckingAmount.AutoSize = true;
            this.lblCheckingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingAmount.Location = new System.Drawing.Point(262, 325);
            this.lblCheckingAmount.Name = "lblCheckingAmount";
            this.lblCheckingAmount.Size = new System.Drawing.Size(127, 16);
            this.lblCheckingAmount.TabIndex = 20;
            this.lblCheckingAmount.Text = "Checking Amount";
            this.lblCheckingAmount.Visible = false;
            // 
            // lblSavingsAmount
            // 
            this.lblSavingsAmount.AutoSize = true;
            this.lblSavingsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsAmount.Location = new System.Drawing.Point(270, 358);
            this.lblSavingsAmount.Name = "lblSavingsAmount";
            this.lblSavingsAmount.Size = new System.Drawing.Size(119, 16);
            this.lblSavingsAmount.TabIndex = 21;
            this.lblSavingsAmount.Text = "Savings Amount";
            this.lblSavingsAmount.Visible = false;
            // 
            // frmTransaction
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(760, 443);
            this.Controls.Add(this.lblSavingsAmount);
            this.Controls.Add(this.lblCheckingAmount);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtComfirm);
            this.Controls.Add(this.txtMoneyInput);
            this.Controls.Add(this.lblSelectAmount);
            this.Controls.Add(this.lblTransactionHeader);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.BtnCheckBalances);
            this.Controls.Add(this.btnSavingtoChecking);
            this.Controls.Add(this.btnCheckingToSaving);
            this.Controls.Add(this.btnCheckingWithdraw);
            this.Controls.Add(this.btnSavingWithdraw);
            this.Controls.Add(this.btnCheckingDeposit);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnCheckingDeposit;
        private System.Windows.Forms.Button btnSavingWithdraw;
        private System.Windows.Forms.Button btnCheckingWithdraw;
        private System.Windows.Forms.Button btnCheckingToSaving;
        private System.Windows.Forms.Button btnSavingtoChecking;
        private System.Windows.Forms.Button BtnCheckBalances;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblTransactionHeader;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.TextBox txtMoneyInput;
        private System.Windows.Forms.TextBox txtComfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblCheckingAmount;
        private System.Windows.Forms.Label lblSavingsAmount;
    }
}