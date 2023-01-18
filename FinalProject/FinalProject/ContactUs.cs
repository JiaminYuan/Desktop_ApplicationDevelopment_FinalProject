using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class contactUsForm : Form
    {
        public contactUsForm()
        {
            InitializeComponent();
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage("itjiaminyuan@gmail.com", emailTextBox.Text);
            mailMessage.Subject = subjectTextBox.Text;
            mailMessage.Body = messageTextBox.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("itjiaminyuan@gmail.com", "Mimi20141121");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailMessage);
                DialogResult result = MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    emailTextBox.Clear();
                    subjectTextBox.Clear();
                    messageTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
