namespace FinalProject
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            this.depositBalanceLabel = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dBalanceDepositTextBox = new System.Windows.Forms.TextBox();
            this.dCurrentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.depositBalanceButton = new System.Windows.Forms.Button();
            this.showBalanceButton = new System.Windows.Forms.Button();
            this.balanceAddedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depositBalanceLabel
            // 
            resources.ApplyResources(this.depositBalanceLabel, "depositBalanceLabel");
            this.depositBalanceLabel.Name = "depositBalanceLabel";
            // 
            // currentBalanceLabel
            // 
            resources.ApplyResources(this.currentBalanceLabel, "currentBalanceLabel");
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dBalanceDepositTextBox
            // 
            resources.ApplyResources(this.dBalanceDepositTextBox, "dBalanceDepositTextBox");
            this.dBalanceDepositTextBox.Name = "dBalanceDepositTextBox";
            // 
            // dCurrentBalanceTextBox
            // 
            resources.ApplyResources(this.dCurrentBalanceTextBox, "dCurrentBalanceTextBox");
            this.dCurrentBalanceTextBox.Name = "dCurrentBalanceTextBox";
            this.dCurrentBalanceTextBox.ReadOnly = true;
            // 
            // depositBalanceButton
            // 
            resources.ApplyResources(this.depositBalanceButton, "depositBalanceButton");
            this.depositBalanceButton.Name = "depositBalanceButton";
            this.depositBalanceButton.UseVisualStyleBackColor = true;
            this.depositBalanceButton.Click += new System.EventHandler(this.depositBalanceButton_Click);
            // 
            // showBalanceButton
            // 
            resources.ApplyResources(this.showBalanceButton, "showBalanceButton");
            this.showBalanceButton.Name = "showBalanceButton";
            this.showBalanceButton.UseVisualStyleBackColor = true;
            this.showBalanceButton.Click += new System.EventHandler(this.showBalanceButton_Click);
            // 
            // balanceAddedTextBox
            // 
            resources.ApplyResources(this.balanceAddedTextBox, "balanceAddedTextBox");
            this.balanceAddedTextBox.Name = "balanceAddedTextBox";
            this.balanceAddedTextBox.ReadOnly = true;
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
            // DepositForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceAddedTextBox);
            this.Controls.Add(this.depositBalanceLabel);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dBalanceDepositTextBox);
            this.Controls.Add(this.dCurrentBalanceTextBox);
            this.Controls.Add(this.depositBalanceButton);
            this.Controls.Add(this.showBalanceButton);
            this.Name = "DepositForm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositBalanceLabel;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox dBalanceDepositTextBox;
        private System.Windows.Forms.TextBox dCurrentBalanceTextBox;
        private System.Windows.Forms.Button depositBalanceButton;
        private System.Windows.Forms.Button showBalanceButton;
        private System.Windows.Forms.TextBox balanceAddedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}