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

            //TODO: Set last added client as selected client in list
        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            AddSessionForm s = new AddSessionForm();

            s.FormClosed += new FormClosedEventHandler(Session_FormClosed);
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
        }

        private void ViewSelectedClientButton_Click(object sender, EventArgs e)
        {

            Client tempClient = (Client)clientListBox.SelectedItem;
            using (var v = new ViewClientForm(tempClient))
            {
                var result = v.ShowDialog();
                if (result == DialogResult.OK)
                {
                    returnClient = v.returnClient;
                    v.FormClosing += new FormClosingEventHandler(this.V_FormClosing);
                }

            }

            Clients.Remove(tempClient);

            //TODO: Use clients.Insert, capture clients (tempClient) index for insert position

            Clients.Add(returnClient);

            TextConnectorProcessor.SaveToClientFile(Clients, TextConnection.ClientFile);
            WireUpLists();
            

        }

        private void V_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }
    }
}
