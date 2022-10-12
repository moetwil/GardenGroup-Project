namespace Garden_Group.Forms
{
    partial class TicketAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketAddingForm));
            this.label2 = new System.Windows.Forms.Label();
            this.labelTicketTitle = new System.Windows.Forms.Label();
            this.textBoxTicketTitle = new System.Windows.Forms.TextBox();
            this.labelTicketDescription = new System.Windows.Forms.Label();
            this.textBoxTicketDescription = new System.Windows.Forms.TextBox();
            this.labelTicketState = new System.Windows.Forms.Label();
            this.comboBoxTicketStateState = new System.Windows.Forms.ComboBox();
            this.labelTicketDates = new System.Windows.Forms.Label();
            this.labelTicketPriority = new System.Windows.Forms.Label();
            this.comboBoxTicketPriority = new System.Windows.Forms.ComboBox();
            this.buttonBackToDashBoard = new System.Windows.Forms.Button();
            this.labelTicketIncidentType = new System.Windows.Forms.Label();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonTicketCancel = new System.Windows.Forms.Button();
            this.comboBoxTypeOfIncident = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTicketDeadline = new System.Windows.Forms.DateTimePicker();
            this.labelErrorHandling = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(606, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vul hieronder de benodigde informatie in om een nieuwe ticket te maken. \r\nVelden " +
    "met een \'*\' zijn verplicht.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTicketTitle
            // 
            this.labelTicketTitle.AutoSize = true;
            this.labelTicketTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketTitle.Location = new System.Drawing.Point(391, 196);
            this.labelTicketTitle.Name = "labelTicketTitle";
            this.labelTicketTitle.Size = new System.Drawing.Size(65, 25);
            this.labelTicketTitle.TabIndex = 2;
            this.labelTicketTitle.Text = "Titel: *";
            // 
            // textBoxTicketTitle
            // 
            this.textBoxTicketTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTicketTitle.Location = new System.Drawing.Point(606, 193);
            this.textBoxTicketTitle.Name = "textBoxTicketTitle";
            this.textBoxTicketTitle.Size = new System.Drawing.Size(699, 33);
            this.textBoxTicketTitle.TabIndex = 1;
            // 
            // labelTicketDescription
            // 
            this.labelTicketDescription.AutoSize = true;
            this.labelTicketDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketDescription.Location = new System.Drawing.Point(391, 679);
            this.labelTicketDescription.Name = "labelTicketDescription";
            this.labelTicketDescription.Size = new System.Drawing.Size(131, 25);
            this.labelTicketDescription.TabIndex = 4;
            this.labelTicketDescription.Text = "Beschrijving: *";
            // 
            // textBoxTicketDescription
            // 
            this.textBoxTicketDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTicketDescription.Location = new System.Drawing.Point(606, 679);
            this.textBoxTicketDescription.Multiline = true;
            this.textBoxTicketDescription.Name = "textBoxTicketDescription";
            this.textBoxTicketDescription.Size = new System.Drawing.Size(699, 158);
            this.textBoxTicketDescription.TabIndex = 6;
            // 
            // labelTicketState
            // 
            this.labelTicketState.AutoSize = true;
            this.labelTicketState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketState.Location = new System.Drawing.Point(391, 285);
            this.labelTicketState.Name = "labelTicketState";
            this.labelTicketState.Size = new System.Drawing.Size(132, 25);
            this.labelTicketState.TabIndex = 8;
            this.labelTicketState.Text = "Ticket status: *";
            // 
            // comboBoxTicketStateState
            // 
            this.comboBoxTicketStateState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTicketStateState.FormattingEnabled = true;
            this.comboBoxTicketStateState.Location = new System.Drawing.Point(606, 285);
            this.comboBoxTicketStateState.Name = "comboBoxTicketStateState";
            this.comboBoxTicketStateState.Size = new System.Drawing.Size(326, 33);
            this.comboBoxTicketStateState.TabIndex = 2;
            // 
            // labelTicketDates
            // 
            this.labelTicketDates.AutoSize = true;
            this.labelTicketDates.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketDates.Location = new System.Drawing.Point(391, 387);
            this.labelTicketDates.Name = "labelTicketDates";
            this.labelTicketDates.Size = new System.Drawing.Size(143, 25);
            this.labelTicketDates.TabIndex = 13;
            this.labelTicketDates.Text = "Ticket deadline:";
            // 
            // labelTicketPriority
            // 
            this.labelTicketPriority.AutoSize = true;
            this.labelTicketPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketPriority.Location = new System.Drawing.Point(391, 480);
            this.labelTicketPriority.Name = "labelTicketPriority";
            this.labelTicketPriority.Size = new System.Drawing.Size(156, 25);
            this.labelTicketPriority.TabIndex = 20;
            this.labelTicketPriority.Text = "Ticket prioriteit: *";
            // 
            // comboBoxTicketPriority
            // 
            this.comboBoxTicketPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTicketPriority.FormattingEnabled = true;
            this.comboBoxTicketPriority.Location = new System.Drawing.Point(606, 480);
            this.comboBoxTicketPriority.Name = "comboBoxTicketPriority";
            this.comboBoxTicketPriority.Size = new System.Drawing.Size(326, 33);
            this.comboBoxTicketPriority.TabIndex = 4;
            // 
            // buttonBackToDashBoard
            // 
            this.buttonBackToDashBoard.BackColor = System.Drawing.Color.White;
            this.buttonBackToDashBoard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToDashBoard.Location = new System.Drawing.Point(49, 50);
            this.buttonBackToDashBoard.Name = "buttonBackToDashBoard";
            this.buttonBackToDashBoard.Size = new System.Drawing.Size(125, 75);
            this.buttonBackToDashBoard.TabIndex = 9;
            this.buttonBackToDashBoard.Text = "Terug";
            this.buttonBackToDashBoard.UseVisualStyleBackColor = false;
            this.buttonBackToDashBoard.Click += new System.EventHandler(this.buttonBackToDashBoard_Click);
            // 
            // labelTicketIncidentType
            // 
            this.labelTicketIncidentType.AutoSize = true;
            this.labelTicketIncidentType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketIncidentType.Location = new System.Drawing.Point(391, 580);
            this.labelTicketIncidentType.Name = "labelTicketIncidentType";
            this.labelTicketIncidentType.Size = new System.Drawing.Size(141, 25);
            this.labelTicketIncidentType.TabIndex = 23;
            this.labelTicketIncidentType.Text = "Type incident: *";
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTicket.Location = new System.Drawing.Point(1105, 897);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(200, 75);
            this.buttonAddTicket.TabIndex = 7;
            this.buttonAddTicket.Text = "Ticket toevoegen";
            this.buttonAddTicket.UseVisualStyleBackColor = false;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // buttonTicketCancel
            // 
            this.buttonTicketCancel.BackColor = System.Drawing.Color.White;
            this.buttonTicketCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTicketCancel.Location = new System.Drawing.Point(883, 897);
            this.buttonTicketCancel.Name = "buttonTicketCancel";
            this.buttonTicketCancel.Size = new System.Drawing.Size(200, 75);
            this.buttonTicketCancel.TabIndex = 8;
            this.buttonTicketCancel.Text = "Ticket \r\nannuleren";
            this.buttonTicketCancel.UseVisualStyleBackColor = false;
            this.buttonTicketCancel.Click += new System.EventHandler(this.buttonTicketCancel_Click);
            // 
            // comboBoxTypeOfIncident
            // 
            this.comboBoxTypeOfIncident.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTypeOfIncident.FormattingEnabled = true;
            this.comboBoxTypeOfIncident.Location = new System.Drawing.Point(606, 580);
            this.comboBoxTypeOfIncident.Name = "comboBoxTypeOfIncident";
            this.comboBoxTypeOfIncident.Size = new System.Drawing.Size(326, 33);
            this.comboBoxTypeOfIncident.TabIndex = 5;
            // 
            // dateTimePickerTicketDeadline
            // 
            this.dateTimePickerTicketDeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTicketDeadline.Location = new System.Drawing.Point(606, 387);
            this.dateTimePickerTicketDeadline.Name = "dateTimePickerTicketDeadline";
            this.dateTimePickerTicketDeadline.Size = new System.Drawing.Size(326, 33);
            this.dateTimePickerTicketDeadline.TabIndex = 3;
            // 
            // labelErrorHandling
            // 
            this.labelErrorHandling.AutoSize = true;
            this.labelErrorHandling.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorHandling.ForeColor = System.Drawing.SystemColors.Control;
            this.labelErrorHandling.Location = new System.Drawing.Point(606, 862);
            this.labelErrorHandling.Name = "labelErrorHandling";
            this.labelErrorHandling.Size = new System.Drawing.Size(0, 25);
            this.labelErrorHandling.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(606, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Waar kunnen we u bij helpen? Vat uw titel samen in een aantal woorden.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(606, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(647, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Hoe gedetailleerder u uw incident kunt omschrijven, hoe beter en sneller wij kunn" +
    "en reageren op uw incident. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1552, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // TicketAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErrorHandling);
            this.Controls.Add(this.comboBoxTypeOfIncident);
            this.Controls.Add(this.buttonTicketCancel);
            this.Controls.Add(this.buttonAddTicket);
            this.Controls.Add(this.labelTicketIncidentType);
            this.Controls.Add(this.buttonBackToDashBoard);
            this.Controls.Add(this.comboBoxTicketPriority);
            this.Controls.Add(this.labelTicketPriority);
            this.Controls.Add(this.dateTimePickerTicketDeadline);
            this.Controls.Add(this.labelTicketDates);
            this.Controls.Add(this.comboBoxTicketStateState);
            this.Controls.Add(this.labelTicketState);
            this.Controls.Add(this.textBoxTicketDescription);
            this.Controls.Add(this.labelTicketDescription);
            this.Controls.Add(this.textBoxTicketTitle);
            this.Controls.Add(this.labelTicketTitle);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TicketAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Een nieuwe ticket toevoegen";
            this.Load += new System.EventHandler(this.TicketAddingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label labelTicketTitle;
        private TextBox textBoxTicketTitle;
        private Label labelTicketDescription;
        private TextBox textBoxTicketDescription;
        private Label labelTicketState;
        private ComboBox comboBoxTicketStateState;
        private Label labelTicketDates;
        private Label labelTicketPriority;
        private ComboBox comboBoxTicketPriority;
        private Button buttonBackToDashBoard;
        private Label labelTicketIncidentType;
        private Button buttonAddTicket;
        private Button buttonTicketCancel;
        private ComboBox comboBoxTypeOfIncident;
        private DateTimePicker dateTimePickerTicketDeadline;
        private Label labelErrorHandling;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}