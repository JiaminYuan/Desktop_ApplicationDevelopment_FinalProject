namespace FinalProject
{
    partial class CurrentClientDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentClientDetailForm));
            this.readNameTextBox = new System.Windows.Forms.TextBox();
            this.readGenderTextBox = new System.Windows.Forms.TextBox();
            this.readAgeTextBox = new System.Windows.Forms.TextBox();
            this.readPhoneTextBox = new System.Windows.Forms.TextBox();
            this.readAccountTextBox = new System.Windows.Forms.TextBox();
            this.readBalanceTextBox = new System.Windows.Forms.TextBox();
            this.readNameLabel = new System.Windows.Forms.Label();
            this.readGenderLabel = new System.Windows.Forms.Label();
            this.readAgeLabel = new System.Windows.Forms.Label();
            this.readPhoneLabel = new System.Windows.Forms.Label();
            this.readAccountLabel = new System.Windows.Forms.Label();
            this.readBalanceLabel = new System.Windows.Forms.Label();
            this.showDetailButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readNameTextBox
            // 
            resources.ApplyResources(this.readNameTextBox, "readNameTextBox");
            this.readNameTextBox.Name = "readNameTextBox";
            this.readNameTextBox.ReadOnly = true;
            // 
            // readGenderTextBox
            // 
            resources.ApplyResources(this.readGenderTextBox, "readGenderTextBox");
            this.readGenderTextBox.Name = "readGenderTextBox";
            this.readGenderTextBox.ReadOnly = true;
            // 
            // readAgeTextBox
            // 
            resources.ApplyResources(this.readAgeTextBox, "readAgeTextBox");
            this.readAgeTextBox.Name = "readAgeTextBox";
            this.readAgeTextBox.ReadOnly = true;
            // 
            // readPhoneTextBox
            // 
            resources.ApplyResources(this.readPhoneTextBox, "readPhoneTextBox");
            this.readPhoneTextBox.Name = "readPhoneTextBox";
            this.readPhoneTextBox.ReadOnly = true;
            // 
            // readAccountTextBox
            // 
            resources.ApplyResources(this.readAccountTextBox, "readAccountTextBox");
            this.readAccountTextBox.Name = "readAccountTextBox";
            this.readAccountTextBox.ReadOnly = true;
            // 
            // readBalanceTextBox
            // 
            resources.ApplyResources(this.readBalanceTextBox, "readBalanceTextBox");
            this.readBalanceTextBox.Name = "readBalanceTextBox";
            this.readBalanceTextBox.ReadOnly = true;
            // 
            // readNameLabel
            // 
            resources.ApplyResources(this.readNameLabel, "readNameLabel");
            this.readNameLabel.Name = "readNameLabel";
            // 
            // readGenderLabel
            // 
            resources.ApplyResources(this.readGenderLabel, "readGenderLabel");
            this.readGenderLabel.Name = "readGenderLabel";
            // 
            // readAgeLabel
            // 
            resources.ApplyResources(this.readAgeLabel, "readAgeLabel");
            this.readAgeLabel.Name = "readAgeLabel";
            // 
            // readPhoneLabel
            // 
            resources.ApplyResources(this.readPhoneLabel, "readPhoneLabel");
            this.readPhoneLabel.Name = "readPhoneLabel";
            // 
            // readAccountLabel
            // 
            resources.ApplyResources(this.readAccountLabel, "readAccountLabel");
            this.readAccountLabel.Name = "readAccountLabel";
            // 
            // readBalanceLabel
            // 
            resources.ApplyResources(this.readBalanceLabel, "readBalanceLabel");
            this.readBalanceLabel.Name = "readBalanceLabel";
            // 
            // showDetailButton
            // 
            resources.ApplyResources(this.showDetailButton, "showDetailButton");
            this.showDetailButton.Name = "showDetailButton";
            this.showDetailButton.UseVisualStyleBackColor = true;
            this.showDetailButton.Click += new System.EventHandler(this.showDetailButton_Click);
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // CurrentClientDetailForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showDetailButton);
            this.Controls.Add(this.readBalanceLabel);
            this.Controls.Add(this.readAccountLabel);
            this.Controls.Add(this.readPhoneLabel);
            this.Controls.Add(this.readAgeLabel);
            this.Controls.Add(this.readGenderLabel);
            this.Controls.Add(this.readNameLabel);
            this.Controls.Add(this.readBalanceTextBox);
            this.Controls.Add(this.readAccountTextBox);
            this.Controls.Add(this.readPhoneTextBox);
            this.Controls.Add(this.readAgeTextBox);
            this.Controls.Add(this.readGenderTextBox);
            this.Controls.Add(this.readNameTextBox);
            this.Name = "CurrentClientDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox readNameTextBox;
        private System.Windows.Forms.TextBox readGenderTextBox;
        private System.Windows.Forms.TextBox readAgeTextBox;
        private System.Windows.Forms.TextBox readPhoneTextBox;
        private System.Windows.Forms.TextBox readAccountTextBox;
        private System.Windows.Forms.TextBox readBalanceTextBox;
        private System.Windows.Forms.Label readNameLabel;
        private System.Windows.Forms.Label readGenderLabel;
        private System.Windows.Forms.Label readAgeLabel;
        private System.Windows.Forms.Label readPhoneLabel;
        private System.Windows.Forms.Label readAccountLabel;
        private System.Windows.Forms.Label readBalanceLabel;
        private System.Windows.Forms.Button showDetailButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}