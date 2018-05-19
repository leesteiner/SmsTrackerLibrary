namespace SmsTracker
{
    partial class SmsTracker
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
            this.CreateClientButton = new System.Windows.Forms.Button();
            this.CreateSessionButton = new System.Windows.Forms.Button();
            this.SmsClientTrackerLabel = new System.Windows.Forms.Label();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.currentClientsLabel = new System.Windows.Forms.Label();
            this.viewSelectedClientButton = new System.Windows.Forms.Button();
            this.viewSelectedSessionButton = new System.Windows.Forms.Button();
            this.currentSessionsLabel = new System.Windows.Forms.Label();
            this.sessionListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedClientButton = new System.Windows.Forms.Button();
            this.deleteSelectedSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateClientButton
            // 
            this.CreateClientButton.BackColor = System.Drawing.Color.White;
            this.CreateClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateClientButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClientButton.ForeColor = System.Drawing.Color.Black;
            this.CreateClientButton.Location = new System.Drawing.Point(205, 135);
            this.CreateClientButton.Name = "CreateClientButton";
            this.CreateClientButton.Size = new System.Drawing.Size(133, 40);
            this.CreateClientButton.TabIndex = 11;
            this.CreateClientButton.Text = "Create New";
            this.CreateClientButton.UseVisualStyleBackColor = false;
            this.CreateClientButton.Click += new System.EventHandler(this.CreateClientButton_Click);
            // 
            // CreateSessionButton
            // 
            this.CreateSessionButton.BackColor = System.Drawing.Color.White;
            this.CreateSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSessionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSessionButton.ForeColor = System.Drawing.Color.Black;
            this.CreateSessionButton.Location = new System.Drawing.Point(715, 117);
            this.CreateSessionButton.Name = "CreateSessionButton";
            this.CreateSessionButton.Size = new System.Drawing.Size(173, 50);
            this.CreateSessionButton.TabIndex = 12;
            this.CreateSessionButton.Text = "Create Session";
            this.CreateSessionButton.UseVisualStyleBackColor = false;
            this.CreateSessionButton.Click += new System.EventHandler(this.CreateSessionButton_Click);
            // 
            // SmsClientTrackerLabel
            // 
            this.SmsClientTrackerLabel.AutoSize = true;
            this.SmsClientTrackerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmsClientTrackerLabel.Location = new System.Drawing.Point(148, 19);
            this.SmsClientTrackerLabel.Name = "SmsClientTrackerLabel";
            this.SmsClientTrackerLabel.Size = new System.Drawing.Size(525, 45);
            this.SmsClientTrackerLabel.TabIndex = 13;
            this.SmsClientTrackerLabel.Text = "Steiner Music Studios Client Tracker";
            // 
            // clientListBox
            // 
            this.clientListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 21;
            this.clientListBox.Location = new System.Drawing.Point(12, 188);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(326, 298);
            this.clientListBox.TabIndex = 14;
            // 
            // currentClientsLabel
            // 
            this.currentClientsLabel.AutoSize = true;
            this.currentClientsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentClientsLabel.Location = new System.Drawing.Point(12, 135);
            this.currentClientsLabel.Name = "currentClientsLabel";
            this.currentClientsLabel.Size = new System.Drawing.Size(87, 32);
            this.currentClientsLabel.TabIndex = 15;
            this.currentClientsLabel.Text = "Clients";
            // 
            // viewSelectedClientButton
            // 
            this.viewSelectedClientButton.BackColor = System.Drawing.Color.White;
            this.viewSelectedClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedClientButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSelectedClientButton.ForeColor = System.Drawing.Color.Black;
            this.viewSelectedClientButton.Location = new System.Drawing.Point(12, 492);
            this.viewSelectedClientButton.Name = "viewSelectedClientButton";
            this.viewSelectedClientButton.Size = new System.Drawing.Size(326, 40);
            this.viewSelectedClientButton.TabIndex = 16;
            this.viewSelectedClientButton.Text = "View Selected Client";
            this.viewSelectedClientButton.UseVisualStyleBackColor = false;
            this.viewSelectedClientButton.Click += new System.EventHandler(this.ViewSelectedClientButton_Click);
            // 
            // viewSelectedSessionButton
            // 
            this.viewSelectedSessionButton.BackColor = System.Drawing.Color.White;
            this.viewSelectedSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedSessionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSelectedSessionButton.ForeColor = System.Drawing.Color.Black;
            this.viewSelectedSessionButton.Location = new System.Drawing.Point(512, 492);
            this.viewSelectedSessionButton.Name = "viewSelectedSessionButton";
            this.viewSelectedSessionButton.Size = new System.Drawing.Size(326, 40);
            this.viewSelectedSessionButton.TabIndex = 19;
            this.viewSelectedSessionButton.Text = "View Selected Session";
            this.viewSelectedSessionButton.UseVisualStyleBackColor = false;
            // 
            // currentSessionsLabel
            // 
            this.currentSessionsLabel.AutoSize = true;
            this.currentSessionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSessionsLabel.Location = new System.Drawing.Point(512, 135);
            this.currentSessionsLabel.Name = "currentSessionsLabel";
            this.currentSessionsLabel.Size = new System.Drawing.Size(105, 32);
            this.currentSessionsLabel.TabIndex = 18;
            this.currentSessionsLabel.Text = "Sessions";
            // 
            // sessionListBox
            // 
            this.sessionListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionListBox.FormattingEnabled = true;
            this.sessionListBox.ItemHeight = 21;
            this.sessionListBox.Location = new System.Drawing.Point(512, 188);
            this.sessionListBox.Name = "sessionListBox";
            this.sessionListBox.Size = new System.Drawing.Size(326, 298);
            this.sessionListBox.TabIndex = 17;
            // 
            // deleteSelectedClientButton
            // 
            this.deleteSelectedClientButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedClientButton.ForeColor = System.Drawing.Color.Black;
            this.deleteSelectedClientButton.Location = new System.Drawing.Point(12, 568);
            this.deleteSelectedClientButton.Name = "deleteSelectedClientButton";
            this.deleteSelectedClientButton.Size = new System.Drawing.Size(147, 30);
            this.deleteSelectedClientButton.TabIndex = 20;
            this.deleteSelectedClientButton.Text = "Delete Selected Client";
            this.deleteSelectedClientButton.UseVisualStyleBackColor = false;
            this.deleteSelectedClientButton.Click += new System.EventHandler(this.deleteSelectedClientButton_Click);
            // 
            // deleteSelectedSessionButton
            // 
            this.deleteSelectedSessionButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedSessionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedSessionButton.ForeColor = System.Drawing.Color.Black;
            this.deleteSelectedSessionButton.Location = new System.Drawing.Point(512, 568);
            this.deleteSelectedSessionButton.Name = "deleteSelectedSessionButton";
            this.deleteSelectedSessionButton.Size = new System.Drawing.Size(161, 30);
            this.deleteSelectedSessionButton.TabIndex = 21;
            this.deleteSelectedSessionButton.Text = "Delete Selected Session";
            this.deleteSelectedSessionButton.UseVisualStyleBackColor = false;
            this.deleteSelectedSessionButton.Click += new System.EventHandler(this.deleteSelectedSessionButton_Click);
            // 
            // SmsTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 631);
            this.Controls.Add(this.deleteSelectedSessionButton);
            this.Controls.Add(this.deleteSelectedClientButton);
            this.Controls.Add(this.viewSelectedSessionButton);
            this.Controls.Add(this.currentSessionsLabel);
            this.Controls.Add(this.sessionListBox);
            this.Controls.Add(this.viewSelectedClientButton);
            this.Controls.Add(this.currentClientsLabel);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.SmsClientTrackerLabel);
            this.Controls.Add(this.CreateSessionButton);
            this.Controls.Add(this.CreateClientButton);
            this.Name = "SmsTracker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateClientButton;
        private System.Windows.Forms.Button CreateSessionButton;
        private System.Windows.Forms.Label SmsClientTrackerLabel;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.Label currentClientsLabel;
        private System.Windows.Forms.Button viewSelectedClientButton;
        private System.Windows.Forms.Button viewSelectedSessionButton;
        private System.Windows.Forms.Label currentSessionsLabel;
        private System.Windows.Forms.ListBox sessionListBox;
        private System.Windows.Forms.Button deleteSelectedClientButton;
        private System.Windows.Forms.Button deleteSelectedSessionButton;
    }
}

