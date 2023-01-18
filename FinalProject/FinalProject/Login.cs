using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.GetItemText(userComboBox.SelectedItem) == "Admin")
            {
                if (passwordTextBox.Text == "Password" && captchaTextBox.Text == captchaLabel.Text)
                {
                    adminMainForm newForm = new adminMainForm();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    if (passwordTextBox.Text != "Password")
                    {
                        MessageBox.Show("Password is incorrect, please try again!");
                        this.OnLoad(e);
                    }
                    else if (captchaTextBox.Text != captchaLabel.Text)
                    {
                        MessageBox.Show("Captcha is incorrect, please try again!");
                        this.OnLoad(e);
                    }
                    else {
                        MessageBox.Show("Both Password and Captcha is incorrect, please try again!");
                        this.OnLoad(e);
                    }
                   
                }
            }
            else if(userComboBox.GetItemText(userComboBox.SelectedItem) == "Client")
            {
                if (passwordTextBox.Text == "Password2" && captchaTextBox.Text == captchaLabel.Text)
                {
                    mainForm newForm = new mainForm();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    if (passwordTextBox.Text != "Password2")
                    {
                        MessageBox.Show("Password is incorrect, please try again!");
                        this.OnLoad(e);
                    }
                    else if (captchaTextBox.Text != captchaLabel.Text)
                    {
                        MessageBox.Show("Captcha is incorrect, please try again!");
                        this.OnLoad(e);
                    }
                    else
                    {
                        MessageBox.Show("Both Password and Captcha are incorrect, please try again!");
                        this.OnLoad(e);
                    }

                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = random.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num) { break; }
                }
            } while (true);
            captchaLabel.Text = captcha;
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1: changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2: changeLanguage.UpdateConfig("language", "es-US");
                    Application.Restart();
                    break;
            }
        }
    }
}
