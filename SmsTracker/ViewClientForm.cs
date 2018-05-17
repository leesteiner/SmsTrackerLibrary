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

        public ViewClientForm(Client c)
        {
            InitializeComponent();
            firstNameTextBox.Text = c.FirstName;
            lastNameTextBox.Text = c.LastName;
            emailAddressTextBox.Text = c.EmailAddress;
            cellPhoneNumberTextBox.Text = c.CellphoneNumber;
            returnClient = c;
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {
            this.returnClient = c;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            cellPhoneNumberTextBox.Text = "";
            this.Close();

            //TODO: Find out how to return these values to variable
        }
    }
}
