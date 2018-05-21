using SmsTrackerLibrary.DataAccess;
using SmsTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsTracker
{
    public partial class SmsTracker : Form
    {
        //TODO: Add session Id to Client object in Session object
        //TODO: Add Sort function? Implement IComparable on Client / Session models? Session by date, client by Last Name?
        //TODO: Export to spreadsheet - print out sessions / print out client list
        //TODO: Client count / session count
        //TODO: Use DB
        //TODO: Type : Change PianoTracks to Tracks
        //TODO: Misc / voiceover? / other
        //TODO: Prepopulate rate box based on sessionType
        //TODO: Add discount box ? 
        //TODO: Session list, highlight people who haven't paid?
        //TODO: Add view session button to view client pane
        
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
            addClientForm f = new addClientForm();

            f.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
            f.ShowDialog();
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            Client returnClient = new Client();
            int clientId = 0;

            using (var s = new addSessionForm())
            {
                var result = s.ShowDialog();
                if (result == DialogResult.OK)
                {
                    returnClient = s.returnClient;
                    clientId = returnClient.Id;

                    Clients.Insert(clientId, returnClient);
                    Clients.RemoveAt(clientId-1) ;

                    TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);

                    s.FormClosing += new FormClosingEventHandler(this.F_FormClosing);
                }

            }

            WireUpLists();


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
                int editedClientPosition = 0;
                using (var v = new viewClientForm(tempClient))
                {
                    var result = v.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        returnClient = v.returnClient;


                        editedClientPosition = returnClient.Id;
                        Clients.Insert(editedClientPosition, returnClient);

                        Clients.RemoveAt(editedClientPosition-1);
                        TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);
                        v.FormClosing += new FormClosingEventHandler(this.V_FormClosing);
                    }
                    if (result == DialogResult.Cancel)
                    {
                        returnClient = tempClient;
                    }

                }

                

                
                WireUpLists();
                //TODO: (bEFORE!!) On session delete, remove session Id from client's Session Id list
                //TODO: Set selected item based on last one used. 
                /*foreach (Client c in clientListBox.Items)
                {
                    if(c.Id == editedClientPosition)
                    {
                        clientListBox.SelectedItems.Add(c);
                    }
                }
                */
                //clientListBox.SetSelected(editedClientPosition, true);
            }

            else
            {
                MessageBox.Show("There are no clients available to view.");
            }
            

            //TODO: Fix error of x'ing out of add client box. Changes record to NULL in JSON? - or replaces model with last edited one??
            //TODO: list client sessions by Id instead of namesearch

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
                List<int> sessionsToRemove = new List<int>();
                foreach (Session s in Sessions)
                {
                    if (s.client.FullName == selectedClient.FullName)
                    {
                        sessionsToRemove.Add(s.Id);
                    }
                }

                foreach (int i in sessionsToRemove)
                {
                    Sessions.RemoveAll(p => p.Id == i);
                }

                TextConnectorProcessor.SaveToSessionFile(Sessions, TextConnection.SessionFile);
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

        private void viewSelectedSessionButton_Click(object sender, EventArgs e)
        {

            Session tempSession = (Session)sessionListBox.SelectedItem;

            if (tempSession != null)
            {
                using (var v = new viewSessionForm(tempSession))
                {
                    var result = v.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        returnSession = v.returnSession;
                        v.FormClosing += new FormClosingEventHandler(this.V_FormClosing);
                    }
                    if (result == DialogResult.Cancel)
                    {
                        returnSession = tempSession;
                    }

                }

                int editedSessionPosition = Sessions.IndexOf(tempSession);
                Sessions.Insert(editedSessionPosition, returnSession);

                Sessions.Remove(tempSession);
                TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);
                TextConnectorProcessor.SaveToSessionFile(Sessions, TextConnection.SessionFile);
                WireUpLists();
                sessionListBox.SetSelected(editedSessionPosition, true);
            }

            else
            {
                MessageBox.Show("There are no sessions available to view.");
            }


            //TODO: Fix error of x'ing out of add client box. Changes record to NULL in JSON? - or replaces model with last edited one??        



        }

        private void exportEmailsButton_Click(object sender, EventArgs e)
        {
            List<string> clientEmails = new List<string>();
            foreach (Client c in Clients)
            {
                clientEmails.Add(c.EmailAddress);
            }

            System.IO.File.WriteAllLines(TextConnection.EmailList.FullFilePath(), clientEmails);
            System.Diagnostics.Process.Start(TextConnection.EmailList.FullFilePath());
        }
    }
}
