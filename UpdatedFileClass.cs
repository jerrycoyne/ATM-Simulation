/*Jerald Coyne
 * Last Updated: 10/18/2018
 * Class Number: 4
 * This class is responsible for
 * the updatefile text file
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBank
{
    class updatedFileClass
    {
       
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSR;   
        private int recordWrittenCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public updatedFileClass (string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSR = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }  


        //Adds next record to textfile then adds to records written
        public void putNextRecord (string Record)
        {
            updatedFileSR.WriteLine(Record);
            recordWrittenCount++;
        }

        public void closeFile()
        {
            updatedFileSR.Close();
        } 

        public void rewindFile()
        {
            recordWrittenCount = 0;
            updatedFileSR.Write("");
            updatedFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }

        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        } 

    }

    }

