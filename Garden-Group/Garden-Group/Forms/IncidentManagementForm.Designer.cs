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
            this.labelCodeText = new System.Windows.Forms.Label();
            this.labelPriorityTxt = new System.Windows.Forms.Label();
            this.labelTypeTxt = new System.Windows.Forms.Label();
            this.labelStateTxt = new System.Windows.Forms.Label();
            this.labelOpenTxt = new System.Windows.Forms.Label();
            this.labelCloseTxt = new System.Windows.Forms.Label();
            this.labelDeadlineTxt = new System.Windows.Forms.Label();
            this.labelCreatorTxt = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOpen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerClosed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.labelCreatorName = new System.Windows.Forms.Label();
            this.labelStateCode = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBecomeSolver = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCloseTicket = new System.Windows.Forms.Button();

            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelIncidents
            // 
            this.flowLayoutPanelIncidents.AutoScroll = true;
            this.flowLayoutPanelIncidents.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanelIncidents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelIncidents.Location = new System.Drawing.Point(770, 234);
            this.flowLayoutPanelIncidents.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelIncidents.Name = "flowLayoutPanelIncidents";
            this.flowLayoutPanelIncidents.Size = new System.Drawing.Size(719, 710);
            this.flowLayoutPanelIncidents.TabIndex = 0;
            this.flowLayoutPanelIncidents.WrapContents = false;
            // 
            // labelDescriptionTxt
            // 
            this.labelDescriptionTxt.AutoSize = true;
            this.labelDescriptionTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescriptionTxt.Location = new System.Drawing.Point(116, 201);
            this.labelDescriptionTxt.Name = "labelDescriptionTxt";
            this.labelDescriptionTxt.Size = new System.Drawing.Size(128, 30);
            this.labelDescriptionTxt.TabIndex = 2;
            this.labelDescriptionTxt.Text = "Beschrijving:";
            // 
            // labelCodeText
            // 
            this.labelCodeText.AutoSize = true;
            this.labelCodeText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodeText.Location = new System.Drawing.Point(483, 201);
            this.labelCodeText.Name = "labelCodeText";
            this.labelCodeText.Size = new System.Drawing.Size(125, 30);
            this.labelCodeText.TabIndex = 3;
            this.labelCodeText.Text = "Status code:";
            // 
            // labelPriorityTxt
            // 
            this.labelPriorityTxt.AutoSize = true;
            this.labelPriorityTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriorityTxt.Location = new System.Drawing.Point(113, 382);
            this.labelPriorityTxt.Name = "labelPriorityTxt";
            this.labelPriorityTxt.Size = new System.Drawing.Size(144, 30);
            this.labelPriorityTxt.TabIndex = 4;
            this.labelPriorityTxt.Text = "Prioriteit level:";
            // 
            // labelTypeTxt
            // 
            this.labelTypeTxt.AutoSize = true;
            this.labelTypeTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeTxt.Location = new System.Drawing.Point(113, 441);
            this.labelTypeTxt.Name = "labelTypeTxt";
            this.labelTypeTxt.Size = new System.Drawing.Size(61, 30);
            this.labelTypeTxt.TabIndex = 5;
            this.labelTypeTxt.Text = "Type:";
            // 
            // labelStateTxt
            // 
            this.labelStateTxt.AutoSize = true;
            this.labelStateTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStateTxt.Location = new System.Drawing.Point(113, 496);
            this.labelStateTxt.Name = "labelStateTxt";
            this.labelStateTxt.Size = new System.Drawing.Size(74, 30);
            this.labelStateTxt.TabIndex = 6;
            this.labelStateTxt.Text = "Status:";
            // 
            // labelOpenTxt
            // 
            this.labelOpenTxt.AutoSize = true;
            this.labelOpenTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOpenTxt.Location = new System.Drawing.Point(120, 587);
            this.labelOpenTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelOpenTxt.Name = "labelOpenTxt";
            this.labelOpenTxt.Size = new System.Drawing.Size(132, 30);
            this.labelOpenTxt.TabIndex = 7;
            this.labelOpenTxt.Text = "Geopend op:";
            // 
            // labelCloseTxt
            // 
            this.labelCloseTxt.AutoSize = true;
            this.labelCloseTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCloseTxt.Location = new System.Drawing.Point(120, 637);
            this.labelCloseTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelCloseTxt.Name = "labelCloseTxt";
            this.labelCloseTxt.Size = new System.Drawing.Size(129, 30);
            this.labelCloseTxt.TabIndex = 8;
            this.labelCloseTxt.Text = "Gesloten op:";
            // 
            // labelDeadlineTxt
            // 
            this.labelDeadlineTxt.AutoSize = true;
            this.labelDeadlineTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadlineTxt.Location = new System.Drawing.Point(120, 687);
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
            this.labelCreatorTxt.Location = new System.Drawing.Point(113, 755);
            this.labelCreatorTxt.Name = "labelCreatorTxt";
            this.labelCreatorTxt.Size = new System.Drawing.Size(149, 30);
            this.labelCreatorTxt.TabIndex = 10;
            this.labelCreatorTxt.Text = "Gemaakt door:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(118, 234);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(617, 123);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(268, 379);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 38);
            this.comboBoxPriority.TabIndex = 15;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(268, 438);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 38);
            this.comboBoxType.TabIndex = 16;
            // 
            // dateTimePickerOpen
            // 
            this.dateTimePickerOpen.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOpen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOpen.Location = new System.Drawing.Point(298, 587);
            this.dateTimePickerOpen.Name = "dateTimePickerOpen";
            this.dateTimePickerOpen.Size = new System.Drawing.Size(374, 35);
            this.dateTimePickerOpen.TabIndex = 17;
            // 
            // dateTimePickerClosed
            // 
            this.dateTimePickerClosed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerClosed.Location = new System.Drawing.Point(298, 633);
            this.dateTimePickerClosed.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.dateTimePickerClosed.Name = "dateTimePickerClosed";
            this.dateTimePickerClosed.Size = new System.Drawing.Size(374, 35);
            this.dateTimePickerClosed.TabIndex = 18;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(298, 683);
            this.dateTimePickerDeadline.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(374, 35);
            this.dateTimePickerDeadline.TabIndex = 19;
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.AutoSize = true;
            this.labelCreatorName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreatorName.Location = new System.Drawing.Point(298, 755);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(224, 30);
            this.labelCreatorName.TabIndex = 20;
            this.labelCreatorName.Text = "Voornaam achternaam";
            // 
            // labelStateCode
            // 
            this.labelStateCode.AutoSize = true;
            this.labelStateCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStateCode.Location = new System.Drawing.Point(615, 201);
            this.labelStateCode.Name = "labelStateCode";
            this.labelStateCode.Size = new System.Drawing.Size(57, 30);
            this.labelStateCode.TabIndex = 21;
            this.labelStateCode.Text = "Error";
            // 
            // comboBoxState
            // 
            this.comboBoxState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(268, 493);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 38);
            this.comboBoxState.TabIndex = 22;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(120, 130);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(345, 32);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "voorbeeld Kapotte computer";
            // 
            // buttonBecomeSolver
            // 
            this.buttonBecomeSolver.Enabled = false;
            this.buttonBecomeSolver.Location = new System.Drawing.Point(586, 373);
            this.buttonBecomeSolver.Name = "buttonBecomeSolver";
            this.buttonBecomeSolver.Size = new System.Drawing.Size(139, 56);
            this.buttonBecomeSolver.TabIndex = 24;
            this.buttonBecomeSolver.Text = "Word oplosser";
            this.buttonBecomeSolver.UseVisualStyleBackColor = true;
            this.buttonBecomeSolver.Click += new System.EventHandler(this.buttonBecomeSolver_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(599, 441);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 35);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete ticket";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCloseTicket
            // 
            this.buttonCloseTicket.AutoSize = true;
            this.buttonCloseTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseTicket.Location = new System.Drawing.Point(599, 482);
            this.buttonCloseTicket.Name = "buttonCloseTicket";
            this.buttonCloseTicket.Size = new System.Drawing.Size(126, 35);
            this.buttonCloseTicket.TabIndex = 26;
            this.buttonCloseTicket.Text = "Sluit ticket";
            this.buttonCloseTicket.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Location = new System.Drawing.Point(773, 156);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(91, 19);
            this.checkBoxFilter.TabIndex = 27;
            this.checkBoxFilter.Text = "Filter Tickets";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(772, 187);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(521, 23);
            this.textBoxFilter.TabIndex = 28;
            // 
            // IncidentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.buttonCloseTicket);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBecomeSolver);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.labelStateCode);
            this.Controls.Add(this.labelCreatorName);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.dateTimePickerClosed);
            this.Controls.Add(this.dateTimePickerOpen);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelCreatorTxt);
            this.Controls.Add(this.labelDeadlineTxt);
            this.Controls.Add(this.labelCloseTxt);
            this.Controls.Add(this.labelOpenTxt);
            this.Controls.Add(this.labelStateTxt);
            this.Controls.Add(this.labelTypeTxt);
            this.Controls.Add(this.labelPriorityTxt);
            this.Controls.Add(this.labelCodeText);
            this.Controls.Add(this.labelDescriptionTxt);
            this.Controls.Add(this.flowLayoutPanelIncidents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncidentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IncidentManagementForm";
            this.Load += new System.EventHandler(this.IncidentManagementForm_Load);
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelIncidents;
        private Label labelDescriptionTxt;
        private Label labelCodeText;
        private Label labelPriorityTxt;
        private Label labelTypeTxt;
        private Label labelStateTxt;
        private Label labelOpenTxt;
        private Label labelCloseTxt;
        private Label labelDeadlineTxt;
        private Label labelCreatorTxt;
        private RichTextBox richTextBoxDescription;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxType;
        private DateTimePicker dateTimePickerOpen;
        private DateTimePicker dateTimePickerClosed;
        private DateTimePicker dateTimePickerDeadline;
        private Label labelCreatorName;
        private Label labelStateCode;
        private ComboBox comboBoxState;
        private Label labelTitle;
        private Button buttonBecomeSolver;
        private Button buttonDelete;
        private Button buttonCloseTicket;
        private CheckBox checkBoxFilter;
        private TextBox textBoxFilter;
    }
}