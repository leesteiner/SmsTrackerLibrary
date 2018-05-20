namespace SmsTracker
{
    partial class viewClientForm
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
            this.viewClientLabel = new System.Windows.Forms.Label();
            this.updateClientButton = new System.Windows.Forms.Button();
            this.cellPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneNumberLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.sessionsLabel = new System.Windows.Forms.Label();
            this.sessionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewClientLabel
            // 
            this.viewClientLabel.AutoSize = true;
            this.viewClientLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.viewClientLabel.Location = new System.Drawing.Point(241, 10);
            this.viewClientLabel.Name = "viewClientLabel";
            this.viewClientLabel.Size = new System.Drawing.Size(450, 65);
            this.viewClientLabel.TabIndex = 14;
            this.viewClientLabel.Text = "View and Edit Client";
            // 
            // updateClientButton
            // 
            this.updateClientButton.BackColor = System.Drawing.Color.White;
            this.updateClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateClientButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.updateClientButton.Location = new System.Drawing.Point(308, 296);
            this.updateClientButton.Name = "updateClientButton";
            this.updateClientButton.Size = new System.Drawing.Size(317, 40);
            this.updateClientButton.TabIndex = 23;
            this.updateClientButton.Text = "Update Client Info and Return";
            this.updateClientButton.UseVisualStyleBackColor = false;
            this.updateClientButton.Click += new System.EventHandler(this.UpdateClientButton_Click);
            // 
            // cellPhoneNumberTextBox
            // 
            this.cellPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneNumberTextBox.Location = new System.Drawing.Point(218, 241);
            this.cellPhoneNumberTextBox.Name = "cellPhoneNumberTextBox";
            this.cellPhoneNumberTextBox.Size = new System.Drawing.Size(317, 33);
            this.cellPhoneNumberTextBox.TabIndex = 22;
            // 
            // cellPhoneNumberLabel
            // 
            this.cellPhoneNumberLabel.AutoSize = true;
            this.cellPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.cellPhoneNumberLabel.Location = new System.Drawing.Point(12, 244);
            this.cellPhoneNumberLabel.Name = "cellPhoneNumberLabel";
            this.cellPhoneNumberLabel.Size = new System.Drawing.Size(186, 25);
            this.cellPhoneNumberLabel.TabIndex = 21;
            this.cellPhoneNumberLabel.Text = "Cellphone Number : ";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(218, 201);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(317, 33);
            this.emailAddressTextBox.TabIndex = 20;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.emailAddressLabel.Location = new System.Drawing.Point(12, 204);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(144, 25);
            this.emailAddressLabel.TabIndex = 19;
            this.emailAddressLabel.Text = "Email Address : ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(218, 161);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(317, 33);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.lastNameLabel.Location = new System.Drawing.Point(12, 164);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(114, 25);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name : ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(218, 121);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(317, 33);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.firstNameLabel.Location = new System.Drawing.Point(12, 124);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "First Name : ";
            // 
            // sessionsLabel
            // 
            this.sessionsLabel.AutoSize = true;
            this.sessionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.sessionsLabel.Location = new System.Drawing.Point(782, 75);
            this.sessionsLabel.Name = "sessionsLabel";
            this.sessionsLabel.Size = new System.Drawing.Size(105, 32);
            this.sessionsLabel.TabIndex = 25;
            this.sessionsLabel.Text = "Sessions";
            // 
            // sessionListBox
            // 
            this.sessionListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionListBox.FormattingEnabled = true;
            this.sessionListBox.ItemHeight = 25;
            this.sessionListBox.Location = new System.Drawing.Point(561, 121);
            this.sessionListBox.Name = "sessionListBox";
            this.sessionListBox.Size = new System.Drawing.Size(326, 154);
            this.sessionListBox.TabIndex = 24;
            // 
            // viewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 370);
            this.Controls.Add(this.sessionsLabel);
            this.Controls.Add(this.sessionListBox);
            this.Controls.Add(this.updateClientButton);
            this.Controls.Add(this.cellPhoneNumberTextBox);
            this.Controls.Add(this.cellPhoneNumberLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.viewClientLabel);
            this.Name = "viewClientForm";
            this.Text = "View Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewClientLabel;
        private System.Windows.Forms.Button updateClientButton;
        private System.Windows.Forms.TextBox cellPhoneNumberTextBox;
        private System.Windows.Forms.Label cellPhoneNumberLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label sessionsLabel;
        private System.Windows.Forms.ListBox sessionListBox;
    }
}