namespace Garden_Group.UserControls
{
    partial class IncidentsUC
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
            this.labelTextState = new System.Windows.Forms.Label();
            this.labelTextSdate = new System.Windows.Forms.Label();
            this.labelTextEdate = new System.Windows.Forms.Label();
            this.panelTicketPriority = new System.Windows.Forms.Panel();
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
            this.labelDescription.BackColor = System.Drawing.Color.White;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(59, 34);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(262, 52);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelTicketDateStart
            // 
            this.labelTicketDateStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTicketDateStart.AutoSize = true;
            this.labelTicketDateStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketDateStart.Location = new System.Drawing.Point(419, 34);
            this.labelTicketDateStart.Name = "labelTicketDateStart";
            this.labelTicketDateStart.Size = new System.Drawing.Size(45, 20);
            this.labelTicketDateStart.TabIndex = 2;
            this.labelTicketDateStart.Text = "sdate";
            // 
            // labelTicketDateEnd
            // 
            this.labelTicketDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTicketDateEnd.AutoSize = true;
            this.labelTicketDateEnd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketDateEnd.Location = new System.Drawing.Point(444, 55);
            this.labelTicketDateEnd.Name = "labelTicketDateEnd";
            this.labelTicketDateEnd.Size = new System.Drawing.Size(47, 20);
            this.labelTicketDateEnd.TabIndex = 3;
            this.labelTicketDateEnd.Text = "edate";
            // 
            // labelTextState
            // 
            this.labelTextState.AutoSize = true;
            this.labelTextState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextState.Location = new System.Drawing.Point(233, 6);
            this.labelTextState.Name = "labelTextState";
            this.labelTextState.Size = new System.Drawing.Size(52, 20);
            this.labelTextState.TabIndex = 4;
            this.labelTextState.Text = "Status:";
            // 
            // labelTextSdate
            // 
            this.labelTextSdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTextSdate.AutoSize = true;
            this.labelTextSdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextSdate.Location = new System.Drawing.Point(323, 34);
            this.labelTextSdate.Name = "labelTextSdate";
            this.labelTextSdate.Size = new System.Drawing.Size(90, 20);
            this.labelTextSdate.TabIndex = 5;
            this.labelTextSdate.Text = "Start datum:";
            // 
            // labelTextEdate
            // 
            this.labelTextEdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTextEdate.AutoSize = true;
            this.labelTextEdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextEdate.Location = new System.Drawing.Point(323, 55);
            this.labelTextEdate.Name = "labelTextEdate";
            this.labelTextEdate.Size = new System.Drawing.Size(115, 20);
            this.labelTextEdate.TabIndex = 6;
            this.labelTextEdate.Text = "Sluitings datum:";
            // 
            // panelTicketPriority
            // 
            this.panelTicketPriority.Location = new System.Drawing.Point(3, 5);
            this.panelTicketPriority.Name = "panelTicketPriority";
            this.panelTicketPriority.Size = new System.Drawing.Size(50, 58);
            this.panelTicketPriority.TabIndex = 7;
            // 
            // labelTicketState
            // 
            this.labelTicketState.AutoSize = true;
            this.labelTicketState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketState.Location = new System.Drawing.Point(326, 5);
            this.labelTicketState.Name = "labelTicketState";
            this.labelTicketState.Size = new System.Drawing.Size(87, 20);
            this.labelTicketState.TabIndex = 8;
            this.labelTicketState.Text = "Ticket state:";
            // 
            // IncidentsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelTicketState);
            this.Controls.Add(this.panelTicketPriority);
            this.Controls.Add(this.labelTextEdate);
            this.Controls.Add(this.labelTextSdate);
            this.Controls.Add(this.labelTextState);
            this.Controls.Add(this.labelTicketDateEnd);
            this.Controls.Add(this.labelTicketDateStart);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IncidentsUC";
            this.Size = new System.Drawing.Size(514, 84);
            this.Load += new System.EventHandler(this.IncidentsUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label labelTicketDateStart;
        private Label labelTicketDateEnd;
        private Label labelTextState;
        private Label labelTextSdate;
        private Label labelTextEdate;
        private Panel panelTicketPriority;
        private Label labelTicketState;
    }
}
