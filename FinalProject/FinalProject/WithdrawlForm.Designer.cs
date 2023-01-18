namespace FinalProject
{
    partial class WithdrawlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawlForm));
            this.showBalanceButton = new System.Windows.Forms.Button();
            this.withdrawBalanceButton = new System.Windows.Forms.Button();
            this.wCurrentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.wBalanceWithdrawTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BalanceRemoveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showBalanceButton
            // 
            resources.ApplyResources(this.showBalanceButton, "showBalanceButton");
            this.showBalanceButton.Name = "showBalanceButton";
            this.showBalanceButton.UseVisualStyleBackColor = true;
            this.showBalanceButton.Click += new System.EventHandler(this.showBalanceButton_Click);
            // 
            // withdrawBalanceButton
            // 
            resources.ApplyResources(this.withdrawBalanceButton, "withdrawBalanceButton");
            this.withdrawBalanceButton.Name = "withdrawBalanceButton";
            this.withdrawBalanceButton.UseVisualStyleBackColor = true;
            this.withdrawBalanceButton.Click += new System.EventHandler(this.withdrawBalanceButton_Click);
            // 
            // wCurrentBalanceTextBox
            // 
            resources.ApplyResources(this.wCurrentBalanceTextBox, "wCurrentBalanceTextBox");
            this.wCurrentBalanceTextBox.Name = "wCurrentBalanceTextBox";
            this.wCurrentBalanceTextBox.ReadOnly = true;
            // 
            // wBalanceWithdrawTextBox
            // 
            resources.ApplyResources(this.wBalanceWithdrawTextBox, "wBalanceWithdrawTextBox");
            this.wBalanceWithdrawTextBox.Name = "wBalanceWithdrawTextBox";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // currentBalanceLabel
            // 
            resources.ApplyResources(this.currentBalanceLabel, "currentBalanceLabel");
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BalanceRemoveTextBox
            // 
            resources.ApplyResources(this.BalanceRemoveTextBox, "BalanceRemoveTextBox");
            this.BalanceRemoveTextBox.Name = "BalanceRemoveTextBox";
            this.BalanceRemoveTextBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // WithdrawlForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalanceRemoveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wBalanceWithdrawTextBox);
            this.Controls.Add(this.wCurrentBalanceTextBox);
            this.Controls.Add(this.withdrawBalanceButton);
            this.Controls.Add(this.showBalanceButton);
            this.Name = "WithdrawlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBalanceButton;
        private System.Windows.Forms.Button withdrawBalanceButton;
        private System.Windows.Forms.TextBox wCurrentBalanceTextBox;
        private System.Windows.Forms.TextBox wBalanceWithdrawTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BalanceRemoveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}