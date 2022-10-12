namespace Garden_Group.UserControls
{
    partial class UserUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAmountOfTickets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 19);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 15);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "label1";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(216, 19);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(38, 15);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "label1";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(327, 19);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(38, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "label1";
            // 
            // labelAmountOfTickets
            // 
            this.labelAmountOfTickets.AutoSize = true;
            this.labelAmountOfTickets.Location = new System.Drawing.Point(521, 19);
            this.labelAmountOfTickets.Name = "labelAmountOfTickets";
            this.labelAmountOfTickets.Size = new System.Drawing.Size(38, 15);
            this.labelAmountOfTickets.TabIndex = 3;
            this.labelAmountOfTickets.Text = "label1";
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelAmountOfTickets);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEmail);
            this.Name = "UserUC";
            this.Size = new System.Drawing.Size(658, 49);
            this.Click += new System.EventHandler(this.UserUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEmail;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAmountOfTickets;
    }
}
