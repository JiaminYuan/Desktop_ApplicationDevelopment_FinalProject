using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FinalProject;

namespace FinalProject
{
    public partial class WithdrawlForm : Form
    {
        private FileStream input; // maintains the connection to the file
        private StreamReader fileReader; // reads data from text file 
        decimal temp;
        decimal amountToWithdraw;
        


        public WithdrawlForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // close file and StreamReader
            try
            {
                fileReader?.Close(); // close StreamReader and underlying file
            }
            catch (IOException)
            {
                // notify user of error closing file
                MessageBox.Show("Cannot close file", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBalanceButton_Click(object sender, EventArgs e)
        {
            // create dialog box enabling user to open file
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // exit event handler if user clicked Cancel
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // create FileStream to obtain read access to file
                    input = new FileStream(fileName,
                    FileMode.Open, FileAccess.Read);

                    // set file from where data is read
                    fileReader = new StreamReader(input);
                    //Enable withdraw button Except Show Balance button
                    showBalanceButton.Enabled = false;
                    withdrawBalanceButton.Enabled = true;
                }
            }
                // convert sender explicitly to object of type button
                //Button senderButton = (Button)sender;

                // get text from clicked Button, which stores account type
                //string accountType = senderButton.Text;
                //from this fella right here ^

                // read and display file information
                try
                {
                    // go back to the beginning of the file
                    input.Seek(0, SeekOrigin.Begin);

                    //button will display current balance the button name
                    //wCurrentBalanceTextBox.Text = $" {accountType}{Environment.NewLine} ";

                    // traverse file until end of file
                    while (true)
                    {
                        // get next Record available in file
                        string inputRecord = fileReader.ReadLine();

                        // when at the end of file, exit method
                        if (inputRecord == null)
                        {
                            return;
                        }

                        // parse input
                        string[] inputFields = inputRecord.Split(',');

                        // create Record from input
                        var client =
                        new ClientInfo(inputFields[0], inputFields[1], inputFields[2], inputFields[3], inputFields[4], inputFields[5], decimal.Parse(inputFields[6]));

                        // determine whether to display balance
                        if (ShouldDisplay(client.Balance))
                        {
                            // display record
                            wCurrentBalanceTextBox.AppendText($"{client.Balance:C}");
                        temp = client.Balance;

                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot Read File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public bool ShouldDisplay(decimal balance)
        {
            if (balance > 0M)
            {
                return true;
            }
            else if (balance < 0M)
            {
                MessageBox.Show("Cannot receive negative number on a newly account", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(balance == 0M)
            {
                return true;
            }
            return false;
        }
        

                private void withdrawBalanceButton_Click(object sender, EventArgs e)
        {
            amountToWithdraw = decimal.Parse(wBalanceWithdrawTextBox.Text);
                temp -= amountToWithdraw;
            BalanceRemoveTextBox.Text = temp.ToString();


        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "es-US");
                    Application.Restart();
                    break;
            }
        }
    }
}
