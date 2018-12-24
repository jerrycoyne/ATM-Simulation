namespace ATMBank
{
    partial class frmEnterPin
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
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblPinWelcome = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBankName.Font = new System.Drawing.Font("Engravers MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(157, 28);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(284, 37);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Jerry Bank";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(36, 202);
            this.lblPin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(185, 18);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "Pin (a 4 Digit Number): ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 232);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(385, 195);
            this.txtPin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(88, 20);
            this.txtPin.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(385, 230);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(251, 300);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = " OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblPinWelcome
            // 
            this.lblPinWelcome.AutoSize = true;
            this.lblPinWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinWelcome.Location = new System.Drawing.Point(210, 84);
            this.lblPinWelcome.Name = "lblPinWelcome";
            this.lblPinWelcome.Size = new System.Drawing.Size(157, 18);
            this.lblPinWelcome.TabIndex = 6;
            this.lblPinWelcome.Text = "Pin and Name Entry";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(158, 127);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(283, 18);
            this.lblDirections.TabIndex = 7;
            this.lblDirections.Text = "Enter Pin and Name and Press OK...";
            // 
            // frmEnterPin
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblPinWelcome);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblBankName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEnterPin";
            this.Text = "Enter Pin and Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblPinWelcome;
        private System.Windows.Forms.Label lblDirections;
    }
}