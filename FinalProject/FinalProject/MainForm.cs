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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            (new createAccountForm()).ShowDialog();
            this.Show();
        }

        private void withdrawlButton_Click(object sender, EventArgs e)
        {
            (new WithdrawlForm()).ShowDialog();
            this.Show();
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            (new DepositForm()).ShowDialog();
            this.Show();
        }

        private void accountDetailButton_Click(object sender, EventArgs e)
        {
            (new CurrentClientDetailForm()).ShowDialog();
            this.Show();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            (new aboutUsForm()).ShowDialog();
            this.Show();
        }

        private void contactUsButton_Click(object sender, EventArgs e)
        {
            (new contactUsForm()).ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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
