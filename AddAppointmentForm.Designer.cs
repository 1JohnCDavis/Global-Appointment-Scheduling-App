namespace John_Davis_Appointment_App
{
    partial class AddAppointmentForm
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
            this.addAppointmentCancelBtn = new System.Windows.Forms.Button();
            this.addAppointmentSaveBtn = new System.Windows.Forms.Button();
            this.addAppointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.addAppointmentStartDateLabel = new System.Windows.Forms.Label();
            this.addAppointmentEndDateLabel = new System.Windows.Forms.Label();
            this.addAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.addAppointmentLabel = new System.Windows.Forms.Label();
            this.addAppointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.addAppointmentCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.addAppointmentCustomerIdLabel = new System.Windows.Forms.Label();
            this.u06rPSDataSet = new John_Davis_Appointment_App.U06rPSDataSet();
            this.addAppointmentStartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.addAppointmentEndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentEndTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.u06rPSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addAppointmentCancelBtn
            // 
            this.addAppointmentCancelBtn.AutoSize = true;
            this.addAppointmentCancelBtn.Location = new System.Drawing.Point(98, 292);
            this.addAppointmentCancelBtn.Name = "addAppointmentCancelBtn";
            this.addAppointmentCancelBtn.Size = new System.Drawing.Size(75, 31);
            this.addAppointmentCancelBtn.TabIndex = 9;
            this.addAppointmentCancelBtn.Text = "Cancel";
            this.addAppointmentCancelBtn.UseVisualStyleBackColor = true;
            this.addAppointmentCancelBtn.Click += new System.EventHandler(this.addAppointmentCancelBtn_Click);
            // 
            // addAppointmentSaveBtn
            // 
            this.addAppointmentSaveBtn.AutoSize = true;
            this.addAppointmentSaveBtn.Location = new System.Drawing.Point(17, 292);
            this.addAppointmentSaveBtn.Name = "addAppointmentSaveBtn";
            this.addAppointmentSaveBtn.Size = new System.Drawing.Size(75, 31);
            this.addAppointmentSaveBtn.TabIndex = 8;
            this.addAppointmentSaveBtn.Text = "Save";
            this.addAppointmentSaveBtn.UseVisualStyleBackColor = true;
            this.addAppointmentSaveBtn.Click += new System.EventHandler(this.addAppointmentSaveBtn_Click);
            // 
            // addAppointmentTypeTextBox
            // 
            this.addAppointmentTypeTextBox.Location = new System.Drawing.Point(17, 124);
            this.addAppointmentTypeTextBox.Name = "addAppointmentTypeTextBox";
            this.addAppointmentTypeTextBox.Size = new System.Drawing.Size(413, 29);
            this.addAppointmentTypeTextBox.TabIndex = 3;
            this.addAppointmentTypeTextBox.TextChanged += new System.EventHandler(this.addAppointmentTypeTextBox_TextChanged);
            // 
            // addAppointmentStartDateLabel
            // 
            this.addAppointmentStartDateLabel.AutoSize = true;
            this.addAppointmentStartDateLabel.Location = new System.Drawing.Point(13, 156);
            this.addAppointmentStartDateLabel.Name = "addAppointmentStartDateLabel";
            this.addAppointmentStartDateLabel.Size = new System.Drawing.Size(76, 21);
            this.addAppointmentStartDateLabel.TabIndex = 4;
            this.addAppointmentStartDateLabel.Text = "Start date";
            // 
            // addAppointmentEndDateLabel
            // 
            this.addAppointmentEndDateLabel.AutoSize = true;
            this.addAppointmentEndDateLabel.Location = new System.Drawing.Point(13, 212);
            this.addAppointmentEndDateLabel.Name = "addAppointmentEndDateLabel";
            this.addAppointmentEndDateLabel.Size = new System.Drawing.Size(70, 21);
            this.addAppointmentEndDateLabel.TabIndex = 6;
            this.addAppointmentEndDateLabel.Text = "End date";
            // 
            // addAppointmentTypeLabel
            // 
            this.addAppointmentTypeLabel.AutoSize = true;
            this.addAppointmentTypeLabel.Location = new System.Drawing.Point(13, 100);
            this.addAppointmentTypeLabel.Name = "addAppointmentTypeLabel";
            this.addAppointmentTypeLabel.Size = new System.Drawing.Size(135, 21);
            this.addAppointmentTypeLabel.TabIndex = 2;
            this.addAppointmentTypeLabel.Text = "Appointment type";
            // 
            // addAppointmentLabel
            // 
            this.addAppointmentLabel.AutoSize = true;
            this.addAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.addAppointmentLabel.Name = "addAppointmentLabel";
            this.addAppointmentLabel.Size = new System.Drawing.Size(186, 30);
            this.addAppointmentLabel.TabIndex = 0;
            this.addAppointmentLabel.Text = "Add Appointment";
            // 
            // addAppointmentEndDateDateTimePicker
            // 
            this.addAppointmentEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addAppointmentEndDateDateTimePicker.Location = new System.Drawing.Point(17, 236);
            this.addAppointmentEndDateDateTimePicker.Name = "addAppointmentEndDateDateTimePicker";
            this.addAppointmentEndDateDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.addAppointmentEndDateDateTimePicker.TabIndex = 7;
            // 
            // addAppointmentStartDateDateTimePicker
            // 
            this.addAppointmentStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addAppointmentStartDateDateTimePicker.Location = new System.Drawing.Point(17, 180);
            this.addAppointmentStartDateDateTimePicker.Name = "addAppointmentStartDateDateTimePicker";
            this.addAppointmentStartDateDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.addAppointmentStartDateDateTimePicker.TabIndex = 5;
            // 
            // addAppointmentCustomerNameComboBox
            // 
            this.addAppointmentCustomerNameComboBox.FormattingEnabled = true;
            this.addAppointmentCustomerNameComboBox.Location = new System.Drawing.Point(17, 68);
            this.addAppointmentCustomerNameComboBox.Name = "addAppointmentCustomerNameComboBox";
            this.addAppointmentCustomerNameComboBox.Size = new System.Drawing.Size(411, 29);
            this.addAppointmentCustomerNameComboBox.TabIndex = 1;
            this.addAppointmentCustomerNameComboBox.Text = "Select customer";
            this.addAppointmentCustomerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.addAppointmentCustomerNameComboBox_SelectedIndexChanged);
            // 
            // addAppointmentCustomerIdTextBox
            // 
            this.addAppointmentCustomerIdTextBox.Location = new System.Drawing.Point(299, 294);
            this.addAppointmentCustomerIdTextBox.Name = "addAppointmentCustomerIdTextBox";
            this.addAppointmentCustomerIdTextBox.ReadOnly = true;
            this.addAppointmentCustomerIdTextBox.Size = new System.Drawing.Size(71, 29);
            this.addAppointmentCustomerIdTextBox.TabIndex = 19;
            this.addAppointmentCustomerIdTextBox.Visible = false;
            // 
            // addAppointmentCustomerIdLabel
            // 
            this.addAppointmentCustomerIdLabel.AutoSize = true;
            this.addAppointmentCustomerIdLabel.Location = new System.Drawing.Point(295, 270);
            this.addAppointmentCustomerIdLabel.Name = "addAppointmentCustomerIdLabel";
            this.addAppointmentCustomerIdLabel.Size = new System.Drawing.Size(91, 21);
            this.addAppointmentCustomerIdLabel.TabIndex = 26;
            this.addAppointmentCustomerIdLabel.Text = "CustomerId";
            this.addAppointmentCustomerIdLabel.Visible = false;
            // 
            // u06rPSDataSet
            // 
            this.u06rPSDataSet.DataSetName = "U06rPSDataSet";
            this.u06rPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addAppointmentStartTimeDateTimePicker
            // 
            this.addAppointmentStartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addAppointmentStartTimeDateTimePicker.Location = new System.Drawing.Point(204, 180);
            this.addAppointmentStartTimeDateTimePicker.Name = "addAppointmentStartTimeDateTimePicker";
            this.addAppointmentStartTimeDateTimePicker.ShowUpDown = true;
            this.addAppointmentStartTimeDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.addAppointmentStartTimeDateTimePicker.TabIndex = 27;
            // 
            // addAppointmentStartTimeLabel
            // 
            this.addAppointmentStartTimeLabel.AutoSize = true;
            this.addAppointmentStartTimeLabel.Location = new System.Drawing.Point(200, 156);
            this.addAppointmentStartTimeLabel.Name = "addAppointmentStartTimeLabel";
            this.addAppointmentStartTimeLabel.Size = new System.Drawing.Size(77, 21);
            this.addAppointmentStartTimeLabel.TabIndex = 28;
            this.addAppointmentStartTimeLabel.Text = "Start time";
            // 
            // addAppointmentEndTimeDateTimePicker
            // 
            this.addAppointmentEndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addAppointmentEndTimeDateTimePicker.Location = new System.Drawing.Point(204, 236);
            this.addAppointmentEndTimeDateTimePicker.Name = "addAppointmentEndTimeDateTimePicker";
            this.addAppointmentEndTimeDateTimePicker.ShowUpDown = true;
            this.addAppointmentEndTimeDateTimePicker.Size = new System.Drawing.Size(181, 29);
            this.addAppointmentEndTimeDateTimePicker.TabIndex = 29;
            // 
            // addAppointmentEndTimeLabel
            // 
            this.addAppointmentEndTimeLabel.AutoSize = true;
            this.addAppointmentEndTimeLabel.Location = new System.Drawing.Point(200, 212);
            this.addAppointmentEndTimeLabel.Name = "addAppointmentEndTimeLabel";
            this.addAppointmentEndTimeLabel.Size = new System.Drawing.Size(71, 21);
            this.addAppointmentEndTimeLabel.TabIndex = 30;
            this.addAppointmentEndTimeLabel.Text = "End time";
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.addAppointmentEndTimeLabel);
            this.Controls.Add(this.addAppointmentEndTimeDateTimePicker);
            this.Controls.Add(this.addAppointmentStartTimeLabel);
            this.Controls.Add(this.addAppointmentStartTimeDateTimePicker);
            this.Controls.Add(this.addAppointmentCustomerIdLabel);
            this.Controls.Add(this.addAppointmentCustomerIdTextBox);
            this.Controls.Add(this.addAppointmentCustomerNameComboBox);
            this.Controls.Add(this.addAppointmentStartDateDateTimePicker);
            this.Controls.Add(this.addAppointmentEndDateDateTimePicker);
            this.Controls.Add(this.addAppointmentCancelBtn);
            this.Controls.Add(this.addAppointmentSaveBtn);
            this.Controls.Add(this.addAppointmentTypeTextBox);
            this.Controls.Add(this.addAppointmentStartDateLabel);
            this.Controls.Add(this.addAppointmentEndDateLabel);
            this.Controls.Add(this.addAppointmentTypeLabel);
            this.Controls.Add(this.addAppointmentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.u06rPSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAppointmentCancelBtn;
        private System.Windows.Forms.Button addAppointmentSaveBtn;
        private System.Windows.Forms.TextBox addAppointmentTypeTextBox;
        private System.Windows.Forms.Label addAppointmentStartDateLabel;
        private System.Windows.Forms.Label addAppointmentEndDateLabel;
        private System.Windows.Forms.Label addAppointmentTypeLabel;
        private System.Windows.Forms.Label addAppointmentLabel;
        private System.Windows.Forms.DateTimePicker addAppointmentEndDateDateTimePicker;
        private System.Windows.Forms.ComboBox addAppointmentCustomerNameComboBox;
        public System.Windows.Forms.TextBox addAppointmentCustomerIdTextBox;
        private System.Windows.Forms.Label addAppointmentCustomerIdLabel;
        private U06rPSDataSet u06rPSDataSet;
        private System.Windows.Forms.Label addAppointmentStartTimeLabel;
        private System.Windows.Forms.DateTimePicker addAppointmentEndTimeDateTimePicker;
        private System.Windows.Forms.Label addAppointmentEndTimeLabel;
        private System.Windows.Forms.DateTimePicker addAppointmentStartTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker addAppointmentStartDateDateTimePicker;
    }
}