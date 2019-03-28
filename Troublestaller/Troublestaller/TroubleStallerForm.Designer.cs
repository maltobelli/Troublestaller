namespace Troublestaller
{
    partial class TroubleStallerForm
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
            this.wizardTabControl = new System.Windows.Forms.TabControl();
            this.wizardTabPage = new System.Windows.Forms.TabPage();
            this.welcomeButton = new System.Windows.Forms.Button();
            this.welcomeTitle = new System.Windows.Forms.Label();
            this.eulaTabPage = new System.Windows.Forms.TabPage();
            this.agreeButton = new System.Windows.Forms.Button();
            this.DisagreeButton = new System.Windows.Forms.Button();
            this.eula = new System.Windows.Forms.TextBox();
            this.installingPage = new System.Windows.Forms.TabPage();
            this.installedButton = new System.Windows.Forms.Button();
            this.installingProgress = new System.Windows.Forms.ProgressBar();
            this.installingLabel = new System.Windows.Forms.Label();
            this.wizardTabControl.SuspendLayout();
            this.wizardTabPage.SuspendLayout();
            this.eulaTabPage.SuspendLayout();
            this.installingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardTabControl
            // 
            this.wizardTabControl.Controls.Add(this.wizardTabPage);
            this.wizardTabControl.Controls.Add(this.eulaTabPage);
            this.wizardTabControl.Controls.Add(this.installingPage);
            this.wizardTabControl.ItemSize = new System.Drawing.Size(10, 10);
            this.wizardTabControl.Location = new System.Drawing.Point(12, 12);
            this.wizardTabControl.Name = "wizardTabControl";
            this.wizardTabControl.SelectedIndex = 0;
            this.wizardTabControl.Size = new System.Drawing.Size(790, 400);
            this.wizardTabControl.TabIndex = 0;
            this.wizardTabControl.TabStop = false;
            // 
            // wizardTabPage
            // 
            this.wizardTabPage.Controls.Add(this.welcomeButton);
            this.wizardTabPage.Controls.Add(this.welcomeTitle);
            this.wizardTabPage.Location = new System.Drawing.Point(4, 14);
            this.wizardTabPage.Name = "wizardTabPage";
            this.wizardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wizardTabPage.Size = new System.Drawing.Size(782, 382);
            this.wizardTabPage.TabIndex = 0;
            this.wizardTabPage.Text = "Welcome";
            this.wizardTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeButton
            // 
            this.welcomeButton.Location = new System.Drawing.Point(291, 199);
            this.welcomeButton.Name = "welcomeButton";
            this.welcomeButton.Size = new System.Drawing.Size(75, 23);
            this.welcomeButton.TabIndex = 1;
            this.welcomeButton.Text = "Continue";
            this.welcomeButton.UseVisualStyleBackColor = true;
            this.welcomeButton.Click += new System.EventHandler(this.WelcomeButton_Click);
            // 
            // welcomeTitle
            // 
            this.welcomeTitle.AutoSize = true;
            this.welcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTitle.Location = new System.Drawing.Point(191, 19);
            this.welcomeTitle.Name = "welcomeTitle";
            this.welcomeTitle.Size = new System.Drawing.Size(266, 25);
            this.welcomeTitle.TabIndex = 0;
            this.welcomeTitle.Text = "Welcome to the Installer";
            // 
            // eulaTabPage
            // 
            this.eulaTabPage.Controls.Add(this.agreeButton);
            this.eulaTabPage.Controls.Add(this.DisagreeButton);
            this.eulaTabPage.Controls.Add(this.eula);
            this.eulaTabPage.Location = new System.Drawing.Point(4, 14);
            this.eulaTabPage.Name = "eulaTabPage";
            this.eulaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eulaTabPage.Size = new System.Drawing.Size(782, 382);
            this.eulaTabPage.TabIndex = 1;
            this.eulaTabPage.Text = "EULA";
            this.eulaTabPage.UseVisualStyleBackColor = true;
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(474, 330);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(128, 37);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Agree and Install";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // DisagreeButton
            // 
            this.DisagreeButton.Location = new System.Drawing.Point(137, 337);
            this.DisagreeButton.Name = "DisagreeButton";
            this.DisagreeButton.Size = new System.Drawing.Size(75, 23);
            this.DisagreeButton.TabIndex = 1;
            this.DisagreeButton.Text = "Disagree";
            this.DisagreeButton.UseVisualStyleBackColor = true;
            this.DisagreeButton.Click += new System.EventHandler(this.DisagreeButton_Click);
            // 
            // eula
            // 
            this.eula.Enabled = false;
            this.eula.Location = new System.Drawing.Point(6, 6);
            this.eula.Multiline = true;
            this.eula.Name = "eula";
            this.eula.Size = new System.Drawing.Size(766, 318);
            this.eula.TabIndex = 0;
            this.eula.Text = "By Agreeing to this agreement you agree to only use this program for the purposes" +
    " of testing and \r\nnot to hold it\'s creator or anyone else accountable for it\'s a" +
    "ctions.";
            // 
            // installingPage
            // 
            this.installingPage.Controls.Add(this.installedButton);
            this.installingPage.Controls.Add(this.installingProgress);
            this.installingPage.Controls.Add(this.installingLabel);
            this.installingPage.Location = new System.Drawing.Point(4, 14);
            this.installingPage.Name = "installingPage";
            this.installingPage.Padding = new System.Windows.Forms.Padding(3);
            this.installingPage.Size = new System.Drawing.Size(782, 382);
            this.installingPage.TabIndex = 2;
            this.installingPage.Text = "Installing";
            this.installingPage.UseVisualStyleBackColor = true;
            this.installingPage.Enter += new System.EventHandler(this.InstallingPage_Enter);
            // 
            // installedButton
            // 
            this.installedButton.Location = new System.Drawing.Point(653, 331);
            this.installedButton.Name = "installedButton";
            this.installedButton.Size = new System.Drawing.Size(75, 23);
            this.installedButton.TabIndex = 2;
            this.installedButton.Text = "Close";
            this.installedButton.UseVisualStyleBackColor = true;
            this.installedButton.Visible = false;
            this.installedButton.Click += new System.EventHandler(this.installedButton_Click);
            // 
            // installingProgress
            // 
            this.installingProgress.Location = new System.Drawing.Point(45, 180);
            this.installingProgress.Name = "installingProgress";
            this.installingProgress.Size = new System.Drawing.Size(671, 23);
            this.installingProgress.TabIndex = 1;
            // 
            // installingLabel
            // 
            this.installingLabel.AutoSize = true;
            this.installingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installingLabel.Location = new System.Drawing.Point(293, 74);
            this.installingLabel.Name = "installingLabel";
            this.installingLabel.Size = new System.Drawing.Size(107, 25);
            this.installingLabel.TabIndex = 0;
            this.installingLabel.Text = "Installing";
            // 
            // TroubleStallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wizardTabControl);
            this.Name = "TroubleStallerForm";
            this.Text = "Installer - Powered By Troublestaller";
            this.Load += new System.EventHandler(this.TroubleStallerForm_Load);
            this.wizardTabControl.ResumeLayout(false);
            this.wizardTabPage.ResumeLayout(false);
            this.wizardTabPage.PerformLayout();
            this.eulaTabPage.ResumeLayout(false);
            this.eulaTabPage.PerformLayout();
            this.installingPage.ResumeLayout(false);
            this.installingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl wizardTabControl;
        private System.Windows.Forms.TabPage wizardTabPage;
        private System.Windows.Forms.TabPage eulaTabPage;
        private System.Windows.Forms.Button welcomeButton;
        private System.Windows.Forms.Label welcomeTitle;
        private System.Windows.Forms.TextBox eula;
        private System.Windows.Forms.TabPage installingPage;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.Button DisagreeButton;
        private System.Windows.Forms.Label installingLabel;
        private System.Windows.Forms.ProgressBar installingProgress;
        private System.Windows.Forms.Button installedButton;
    }
}

