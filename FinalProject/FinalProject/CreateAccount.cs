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

namespace FinalProject
{
    public partial class createAccountForm : Form
    {
        private StreamWriter fileWriter; // writes data to text file
        protected int TextBoxCount { get; set; } = 7; // number of TextBoxes
        public enum TextBoxIndices { Name, Gender, Age, PhoneNumber,Account,Password,Balance }

        public createAccountForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to save file
            DialogResult result; // result of SaveFileDialog
            string fileName; // name of file containing data
            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // name of file to save data
            }

            // ensure that user clicked "OK"
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
                    // save file via FileStream
                    try
                    {
                        // open file with write access
                        var output = new FileStream(fileName,
                         FileMode.OpenOrCreate, FileAccess.Write);


                        // sets file to where data is written
                        fileWriter = new StreamWriter(output);

                    }
                    catch (IOException)
                    {
                        // notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            // store TextBox values string array
            string[] values = GetTextBoxValues();

            // determine whether TextBox account field is empty
            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.Account]))
            {
                // store TextBox values in Record and output it
                try
                {
                    
                    // get account-number value from TextBox
                    int account =
                    int.Parse(values[(int)TextBoxIndices.Account]);


                    // determine whether accountNumber is valid
                    if (account > 0)
                    {
                        // Record containing TextBox values to output
                        // clientInfo might need var clientInfo = new ClienInfo(account + ...)
                        var clientInfo = new ClientInfo(
                        values[(int)TextBoxIndices.Name],
                        values[(int)TextBoxIndices.Gender],
                        values[(int)TextBoxIndices.Age],
                        values[(int)TextBoxIndices.PhoneNumber],
                        values[(int)TextBoxIndices.Account],
                        values[(int)TextBoxIndices.Password],
                        decimal.Parse(values[(int)TextBoxIndices.Balance]));

                        // write Record to file, fields separated by commas
                        fileWriter.WriteLine(
                         $"{clientInfo.Name},{clientInfo.Gender}," +
                         $"{clientInfo.Age},{clientInfo.PhoneNumber}," +
                         $"{clientInfo.Account},{clientInfo.Password}," +
                         $"{clientInfo.Balance}"
                         );
                    }

                    else
                    {
                        // notify user if invalid account number
                        MessageBox.Show("Invalid Account Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Writing to File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                fileWriter.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearTextBoxes(); // clear TextBox values

        }

        public void SetTextBoxValues(string[] values)
        {
            // determine whether string array has correct length
            if (values.Length != TextBoxCount)
            {
                // throw exception if not correct length
                throw (new ArgumentException(
                $"There must be {TextBoxCount} strings in the array",
                nameof(values)));
            }
            else // set array values if array has correct length
            {
                // set array values to TextBox values
                nameTextBox.Text = values[(int)TextBoxIndices.Name];
                genderComboBox.Text = values[(int)TextBoxIndices.Gender];
                ageTextBox.Text = values[(int)TextBoxIndices.Age];
                phoneNumberTextBox.Text = values[(int)TextBoxIndices.PhoneNumber];
                accountTextBox.Text = values[(int)TextBoxIndices.Account];
                passwordTextBox.Text = values[(int)TextBoxIndices.Password];
                BalanceTextBox.Text = values[(int)TextBoxIndices.Balance];

            }
        }

        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[] {
         nameTextBox.Text,genderComboBox.Text,ageTextBox.Text,
         phoneNumberTextBox.Text,accountTextBox.Text,passwordTextBox.Text,
         BalanceTextBox.Text };
        }

            // clear all TextBoxes
            public void ClearTextBoxes()
        {
            // iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                // if Control is TextBox, clear it
                (guiControl as TextBox)?.Clear();
            }
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
