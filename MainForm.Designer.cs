namespace John_Davis_Appointment_App
{
    partial class MainForm
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
            this.mainFormTitleLabel = new System.Windows.Forms.Label();
            this.customerDgv = new System.Windows.Forms.DataGridView();
            this.customerDgvLabel = new System.Windows.Forms.Label();
            this.appointmentDgvLabel = new System.Windows.Forms.Label();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.appointmentDeleteBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.appointmentUpdateBtn = new System.Windows.Forms.Button();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.appointmentAddBtn = new System.Windows.Forms.Button();
            this.mainFormCalendar = new System.Windows.Forms.MonthCalendar();
            this.dayRadioBtn = new System.Windows.Forms.RadioButton();
            this.weekRadioBtn = new System.Windows.Forms.RadioButton();
            this.monthRadioBtn = new System.Windows.Forms.RadioButton();
            this.appointmentDgv = new System.Windows.Forms.DataGridView();
            this.u06rPSDataSet = new John_Davis_Appointment_App.U06rPSDataSet();
            this.mainFormExitBtn = new System.Windows.Forms.Button();
            this.filterAppointmentsByCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.filterAppointmentsByCustomerLabel = new System.Windows.Forms.Label();
            this.reportsLabel = new System.Windows.Forms.Label();
            this.customersWithAppointmentsBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.appointmentsByMonthBtn = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.searchAppointmentsByCustomerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06rPSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormTitleLabel
            // 
            this.mainFormTitleLabel.AutoSize = true;
            this.mainFormTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.mainFormTitleLabel.Name = "mainFormTitleLabel";
            this.mainFormTitleLabel.Size = new System.Drawing.Size(233, 30);
            this.mainFormTitleLabel.TabIndex = 0;
            this.mainFormTitleLabel.Text = "Appointment Manager";
            // 
            // customerDgv
            // 
            this.customerDgv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgv.Location = new System.Drawing.Point(12, 82);
            this.customerDgv.Name = "customerDgv";
            this.customerDgv.ReadOnly = true;
            this.customerDgv.RowHeadersVisible = false;
            this.customerDgv.RowHeadersWidth = 62;
            this.customerDgv.RowTemplate.Height = 28;
            this.customerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDgv.Size = new System.Drawing.Size(592, 246);
            this.customerDgv.TabIndex = 3;
            // 
            // customerDgvLabel
            // 
            this.customerDgvLabel.AutoSize = true;
            this.customerDgvLabel.Location = new System.Drawing.Point(12, 56);
            this.customerDgvLabel.Name = "customerDgvLabel";
            this.customerDgvLabel.Size = new System.Drawing.Size(138, 21);
            this.customerDgvLabel.TabIndex = 1;
            this.customerDgvLabel.Text = "Customer Records";
            // 
            // appointmentDgvLabel
            // 
            this.appointmentDgvLabel.AutoSize = true;
            this.appointmentDgvLabel.Location = new System.Drawing.Point(620, 56);
            this.appointmentDgvLabel.Name = "appointmentDgvLabel";
            this.appointmentDgvLabel.Size = new System.Drawing.Size(108, 21);
            this.appointmentDgvLabel.TabIndex = 2;
            this.appointmentDgvLabel.Text = "Appointments";
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.AutoSize = true;
            this.customerDeleteBtn.Location = new System.Drawing.Point(174, 334);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.customerDeleteBtn.TabIndex = 7;
            this.customerDeleteBtn.Text = "Delete";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // appointmentDeleteBtn
            // 
            this.appointmentDeleteBtn.AutoSize = true;
            this.appointmentDeleteBtn.Location = new System.Drawing.Point(786, 334);
            this.appointmentDeleteBtn.Name = "appointmentDeleteBtn";
            this.appointmentDeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.appointmentDeleteBtn.TabIndex = 10;
            this.appointmentDeleteBtn.Text = "Delete";
            this.appointmentDeleteBtn.UseVisualStyleBackColor = true;
            this.appointmentDeleteBtn.Click += new System.EventHandler(this.appointmentDeleteBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.AutoSize = true;
            this.customerUpdateBtn.Location = new System.Drawing.Point(93, 334);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(75, 31);
            this.customerUpdateBtn.TabIndex = 6;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // appointmentUpdateBtn
            // 
            this.appointmentUpdateBtn.AutoSize = true;
            this.appointmentUpdateBtn.Location = new System.Drawing.Point(705, 334);
            this.appointmentUpdateBtn.Name = "appointmentUpdateBtn";
            this.appointmentUpdateBtn.Size = new System.Drawing.Size(75, 31);
            this.appointmentUpdateBtn.TabIndex = 9;
            this.appointmentUpdateBtn.Text = "Update";
            this.appointmentUpdateBtn.UseVisualStyleBackColor = true;
            this.appointmentUpdateBtn.Click += new System.EventHandler(this.appointmentUpdateBtn_Click);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.AutoSize = true;
            this.customerAddBtn.Location = new System.Drawing.Point(12, 334);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(75, 31);
            this.customerAddBtn.TabIndex = 5;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // appointmentAddBtn
            // 
            this.appointmentAddBtn.AutoSize = true;
            this.appointmentAddBtn.Location = new System.Drawing.Point(624, 334);
            this.appointmentAddBtn.Name = "appointmentAddBtn";
            this.appointmentAddBtn.Size = new System.Drawing.Size(75, 31);
            this.appointmentAddBtn.TabIndex = 8;
            this.appointmentAddBtn.Text = "Add";
            this.appointmentAddBtn.UseVisualStyleBackColor = true;
            this.appointmentAddBtn.Click += new System.EventHandler(this.appointmentAddBtn_Click);
            // 
            // mainFormCalendar
            // 
            this.mainFormCalendar.Location = new System.Drawing.Point(960, 371);
            this.mainFormCalendar.Name = "mainFormCalendar";
            this.mainFormCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainFormCalendar.TabIndex = 16;
            this.mainFormCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mainFormCalendar_DateSelected);
            // 
            // dayRadioBtn
            // 
            this.dayRadioBtn.AutoSize = true;
            this.dayRadioBtn.Checked = true;
            this.dayRadioBtn.Location = new System.Drawing.Point(886, 417);
            this.dayRadioBtn.Name = "dayRadioBtn";
            this.dayRadioBtn.Size = new System.Drawing.Size(62, 25);
            this.dayRadioBtn.TabIndex = 13;
            this.dayRadioBtn.TabStop = true;
            this.dayRadioBtn.Text = "Day";
            this.dayRadioBtn.UseVisualStyleBackColor = true;
            this.dayRadioBtn.CheckedChanged += new System.EventHandler(this.dayRadioBtn_CheckedChanged);
            // 
            // weekRadioBtn
            // 
            this.weekRadioBtn.AutoSize = true;
            this.weekRadioBtn.Location = new System.Drawing.Point(886, 448);
            this.weekRadioBtn.Name = "weekRadioBtn";
            this.weekRadioBtn.Size = new System.Drawing.Size(73, 25);
            this.weekRadioBtn.TabIndex = 14;
            this.weekRadioBtn.Text = "Week";
            this.weekRadioBtn.UseVisualStyleBackColor = true;
            this.weekRadioBtn.CheckedChanged += new System.EventHandler(this.weekRadioBtn_CheckedChanged);
            // 
            // monthRadioBtn
            // 
            this.monthRadioBtn.AutoSize = true;
            this.monthRadioBtn.Location = new System.Drawing.Point(886, 479);
            this.monthRadioBtn.Name = "monthRadioBtn";
            this.monthRadioBtn.Size = new System.Drawing.Size(81, 25);
            this.monthRadioBtn.TabIndex = 15;
            this.monthRadioBtn.Text = "Month";
            this.monthRadioBtn.UseVisualStyleBackColor = true;
            this.monthRadioBtn.CheckedChanged += new System.EventHandler(this.monthRadioBtn_CheckedChanged);
            // 
            // appointmentDgv
            // 
            this.appointmentDgv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appointmentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDgv.Location = new System.Drawing.Point(624, 82);
            this.appointmentDgv.Name = "appointmentDgv";
            this.appointmentDgv.ReadOnly = true;
            this.appointmentDgv.RowHeadersVisible = false;
            this.appointmentDgv.RowHeadersWidth = 62;
            this.appointmentDgv.RowTemplate.Height = 28;
            this.appointmentDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDgv.Size = new System.Drawing.Size(592, 246);
            this.appointmentDgv.TabIndex = 4;
            // 
            // u06rPSDataSet
            // 
            this.u06rPSDataSet.DataSetName = "U06rPSDataSet";
            this.u06rPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainFormExitBtn
            // 
            this.mainFormExitBtn.AutoSize = true;
            this.mainFormExitBtn.Location = new System.Drawing.Point(12, 559);
            this.mainFormExitBtn.Name = "mainFormExitBtn";
            this.mainFormExitBtn.Size = new System.Drawing.Size(75, 31);
            this.mainFormExitBtn.TabIndex = 17;
            this.mainFormExitBtn.Text = "Exit";
            this.mainFormExitBtn.UseVisualStyleBackColor = true;
            this.mainFormExitBtn.Click += new System.EventHandler(this.mainFormExitBtn_Click);
            // 
            // filterAppointmentsByCustomerComboBox
            // 
            this.filterAppointmentsByCustomerComboBox.FormattingEnabled = true;
            this.filterAppointmentsByCustomerComboBox.Location = new System.Drawing.Point(624, 417);
            this.filterAppointmentsByCustomerComboBox.Name = "filterAppointmentsByCustomerComboBox";
            this.filterAppointmentsByCustomerComboBox.Size = new System.Drawing.Size(237, 29);
            this.filterAppointmentsByCustomerComboBox.TabIndex = 18;
            this.filterAppointmentsByCustomerComboBox.Text = "Select customer";
            this.filterAppointmentsByCustomerComboBox.Visible = false;
            this.filterAppointmentsByCustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.filterAppointmentsByCustomerComboBox_SelectedIndexChanged);
            // 
            // filterAppointmentsByCustomerLabel
            // 
            this.filterAppointmentsByCustomerLabel.AutoSize = true;
            this.filterAppointmentsByCustomerLabel.Location = new System.Drawing.Point(620, 393);
            this.filterAppointmentsByCustomerLabel.Name = "filterAppointmentsByCustomerLabel";
            this.filterAppointmentsByCustomerLabel.Size = new System.Drawing.Size(235, 21);
            this.filterAppointmentsByCustomerLabel.TabIndex = 19;
            this.filterAppointmentsByCustomerLabel.Text = "Filter appointments by customer";
            this.filterAppointmentsByCustomerLabel.Visible = false;
            // 
            // reportsLabel
            // 
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Location = new System.Drawing.Point(155, 393);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(64, 21);
            this.reportsLabel.TabIndex = 20;
            this.reportsLabel.Text = "Reports";
            // 
            // customersWithAppointmentsBtn
            // 
            this.customersWithAppointmentsBtn.AutoSize = true;
            this.customersWithAppointmentsBtn.Location = new System.Drawing.Point(12, 454);
            this.customersWithAppointmentsBtn.Name = "customersWithAppointmentsBtn";
            this.customersWithAppointmentsBtn.Size = new System.Drawing.Size(334, 31);
            this.customersWithAppointmentsBtn.TabIndex = 21;
            this.customersWithAppointmentsBtn.Text = "Your customers who have an appointment";
            this.customersWithAppointmentsBtn.UseVisualStyleBackColor = true;
            this.customersWithAppointmentsBtn.Click += new System.EventHandler(this.customersWithAppointmentsBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.AutoSize = true;
            this.scheduleBtn.Location = new System.Drawing.Point(12, 491);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(334, 31);
            this.scheduleBtn.TabIndex = 22;
            this.scheduleBtn.Text = "Schedules for each consultant";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // appointmentsByMonthBtn
            // 
            this.appointmentsByMonthBtn.AutoSize = true;
            this.appointmentsByMonthBtn.Location = new System.Drawing.Point(12, 417);
            this.appointmentsByMonthBtn.Name = "appointmentsByMonthBtn";
            this.appointmentsByMonthBtn.Size = new System.Drawing.Size(334, 31);
            this.appointmentsByMonthBtn.TabIndex = 23;
            this.appointmentsByMonthBtn.Text = "Your number of appointment types by month";
            this.appointmentsByMonthBtn.UseVisualStyleBackColor = true;
            this.appointmentsByMonthBtn.Click += new System.EventHandler(this.appointmentsByMonthBtn_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(352, 334);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(252, 256);
            this.txtReport.TabIndex = 25;
            this.txtReport.Text = "";
            // 
            // searchAppointmentsByCustomerBtn
            // 
            this.searchAppointmentsByCustomerBtn.AutoSize = true;
            this.searchAppointmentsByCustomerBtn.Location = new System.Drawing.Point(882, 45);
            this.searchAppointmentsByCustomerBtn.Name = "searchAppointmentsByCustomerBtn";
            this.searchAppointmentsByCustomerBtn.Size = new System.Drawing.Size(334, 31);
            this.searchAppointmentsByCustomerBtn.TabIndex = 26;
            this.searchAppointmentsByCustomerBtn.Text = "Search Appointments By Selected Customer";
            this.searchAppointmentsByCustomerBtn.UseVisualStyleBackColor = true;
            this.searchAppointmentsByCustomerBtn.Click += new System.EventHandler(this.searchAppointmentsByCustomerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 602);
            this.Controls.Add(this.searchAppointmentsByCustomerBtn);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.appointmentsByMonthBtn);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.customersWithAppointmentsBtn);
            this.Controls.Add(this.reportsLabel);
            this.Controls.Add(this.filterAppointmentsByCustomerLabel);
            this.Controls.Add(this.filterAppointmentsByCustomerComboBox);
            this.Controls.Add(this.mainFormExitBtn);
            this.Controls.Add(this.appointmentDeleteBtn);
            this.Controls.Add(this.appointmentUpdateBtn);
            this.Controls.Add(this.appointmentAddBtn);
            this.Controls.Add(this.monthRadioBtn);
            this.Controls.Add(this.mainFormCalendar);
            this.Controls.Add(this.appointmentDgv);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.weekRadioBtn);
            this.Controls.Add(this.dayRadioBtn);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerDeleteBtn);
            this.Controls.Add(this.appointmentDgvLabel);
            this.Controls.Add(this.customerDgvLabel);
            this.Controls.Add(this.customerDgv);
            this.Controls.Add(this.mainFormTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06rPSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainFormTitleLabel;
        private System.Windows.Forms.DataGridView customerDgv;
        private System.Windows.Forms.Label customerDgvLabel;
        private System.Windows.Forms.Label appointmentDgvLabel;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button appointmentDeleteBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Button appointmentUpdateBtn;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Button appointmentAddBtn;
        private System.Windows.Forms.MonthCalendar mainFormCalendar;
        private System.Windows.Forms.RadioButton dayRadioBtn;
        private System.Windows.Forms.RadioButton weekRadioBtn;
        private System.Windows.Forms.RadioButton monthRadioBtn;
        private System.Windows.Forms.DataGridView appointmentDgv;
        private U06rPSDataSet u06rPSDataSet;
        private System.Windows.Forms.Button mainFormExitBtn;
        private System.Windows.Forms.ComboBox filterAppointmentsByCustomerComboBox;
        private System.Windows.Forms.Label filterAppointmentsByCustomerLabel;
        private System.Windows.Forms.Label reportsLabel;
        private System.Windows.Forms.Button customersWithAppointmentsBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button appointmentsByMonthBtn;
        private System.Windows.Forms.RichTextBox txtReport;
        private System.Windows.Forms.Button searchAppointmentsByCustomerBtn;
    }
}