using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class adminMainForm : Form
    {
        private FileStream input;
        private StreamReader fileReader;
        public adminMainForm()
        {
            InitializeComponent();
        }
        private void openButton_Click(object sender, EventArgs e)
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
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    fileReader = new StreamReader(input);
                    openButton.Enabled = false;
                    creditButton.Enabled = true;
                    debitButton.Enabled = true;
                    zeroButton.Enabled = true;
                }
            }
        }

        private bool ShouldDisplay(decimal balance, string accountType)
        {
            if (balance > 0M && accountType == "Credit Balances")
            {
                return true; // should display credit balances
            }
            else if (balance < 0M && accountType == "Debit Balances")
            {
                return true; // should display debit balances
            }
            else if (balance == 0 && accountType == "Zero Balances")
            {
                return true; // should display zero balances
            }

            return false;
        }

        private void getBalance_Click(object sender, EventArgs e)
        {
            // convert sender explicitly to object of type button
            Button senderButton = (Button)sender;

            // get text from clicked Button, which stores account type
            string accountType = senderButton.Text;

            // read and display file information
            try
            {
                // go back to the beginning of the file
                input.Seek(0, SeekOrigin.Begin);


                displayTextBox.Text = $"Accounts with {accountType}{Environment.NewLine}";

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
                    var record =
                    new ClientInfo(inputFields[0], inputFields[1],
                    inputFields[2], inputFields[3], inputFields[4],
                    inputFields[5], decimal.Parse(inputFields[6]));

                    displayTextBox.Text = $"Name:\t" +"Gender:\t"+ "Age:\t" + "Phone number:\t" +
                        "Acc.:\t" + "Pass.:\t" + "Balance:\t \r\n";

                    // determine whether to display balance
                    if (ShouldDisplay(record.Balance, accountType))
                    {// display record
                        displayTextBox.AppendText($"{record.Name}\t" +
                         $"{record.Gender}\t{record.Age}\t" +
                         $"{record.PhoneNumber}\t{record.Account}\t" +
                         $"{record.Password}\t{record.Balance:C}");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Read File", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void doneButton_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
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

