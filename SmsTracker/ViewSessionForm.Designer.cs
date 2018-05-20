namespace SmsTracker
{
    partial class viewSessionForm
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
            this.updateSessionButton = new System.Windows.Forms.Button();
            this.clientFullNameTextBox = new System.Windows.Forms.TextBox();
            this.clientFullNameLabel = new System.Windows.Forms.Label();
            this.viewSessionLabel = new System.Windows.Forms.Label();
            this.sessionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.paymentReceivedPanel = new System.Windows.Forms.Panel();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentReceivedLabel = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.sessionTypeLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentReceivedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateSessionButton
            // 
            this.updateSessionButton.BackColor = System.Drawing.Color.White;
            this.updateSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSessionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.updateSessionButton.Location = new System.Drawing.Point(39, 538);
            this.updateSessionButton.Name = "updateSessionButton";
            this.updateSessionButton.Size = new System.Drawing.Size(493, 40);
            this.updateSessionButton.TabIndex = 27;
            this.updateSessionButton.Text = "Update Session Info and Return";
            this.updateSessionButton.UseVisualStyleBackColor = false;
            this.updateSessionButton.Click += new System.EventHandler(this.UpdateSessionButton_Click);
            // 
            // clientFullNameTextBox
            // 
            this.clientFullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFullNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.clientFullNameTextBox.Location = new System.Drawing.Point(235, 97);
            this.clientFullNameTextBox.Name = "clientFullNameTextBox";
            this.clientFullNameTextBox.ReadOnly = true;
            this.clientFullNameTextBox.Size = new System.Drawing.Size(297, 35);
            this.clientFullNameTextBox.TabIndex = 26;
            // 
            // clientFullNameLabel
            // 
            this.clientFullNameLabel.AutoSize = true;
            this.clientFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.clientFullNameLabel.Location = new System.Drawing.Point(28, 100);
            this.clientFullNameLabel.Name = "clientFullNameLabel";
            this.clientFullNameLabel.Size = new System.Drawing.Size(77, 30);
            this.clientFullNameLabel.TabIndex = 25;
            this.clientFullNameLabel.Text = "Client: ";
            // 
            // viewSessionLabel
            // 
            this.viewSessionLabel.AutoSize = true;
            this.viewSessionLabel.BackColor = System.Drawing.Color.White;
            this.viewSessionLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSessionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.viewSessionLabel.Location = new System.Drawing.Point(37, 9);
            this.viewSessionLabel.Name = "viewSessionLabel";
            this.viewSessionLabel.Size = new System.Drawing.Size(486, 65);
            this.viewSessionLabel.TabIndex = 24;
            this.viewSessionLabel.Text = "View and Edit Session";
            // 
            // sessionTypeComboBox
            // 
            this.sessionTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.sessionTypeComboBox.FormattingEnabled = true;
            this.sessionTypeComboBox.Location = new System.Drawing.Point(235, 192);
            this.sessionTypeComboBox.Name = "sessionTypeComboBox";
            this.sessionTypeComboBox.Size = new System.Drawing.Size(297, 38);
            this.sessionTypeComboBox.TabIndex = 38;
            // 
            // paymentReceivedPanel
            // 
            this.paymentReceivedPanel.Controls.Add(this.noRadioButton);
            this.paymentReceivedPanel.Controls.Add(this.yesRadioButton);
            this.paymentReceivedPanel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentReceivedPanel.Location = new System.Drawing.Point(235, 285);
            this.paymentReceivedPanel.Name = "paymentReceivedPanel";
            this.paymentReceivedPanel.Size = new System.Drawing.Size(297, 42);
            this.paymentReceivedPanel.TabIndex = 37;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.noRadioButton.Location = new System.Drawing.Point(170, 3);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(59, 34);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.yesRadioButton.Location = new System.Drawing.Point(70, 3);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(61, 34);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentReceivedLabel
            // 
            this.paymentReceivedLabel.AutoSize = true;
            this.paymentReceivedLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentReceivedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.paymentReceivedLabel.Location = new System.Drawing.Point(28, 291);
            this.paymentReceivedLabel.Name = "paymentReceivedLabel";
            this.paymentReceivedLabel.Size = new System.Drawing.Size(192, 30);
            this.paymentReceivedLabel.TabIndex = 33;
            this.paymentReceivedLabel.Text = "Payment Received: ";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.ForeColor = System.Drawing.Color.Black;
            this.rateTextBox.Location = new System.Drawing.Point(235, 241);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(297, 35);
            this.rateTextBox.TabIndex = 31;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.rateLabel.Location = new System.Drawing.Point(28, 244);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(72, 30);
            this.rateLabel.TabIndex = 30;
            this.rateLabel.Text = "Rate : ";
            // 
            // sessionTypeLabel
            // 
            this.sessionTypeLabel.AutoSize = true;
            this.sessionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.sessionTypeLabel.Location = new System.Drawing.Point(28, 195);
            this.sessionTypeLabel.Name = "sessionTypeLabel";
            this.sessionTypeLabel.Size = new System.Drawing.Size(173, 30);
            this.sessionTypeLabel.TabIndex = 29;
            this.sessionTypeLabel.Text = "Type of Session : ";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.ForeColor = System.Drawing.Color.Black;
            this.notesTextBox.Location = new System.Drawing.Point(235, 343);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(297, 171);
            this.notesTextBox.TabIndex = 35;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.notesLabel.Location = new System.Drawing.Point(28, 346);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(85, 30);
            this.notesLabel.TabIndex = 34;
            this.notesLabel.Text = "Notes : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.dateLabel.Location = new System.Drawing.Point(28, 145);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(68, 30);
            this.dateLabel.TabIndex = 28;
            this.dateLabel.Text = "Date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 29);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "$";
            // 
            // viewSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sessionTypeComboBox);
            this.Controls.Add(this.paymentReceivedPanel);
            this.Controls.Add(this.paymentReceivedLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.sessionTypeLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.updateSessionButton);
            this.Controls.Add(this.clientFullNameTextBox);
            this.Controls.Add(this.clientFullNameLabel);
            this.Controls.Add(this.viewSessionLabel);
            this.Name = "viewSessionForm";
            this.Text = "View Session";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSessionForm_FormClosing);
            this.paymentReceivedPanel.ResumeLayout(false);
            this.paymentReceivedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateSessionButton;
        private System.Windows.Forms.TextBox clientFullNameTextBox;
        private System.Windows.Forms.Label clientFullNameLabel;
        private System.Windows.Forms.Label viewSessionLabel;
        private System.Windows.Forms.ComboBox sessionTypeComboBox;
        private System.Windows.Forms.Panel paymentReceivedPanel;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label paymentReceivedLabel;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label sessionTypeLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}