/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 9
 * This class handles customer
 * transactions and processes them
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBank
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
            
        }

        int toCustomerClass;
       
        //Resets form 
        private void btnReset_Click(object sender, EventArgs e)
        {
            GlobalData.TransactionForm = new frmTransaction();
            GlobalData.TransactionForm.Show();
            this.Dispose(false);
        }

        //displays account balances
        private void BtnCheckBalances_Click(object sender, EventArgs e)
        {
           int checkbalance= GlobalData.customer.checkChecking();
           int savebalance = GlobalData.customer.checkSavings();
           txtMoneyInput.Text = checkbalance.ToString();
           txtComfirm.Text = savebalance.ToString();
           txtComfirm.Visible = true;
           txtMoneyInput.Visible = true;
           btnProcess.Visible = true;
           btnReset.Visible = true;
           lblCheckingAmount.Visible = true;
           lblSavingsAmount.Visible = true;
        }
        
        //This event handler is responsible for all 6 transaction selections that change the file. 
        private void btnTransactionSelection_Click(object sender, EventArgs e)
        {
            BtnCheckBalances.Visible = false;
            lblCheckingAmount.Visible = false;
            lblSavingsAmount.Visible = false;
            this.reset();
            ((Button)sender).Enabled = false;
        }
        
        //this converts and formats string for final transaction
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Boolean isGood = true;
            var allowedChars = "0123456789";
            string toCustomerClass = new string((txtMoneyInput.Text).Where(c => allowedChars.Contains(c)).ToArray());

            if (toCustomerClass.Length > 0)
            {  
                try
                {
                    this.toCustomerClass = int.Parse(toCustomerClass);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                    txtMoneyInput.Focus();
                    txtMoneyInput.Text = "";
                    isGood = false;
                }

                if (this.toCustomerClass < 1 && isGood)
                   
                {
                    isGood = false;
                    MessageBox.Show("Please Enter a number Greater then 0");
                    txtMoneyInput.Focus();
                    txtMoneyInput.Text = "";
                }
               
            }
            else 
            {
                MessageBox.Show("Please Enter a number");
                txtMoneyInput.Focus();
                txtMoneyInput.Text = "";
                isGood = false;
            }

            if (isGood == true) {
                if ((!btnSavingWithdraw.Enabled) ||(!btnCheckingWithdraw.Enabled))
                {
                    if (GlobalData.ATMBank.checkwdamount(this.toCustomerClass))
                    {
                        MessageBox.Show("The max Withdraw amount is   " + (GlobalData.ATMBank.getWithdrawAmount()).ToString()); 
                        txtMoneyInput.Text = "";
                        txtMoneyInput.Focus();
                        isGood = false;
                    }
                }
            }

            //check for sufficient funds
            if (isGood == true)
            {
                if (btnSavingWithdraw.Enabled == false ||btnSavingtoChecking.Enabled == false)
                {
                    if (GlobalData.customer.checkSavings() < this.toCustomerClass)
                    {
                      
                        isGood = false;
                        MessageBox.Show("Insufficient Funds");
                        txtMoneyInput.Text = "";
                        txtMoneyInput.Focus();
                    }

                }
            }

            //check for sufficient funds
            if (isGood == true)
            {
                if (btnCheckingWithdraw.Enabled == false || btnCheckingToSaving.Enabled == false)
                {
                    if (GlobalData.customer.checkChecking() < this.toCustomerClass)
                    {
                        
                        isGood = false;
                        MessageBox.Show("Insufficient Funds" 
                            + (GlobalData.customer.checkChecking()).ToString("C"));
                        txtMoneyInput.Text = "";
                        txtMoneyInput.Focus();
                    }

                }
            }
            
            //if input is valid enables the last buttons
            if (isGood == true)
            {
                lblConfirm.Visible = true;
                txtComfirm.Visible = true;
                txtComfirm.Text = "$" +toCustomerClass;
                btnProcess.Enabled = true;
                btnReset.Enabled = true;
                btnReset.Visible = true;
                btnProcess.Visible = true;
                btnOK.Enabled = false;
                txtMoneyInput.ReadOnly = true;
            }
        }

        //processes request
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (btnCheckingDeposit.Enabled == false)
            {
                GlobalData.customer.depositChecking(toCustomerClass);
            }

            if (btnSavingsDeposit.Enabled == false)
            {
                GlobalData.customer.depositSavings(toCustomerClass);
            }

            if (btnSavingWithdraw.Enabled == false)
            {
                GlobalData.customer.withdrawSavings(toCustomerClass);
            }

            if (btnCheckingWithdraw.Enabled == false)
            {
                GlobalData.customer.withdrawChecking(toCustomerClass);
            }

            if (btnCheckingToSaving.Enabled == false)
            { 
                GlobalData.customer.withdrawChecking(toCustomerClass);
                GlobalData.customer.depositSavings(toCustomerClass);
            }
           
           if (btnSavingtoChecking.Enabled == false)
           { 
                GlobalData.customer.withdrawSavings(toCustomerClass);
                GlobalData.customer.depositChecking(toCustomerClass);
           }
            this.goToCompleteForm();
        }
        
        private void goToCompleteForm()
        {
            GlobalData.TransactionCompleteForm = new frmTransactionComplete();
            GlobalData.TransactionCompleteForm.Show();
            this.Dispose(false);
        }

        //resets form
        private void reset()
        {
            lblSelectAmount.Visible = true;
            lblConfirm.Visible = false;
            txtMoneyInput.Visible = true;
            txtMoneyInput.Enabled = true;
            txtMoneyInput.Focus();
            txtComfirm.Text = "";
            txtComfirm.Visible = false;
            txtMoneyInput.ReadOnly = false;
            txtMoneyInput.Text = "";
            btnOK.Enabled = true;
            btnOK.Visible = true;
            btnProcess.Enabled = false;
            btnReset.Enabled = false;
            btnReset.Visible = false;
            btnProcess.Visible = false;
            btnCheckingDeposit.Enabled = true;
            btnSavingWithdraw.Enabled = true;
            btnCheckingWithdraw.Enabled = true;
            btnSavingsDeposit.Enabled = true;
            btnCheckingToSaving.Enabled = true;
            btnSavingtoChecking.Enabled = true;

        }
    }
}
