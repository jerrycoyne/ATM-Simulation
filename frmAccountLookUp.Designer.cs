namespace ATMBank
{
    partial class frmAccountLookUp
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(315, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(192, 188);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(88, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNum.Location = new System.Drawing.Point(56, 188);
            this.lblAccountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(125, 16);
            this.lblAccountNum.TabIndex = 2;
            this.lblAccountNum.Text = "Account Number:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoEllipsis = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Font = new System.Drawing.Font("Engravers MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(59, 16);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(375, 100);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome To Jerry Bank, Best Bank Ever";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnterAccountNumber
            // 
            this.lblEnterAccountNumber.AutoSize = true;
            this.lblEnterAccountNumber.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAccountNumber.Location = new System.Drawing.Point(31, 140);
            this.lblEnterAccountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterAccountNumber.Name = "lblEnterAccountNumber";
            this.lblEnterAccountNumber.Size = new System.Drawing.Size(437, 16);
            this.lblEnterAccountNumber.TabIndex = 4;
            this.lblEnterAccountNumber.Text = "Please Enter 5 Digit Account Number";
            // 
            // frmAccountLookUp
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(502, 282);
            this.Controls.Add(this.lblEnterAccountNumber);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAccountLookUp";
            this.Text = "Account Look Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterAccountNumber;
    }
}

