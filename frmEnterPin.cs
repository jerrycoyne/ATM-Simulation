/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 8
 * This class handles 
 * validating account name and
 * password
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
    public partial class frmEnterPin : Form
    {
        public frmEnterPin()
        {
            InitializeComponent();
        }
        int failed = 0;
        Boolean nameFound = false;
        Boolean pinFound = false;
        
        private void btnOK_Click(object sender, EventArgs e)
        {
           nameFound = false;
           pinFound = false;
           string Name = txtName.Text;
           string pin = txtPin.Text;
           Name= ((Name).Replace(" ", "")).Replace("*", "");
           Name = Name.ToLower();
           pin = ((pin).Replace(" ", ""));

            //validates pin
            if (pin.Length == 4)
            {
                var allowedChars = "0123456789";
                pin = new string((pin).Where(c => allowedChars.Contains(c)).ToArray());
                if (pin.Length == 4)
                {
                    pinFound = true;
                }
                
            }

            if (Name.Length >= 1)
            {
                nameFound = true;
            }

            if (!nameFound ||!pinFound)
            {
                failed++;
                if (!nameFound && !pinFound)
                {
                    MessageBox.Show("Name and pin were not Correct");
                }else if (!nameFound)
                {
                    MessageBox.Show("Name was not Entered");
                }else MessageBox.Show("Pin was not correct input");
                
            }

            if (nameFound && pinFound)
            {  
                int x = GlobalData.customer.checkPinAndName(pin, Name);
                if (x == 0)
            {
                GlobalData.TransactionForm.Show();
                GlobalData.EnterPinForm.Hide();
                    
            }
                else
                {
                    MessageBox.Show("Pin or Account Name is incorrect");
                }
            }

            //lockout
            if (GlobalData.ATMBank.getTries(failed))
            {
                MessageBox.Show("You Have Exceeded The Number of Attempts Jerry Bank allows, Goodbye.");
                this.Close();
                Application.Exit();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
