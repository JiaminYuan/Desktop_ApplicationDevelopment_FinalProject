namespace FinalProject
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.withdrawlButton = new System.Windows.Forms.Button();
            this.accountDetailButton = new System.Windows.Forms.Button();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.depositeButton = new System.Windows.Forms.Button();
            this.contactUsButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // withdrawlButton
            // 
            resources.ApplyResources(this.withdrawlButton, "withdrawlButton");
            this.withdrawlButton.Name = "withdrawlButton";
            this.withdrawlButton.UseVisualStyleBackColor = true;
            this.withdrawlButton.Click += new System.EventHandler(this.withdrawlButton_Click);
            // 
            // accountDetailButton
            // 
            resources.ApplyResources(this.accountDetailButton, "accountDetailButton");
            this.accountDetailButton.Name = "accountDetailButton";
            this.accountDetailButton.UseVisualStyleBackColor = true;
            this.accountDetailButton.Click += new System.EventHandler(this.accountDetailButton_Click);
            // 
            // aboutUsButton
            // 
            resources.ApplyResources(this.aboutUsButton, "aboutUsButton");
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.UseVisualStyleBackColor = true;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // depositeButton
            // 
            resources.ApplyResources(this.depositeButton, "depositeButton");
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // contactUsButton
            // 
            resources.ApplyResources(this.contactUsButton, "contactUsButton");
            this.contactUsButton.Name = "contactUsButton";
            this.contactUsButton.UseVisualStyleBackColor = true;
            this.contactUsButton.Click += new System.EventHandler(this.contactUsButton_Click);
            // 
            // createAccountButton
            // 
            resources.ApplyResources(this.createAccountButton, "createAccountButton");
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.LaptopMainClient_Money;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.contactUsButton);
            this.Controls.Add(this.depositeButton);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.accountDetailButton);
            this.Controls.Add(this.withdrawlButton);
            this.Controls.Add(this.timeLabel);
            this.Name = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button withdrawlButton;
        private System.Windows.Forms.Button accountDetailButton;
        private System.Windows.Forms.Button aboutUsButton;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.Button contactUsButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}