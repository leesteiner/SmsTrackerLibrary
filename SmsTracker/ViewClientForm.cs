using SmsTrackerLibrary;
using SmsTrackerLibrary.DataAccess;
using SmsTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsTracker
{
    public partial class viewClientForm : Form
    {
        public Client returnClient { get; set; }
        

        private List<Session> allSessions { get; set; } = GlobalConfig.Connection.GetAllSessions();

        public viewClientForm(Client c)
        {
            InitializeComponent();
            firstNameTextBox.Text = c.FirstName;
            lastNameTextBox.Text = c.LastName;
            emailAddressTextBox.Text = c.EmailAddress;
            cellPhoneNumberTextBox.Text = c.CellphoneNumber;
            returnClient = c;
            WireUpLists();
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out string errorMessage))
            {
                Client test1 = new Client();
                test1.Id = returnClient.Id;
                test1.FirstName = firstNameTextBox.Text;
                test1.LastName = lastNameTextBox.Text;
                test1.EmailAddress = emailAddressTextBox.Text;
                test1.CellphoneNumber = cellPhoneNumberTextBox.Text;
                test1.SessionIds = returnClient.SessionIds;
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailAddressTextBox.Text = "";
                cellPhoneNumberTextBox.Text = "";
                this.returnClient = test1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
            

            
        }

        private bool ValidateForm(out string validationError)
        {
            bool output = true;
            string errorMessage = "There are no errors";

            if (!cellPhoneNumberTextBox.Text.ValidatePhoneNumber(false))
            {
                errorMessage = "Invalid Phone Number";
                output = false;
            }

            if (!emailAddressTextBox.Text.ValidateEmailAddress(true))
            {
                output = false;
                errorMessage = "Invalid Email Address";
            }

            if (String.IsNullOrEmpty(firstNameTextBox.Text) || String.IsNullOrEmpty(lastNameTextBox.Text))
            {
                output = false;
                errorMessage = "You must provide a first and last name.";
            }

            validationError = errorMessage;
            return output;
        }

        private void WireUpLists()
        {
            allSessions = GlobalConfig.Connection.GetAllSessions();
            List<Session> currentClientSessions = new List<Session>();

            foreach (Session s in allSessions)
            {
                if (s.client.Id == returnClient.Id)
                {
                    currentClientSessions.Add(s);
                }
            }


            sessionListBox.DataSource = null;
            sessionListBox.DataSource = currentClientSessions;
            sessionListBox.DisplayMember = "basicSummary";

        }

        private void ViewClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.returnClient = returnClient;
        }

        private void ViewClientForm_Load(object sender, EventArgs e)
        {

        }

        

    }
}
