namespace Garden_Group.Forms
{
    partial class ResetPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendEmailTextBox = new System.Windows.Forms.TextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.ReactionLabel = new System.Windows.Forms.Label();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.SendCodePanel = new System.Windows.Forms.Panel();
            this.ChangePasswordPanel = new System.Windows.Forms.Panel();
            this.ReactionLabelPasswordChange = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondPasswordBox = new System.Windows.Forms.TextBox();
            this.FirstPasswordBox = new System.Windows.Forms.TextBox();
            this.InsertCodePanel = new System.Windows.Forms.Panel();
            this.ReactionLabelCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeCheckBox = new System.Windows.Forms.TextBox();
            this.CheckCodeButton = new System.Windows.Forms.Button();
            this.SendCodePanel.SuspendLayout();
            this.ChangePasswordPanel.SuspendLayout();
            this.InsertCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(482, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wachtwoord vergeten?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vul hieronder uw email adres in.";
            // 
            // SendEmailTextBox
            // 
            this.SendEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendEmailTextBox.Location = new System.Drawing.Point(20, 132);
            this.SendEmailTextBox.Name = "SendEmailTextBox";
            this.SendEmailTextBox.Size = new System.Drawing.Size(221, 33);
            this.SendEmailTextBox.TabIndex = 2;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendEmailButton.Location = new System.Drawing.Point(20, 200);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(132, 41);
            this.SendEmailButton.TabIndex = 3;
            this.SendEmailButton.Text = "Stuur code";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // ReactionLabel
            // 
            this.ReactionLabel.AutoSize = true;
            this.ReactionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReactionLabel.ForeColor = System.Drawing.Color.Black;
            this.ReactionLabel.Location = new System.Drawing.Point(20, 172);
            this.ReactionLabel.Name = "ReactionLabel";
            this.ReactionLabel.Size = new System.Drawing.Size(0, 25);
            this.ReactionLabel.TabIndex = 4;
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToLogin.Location = new System.Drawing.Point(34, 26);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(150, 39);
            this.buttonBackToLogin.TabIndex = 5;
            this.buttonBackToLogin.Text = "Back to login";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // SendCodePanel
            // 
            this.SendCodePanel.Controls.Add(this.label2);
            this.SendCodePanel.Controls.Add(this.SendEmailTextBox);
            this.SendCodePanel.Controls.Add(this.SendEmailButton);
            this.SendCodePanel.Controls.Add(this.ReactionLabel);
            this.SendCodePanel.Location = new System.Drawing.Point(482, 275);
            this.SendCodePanel.Name = "SendCodePanel";
            this.SendCodePanel.Size = new System.Drawing.Size(388, 351);
            this.SendCodePanel.TabIndex = 6;
            // 
            // ChangePasswordPanel
            // 
            this.ChangePasswordPanel.Controls.Add(this.ReactionLabelPasswordChange);
            this.ChangePasswordPanel.Controls.Add(this.ChangePasswordButton);
            this.ChangePasswordPanel.Controls.Add(this.label4);
            this.ChangePasswordPanel.Controls.Add(this.SecondPasswordBox);
            this.ChangePasswordPanel.Controls.Add(this.FirstPasswordBox);
            this.ChangePasswordPanel.Location = new System.Drawing.Point(482, 275);
            this.ChangePasswordPanel.Name = "ChangePasswordPanel";
            this.ChangePasswordPanel.Size = new System.Drawing.Size(388, 351);
            this.ChangePasswordPanel.TabIndex = 7;
            // 
            // ReactionLabelPasswordChange
            // 
            this.ReactionLabelPasswordChange.AutoSize = true;
            this.ReactionLabelPasswordChange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReactionLabelPasswordChange.Location = new System.Drawing.Point(24, 244);
            this.ReactionLabelPasswordChange.Name = "ReactionLabelPasswordChange";
            this.ReactionLabelPasswordChange.Size = new System.Drawing.Size(0, 25);
            this.ReactionLabelPasswordChange.TabIndex = 7;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordButton.Location = new System.Drawing.Point(24, 275);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(173, 41);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vul hieronder uw nieuwe wachtoord in.";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordBox.Location = new System.Drawing.Point(24, 208);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.Size = new System.Drawing.Size(221, 33);
            this.SecondPasswordBox.TabIndex = 6;
            // 
            // FirstPasswordBox
            // 
            this.FirstPasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPasswordBox.Location = new System.Drawing.Point(24, 132);
            this.FirstPasswordBox.Name = "FirstPasswordBox";
            this.FirstPasswordBox.Size = new System.Drawing.Size(221, 33);
            this.FirstPasswordBox.TabIndex = 5;
            // 
            // InsertCodePanel
            // 
            this.InsertCodePanel.Controls.Add(this.ReactionLabelCode);
            this.InsertCodePanel.Controls.Add(this.label3);
            this.InsertCodePanel.Controls.Add(this.CodeCheckBox);
            this.InsertCodePanel.Controls.Add(this.CheckCodeButton);
            this.InsertCodePanel.Location = new System.Drawing.Point(482, 275);
            this.InsertCodePanel.Name = "InsertCodePanel";
            this.InsertCodePanel.Size = new System.Drawing.Size(388, 351);
            this.InsertCodePanel.TabIndex = 8;
            // 
            // ReactionLabelCode
            // 
            this.ReactionLabelCode.AutoSize = true;
            this.ReactionLabelCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReactionLabelCode.Location = new System.Drawing.Point(19, 168);
            this.ReactionLabelCode.Name = "ReactionLabelCode";
            this.ReactionLabelCode.Size = new System.Drawing.Size(0, 25);
            this.ReactionLabelCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vul hieronder de meegegeven code in.";
            // 
            // CodeCheckBox
            // 
            this.CodeCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeCheckBox.Location = new System.Drawing.Point(19, 132);
            this.CodeCheckBox.Name = "CodeCheckBox";
            this.CodeCheckBox.Size = new System.Drawing.Size(221, 33);
            this.CodeCheckBox.TabIndex = 4;
            // 
            // CheckCodeButton
            // 
            this.CheckCodeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCodeButton.Location = new System.Drawing.Point(19, 200);
            this.CheckCodeButton.Name = "CheckCodeButton";
            this.CheckCodeButton.Size = new System.Drawing.Size(132, 41);
            this.CheckCodeButton.TabIndex = 4;
            this.CheckCodeButton.Text = "Check code";
            this.CheckCodeButton.UseVisualStyleBackColor = true;
            this.CheckCodeButton.Click += new System.EventHandler(this.CheckCodeButton_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendCodePanel);
            this.Controls.Add(this.ChangePasswordPanel);
            this.Controls.Add(this.InsertCodePanel);
            this.Controls.Add(this.buttonBackToLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResetPasswordForm";
            this.SendCodePanel.ResumeLayout(false);
            this.SendCodePanel.PerformLayout();
            this.ChangePasswordPanel.ResumeLayout(false);
            this.ChangePasswordPanel.PerformLayout();
            this.InsertCodePanel.ResumeLayout(false);
            this.InsertCodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SendEmailTextBox;
        private Button SendEmailButton;
        private Label ReactionLabel;
        private Button buttonBackToLogin;
        private Panel SendCodePanel;
        private Panel ChangePasswordPanel;
        private Panel InsertCodePanel;
        private Label label3;
        private TextBox CodeCheckBox;
        private Button CheckCodeButton;
        private Button ChangePasswordButton;
        private Label label4;
        private TextBox SecondPasswordBox;
        private TextBox FirstPasswordBox;
        private Label ReactionLabelPasswordChange;
        private Label ReactionLabelCode;
    }
}