namespace TaskDepartmentsEmployees
{
    partial class EmployeeForm
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
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocSeries = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewUpdate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dropDownDepartments = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblPatronymicError = new System.Windows.Forms.Label();
            this.lblDateOfBirthError = new System.Windows.Forms.Label();
            this.lblDocSeriesError = new System.Windows.Forms.Label();
            this.lblDocNumberError = new System.Windows.Forms.Label();
            this.lblPositionError = new System.Windows.Forms.Label();
            this.lblDateOfBithError = new System.Windows.Forms.Label();
            this.lblFirstNameRequired = new System.Windows.Forms.Label();
            this.lblLastNameRequired = new System.Windows.Forms.Label();
            this.lblPositionRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(179, 366);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(163, 20);
            this.txtPosition.TabIndex = 26;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Должность";
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(179, 313);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(163, 20);
            this.txtDocNumber.TabIndex = 24;
            this.txtDocNumber.TextChanged += new System.EventHandler(this.txtDocNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер Документа";
            // 
            // txtDocSeries
            // 
            this.txtDocSeries.Location = new System.Drawing.Point(179, 262);
            this.txtDocSeries.Name = "txtDocSeries";
            this.txtDocSeries.Size = new System.Drawing.Size(163, 20);
            this.txtDocSeries.TabIndex = 22;
            this.txtDocSeries.TextChanged += new System.EventHandler(this.txtDocSeries_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Серия Документа";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(179, 155);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(163, 20);
            this.txtPatronymic.TabIndex = 20;
            this.txtPatronymic.TextChanged += new System.EventHandler(this.txtPatronymic_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Отчество";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(179, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 20);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(179, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 20);
            this.txtFirstName.TabIndex = 16;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя";
            // 
            // lblNewUpdate
            // 
            this.lblNewUpdate.AutoSize = true;
            this.lblNewUpdate.Location = new System.Drawing.Point(164, 9);
            this.lblNewUpdate.Name = "lblNewUpdate";
            this.lblNewUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNewUpdate.TabIndex = 14;
            this.lblNewUpdate.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Дата Рождения";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(179, 206);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 30;
            this.dtpDateOfBirth.DropDown += new System.EventHandler(this.dtpDateOfBirth_DropDown);
            // 
            // dropDownDepartments
            // 
            this.dropDownDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDepartments.FormattingEnabled = true;
            this.dropDownDepartments.Location = new System.Drawing.Point(179, 425);
            this.dropDownDepartments.Name = "dropDownDepartments";
            this.dropDownDepartments.Size = new System.Drawing.Size(195, 21);
            this.dropDownDepartments.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Отдел";
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.Location = new System.Drawing.Point(179, 70);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameError.TabIndex = 33;
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Location = new System.Drawing.Point(179, 126);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameError.TabIndex = 34;
            // 
            // lblPatronymicError
            // 
            this.lblPatronymicError.AutoSize = true;
            this.lblPatronymicError.Location = new System.Drawing.Point(176, 178);
            this.lblPatronymicError.Name = "lblPatronymicError";
            this.lblPatronymicError.Size = new System.Drawing.Size(0, 13);
            this.lblPatronymicError.TabIndex = 35;
            // 
            // lblDateOfBirthError
            // 
            this.lblDateOfBirthError.AutoSize = true;
            this.lblDateOfBirthError.Location = new System.Drawing.Point(179, 229);
            this.lblDateOfBirthError.Name = "lblDateOfBirthError";
            this.lblDateOfBirthError.Size = new System.Drawing.Size(0, 13);
            this.lblDateOfBirthError.TabIndex = 36;
            // 
            // lblDocSeriesError
            // 
            this.lblDocSeriesError.AutoSize = true;
            this.lblDocSeriesError.Location = new System.Drawing.Point(179, 285);
            this.lblDocSeriesError.Name = "lblDocSeriesError";
            this.lblDocSeriesError.Size = new System.Drawing.Size(0, 13);
            this.lblDocSeriesError.TabIndex = 37;
            // 
            // lblDocNumberError
            // 
            this.lblDocNumberError.AutoSize = true;
            this.lblDocNumberError.Location = new System.Drawing.Point(179, 336);
            this.lblDocNumberError.Name = "lblDocNumberError";
            this.lblDocNumberError.Size = new System.Drawing.Size(0, 13);
            this.lblDocNumberError.TabIndex = 38;
            // 
            // lblPositionError
            // 
            this.lblPositionError.AutoSize = true;
            this.lblPositionError.Location = new System.Drawing.Point(179, 393);
            this.lblPositionError.Name = "lblPositionError";
            this.lblPositionError.Size = new System.Drawing.Size(0, 13);
            this.lblPositionError.TabIndex = 39;
            // 
            // lblDateOfBithError
            // 
            this.lblDateOfBithError.AutoSize = true;
            this.lblDateOfBithError.Location = new System.Drawing.Point(179, 229);
            this.lblDateOfBithError.Name = "lblDateOfBithError";
            this.lblDateOfBithError.Size = new System.Drawing.Size(0, 13);
            this.lblDateOfBithError.TabIndex = 40;
            // 
            // lblFirstNameRequired
            // 
            this.lblFirstNameRequired.AutoSize = true;
            this.lblFirstNameRequired.Location = new System.Drawing.Point(349, 53);
            this.lblFirstNameRequired.Name = "lblFirstNameRequired";
            this.lblFirstNameRequired.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameRequired.TabIndex = 41;
            // 
            // lblLastNameRequired
            // 
            this.lblLastNameRequired.AutoSize = true;
            this.lblLastNameRequired.Location = new System.Drawing.Point(349, 112);
            this.lblLastNameRequired.Name = "lblLastNameRequired";
            this.lblLastNameRequired.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameRequired.TabIndex = 42;
            // 
            // lblPositionRequired
            // 
            this.lblPositionRequired.AutoSize = true;
            this.lblPositionRequired.Location = new System.Drawing.Point(349, 366);
            this.lblPositionRequired.Name = "lblPositionRequired";
            this.lblPositionRequired.Size = new System.Drawing.Size(0, 13);
            this.lblPositionRequired.TabIndex = 43;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 579);
            this.Controls.Add(this.lblPositionRequired);
            this.Controls.Add(this.lblLastNameRequired);
            this.Controls.Add(this.lblFirstNameRequired);
            this.Controls.Add(this.lblDateOfBithError);
            this.Controls.Add(this.lblPositionError);
            this.Controls.Add(this.lblDocNumberError);
            this.Controls.Add(this.lblDocSeriesError);
            this.Controls.Add(this.lblDateOfBirthError);
            this.Controls.Add(this.lblPatronymicError);
            this.Controls.Add(this.lblLastNameError);
            this.Controls.Add(this.lblFirstNameError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dropDownDepartments);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocSeries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewUpdate);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocSeries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox dropDownDepartments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblPatronymicError;
        private System.Windows.Forms.Label lblDateOfBirthError;
        private System.Windows.Forms.Label lblDocSeriesError;
        private System.Windows.Forms.Label lblDocNumberError;
        private System.Windows.Forms.Label lblPositionError;
        private System.Windows.Forms.Label lblDateOfBithError;
        private System.Windows.Forms.Label lblFirstNameRequired;
        private System.Windows.Forms.Label lblLastNameRequired;
        private System.Windows.Forms.Label lblPositionRequired;
    }
}