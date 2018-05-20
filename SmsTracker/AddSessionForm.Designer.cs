namespace SmsTracker
{
    partial class addSessionForm
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
            this.addSessionLabel = new System.Windows.Forms.Label();
            this.createSessionButton = new System.Windows.Forms.Button();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.sessionTypeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.paymentReceivedLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.paymentReceivedPanel = new System.Windows.Forms.Panel();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.sessionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.newClientButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentReceivedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSessionLabel
            // 
            this.addSessionLabel.AutoSize = true;
            this.addSessionLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSessionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.addSessionLabel.Location = new System.Drawing.Point(139, 9);
            this.addSessionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addSessionLabel.Name = "addSessionLabel";
            this.addSessionLabel.Size = new System.Drawing.Size(286, 65);
            this.addSessionLabel.TabIndex = 1;
            this.addSessionLabel.Text = "Add Session";
            // 
            // createSessionButton
            // 
            this.createSessionButton.BackColor = System.Drawing.Color.White;
            this.createSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSessionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.createSessionButton.Location = new System.Drawing.Point(164, 461);
            this.createSessionButton.Margin = new System.Windows.Forms.Padding(6);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(232, 40);
            this.createSessionButton.TabIndex = 19;
            this.createSessionButton.Text = "Create Session";
            this.createSessionButton.UseVisualStyleBackColor = false;
            this.createSessionButton.Click += new System.EventHandler(this.CreateSessionButton_Click);
            // 
            // rateTextBox
            // 
            this.rateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.Location = new System.Drawing.Point(213, 233);
            this.rateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(317, 33);
            this.rateTextBox.TabIndex = 18;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.rateLabel.Location = new System.Drawing.Point(28, 236);
            this.rateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(63, 25);
            this.rateLabel.TabIndex = 17;
            this.rateLabel.Text = "Rate : ";
            // 
            // sessionTypeLabel
            // 
            this.sessionTypeLabel.AutoSize = true;
            this.sessionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.sessionTypeLabel.Location = new System.Drawing.Point(26, 191);
            this.sessionTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sessionTypeLabel.Name = "sessionTypeLabel";
            this.sessionTypeLabel.Size = new System.Drawing.Size(155, 25);
            this.sessionTypeLabel.TabIndex = 15;
            this.sessionTypeLabel.Text = "Type of Session : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.dateLabel.Location = new System.Drawing.Point(26, 149);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 25);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date: ";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.clientLabel.Location = new System.Drawing.Point(26, 101);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(75, 25);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Client : ";
            // 
            // paymentReceivedLabel
            // 
            this.paymentReceivedLabel.AutoSize = true;
            this.paymentReceivedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentReceivedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.paymentReceivedLabel.Location = new System.Drawing.Point(28, 288);
            this.paymentReceivedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.paymentReceivedLabel.Name = "paymentReceivedLabel";
            this.paymentReceivedLabel.Size = new System.Drawing.Size(172, 25);
            this.paymentReceivedLabel.TabIndex = 20;
            this.paymentReceivedLabel.Text = "Payment Received: ";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(213, 336);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(317, 93);
            this.notesTextBox.TabIndex = 23;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(28, 339);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(75, 25);
            this.notesLabel.TabIndex = 22;
            this.notesLabel.Text = "Notes : ";
            // 
            // paymentReceivedPanel
            // 
            this.paymentReceivedPanel.Controls.Add(this.noRadioButton);
            this.paymentReceivedPanel.Controls.Add(this.yesRadioButton);
            this.paymentReceivedPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentReceivedPanel.Location = new System.Drawing.Point(213, 278);
            this.paymentReceivedPanel.Margin = new System.Windows.Forms.Padding(6);
            this.paymentReceivedPanel.Name = "paymentReceivedPanel";
            this.paymentReceivedPanel.Size = new System.Drawing.Size(152, 46);
            this.paymentReceivedPanel.TabIndex = 25;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRadioButton.Location = new System.Drawing.Point(75, 8);
            this.noRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(55, 29);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadioButton.Location = new System.Drawing.Point(6, 8);
            this.yesRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(57, 29);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // sessionTypeComboBox
            // 
            this.sessionTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTypeComboBox.FormattingEnabled = true;
            this.sessionTypeComboBox.Location = new System.Drawing.Point(213, 188);
            this.sessionTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.sessionTypeComboBox.Name = "sessionTypeComboBox";
            this.sessionTypeComboBox.Size = new System.Drawing.Size(317, 33);
            this.sessionTypeComboBox.TabIndex = 26;
            // 
            // clientComboBox
            // 
            this.clientComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(113, 98);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(295, 33);
            this.clientComboBox.TabIndex = 27;
            // 
            // newClientButton
            // 
            this.newClientButton.BackColor = System.Drawing.Color.White;
            this.newClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.newClientButton.Location = new System.Drawing.Point(420, 98);
            this.newClientButton.Margin = new System.Windows.Forms.Padding(6);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(110, 33);
            this.newClientButton.TabIndex = 28;
            this.newClientButton.Text = "Add Client";
            this.newClientButton.UseVisualStyleBackColor = false;
            this.newClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 143);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 33);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "$";
            // 
            // addSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.sessionTypeComboBox);
            this.Controls.Add(this.paymentReceivedPanel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.paymentReceivedLabel);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.sessionTypeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.addSessionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addSessionForm";
            this.Text = "Add Session";
            this.paymentReceivedPanel.ResumeLayout(false);
            this.paymentReceivedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addSessionLabel;
        private System.Windows.Forms.Button createSessionButton;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label sessionTypeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label paymentReceivedLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Panel paymentReceivedPanel;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.ComboBox sessionTypeComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}