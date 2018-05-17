namespace SmsTracker
{
    partial class ViewClientForm
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
            this.AddSessionLabel = new System.Windows.Forms.Label();
            this.UpdateClientButton = new System.Windows.Forms.Button();
            this.cellPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneNumberLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddSessionLabel
            // 
            this.AddSessionLabel.AutoSize = true;
            this.AddSessionLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionLabel.Location = new System.Drawing.Point(0, 22);
            this.AddSessionLabel.Name = "AddSessionLabel";
            this.AddSessionLabel.Size = new System.Drawing.Size(525, 45);
            this.AddSessionLabel.TabIndex = 14;
            this.AddSessionLabel.Text = "Steiner Music Studios Client Tracker";
            // 
            // UpdateClientButton
            // 
            this.UpdateClientButton.BackColor = System.Drawing.Color.White;
            this.UpdateClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateClientButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClientButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateClientButton.Location = new System.Drawing.Point(48, 336);
            this.UpdateClientButton.Name = "UpdateClientButton";
            this.UpdateClientButton.Size = new System.Drawing.Size(425, 50);
            this.UpdateClientButton.TabIndex = 23;
            this.UpdateClientButton.Text = "Update Client Info and Return";
            this.UpdateClientButton.UseVisualStyleBackColor = false;
            this.UpdateClientButton.Click += new System.EventHandler(this.UpdateClientButton_Click);
            // 
            // cellPhoneNumberTextBox
            // 
            this.cellPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneNumberTextBox.Location = new System.Drawing.Point(218, 264);
            this.cellPhoneNumberTextBox.Name = "cellPhoneNumberTextBox";
            this.cellPhoneNumberTextBox.Size = new System.Drawing.Size(307, 35);
            this.cellPhoneNumberTextBox.TabIndex = 22;
            // 
            // cellPhoneNumberLabel
            // 
            this.cellPhoneNumberLabel.AutoSize = true;
            this.cellPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneNumberLabel.Location = new System.Drawing.Point(11, 267);
            this.cellPhoneNumberLabel.Name = "cellPhoneNumberLabel";
            this.cellPhoneNumberLabel.Size = new System.Drawing.Size(205, 30);
            this.cellPhoneNumberLabel.TabIndex = 21;
            this.cellPhoneNumberLabel.Text = "Cellphone Number : ";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(218, 216);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(307, 35);
            this.emailAddressTextBox.TabIndex = 20;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(11, 219);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(160, 30);
            this.emailAddressLabel.TabIndex = 19;
            this.emailAddressLabel.Text = "Email Address : ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(218, 169);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(307, 35);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(11, 172);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(129, 30);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name : ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(218, 121);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(307, 35);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(11, 124);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(130, 30);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "First Name : ";
            // 
            // ViewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.UpdateClientButton);
            this.Controls.Add(this.cellPhoneNumberTextBox);
            this.Controls.Add(this.cellPhoneNumberLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.AddSessionLabel);
            this.Name = "ViewClientForm";
            this.Text = "ViewClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddSessionLabel;
        private System.Windows.Forms.Button UpdateClientButton;
        private System.Windows.Forms.TextBox cellPhoneNumberTextBox;
        private System.Windows.Forms.Label cellPhoneNumberLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
    }
}