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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(537, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your email address or username";
            // 
            // SendEmailTextBox
            // 
            this.SendEmailTextBox.Location = new System.Drawing.Point(532, 281);
            this.SendEmailTextBox.Name = "SendEmailTextBox";
            this.SendEmailTextBox.Size = new System.Drawing.Size(221, 23);
            this.SendEmailTextBox.TabIndex = 2;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(570, 333);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(132, 41);
            this.SendEmailButton.TabIndex = 3;
            this.SendEmailButton.Text = "Send email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // ReactionLabel
            // 
            this.ReactionLabel.AutoSize = true;
            this.ReactionLabel.ForeColor = System.Drawing.Color.Black;
            this.ReactionLabel.Location = new System.Drawing.Point(532, 307);
            this.ReactionLabel.Name = "ReactionLabel";
            this.ReactionLabel.Size = new System.Drawing.Size(0, 15);
            this.ReactionLabel.TabIndex = 4;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ReactionLabel);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.SendEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SendEmailTextBox;
        private Button SendEmailButton;
        private Label ReactionLabel;
    }
}