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
    public partial class AddSessionForm : Form
    {
        private List<Client> Clients { get; set; } = GlobalConfig.Connection.GetAllClients();

        public AddSessionForm()
        {
            
            InitializeComponent();
            WireUpLists();
        }

        private bool ValidateForm()
        {
            //TODO: Add validation
            return true;
        }


        private void WireUpLists()
        {
            Clients = GlobalConfig.Connection.GetAllClients();
            ClientComboBox.DataSource = null;
            ClientComboBox.DataSource = Clients;
            ClientComboBox.DisplayMember = "FullName";

            var sessionTypes = (SessionType[])Enum.GetValues(typeof(SessionType));

            SessionTypeComboBox.DataSource = null;
            SessionTypeComboBox.DataSource = sessionTypes;
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm();
            
            f.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
            f.ShowDialog();
            


        }

        void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            WireUpLists();
            //todo: set selected client as the one just added

        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Client selectedClient = Clients.Find(x => x.FullName == $"{ClientComboBox.Text}");
                SessionType sessionType;
                Enum.TryParse(RateTextBox.Text, out sessionType);
                bool isChecked = YesRadioButton.Checked;

                Session model = new Session(
                    selectedClient,
                    monthCalendar1.SelectionRange.Start, 
                    decimal.Parse(RateTextBox.Text), 
                    sessionType, 
                    isChecked, 
                    NotesTextBox.Text);

                GlobalConfig.Connection.CreateSession(model);
                Client newlyIdedClient = Clients.Find(x => x.FullName == $"{model.client.FullName}");
                selectedClient.SessionIds.Add(newlyIdedClient.Id);

                //TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.SessionFile);
                //TODO: Save updated client.
                this.Close();

                //TODO: Add this.sessionID to client list of sessions Ids
                //TODO: Validate, validate, validate
                //TODO: Change date format


            }
            else
            {
                MessageBox.Show("There is invalid data in your form, please try again");
            }
                
        }
    }
}
