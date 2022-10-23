namespace Garden_Group.Forms
{
    partial class DashboardForm
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
            this.labelWelcomeText = new System.Windows.Forms.Label();
            this.circularPBUnresolvedIncidents = new CircularProgressBar.CircularProgressBar();
            this.groupBoxUnresolvedIncedents = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxIncidentsPastDeadline = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBarPastDeadline = new CircularProgressBar.CircularProgressBar();
            this.groupBoxUnresolvedIncedents.SuspendLayout();
            this.groupBoxIncidentsPastDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcomeText
            // 
            this.labelWelcomeText.AutoSize = true;
            this.labelWelcomeText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcomeText.Location = new System.Drawing.Point(30, 45);
            this.labelWelcomeText.Name = "labelWelcomeText";
            this.labelWelcomeText.Size = new System.Drawing.Size(70, 28);
            this.labelWelcomeText.TabIndex = 1;
            this.labelWelcomeText.Text = "label1";
            // 
            // circularPBUnresolvedIncidents
            // 
            this.circularPBUnresolvedIncidents.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularPBUnresolvedIncidents.AnimationSpeed = 500;
            this.circularPBUnresolvedIncidents.BackColor = System.Drawing.Color.Transparent;
            this.circularPBUnresolvedIncidents.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularPBUnresolvedIncidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularPBUnresolvedIncidents.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularPBUnresolvedIncidents.InnerMargin = 2;
            this.circularPBUnresolvedIncidents.InnerWidth = -1;
            this.circularPBUnresolvedIncidents.Location = new System.Drawing.Point(130, 98);
            this.circularPBUnresolvedIncidents.MarqueeAnimationSpeed = 2000;
            this.circularPBUnresolvedIncidents.Name = "circularPBUnresolvedIncidents";
            this.circularPBUnresolvedIncidents.OuterColor = System.Drawing.Color.Gray;
            this.circularPBUnresolvedIncidents.OuterMargin = -25;
            this.circularPBUnresolvedIncidents.OuterWidth = 26;
            this.circularPBUnresolvedIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularPBUnresolvedIncidents.ProgressWidth = 25;
            this.circularPBUnresolvedIncidents.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circularPBUnresolvedIncidents.Size = new System.Drawing.Size(177, 180);
            this.circularPBUnresolvedIncidents.StartAngle = 270;
            this.circularPBUnresolvedIncidents.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPBUnresolvedIncidents.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularPBUnresolvedIncidents.SubscriptText = "";
            this.circularPBUnresolvedIncidents.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPBUnresolvedIncidents.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularPBUnresolvedIncidents.SuperscriptText = "";
            this.circularPBUnresolvedIncidents.TabIndex = 2;
            this.circularPBUnresolvedIncidents.Text = "1/15";
            this.circularPBUnresolvedIncidents.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularPBUnresolvedIncidents.Value = 68;
            this.circularPBUnresolvedIncidents.Click += new System.EventHandler(this.circularPBUnresolvedIncidents_Click);
            // 
            // groupBoxUnresolvedIncedents
            // 
            this.groupBoxUnresolvedIncedents.Controls.Add(this.label1);
            this.groupBoxUnresolvedIncedents.Controls.Add(this.circularPBUnresolvedIncidents);
            this.groupBoxUnresolvedIncedents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxUnresolvedIncedents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUnresolvedIncedents.Location = new System.Drawing.Point(216, 366);
            this.groupBoxUnresolvedIncedents.Name = "groupBoxUnresolvedIncedents";
            this.groupBoxUnresolvedIncedents.Size = new System.Drawing.Size(440, 322);
            this.groupBoxUnresolvedIncedents.TabIndex = 4;
            this.groupBoxUnresolvedIncedents.TabStop = false;
            this.groupBoxUnresolvedIncedents.Text = "Unresolved incidents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "All tickets currently open";
            // 
            // groupBoxIncidentsPastDeadline
            // 
            this.groupBoxIncidentsPastDeadline.Controls.Add(this.label2);
            this.groupBoxIncidentsPastDeadline.Controls.Add(this.circularProgressBarPastDeadline);
            this.groupBoxIncidentsPastDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxIncidentsPastDeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxIncidentsPastDeadline.Location = new System.Drawing.Point(764, 366);
            this.groupBoxIncidentsPastDeadline.Name = "groupBoxIncidentsPastDeadline";
            this.groupBoxIncidentsPastDeadline.Size = new System.Drawing.Size(440, 322);
            this.groupBoxIncidentsPastDeadline.TabIndex = 5;
            this.groupBoxIncidentsPastDeadline.TabStop = false;
            this.groupBoxIncidentsPastDeadline.Text = "Incidents past deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "These tickets need your immediate attention";
            // 
            // circularProgressBarPastDeadline
            // 
            this.circularProgressBarPastDeadline.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarPastDeadline.AnimationSpeed = 500;
            this.circularProgressBarPastDeadline.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarPastDeadline.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBarPastDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarPastDeadline.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarPastDeadline.InnerMargin = 2;
            this.circularProgressBarPastDeadline.InnerWidth = -1;
            this.circularProgressBarPastDeadline.Location = new System.Drawing.Point(138, 98);
            this.circularProgressBarPastDeadline.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarPastDeadline.Name = "circularProgressBarPastDeadline";
            this.circularProgressBarPastDeadline.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarPastDeadline.OuterMargin = -25;
            this.circularProgressBarPastDeadline.OuterWidth = 26;
            this.circularProgressBarPastDeadline.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBarPastDeadline.ProgressWidth = 25;
            this.circularProgressBarPastDeadline.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBarPastDeadline.Size = new System.Drawing.Size(177, 180);
            this.circularProgressBarPastDeadline.StartAngle = 270;
            this.circularProgressBarPastDeadline.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarPastDeadline.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarPastDeadline.SubscriptText = "";
            this.circularProgressBarPastDeadline.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarPastDeadline.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarPastDeadline.SuperscriptText = "";
            this.circularProgressBarPastDeadline.TabIndex = 2;
            this.circularProgressBarPastDeadline.Text = "1";
            this.circularProgressBarPastDeadline.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarPastDeadline.Value = 68;
            this.circularProgressBarPastDeadline.Click += new System.EventHandler(this.circularProgressBarPastDeadline_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBoxIncidentsPastDeadline);
            this.Controls.Add(this.groupBoxUnresolvedIncedents);
            this.Controls.Add(this.labelWelcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.groupBoxUnresolvedIncedents.ResumeLayout(false);
            this.groupBoxUnresolvedIncedents.PerformLayout();
            this.groupBoxIncidentsPastDeadline.ResumeLayout(false);
            this.groupBoxIncidentsPastDeadline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelWelcomeText;
        private CircularProgressBar.CircularProgressBar circularPBUnresolvedIncidents;
        private GroupBox groupBoxUnresolvedIncedents;
        private Label label1;
        private GroupBox groupBoxIncidentsPastDeadline;
        private Label label2;
        private CircularProgressBar.CircularProgressBar circularProgressBarPastDeadline;
    }
}