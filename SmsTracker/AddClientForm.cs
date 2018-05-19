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
                    CellphoneNumberTextBox.Text,
                    new List<int>());

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

            int cellphoneCheck = 0;
            int.TryParse(CellphoneNumberTextBox.Text, out cellphoneCheck);
            if (cellphoneCheck == 0)
            {
                MessageBox.Show("You've entered an invalid cellphone number, please try again.");
                output = false;
                
            }
            
            return output;
        }
        //TODO: still... fix null returned Client from CreateClient X'ed out

    }
}
