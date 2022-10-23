namespace Garden_Group.Forms
{
    partial class IncidentManagementForm
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
            this.flowLayoutPanelIncidents = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDescriptionTxt = new System.Windows.Forms.Label();
            this.labelPriorityTxt = new System.Windows.Forms.Label();
            this.labelTypeTxt = new System.Windows.Forms.Label();
            this.labelStateTxt = new System.Windows.Forms.Label();
            this.labelDeadlineTxt = new System.Windows.Forms.Label();
            this.labelCreatorTxt = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.labelCreatorName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBecomeSolver = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCloseTicket = new System.Windows.Forms.Button();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxTransfer = new System.Windows.Forms.CheckBox();
            this.comboBoxTransfer = new System.Windows.Forms.ComboBox();
            this.labelErrorHandling = new System.Windows.Forms.Label();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.panelIncidentEditor = new System.Windows.Forms.Panel();
            this.labelTicketState = new System.Windows.Forms.Label();
            this.buttonEditTicket = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelFeedBack = new System.Windows.Forms.Label();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.buttonSortAscending = new System.Windows.Forms.Button();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelTransfer.SuspendLayout();
            this.panelIncidentEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelIncidents
            // 
            this.flowLayoutPanelIncidents.AutoScroll = true;
            this.flowLayoutPanelIncidents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanelIncidents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelIncidents.Location = new System.Drawing.Point(964, 159);
            this.flowLayoutPanelIncidents.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanelIncidents.Name = "flowLayoutPanelIncidents";
            this.flowLayoutPanelIncidents.Size = new System.Drawing.Size(666, 674);
            this.flowLayoutPanelIncidents.TabIndex = 0;
            this.flowLayoutPanelIncidents.WrapContents = false;
            // 
            // labelDescriptionTxt
            // 
            this.labelDescriptionTxt.AutoSize = true;
            this.labelDescriptionTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescriptionTxt.Location = new System.Drawing.Point(33, 109);
            this.labelDescriptionTxt.Name = "labelDescriptionTxt";
            this.labelDescriptionTxt.Size = new System.Drawing.Size(128, 30);
            this.labelDescriptionTxt.TabIndex = 2;
            this.labelDescriptionTxt.Text = "Beschrijving:";
            // 
            // labelPriorityTxt
            // 
            this.labelPriorityTxt.AutoSize = true;
            this.labelPriorityTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriorityTxt.Location = new System.Drawing.Point(33, 290);
            this.labelPriorityTxt.Name = "labelPriorityTxt";
            this.labelPriorityTxt.Size = new System.Drawing.Size(144, 30);
            this.labelPriorityTxt.TabIndex = 4;
            this.labelPriorityTxt.Text = "Prioriteit level:";
            // 
            // labelTypeTxt
            // 
            this.labelTypeTxt.AutoSize = true;
            this.labelTypeTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeTxt.Location = new System.Drawing.Point(35, 346);
            this.labelTypeTxt.Name = "labelTypeTxt";
            this.labelTypeTxt.Size = new System.Drawing.Size(61, 30);
            this.labelTypeTxt.TabIndex = 5;
            this.labelTypeTxt.Text = "Type:";
            // 
            // labelStateTxt
            // 
            this.labelStateTxt.AutoSize = true;
            this.labelStateTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStateTxt.Location = new System.Drawing.Point(33, 577);
            this.labelStateTxt.Name = "labelStateTxt";
            this.labelStateTxt.Size = new System.Drawing.Size(74, 30);
            this.labelStateTxt.TabIndex = 6;
            this.labelStateTxt.Text = "Status:";
            // 
            // labelDeadlineTxt
            // 
            this.labelDeadlineTxt.AutoSize = true;
            this.labelDeadlineTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadlineTxt.Location = new System.Drawing.Point(33, 400);
            this.labelDeadlineTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelDeadlineTxt.Name = "labelDeadlineTxt";
            this.labelDeadlineTxt.Size = new System.Drawing.Size(100, 30);
            this.labelDeadlineTxt.TabIndex = 9;
            this.labelDeadlineTxt.Text = "Deadline:";
            // 
            // labelCreatorTxt
            // 
            this.labelCreatorTxt.AutoSize = true;
            this.labelCreatorTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreatorTxt.Location = new System.Drawing.Point(33, 607);
            this.labelCreatorTxt.Name = "labelCreatorTxt";
            this.labelCreatorTxt.Size = new System.Drawing.Size(149, 30);
            this.labelCreatorTxt.TabIndex = 10;
            this.labelCreatorTxt.Text = "Gemaakt door:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(185, 109);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(431, 156);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(185, 291);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 33);
            this.comboBoxPriority.TabIndex = 15;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(185, 347);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 33);
            this.comboBoxType.TabIndex = 16;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(185, 398);
            this.dateTimePickerDeadline.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(374, 33);
            this.dateTimePickerDeadline.TabIndex = 19;
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.AutoSize = true;
            this.labelCreatorName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreatorName.Location = new System.Drawing.Point(185, 607);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(21, 30);
            this.labelCreatorName.TabIndex = 20;
            this.labelCreatorName.Text = "-";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(35, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 30);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Titel:";
            // 
            // buttonBecomeSolver
            // 
            this.buttonBecomeSolver.AutoSize = true;
            this.buttonBecomeSolver.BackColor = System.Drawing.Color.LightGray;
            this.buttonBecomeSolver.Enabled = false;
            this.buttonBecomeSolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBecomeSolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBecomeSolver.Location = new System.Drawing.Point(1278, 836);
            this.buttonBecomeSolver.Name = "buttonBecomeSolver";
            this.buttonBecomeSolver.Size = new System.Drawing.Size(152, 39);
            this.buttonBecomeSolver.TabIndex = 24;
            this.buttonBecomeSolver.Text = "Wordt oplosser";
            this.buttonBecomeSolver.UseVisualStyleBackColor = false;
            this.buttonBecomeSolver.Click += new System.EventHandler(this.buttonBecomeSolver_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(1009, 836);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 39);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete ticket";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCloseTicket
            // 
            this.buttonCloseTicket.AutoSize = true;
            this.buttonCloseTicket.BackColor = System.Drawing.Color.LightGray;
            this.buttonCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseTicket.Location = new System.Drawing.Point(1146, 836);
            this.buttonCloseTicket.Name = "buttonCloseTicket";
            this.buttonCloseTicket.Size = new System.Drawing.Size(126, 39);
            this.buttonCloseTicket.TabIndex = 26;
            this.buttonCloseTicket.Text = "Sluit ticket";
            this.buttonCloseTicket.UseVisualStyleBackColor = false;
            this.buttonCloseTicket.Click += new System.EventHandler(this.buttonCloseTicket_Click);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Location = new System.Drawing.Point(964, 97);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(91, 19);
            this.checkBoxFilter.TabIndex = 27;
            this.checkBoxFilter.Text = "Filter Tickets";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(963, 128);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(378, 23);
            this.textBoxFilter.TabIndex = 28;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // checkBoxTransfer
            // 
            this.checkBoxTransfer.AutoSize = true;
            this.checkBoxTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTransfer.Location = new System.Drawing.Point(249, 852);
            this.checkBoxTransfer.Name = "checkBoxTransfer";
            this.checkBoxTransfer.Size = new System.Drawing.Size(98, 29);
            this.checkBoxTransfer.TabIndex = 29;
            this.checkBoxTransfer.Text = "Transfer";
            this.checkBoxTransfer.UseVisualStyleBackColor = true;
            this.checkBoxTransfer.CheckedChanged += new System.EventHandler(this.checkBoxTransfer_CheckedChanged);
            // 
            // comboBoxTransfer
            // 
            this.comboBoxTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTransfer.FormattingEnabled = true;
            this.comboBoxTransfer.Location = new System.Drawing.Point(41, 5);
            this.comboBoxTransfer.Name = "comboBoxTransfer";
            this.comboBoxTransfer.Size = new System.Drawing.Size(414, 29);
            this.comboBoxTransfer.TabIndex = 3;
            this.comboBoxTransfer.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransfer_SelectedIndexChanged_1);
            // 
            // labelErrorHandling
            // 
            this.labelErrorHandling.AutoSize = true;
            this.labelErrorHandling.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorHandling.Location = new System.Drawing.Point(234, 954);
            this.labelErrorHandling.Name = "labelErrorHandling";
            this.labelErrorHandling.Size = new System.Drawing.Size(176, 25);
            this.labelErrorHandling.TabIndex = 31;
            this.labelErrorHandling.Text = "LabelErrorHandling";
            // 
            // panelTransfer
            // 
            this.panelTransfer.Controls.Add(this.comboBoxTransfer);
            this.panelTransfer.Location = new System.Drawing.Point(353, 852);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(508, 43);
            this.panelTransfer.TabIndex = 30;
            // 
            // panelIncidentEditor
            // 
            this.panelIncidentEditor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelIncidentEditor.Controls.Add(this.labelTicketState);
            this.panelIncidentEditor.Controls.Add(this.buttonEditTicket);
            this.panelIncidentEditor.Controls.Add(this.textBoxTitle);
            this.panelIncidentEditor.Controls.Add(this.labelTitle);
            this.panelIncidentEditor.Controls.Add(this.labelDescriptionTxt);
            this.panelIncidentEditor.Controls.Add(this.labelPriorityTxt);
            this.panelIncidentEditor.Controls.Add(this.labelTypeTxt);
            this.panelIncidentEditor.Controls.Add(this.labelStateTxt);
            this.panelIncidentEditor.Controls.Add(this.richTextBoxDescription);
            this.panelIncidentEditor.Controls.Add(this.labelCreatorName);
            this.panelIncidentEditor.Controls.Add(this.dateTimePickerDeadline);
            this.panelIncidentEditor.Controls.Add(this.comboBoxPriority);
            this.panelIncidentEditor.Controls.Add(this.comboBoxType);
            this.panelIncidentEditor.Controls.Add(this.labelCreatorTxt);
            this.panelIncidentEditor.Controls.Add(this.labelDeadlineTxt);
            this.panelIncidentEditor.Location = new System.Drawing.Point(234, 159);
            this.panelIncidentEditor.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.panelIncidentEditor.Name = "panelIncidentEditor";
            this.panelIncidentEditor.Size = new System.Drawing.Size(666, 674);
            this.panelIncidentEditor.TabIndex = 32;
            // 
            // labelTicketState
            // 
            this.labelTicketState.AutoSize = true;
            this.labelTicketState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTicketState.Location = new System.Drawing.Point(185, 577);
            this.labelTicketState.Name = "labelTicketState";
            this.labelTicketState.Size = new System.Drawing.Size(21, 30);
            this.labelTicketState.TabIndex = 32;
            this.labelTicketState.Text = "-";
            // 
            // buttonEditTicket
            // 
            this.buttonEditTicket.AutoSize = true;
            this.buttonEditTicket.BackColor = System.Drawing.Color.LightGray;
            this.buttonEditTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditTicket.Location = new System.Drawing.Point(231, 491);
            this.buttonEditTicket.Name = "buttonEditTicket";
            this.buttonEditTicket.Size = new System.Drawing.Size(148, 42);
            this.buttonEditTicket.TabIndex = 31;
            this.buttonEditTicket.Text = "Bewerk ticket";
            this.buttonEditTicket.UseVisualStyleBackColor = false;
            this.buttonEditTicket.Click += new System.EventHandler(this.buttonEditTicket_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(185, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(431, 35);
            this.textBoxTitle.TabIndex = 27;
            // 
            // labelFeedBack
            // 
            this.labelFeedBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFeedBack.Location = new System.Drawing.Point(768, 898);
            this.labelFeedBack.Name = "labelFeedBack";
            this.labelFeedBack.Size = new System.Drawing.Size(666, 41);
            this.labelFeedBack.TabIndex = 33;
            this.labelFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(1354, 97);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(128, 19);
            this.checkBoxSort.TabIndex = 34;
            this.checkBoxSort.Text = "Sorteer op prioriteit";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            this.checkBoxSort.CheckedChanged += new System.EventHandler(this.checkBoxSort_CheckedChanged);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Location = new System.Drawing.Point(1354, 128);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(130, 25);
            this.buttonSortDescending.TabIndex = 35;
            this.buttonSortDescending.Text = "Dalend";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Visible = false;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Location = new System.Drawing.Point(1497, 128);
            this.buttonSortAscending.Name = "buttonSortAscending";
            this.buttonSortAscending.Size = new System.Drawing.Size(130, 25);
            this.buttonSortAscending.TabIndex = 36;
            this.buttonSortAscending.Text = "Stijgend";
            this.buttonSortAscending.UseVisualStyleBackColor = true;
            this.buttonSortAscending.Visible = false;
            this.buttonSortAscending.Click += new System.EventHandler(this.buttonSortAscending_Click);
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.AutoSize = true;
            this.buttonAddTicket.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTicket.Location = new System.Drawing.Point(1436, 836);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(167, 39);
            this.buttonAddTicket.TabIndex = 37;
            this.buttonAddTicket.Text = "Ticket aanmaken";
            this.buttonAddTicket.UseVisualStyleBackColor = false;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(964, 56);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(378, 23);
            this.textBoxSearch.TabIndex = 38;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1354, 54);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 25);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Zoeken";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // IncidentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAddTicket);
            this.Controls.Add(this.buttonSortAscending);
            this.Controls.Add(this.buttonSortDescending);
            this.Controls.Add(this.checkBoxSort);
            this.Controls.Add(this.labelFeedBack);
            this.Controls.Add(this.panelIncidentEditor);
            this.Controls.Add(this.panelTransfer);
            this.Controls.Add(this.checkBoxTransfer);
            this.Controls.Add(this.labelErrorHandling);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.flowLayoutPanelIncidents);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBecomeSolver);
            this.Controls.Add(this.buttonCloseTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncidentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IncidentManagementForm";
            this.Load += new System.EventHandler(this.IncidentManagementForm_Load);
            this.panelTransfer.ResumeLayout(false);
            this.panelIncidentEditor.ResumeLayout(false);
            this.panelIncidentEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelIncidents;
        private Label labelDescriptionTxt;
        private Label labelPriorityTxt;
        private Label labelTypeTxt;
        private Label labelStateTxt;
        private Label labelDeadlineTxt;
        private Label labelCreatorTxt;
        private RichTextBox richTextBoxDescription;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxType;
        private DateTimePicker dateTimePickerDeadline;
        private Label labelCreatorName;
        private Label labelTitle;
        private Button buttonBecomeSolver;
        private Button buttonDelete;
        private Button buttonCloseTicket;
        private CheckBox checkBoxFilter;
        private TextBox textBoxFilter;
        private CheckBox checkBoxTransfer;
        private ComboBox comboBoxTransfer;
        private Label labelErrorHandling;
        private Panel panelTransfer;
        private Panel panelIncidentEditor;
        private TextBox textBoxTitle;
        private Button buttonEditTicket;
        private Label labelTicketState;
        private Label labelFeedBack;
        private CheckBox checkBoxSort;
        private Button buttonSortDescending;
        private Button buttonSortAscending;
        private Button buttonAddTicket;
        private TextBox textBoxSearch;
        private Button buttonSearch;
    }
}