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
    public partial class addClientForm : Form
    {

        public addClientForm()
        {
            InitializeComponent();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            

            if (ValidateForm(out string errorMessage))
            {
                
                Client model = new Client(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    emailAddressTextBox.Text,
                    cellphoneNumberTextBox.Text,
                    new List<int>());

                GlobalConfig.Connection.CreateClient(model);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailAddressTextBox.Text = "";
                cellphoneNumberTextBox.Text = "";
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

            if (!cellphoneNumberTextBox.Text.ValidatePhoneNumber(false))
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
        //TODO: still... fix null returned Client from CreateClient X'ed out

    }
}
