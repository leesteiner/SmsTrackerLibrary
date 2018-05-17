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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Client model = new Client(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text,
                    EmailAddressTextBox.Text,
                    CellphoneNumberTextBox.Text);

                GlobalConfig.Connection.CreateClient(model);

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailAddressTextBox.Text = "";
                CellphoneNumberTextBox.Text = "";
                this.Close();

            }
            else
            {
                MessageBox.Show("This information is invalid, please try again.");
            }
        }


        private bool ValidateForm()
        {
            bool output = true;
            return output;
        }

        private void AddClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
