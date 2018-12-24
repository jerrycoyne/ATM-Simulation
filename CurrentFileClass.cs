/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 3
 * This class is responsible for
 * the current file text file
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMBank
{
    public class currentFileClass
    {
        private string currentFilePath;
        private System.IO.StreamReader currentFileSR;  
        private int recordReadCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public currentFileClass
            (string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + currentFilePath + "Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        } 

        // Read a record from the current file
        public string getNextRecord(
            ref Boolean endOfFileFlag)
        {
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            } 
            return (nextRecord);
        } 

        // Get value of number of records read
        public int getRecordsReadCount()
        {
            return recordReadCount;
        } 

        // Close the input file
        public void closeFile()
        {
            currentFileSR.Close();
        } 

        // Rewind the input file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } 
    } 
} 

