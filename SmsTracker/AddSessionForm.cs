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
    public partial class addSessionForm : Form
    {
        public Client returnClient { get; set; }

        private List<Client> Clients { get; set; } = GlobalConfig.Connection.GetAllClients();

        public addSessionForm()
        {
            
            InitializeComponent();
            WireUpLists();
        }

        private bool ValidateForm(out string validationError)
        {
            bool output = true;
            string errorMessage = "There are no errors.";
            

            decimal number;
            if (!decimal.TryParse(rateTextBox.Text, out number))
            {
                errorMessage = "Your rate cannot be converted to a decimal, please try again.";
                output = false;
            }


            validationError = errorMessage;
            return output;

            
        }


        private void WireUpLists()
        {
            Clients = GlobalConfig.Connection.GetAllClients();
            clientComboBox.DataSource = null;
            clientComboBox.DataSource = Clients;
            clientComboBox.DisplayMember = "FullName";

            var sessionTypes = (SessionType[])Enum.GetValues(typeof(SessionType));

            sessionTypeComboBox.DataSource = null;
            sessionTypeComboBox.DataSource = sessionTypes;
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            addClientForm f = new addClientForm();
            
            f.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
            f.ShowDialog();
            


        }

        void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            WireUpLists();
            //todo: set selected client as the one just added, copy code from View Client form, updated to fix based on dialogresult

        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out string errorMessage))
            {
                Client selectedClient = Clients.Find(x => x.FullName == $"{clientComboBox.Text}");
                SessionType sessionType;
                Enum.TryParse(sessionTypeComboBox.Text, out sessionType);
                bool isChecked = yesRadioButton.Checked;
                string strippedNotes = notesTextBox.Text.Replace(",", "");
                Session model = new Session(
                    selectedClient,
                    dateTimePicker1.Value, 
                    decimal.Parse(rateTextBox.Text), 
                    sessionType, 
                    isChecked, 
                    strippedNotes);

                Session newlyIdedSession = GlobalConfig.Connection.CreateSession(model);

                Client clientToWhomIdsWillBeAdded = Clients.Find(x => x.FullName == $"{newlyIdedSession.client.FullName}");
                clientToWhomIdsWillBeAdded.SessionIds.Add(newlyIdedSession.Id);
                Clients.Insert(selectedClient.Id, clientToWhomIdsWillBeAdded);
                Clients.Remove(selectedClient);
                this.returnClient = clientToWhomIdsWillBeAdded;
                this.DialogResult = DialogResult.OK;
                this.Close();

                
                
                
                
                //TODO: Across all forms, session ID is not being added to client's session ID list

            


            }
            else
            {
                MessageBox.Show(errorMessage);
            }
                
        }
    }
}
