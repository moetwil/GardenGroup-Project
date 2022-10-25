namespace Garden_Group.Forms
{
    partial class TicketOverviewForm
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
            this.flowTicketOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTicketOverview = new System.Windows.Forms.Label();
            this.buttonIncidentAanmaken = new System.Windows.Forms.Button();
            this.buttonHighPriority = new System.Windows.Forms.Button();
            this.buttonLowPriority = new System.Windows.Forms.Button();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.panelTicketInfo = new System.Windows.Forms.Panel();
            this.labelDeadlineText = new System.Windows.Forms.Label();
            this.labelIncidentText = new System.Windows.Forms.Label();
            this.labelOpentText = new System.Windows.Forms.Label();
            this.labelDateDeadline = new System.Windows.Forms.Label();
            this.labelIncidentType = new System.Windows.Forms.Label();
            this.labelCloseText = new System.Windows.Forms.Label();
            this.labelDateOpen = new System.Windows.Forms.Label();
            this.labelStateText = new System.Windows.Forms.Label();
            this.labelDateClose = new System.Windows.Forms.Label();
            this.labelStateName = new System.Windows.Forms.Label();
            this.labelPriorText = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelTicketInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowTicketOverview
            // 
            this.flowTicketOverview.AutoScroll = true;
            this.flowTicketOverview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowTicketOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowTicketOverview.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicketOverview.Location = new System.Drawing.Point(363, 119);
            this.flowTicketOverview.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.flowTicketOverview.Name = "flowTicketOverview";
            this.flowTicketOverview.Size = new System.Drawing.Size(666, 832);
            this.flowTicketOverview.TabIndex = 0;
            this.flowTicketOverview.WrapContents = false;
            // 
            // labelTicketOverview
            // 
            this.labelTicketOverview.AutoSize = true;
            this.labelTicketOverview.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketOverview.Location = new System.Drawing.Point(363, 63);
            this.labelTicketOverview.Margin = new System.Windows.Forms.Padding(50, 0, 3, 10);
            this.labelTicketOverview.Name = "labelTicketOverview";
            this.labelTicketOverview.Size = new System.Drawing.Size(101, 30);
            this.labelTicketOverview.TabIndex = 1;
            this.labelTicketOverview.Text = "Overzicht";
            // 
            // buttonIncidentAanmaken
            // 
            this.buttonIncidentAanmaken.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIncidentAanmaken.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonIncidentAanmaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncidentAanmaken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIncidentAanmaken.Location = new System.Drawing.Point(1072, 644);
            this.buttonIncidentAanmaken.Name = "buttonIncidentAanmaken";
            this.buttonIncidentAanmaken.Size = new System.Drawing.Size(160, 72);
            this.buttonIncidentAanmaken.TabIndex = 2;
            this.buttonIncidentAanmaken.Text = "Nieuw incident aanmaken";
            this.buttonIncidentAanmaken.UseVisualStyleBackColor = false;
            this.buttonIncidentAanmaken.Click += new System.EventHandler(this.buttonIncidentAanmaken_Click);
            // 
            // buttonHighPriority
            // 
            this.buttonHighPriority.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHighPriority.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHighPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHighPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHighPriority.Location = new System.Drawing.Point(1072, 767);
            this.buttonHighPriority.Name = "buttonHighPriority";
            this.buttonHighPriority.Size = new System.Drawing.Size(160, 72);
            this.buttonHighPriority.TabIndex = 3;
            this.buttonHighPriority.Text = "Prioriteit hoog";
            this.buttonHighPriority.UseVisualStyleBackColor = false;
            this.buttonHighPriority.Click += new System.EventHandler(this.buttonHighPriority_Click);
            // 
            // buttonLowPriority
            // 
            this.buttonLowPriority.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLowPriority.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLowPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLowPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLowPriority.Location = new System.Drawing.Point(1072, 879);
            this.buttonLowPriority.Name = "buttonLowPriority";
            this.buttonLowPriority.Size = new System.Drawing.Size(160, 72);
            this.buttonLowPriority.TabIndex = 4;
            this.buttonLowPriority.Text = "Prioriteit laag";
            this.buttonLowPriority.UseVisualStyleBackColor = false;
            this.buttonLowPriority.Click += new System.EventHandler(this.buttonLowPriority_Click);
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfoTitle.Location = new System.Drawing.Point(15, 21);
            this.labelInfoTitle.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(278, 60);
            this.labelInfoTitle.TabIndex = 5;
            this.labelInfoTitle.Text = "Titel";
            // 
            // panelTicketInfo
            // 
            this.panelTicketInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTicketInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicketInfo.Controls.Add(this.labelDeadlineText);
            this.panelTicketInfo.Controls.Add(this.labelIncidentText);
            this.panelTicketInfo.Controls.Add(this.labelOpentText);
            this.panelTicketInfo.Controls.Add(this.labelDateDeadline);
            this.panelTicketInfo.Controls.Add(this.labelIncidentType);
            this.panelTicketInfo.Controls.Add(this.labelCloseText);
            this.panelTicketInfo.Controls.Add(this.labelDateOpen);
            this.panelTicketInfo.Controls.Add(this.labelStateText);
            this.panelTicketInfo.Controls.Add(this.labelDateClose);
            this.panelTicketInfo.Controls.Add(this.labelStateName);
            this.panelTicketInfo.Controls.Add(this.labelPriorText);
            this.panelTicketInfo.Controls.Add(this.labelPriority);
            this.panelTicketInfo.Controls.Add(this.labelDescription);
            this.panelTicketInfo.Controls.Add(this.labelInfoTitle);
            this.panelTicketInfo.Location = new System.Drawing.Point(1072, 119);
            this.panelTicketInfo.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.panelTicketInfo.Name = "panelTicketInfo";
            this.panelTicketInfo.Size = new System.Drawing.Size(326, 473);
            this.panelTicketInfo.TabIndex = 6;
            // 
            // labelDeadlineText
            // 
            this.labelDeadlineText.AutoSize = true;
            this.labelDeadlineText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadlineText.Location = new System.Drawing.Point(16, 371);
            this.labelDeadlineText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelDeadlineText.Name = "labelDeadlineText";
            this.labelDeadlineText.Size = new System.Drawing.Size(91, 25);
            this.labelDeadlineText.TabIndex = 20;
            this.labelDeadlineText.Text = "Deadline:";
            // 
            // labelIncidentText
            // 
            this.labelIncidentText.AutoSize = true;
            this.labelIncidentText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncidentText.Location = new System.Drawing.Point(229, 84);
            this.labelIncidentText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelIncidentText.Name = "labelIncidentText";
            this.labelIncidentText.Size = new System.Drawing.Size(80, 25);
            this.labelIncidentText.TabIndex = 19;
            this.labelIncidentText.Text = "incident";
            // 
            // labelOpentText
            // 
            this.labelOpentText.AutoSize = true;
            this.labelOpentText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOpentText.Location = new System.Drawing.Point(16, 402);
            this.labelOpentText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelOpentText.Name = "labelOpentText";
            this.labelOpentText.Size = new System.Drawing.Size(120, 25);
            this.labelOpentText.TabIndex = 18;
            this.labelOpentText.Text = "Geopend op:";
            // 
            // labelDateDeadline
            // 
            this.labelDateDeadline.AutoSize = true;
            this.labelDateDeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateDeadline.Location = new System.Drawing.Point(160, 366);
            this.labelDateDeadline.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelDateDeadline.Name = "labelDateDeadline";
            this.labelDateDeadline.Size = new System.Drawing.Size(91, 25);
            this.labelDateDeadline.TabIndex = 13;
            this.labelDateDeadline.Text = "Deadline:";
            // 
            // labelIncidentType
            // 
            this.labelIncidentType.AutoSize = true;
            this.labelIncidentType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncidentType.Location = new System.Drawing.Point(125, 84);
            this.labelIncidentType.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelIncidentType.Name = "labelIncidentType";
            this.labelIncidentType.Size = new System.Drawing.Size(94, 25);
            this.labelIncidentType.TabIndex = 12;
            this.labelIncidentType.Text = "Hardware";
            this.labelIncidentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCloseText
            // 
            this.labelCloseText.AutoSize = true;
            this.labelCloseText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCloseText.Location = new System.Drawing.Point(15, 433);
            this.labelCloseText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelCloseText.Name = "labelCloseText";
            this.labelCloseText.Size = new System.Drawing.Size(117, 25);
            this.labelCloseText.TabIndex = 16;
            this.labelCloseText.Text = "Gesloten op:";
            // 
            // labelDateOpen
            // 
            this.labelDateOpen.AutoSize = true;
            this.labelDateOpen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateOpen.Location = new System.Drawing.Point(160, 402);
            this.labelDateOpen.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelDateOpen.Name = "labelDateOpen";
            this.labelDateOpen.Size = new System.Drawing.Size(96, 25);
            this.labelDateOpen.TabIndex = 11;
            this.labelDateOpen.Text = "8/10/2022";
            // 
            // labelStateText
            // 
            this.labelStateText.AutoSize = true;
            this.labelStateText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStateText.Location = new System.Drawing.Point(16, 340);
            this.labelStateText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelStateText.Name = "labelStateText";
            this.labelStateText.Size = new System.Drawing.Size(66, 25);
            this.labelStateText.TabIndex = 15;
            this.labelStateText.Text = "Status:";
            // 
            // labelDateClose
            // 
            this.labelDateClose.AutoSize = true;
            this.labelDateClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateClose.Location = new System.Drawing.Point(160, 433);
            this.labelDateClose.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelDateClose.Name = "labelDateClose";
            this.labelDateClose.Size = new System.Drawing.Size(96, 25);
            this.labelDateClose.TabIndex = 9;
            this.labelDateClose.Text = "8/10/2022";
            // 
            // labelStateName
            // 
            this.labelStateName.AutoSize = true;
            this.labelStateName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStateName.Location = new System.Drawing.Point(160, 335);
            this.labelStateName.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(58, 25);
            this.labelStateName.TabIndex = 8;
            this.labelStateName.Text = "Open";
            // 
            // labelPriorText
            // 
            this.labelPriorText.AutoSize = true;
            this.labelPriorText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriorText.Location = new System.Drawing.Point(15, 309);
            this.labelPriorText.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelPriorText.Name = "labelPriorText";
            this.labelPriorText.Size = new System.Drawing.Size(133, 25);
            this.labelPriorText.TabIndex = 14;
            this.labelPriorText.Text = "Prioriteit level:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(160, 304);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(46, 25);
            this.labelPriority.TabIndex = 7;
            this.labelPriority.Text = "Low";
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(15, 117);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(294, 184);
            this.labelDescription.TabIndex = 6;
            // 
            // TicketOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelTicketInfo);
            this.Controls.Add(this.buttonLowPriority);
            this.Controls.Add(this.buttonHighPriority);
            this.Controls.Add(this.buttonIncidentAanmaken);
            this.Controls.Add(this.labelTicketOverview);
            this.Controls.Add(this.flowTicketOverview);
            this.Name = "TicketOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TicketOverviewForm";
            this.Load += new System.EventHandler(this.TicketOverviewForm_Load);
            this.panelTicketInfo.ResumeLayout(false);
            this.panelTicketInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowTicketOverview;
        private Label labelTicketOverview;
        private Button buttonIncidentAanmaken;
        private Button buttonHighPriority;
        private Button buttonLowPriority;
        private Label labelInfoTitle;
        private Panel panelTicketInfo;
        private Label labelDateOpen;
        private Label labelDateClose;
        private Label labelStateName;
        private Label labelPriority;
        private Label labelDescription;
        private Label labelDateDeadline;
        private Label labelIncidentType;
        private Label labelOpentText;
        private Label labelCloseText;
        private Label labelStateText;
        private Label labelPriorText;
        private Label labelDeadlineText;
        private Label labelIncidentText;
    }
}