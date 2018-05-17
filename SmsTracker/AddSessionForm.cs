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

        private void WireUpLists()
        {
            Clients = GlobalConfig.Connection.GetAllClients();
            ClientComboBox.DataSource = null;
            ClientComboBox.DataSource = Clients;
            ClientComboBox.DisplayMember = "FullName";
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
            MessageBox.Show("In Form Closing Event!");

            //TODO: Set last added client as selected client in list
        }
        
    }
}
