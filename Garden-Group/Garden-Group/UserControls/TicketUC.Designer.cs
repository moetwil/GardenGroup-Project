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
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTicketDateStart = new System.Windows.Forms.Label();
            this.labelTicketDateEnd = new System.Windows.Forms.Label();
            this.labelPriorityLevel = new System.Windows.Forms.Label();
            this.labelTextSdate = new System.Windows.Forms.Label();
            this.labelTextEdate = new System.Windows.Forms.Label();
            this.panelTicketState = new System.Windows.Forms.Panel();
            this.labelTicketState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(59, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(44, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDescription.Location = new System.Drawing.Point(59, 27);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(187, 40);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelTicketDateStart
            // 
            this.labelTicketDateStart.AutoSize = true;
            this.labelTicketDateStart.Location = new System.Drawing.Point(338, 37);
            this.labelTicketDateStart.Name = "labelTicketDateStart";
            this.labelTicketDateStart.Size = new System.Drawing.Size(35, 15);
            this.labelTicketDateStart.TabIndex = 2;
            this.labelTicketDateStart.Text = "sdate";
            // 
            // labelTicketDateEnd
            // 
            this.labelTicketDateEnd.AutoSize = true;
            this.labelTicketDateEnd.Location = new System.Drawing.Point(338, 52);
            this.labelTicketDateEnd.Name = "labelTicketDateEnd";
            this.labelTicketDateEnd.Size = new System.Drawing.Size(36, 15);
            this.labelTicketDateEnd.TabIndex = 3;
            this.labelTicketDateEnd.Text = "edate";
            // 
            // labelPriorityLevel
            // 
            this.labelPriorityLevel.AutoSize = true;
            this.labelPriorityLevel.Location = new System.Drawing.Point(171, 5);
            this.labelPriorityLevel.Name = "labelPriorityLevel";
            this.labelPriorityLevel.Size = new System.Drawing.Size(43, 15);
            this.labelPriorityLevel.TabIndex = 4;
            this.labelPriorityLevel.Text = "P-level";
            // 
            // labelTextSdate
            // 
            this.labelTextSdate.AutoSize = true;
            this.labelTextSdate.Location = new System.Drawing.Point(247, 37);
            this.labelTextSdate.Name = "labelTextSdate";
            this.labelTextSdate.Size = new System.Drawing.Size(72, 15);
            this.labelTextSdate.TabIndex = 5;
            this.labelTextSdate.Text = "Start datum:";
            // 
            // labelTextEdate
            // 
            this.labelTextEdate.AutoSize = true;
            this.labelTextEdate.Location = new System.Drawing.Point(247, 52);
            this.labelTextEdate.Name = "labelTextEdate";
            this.labelTextEdate.Size = new System.Drawing.Size(93, 15);
            this.labelTextEdate.TabIndex = 6;
            this.labelTextEdate.Text = "Sluitings datum:";
            // 
            // panelTicketState
            // 
            this.panelTicketState.Location = new System.Drawing.Point(3, 5);
            this.panelTicketState.MaximumSize = new System.Drawing.Size(50, 58);
            this.panelTicketState.Name = "panelTicketState";
            this.panelTicketState.Size = new System.Drawing.Size(50, 58);
            this.panelTicketState.TabIndex = 7;
            // 
            // labelTicketState
            // 
            this.labelTicketState.AutoSize = true;
            this.labelTicketState.Location = new System.Drawing.Point(247, 5);
            this.labelTicketState.Name = "labelTicketState";
            this.labelTicketState.Size = new System.Drawing.Size(69, 15);
            this.labelTicketState.TabIndex = 8;
            this.labelTicketState.Text = "Ticket state:";
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTicketState);
            this.Controls.Add(this.panelTicketState);
            this.Controls.Add(this.labelTextEdate);
            this.Controls.Add(this.labelTextSdate);
            this.Controls.Add(this.labelPriorityLevel);
            this.Controls.Add(this.labelTicketDateEnd);
            this.Controls.Add(this.labelTicketDateStart);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(450, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label labelTicketDateStart;
        private Label labelTicketDateEnd;
        private Label labelPriorityLevel;
        private Label labelTextSdate;
        private Label labelTextEdate;
        private Panel panelTicketState;
        private Label labelTicketState;
    }
}
