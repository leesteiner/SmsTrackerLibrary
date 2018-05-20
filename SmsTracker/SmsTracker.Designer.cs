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
            this.createClientButton = new System.Windows.Forms.Button();
            this.createSessionButton = new System.Windows.Forms.Button();
            this.clientTrackerLabel = new System.Windows.Forms.Label();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.currentClientsLabel = new System.Windows.Forms.Label();
            this.viewSelectedClientButton = new System.Windows.Forms.Button();
            this.viewSelectedSessionButton = new System.Windows.Forms.Button();
            this.currentSessionsLabel = new System.Windows.Forms.Label();
            this.sessionListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedClientButton = new System.Windows.Forms.Button();
            this.deleteSelectedSessionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exportEmailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createClientButton
            // 
            this.createClientButton.BackColor = System.Drawing.Color.White;
            this.createClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.createClientButton.Location = new System.Drawing.Point(213, 142);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(125, 35);
            this.createClientButton.TabIndex = 11;
            this.createClientButton.Text = "Create New";
            this.createClientButton.UseVisualStyleBackColor = false;
            this.createClientButton.Click += new System.EventHandler(this.CreateClientButton_Click);
            // 
            // createSessionButton
            // 
            this.createSessionButton.BackColor = System.Drawing.Color.White;
            this.createSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSessionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.createSessionButton.Location = new System.Drawing.Point(628, 142);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(125, 35);
            this.createSessionButton.TabIndex = 12;
            this.createSessionButton.Text = "Create Session";
            this.createSessionButton.UseVisualStyleBackColor = false;
            this.createSessionButton.Click += new System.EventHandler(this.CreateSessionButton_Click);
            // 
            // clientTrackerLabel
            // 
            this.clientTrackerLabel.AutoSize = true;
            this.clientTrackerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTrackerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.clientTrackerLabel.Location = new System.Drawing.Point(226, 27);
            this.clientTrackerLabel.Name = "clientTrackerLabel";
            this.clientTrackerLabel.Size = new System.Drawing.Size(313, 65);
            this.clientTrackerLabel.TabIndex = 13;
            this.clientTrackerLabel.Text = "Client Tracker";
            // 
            // clientListBox
            // 
            this.clientListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
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
            this.currentClientsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.currentClientsLabel.Location = new System.Drawing.Point(12, 140);
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
            this.viewSelectedClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
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
            this.viewSelectedSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.viewSelectedSessionButton.Location = new System.Drawing.Point(427, 492);
            this.viewSelectedSessionButton.Name = "viewSelectedSessionButton";
            this.viewSelectedSessionButton.Size = new System.Drawing.Size(326, 40);
            this.viewSelectedSessionButton.TabIndex = 19;
            this.viewSelectedSessionButton.Text = "View Selected Session";
            this.viewSelectedSessionButton.UseVisualStyleBackColor = false;
            this.viewSelectedSessionButton.Click += new System.EventHandler(this.viewSelectedSessionButton_Click);
            // 
            // currentSessionsLabel
            // 
            this.currentSessionsLabel.AutoSize = true;
            this.currentSessionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSessionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.currentSessionsLabel.Location = new System.Drawing.Point(421, 140);
            this.currentSessionsLabel.Name = "currentSessionsLabel";
            this.currentSessionsLabel.Size = new System.Drawing.Size(105, 32);
            this.currentSessionsLabel.TabIndex = 18;
            this.currentSessionsLabel.Text = "Sessions";
            // 
            // sessionListBox
            // 
            this.sessionListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.sessionListBox.FormattingEnabled = true;
            this.sessionListBox.ItemHeight = 21;
            this.sessionListBox.Location = new System.Drawing.Point(427, 188);
            this.sessionListBox.Name = "sessionListBox";
            this.sessionListBox.Size = new System.Drawing.Size(326, 298);
            this.sessionListBox.TabIndex = 17;
            // 
            // deleteSelectedClientButton
            // 
            this.deleteSelectedClientButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
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
            this.deleteSelectedSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.deleteSelectedSessionButton.Location = new System.Drawing.Point(427, 568);
            this.deleteSelectedSessionButton.Name = "deleteSelectedSessionButton";
            this.deleteSelectedSessionButton.Size = new System.Drawing.Size(161, 30);
            this.deleteSelectedSessionButton.TabIndex = 21;
            this.deleteSelectedSessionButton.Text = "Delete Selected Session";
            this.deleteSelectedSessionButton.UseVisualStyleBackColor = false;
            this.deleteSelectedSessionButton.Click += new System.EventHandler(this.deleteSelectedSessionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SmsTracker.Properties.Resources.Steiner_Horizontal_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // exportEmailsButton
            // 
            this.exportEmailsButton.BackColor = System.Drawing.Color.White;
            this.exportEmailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportEmailsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportEmailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.exportEmailsButton.Location = new System.Drawing.Point(612, 12);
            this.exportEmailsButton.Name = "exportEmailsButton";
            this.exportEmailsButton.Size = new System.Drawing.Size(141, 35);
            this.exportEmailsButton.TabIndex = 23;
            this.exportEmailsButton.Text = "Export Email List";
            this.exportEmailsButton.UseVisualStyleBackColor = false;
            this.exportEmailsButton.Click += new System.EventHandler(this.exportEmailsButton_Click);
            // 
            // SmsTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 631);
            this.Controls.Add(this.exportEmailsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteSelectedSessionButton);
            this.Controls.Add(this.deleteSelectedClientButton);
            this.Controls.Add(this.viewSelectedSessionButton);
            this.Controls.Add(this.currentSessionsLabel);
            this.Controls.Add(this.sessionListBox);
            this.Controls.Add(this.viewSelectedClientButton);
            this.Controls.Add(this.currentClientsLabel);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.clientTrackerLabel);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.createClientButton);
            this.Name = "SmsTracker";
            this.Text = "Steiner Music Studios Client Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createClientButton;
        private System.Windows.Forms.Button createSessionButton;
        private System.Windows.Forms.Label clientTrackerLabel;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.Label currentClientsLabel;
        private System.Windows.Forms.Button viewSelectedClientButton;
        private System.Windows.Forms.Button viewSelectedSessionButton;
        private System.Windows.Forms.Label currentSessionsLabel;
        private System.Windows.Forms.ListBox sessionListBox;
        private System.Windows.Forms.Button deleteSelectedClientButton;
        private System.Windows.Forms.Button deleteSelectedSessionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exportEmailsButton;
    }
}

