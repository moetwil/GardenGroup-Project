namespace Garden_Group.UserControls
{
    partial class TicketUC
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTicketDateStart = new System.Windows.Forms.Label();
            this.labelPriorityLevel = new System.Windows.Forms.Label();
            this.labelTicketState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(33, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(29, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.Click += new System.EventHandler(this.TicketUC_Click);
            // 
            // labelTicketDateStart
            // 
            this.labelTicketDateStart.AutoSize = true;
            this.labelTicketDateStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTicketDateStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketDateStart.Location = new System.Drawing.Point(309, 18);
            this.labelTicketDateStart.Name = "labelTicketDateStart";
            this.labelTicketDateStart.Size = new System.Drawing.Size(35, 15);
            this.labelTicketDateStart.TabIndex = 2;
            this.labelTicketDateStart.Text = "sdate";
            this.labelTicketDateStart.Click += new System.EventHandler(this.TicketUC_Click);
            // 
            // labelPriorityLevel
            // 
            this.labelPriorityLevel.AutoSize = true;
            this.labelPriorityLevel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriorityLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriorityLevel.Location = new System.Drawing.Point(420, 18);
            this.labelPriorityLevel.Name = "labelPriorityLevel";
            this.labelPriorityLevel.Size = new System.Drawing.Size(43, 15);
            this.labelPriorityLevel.TabIndex = 4;
            this.labelPriorityLevel.Text = "P-level";
            this.labelPriorityLevel.Click += new System.EventHandler(this.TicketUC_Click);
            // 
            // labelTicketState
            // 
            this.labelTicketState.AutoSize = true;
            this.labelTicketState.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTicketState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketState.Location = new System.Drawing.Point(530, 18);
            this.labelTicketState.Name = "labelTicketState";
            this.labelTicketState.Size = new System.Drawing.Size(69, 15);
            this.labelTicketState.TabIndex = 8;
            this.labelTicketState.Text = "Ticket state:";
            this.labelTicketState.Click += new System.EventHandler(this.TicketUC_Click);
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTicketState);
            this.Controls.Add(this.labelPriorityLevel);
            this.Controls.Add(this.labelTicketDateStart);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(658, 50);
            this.Click += new System.EventHandler(this.TicketUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Label labelTicketDateStart;
        private Label labelPriorityLevel;
        private Label labelTicketState;
    }
}
