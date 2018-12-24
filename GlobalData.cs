/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 5
 * This class holds references between our classes 
 * so that you dont have to instantiate every class
 * everytime you need it in a file
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMBank
{
    public class GlobalData
    {
     
        // Application classes
        public static ATMBankClass ATMBank = new ATMBankClass();
        public static CustomerClass customer = new CustomerClass();


        // Creating instances of all the forms ...
        public static Form AccountLookUpForm = new frmAccountLookUp();
        public static Form EnterPinForm = new frmEnterPin();
        public static Form TransactionForm = new frmTransaction();
        public static Form TransactionCompleteForm = new frmTransactionComplete();
    } 

} 

