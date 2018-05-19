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
    public partial class SmsTracker : Form
    {
        private List<Client> Clients { get; set; } = GlobalConfig.Connection.GetAllClients();
        private Client returnClient { get; set; }

        private List<Session> Sessions { get; set; } = GlobalConfig.Connection.GetAllSessions();
        private Session returnSession { get; set; }


        public SmsTracker()
        {
            InitializeComponent();
            WireUpLists();
            
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm();

            f.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
            f.ShowDialog();
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            AddSessionForm s = new AddSessionForm();

            s.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
            s.ShowDialog();

        }

        private void Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("In Session Form Closed event");
        }



        private void WireUpLists()
        {
            Clients = GlobalConfig.Connection.GetAllClients();
            clientListBox.DataSource = null;
            clientListBox.DataSource = Clients;
            clientListBox.DisplayMember = "FullName";

            Sessions = GlobalConfig.Connection.GetAllSessions();
            sessionListBox.DataSource = null;
            sessionListBox.DataSource = Sessions;
            sessionListBox.DisplayMember = "basicSummary";
        }

        private void ViewSelectedClientButton_Click(object sender, EventArgs e)
        {

            Client tempClient = (Client)clientListBox.SelectedItem;
            
            if (tempClient != null)
            {
                using (var v = new ViewClientForm(tempClient))
                {
                    var result = v.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        returnClient = v.returnClient;
                        v.FormClosing += new FormClosingEventHandler(this.V_FormClosing);
                    }
                    if (result == DialogResult.Cancel)
                    {
                        returnClient = tempClient;
                    }

                }

                int editedClientPosition = Clients.IndexOf(tempClient);
                Clients.Insert(editedClientPosition, returnClient);

                Clients.Remove(tempClient);

                TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);
                WireUpLists();
                clientListBox.SetSelected(editedClientPosition, true);
            }

            else
            {
                MessageBox.Show("There are no clients available to view.");
            }
            

            //TODO: Fix error of x'ing out of add client box. Changes record to NULL in JSON? - or replaces model with last edited one??
            

        }

        private void V_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }

        private void deleteSelectedClientButton_Click(object sender, EventArgs e)
        {

            Client selectedClient = (Client)clientListBox.SelectedItem;
            if (selectedClient != null)
            {
                Clients.Remove(selectedClient);
                TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);
                WireUpLists();
            }

            else
            {
                MessageBox.Show("There are no clients to delete.");
            }
            
        }

        private void deleteSelectedSessionButton_Click(object sender, EventArgs e)
        {
            Session selectedSession = (Session)sessionListBox.SelectedItem;
            if (selectedSession != null)
            {
                Sessions.Remove(selectedSession);
                TextConnectorProcessor.SaveToSessionFile(Sessions, TextConnection.SessionFile);
                WireUpLists();
            }

            else
            {
                MessageBox.Show("There are no clients to delete.");
            }

        }
    }
}
