/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 1
 * This class is the controll class
 * for the ATM program
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMBank
{
    public class ATMBankClass
    {
        // Bank files variables
        private static string currentFilePath = "currentFile.txt";
        private static string updatedFilePath = "updatedFile.txt";

        private currentFileClass currentFile = new currentFileClass(currentFilePath);
        private updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Account number length validation index
        private int hiddenAccountLength = 5;
        public Boolean getAccountLength(int checkNum)
        {
            if (hiddenAccountLength == checkNum)
            {
                return true;
            }
            else return false;
        }

        // Constructor for the ATM Bank Class 
        public ATMBankClass()
        {

        }

        // Number of login attempts allowed before terminating session
        private int hiddenTryCountMax = 3;

        // Maximum withdrawal amount bank allows per day
        private int hiddenWDAmount = 500;
        public Boolean checkwdamount(int checkNum)
        {
            if (hiddenWDAmount > checkNum)
            {
                return false;
            }
            else return true;
           
        }//Checks to see if the withdraw amount is ok
        public int getWithdrawAmount()
        {
            return hiddenWDAmount;

        }

        public Boolean getTries(int checkNum)
        {
            if (hiddenTryCountMax == checkNum)
            {
                return true;
            }
            else return false;
        }
            
        // Find customer record given the entered account
        public string findCustomerRecord(string account, ref Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (GlobalData.customer.customerMatch(account, nextRecord))
                {
                    found = true;
                    return (nextRecord);
                }
                else
                {
                    updatedFile.putNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                } 
            } 

            return (nextRecord);
        } 


        // Writes a single record (such as a modified record) to the updated file
        public void writeOut(string record)
        {
            updatedFile.putNextRecord(record);
        }  


        // Copies remaining records from currentFile to updatedFile.
        public void CopyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.putNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            } 
        } 

        public void rewindFiles()
        {
            currentFile.rewindFile();
            updatedFile.rewindFile();
        }  


        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }  

    } 

} 

