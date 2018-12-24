/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 7
 * This class handles customer
 * Account lookup and validation
 * of user input
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
    public partial class frmAccountLookUp : Form
    {
        public frmAccountLookUp()
        {
            InitializeComponent();
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //validate input length
            Boolean found = false;
            string accountNumberInput = txtAccountNumber.Text;
            
            if  (GlobalData.ATMBank.getAccountLength(accountNumberInput.Length))
            {
                //checks if input is all a number
                int check = 0;
                foreach (char c in accountNumberInput)
                {
                    if (c >= '0' && c <= '9')
                    {
                        check++;
                    }
                }
                
                //runs if input validated
                if (GlobalData.ATMBank.getAccountLength(check))
                {
                    
                    String customerData=GlobalData.ATMBank.findCustomerRecord(accountNumberInput, ref found);
                    if (found == true)
                    {
                        GlobalData.customer.createCustomer(customerData);
                        GlobalData.EnterPinForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        GlobalData.ATMBank.rewindFiles();
                        MessageBox.Show("Acount not found. Enter Again");
                    }

                }
                else
                {
                    MessageBox.Show("Acount Number Invalid Use Only Numbers", "Error");
                        txtAccountNumber.Text = "";
                    GlobalData.ATMBank.rewindFiles();
                }
            }
            else
            {
                MessageBox.Show("Acount number invalid");
                txtAccountNumber.Text = "";
                GlobalData.ATMBank.rewindFiles();
            }

        }
    }
}
