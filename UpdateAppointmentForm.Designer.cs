namespace John_Davis_Appointment_App
{
    partial class UpdateAppointmentForm
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
            this.updateAppointmentCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.updateAppointmentCancelBtn = new System.Windows.Forms.Button();
            this.updateAppointmentSaveBtn = new System.Windows.Forms.Button();
            this.updateAppointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.updateAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.updateAppointmentLabel = new System.Windows.Forms.Label();
            this.updateAppointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.updateAppointmentIdLabel = new System.Windows.Forms.Label();
            this.updateAppointmentCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.updateAppointmentCustomerIdLabel = new System.Windows.Forms.Label();
            this.updateAppointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateAppointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateAppointmentStartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateAppointmentEndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateAppointmentStartDateLabel = new System.Windows.Forms.Label();
            this.updateAppointmentEndDateLabel = new System.Windows.Forms.Label();
            this.updateAppointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.updateAppointmentEndTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateAppointmentCustomerNameComboBox
            // 
            this.updateAppointmentCustomerNameComboBox.FormattingEnabled = true;
            this.updateAppointmentCustomerNameComboBox.Location = new System.Drawing.Point(17, 68);
            this.updateAppointmentCustomerNameComboBox.Name = "updateAppointmentCustomerNameComboBox";
            this.updateAppointmentCustomerNameComboBox.Size = new System.Drawing.Size(411, 29);
            this.updateAppointmentCustomerNameComboBox.TabIndex = 11;
            this.updateAppointmentCustomerNameComboBox.Text = "Select customer";
            this.updateAppointmentCustomerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.updateAppointmentCustomerNameComboBox_SelectedIndexChanged);
            // 
            // updateAppointmentCancelBtn
            // 
            this.updateAppointmentCancelBtn.AutoSize = true;
            this.updateAppointmentCancelBtn.Location = new System.Drawing.Point(98, 292);
            this.updateAppointmentCancelBtn.Name = "updateAppointmentCancelBtn";
            this.updateAppointmentCancelBtn.Size = new System.Drawing.Size(75, 31);
            this.updateAppointmentCancelBtn.TabIndex = 19;
            this.updateAppointmentCancelBtn.Text = "Cancel";
            this.updateAppointmentCancelBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentCancelBtn.Click += new System.EventHandler(this.updateAppointmentCancelBtn_Click);
            // 
            // updateAppointmentSaveBtn
            // 
            this.updateAppointmentSaveBtn.AutoSize = true;
            this.updateAppointmentSaveBtn.Location = new System.Drawing.Point(17, 292);
            this.updateAppointmentSaveBtn.Name = "updateAppointmentSaveBtn";
            this.updateAppointmentSaveBtn.Size = new System.Drawing.Size(75, 31);
            this.updateAppointmentSaveBtn.TabIndex = 18;
            this.updateAppointmentSaveBtn.Text = "Save";
            this.updateAppointmentSaveBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentSaveBtn.Click += new System.EventHandler(this.updateAppointmentSaveBtn_Click);
            // 
            // updateAppointmentTypeTextBox
            // 
            this.updateAppointmentTypeTextBox.Location = new System.Drawing.Point(17, 124);
            this.updateAppointmentTypeTextBox.Name = "updateAppointmentTypeTextBox";
            this.updateAppointmentTypeTextBox.Size = new System.Drawing.Size(413, 29);
            this.updateAppointmentTypeTextBox.TabIndex = 13;
            this.updateAppointmentTypeTextBox.TextChanged += new System.EventHandler(this.updateAppointmentTypeTextBox_TextChanged);
            // 
            // updateAppointmentTypeLabel
            // 
            this.updateAppointmentTypeLabel.AutoSize = true;
            this.updateAppointmentTypeLabel.Location = new System.Drawing.Point(13, 100);
            this.updateAppointmentTypeLabel.Name = "updateAppointmentTypeLabel";
            this.updateAppointmentTypeLabel.Size = new System.Drawing.Size(135, 21);
            this.updateAppointmentTypeLabel.TabIndex = 12;
            this.updateAppointmentTypeLabel.Text = "Appointment type";
            // 
            // updateAppointmentLabel
            // 
            this.updateAppointmentLabel.AutoSize = true;
            this.updateAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.updateAppointmentLabel.Name = "updateAppointmentLabel";
            this.updateAppointmentLabel.Size = new System.Drawing.Size(217, 30);
            this.updateAppointmentLabel.TabIndex = 10;
            this.updateAppointmentLabel.Text = "Update Appointment";
            // 
            // updateAppointmentIdTextBox
            // 
            this.updateAppointmentIdTextBox.Location = new System.Drawing.Point(179, 294);
            this.updateAppointmentIdTextBox.Name = "updateAppointmentIdTextBox";
            this.updateAppointmentIdTextBox.ReadOnly = true;
            this.updateAppointmentIdTextBox.Size = new System.Drawing.Size(71, 29);
            this.updateAppointmentIdTextBox.TabIndex = 21;
            this.updateAppointmentIdTextBox.Visible = false;
            // 
            // updateAppointmentIdLabel
            // 
            this.updateAppointmentIdLabel.AutoSize = true;
            this.updateAppointmentIdLabel.Location = new System.Drawing.Point(175, 270);
            this.updateAppointmentIdLabel.Name = "updateAppointmentIdLabel";
            this.updateAppointmentIdLabel.Size = new System.Drawing.Size(114, 21);
            this.updateAppointmentIdLabel.TabIndex = 28;
            this.updateAppointmentIdLabel.Text = "AppointmentId";
            this.updateAppointmentIdLabel.Visible = false;
            // 
            // updateAppointmentCustomerIdTextBox
            // 
            this.updateAppointmentCustomerIdTextBox.Location = new System.Drawing.Point(299, 294);
            this.updateAppointmentCustomerIdTextBox.Name = "updateAppointmentCustomerIdTextBox";
            this.updateAppointmentCustomerIdTextBox.ReadOnly = true;
            this.updateAppointmentCustomerIdTextBox.Size = new System.Drawing.Size(71, 29);
            this.updateAppointmentCustomerIdTextBox.TabIndex = 29;
            this.updateAppointmentCustomerIdTextBox.Visible = false;
            // 
            // updateAppointmentCustomerIdLabel
            // 
            this.updateAppointmentCustomerIdLabel.AutoSize = true;
            this.updateAppointmentCustomerIdLabel.Location = new System.Drawing.Point(295, 270);
            this.updateAppointmentCustomerIdLabel.Name = "updateAppointmentCustomerIdLabel";
            this.updateAppointmentCustomerIdLabel.Size = new System.Drawing.Size(91, 21);
            this.updateAppointmentCustomerIdLabel.TabIndex = 30;
            this.updateAppointmentCustomerIdLabel.Text = "CustomerId";
            this.updateAppointmentCustomerIdLabel.Visible = false;
            // 
            // updateAppointmentStartDateDateTimePicker
            // 
            this.updateAppointmentStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateAppointmentStartDateDateTimePicker.Location = new System.Drawing.Point(17, 180);
            this.updateAppointmentStartDateDateTimePicker.Name = "updateAppointmentStartDateDateTimePicker";
            this.updateAppointmentStartDateDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.updateAppointmentStartDateDateTimePicker.TabIndex = 31;
            // 
            // updateAppointmentEndDateDateTimePicker
            // 
            this.updateAppointmentEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateAppointmentEndDateDateTimePicker.Location = new System.Drawing.Point(17, 236);
            this.updateAppointmentEndDateDateTimePicker.Name = "updateAppointmentEndDateDateTimePicker";
            this.updateAppointmentEndDateDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.updateAppointmentEndDateDateTimePicker.TabIndex = 32;
            // 
            // updateAppointmentStartTimeDateTimePicker
            // 
            this.updateAppointmentStartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updateAppointmentStartTimeDateTimePicker.Location = new System.Drawing.Point(204, 180);
            this.updateAppointmentStartTimeDateTimePicker.Name = "updateAppointmentStartTimeDateTimePicker";
            this.updateAppointmentStartTimeDateTimePicker.ShowUpDown = true;
            this.updateAppointmentStartTimeDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.updateAppointmentStartTimeDateTimePicker.TabIndex = 33;
            // 
            // updateAppointmentEndTimeDateTimePicker
            // 
            this.updateAppointmentEndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updateAppointmentEndTimeDateTimePicker.Location = new System.Drawing.Point(204, 236);
            this.updateAppointmentEndTimeDateTimePicker.Name = "updateAppointmentEndTimeDateTimePicker";
            this.updateAppointmentEndTimeDateTimePicker.ShowUpDown = true;
            this.updateAppointmentEndTimeDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.updateAppointmentEndTimeDateTimePicker.TabIndex = 34;
            // 
            // updateAppointmentStartDateLabel
            // 
            this.updateAppointmentStartDateLabel.AutoSize = true;
            this.updateAppointmentStartDateLabel.Location = new System.Drawing.Point(13, 156);
            this.updateAppointmentStartDateLabel.Name = "updateAppointmentStartDateLabel";
            this.updateAppointmentStartDateLabel.Size = new System.Drawing.Size(76, 21);
            this.updateAppointmentStartDateLabel.TabIndex = 35;
            this.updateAppointmentStartDateLabel.Text = "Start date";
            // 
            // updateAppointmentEndDateLabel
            // 
            this.updateAppointmentEndDateLabel.AutoSize = true;
            this.updateAppointmentEndDateLabel.Location = new System.Drawing.Point(13, 212);
            this.updateAppointmentEndDateLabel.Name = "updateAppointmentEndDateLabel";
            this.updateAppointmentEndDateLabel.Size = new System.Drawing.Size(70, 21);
            this.updateAppointmentEndDateLabel.TabIndex = 36;
            this.updateAppointmentEndDateLabel.Text = "End date";
            // 
            // updateAppointmentStartTimeLabel
            // 
            this.updateAppointmentStartTimeLabel.AutoSize = true;
            this.updateAppointmentStartTimeLabel.Location = new System.Drawing.Point(200, 156);
            this.updateAppointmentStartTimeLabel.Name = "updateAppointmentStartTimeLabel";
            this.updateAppointmentStartTimeLabel.Size = new System.Drawing.Size(77, 21);
            this.updateAppointmentStartTimeLabel.TabIndex = 37;
            this.updateAppointmentStartTimeLabel.Text = "Start time";
            // 
            // updateAppointmentEndTimeLabel
            // 
            this.updateAppointmentEndTimeLabel.AutoSize = true;
            this.updateAppointmentEndTimeLabel.Location = new System.Drawing.Point(200, 212);
            this.updateAppointmentEndTimeLabel.Name = "updateAppointmentEndTimeLabel";
            this.updateAppointmentEndTimeLabel.Size = new System.Drawing.Size(71, 21);
            this.updateAppointmentEndTimeLabel.TabIndex = 38;
            this.updateAppointmentEndTimeLabel.Text = "End time";
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.updateAppointmentEndTimeLabel);
            this.Controls.Add(this.updateAppointmentStartTimeLabel);
            this.Controls.Add(this.updateAppointmentEndDateLabel);
            this.Controls.Add(this.updateAppointmentStartDateLabel);
            this.Controls.Add(this.updateAppointmentEndTimeDateTimePicker);
            this.Controls.Add(this.updateAppointmentStartTimeDateTimePicker);
            this.Controls.Add(this.updateAppointmentEndDateDateTimePicker);
            this.Controls.Add(this.updateAppointmentStartDateDateTimePicker);
            this.Controls.Add(this.updateAppointmentCustomerIdLabel);
            this.Controls.Add(this.updateAppointmentCustomerIdTextBox);
            this.Controls.Add(this.updateAppointmentIdLabel);
            this.Controls.Add(this.updateAppointmentIdTextBox);
            this.Controls.Add(this.updateAppointmentCustomerNameComboBox);
            this.Controls.Add(this.updateAppointmentCancelBtn);
            this.Controls.Add(this.updateAppointmentSaveBtn);
            this.Controls.Add(this.updateAppointmentTypeTextBox);
            this.Controls.Add(this.updateAppointmentTypeLabel);
            this.Controls.Add(this.updateAppointmentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "UpdateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox updateAppointmentCustomerNameComboBox;
        private System.Windows.Forms.Button updateAppointmentCancelBtn;
        private System.Windows.Forms.Button updateAppointmentSaveBtn;
        private System.Windows.Forms.TextBox updateAppointmentTypeTextBox;
        private System.Windows.Forms.Label updateAppointmentTypeLabel;
        private System.Windows.Forms.Label updateAppointmentLabel;
        public System.Windows.Forms.TextBox updateAppointmentIdTextBox;
        private System.Windows.Forms.Label updateAppointmentIdLabel;
        public System.Windows.Forms.TextBox updateAppointmentCustomerIdTextBox;
        private System.Windows.Forms.Label updateAppointmentCustomerIdLabel;
        private System.Windows.Forms.DateTimePicker updateAppointmentStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateAppointmentEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateAppointmentStartTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateAppointmentEndTimeDateTimePicker;
        private System.Windows.Forms.Label updateAppointmentStartDateLabel;
        private System.Windows.Forms.Label updateAppointmentEndDateLabel;
        private System.Windows.Forms.Label updateAppointmentStartTimeLabel;
        private System.Windows.Forms.Label updateAppointmentEndTimeLabel;
    }
}