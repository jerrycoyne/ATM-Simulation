/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 10
 * Finalizes and summarizes
 * transactions
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
    public partial class frmTransactionComplete : Form
    {
        public frmTransactionComplete()
        {
            InitializeComponent();
        }

        //check balance
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            txtChecking.Text=(GlobalData.customer.checkChecking()).ToString("C");
            txtSavings.Text= (GlobalData.customer.checkSavings()).ToString("C");
        }

        //allows to go back for another transaction
        private void btnMoreTransactions_Click(object sender, EventArgs e)
        {
            GlobalData.TransactionForm = new frmTransaction();
            GlobalData.TransactionForm.Show();
            this.Dispose(false);

        }

        //writes to updated text file and closes application
        private void btrWriteToUpdatedLine_Click(object sender, EventArgs e)
        {
            GlobalData.ATMBank.writeOut(GlobalData.customer.updatedCustomer());
            GlobalData.ATMBank.CopyRemainingRecords();
            GlobalData.ATMBank.closeFiles();
            Application.Exit();
        }
    }
}
