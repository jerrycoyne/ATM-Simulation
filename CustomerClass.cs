/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 2
 * This class handles customer
 * data
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBank
{
    public class CustomerClass
    {
        private string customerAccountNumber;
        private String customerAccountName;
        private String customerPin;
        private int savingsAmount;
        private int checkingAmount;
        private String[] customerDataLine;

        //parameterless constructor
        public CustomerClass()
        {

        }

        // this creates the customer data line that is to be put into the text file
        public void createCustomer(string nextrecord)
        {
            var allowedChars = "0123456789";

            customerDataLine = nextrecord.Split('*');
            customerAccountNumber = new string((customerDataLine[0]).Where(c => allowedChars.Contains(c)).ToArray());
            customerAccountName = ((customerDataLine[1].Replace(" ", "")).Replace("*", "")).ToLower();
            customerPin = (customerDataLine[2].Replace(" ", "")).Replace("*", "");
            string savingsString = new string((customerDataLine[3]).Where(c => allowedChars.Contains(c)).ToArray());
            string checkingString = new string((customerDataLine[4]).Where(c => allowedChars.Contains(c)).ToArray());

            savingsAmount = Int32.Parse(savingsString);
            checkingAmount = Int32.Parse(checkingString);
        }

        //tells whether customer has been found or not and validates proper input
        public Boolean customerMatch(string theAccountNumber, string nextRecord)
        {
            string[] checkAccountNumber = nextRecord.Split('*');
            var allowedChars = "0123456789";

            string accountNumebrValidate = new string((checkAccountNumber[0]).Where(c => allowedChars.Contains(c)).ToArray());
            checkAccountNumber[0] = accountNumebrValidate;

            if (checkAccountNumber[0] == theAccountNumber)
            {
                return true;
            } else return false;
        }

        //This is the updated customer data line to be written to the updatedtxt file
        public string updatedCustomer() 
        { 
            customerAccountName = (customerDataLine[1].Replace("*", ""));

            string finalsavings= (savingsAmount.ToString("#,##0"));
            finalsavings = "$"+ finalsavings;

            string finalchecking = (checkingAmount.ToString("#,##0"));
            finalchecking = "$" + finalchecking;

            String set = (customerAccountNumber + "*" + customerAccountName + "*" + customerPin + "*" + finalsavings + "*" + finalchecking + "\n");
            return set;
        }

        //Methods to perform transaction page functions
        public int checkSavings()
        {
            return savingsAmount;
        }

        public int checkChecking()
        {
            return checkingAmount;
        }

        public void withdrawSavings(int savingsWithdraw)
        {
            savingsAmount = savingsAmount - savingsWithdraw;
        }

        public void withdrawChecking(int checkingWithdraw)
        {
            checkingAmount = checkingAmount - checkingWithdraw;
        }

        public void depositSavings(int savingsDeposit)
        {
            savingsAmount = savingsAmount + savingsDeposit;
        }

        public void depositChecking(int checkingDeposit)
        {
            checkingAmount = checkingAmount + checkingDeposit;
        }
        //end methods for transaction page

        //checks pin and name and gives warning for error
        public int checkPinAndName(string pin,string name)
        {
            if (pin == customerPin)
            {
                if (name == customerAccountName)
                {
                    return 0;
                }
                else return 1;
            }
            else if (name == customerAccountName) {
                return 1;
            }
            else return 1;
        }
    }
}
