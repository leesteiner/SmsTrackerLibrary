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
    public partial class ViewClientForm : Form
    {
        public Client returnClient { get; set; }

        private List<Session> allSessions { get; set; } = GlobalConfig.Connection.GetAllSessions();

        public ViewClientForm(Client c)
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
            Client test1 = new Client();
            test1.Id = returnClient.Id;
            test1.FirstName = firstNameTextBox.Text;
            test1.LastName = lastNameTextBox.Text;
            test1.EmailAddress = emailAddressTextBox.Text;
            test1.CellphoneNumber = cellPhoneNumberTextBox.Text;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            cellPhoneNumberTextBox.Text = "";
            this.returnClient = test1;
            this.DialogResult = DialogResult.OK;
            this.Close();

            
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
    }
}
