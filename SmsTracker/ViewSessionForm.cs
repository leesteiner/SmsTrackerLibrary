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
    public partial class viewSessionForm : Form
    {
        public Session returnSession { get; set; }

        public viewSessionForm(Session s)
        {
            InitializeComponent();
            WireUpLists();
            clientFullNameTextBox.Text = s.client.FullName;
            sessionTypeComboBox.SelectedItem = s.Type;
            rateTextBox.Text = s.Rate.ToString();
            if (s.PaymentReceived)
            {
                yesRadioButton.Checked = true;
            }
            else
            {
                noRadioButton.Checked = true;
            }
            notesTextBox.Text = s.Notes;
            dateTimePicker1.Value = s.Time;

            returnSession = s;
        }

        private void WireUpLists()
        {
            var sessionTypes = (SessionType[])Enum.GetValues(typeof(SessionType));

            sessionTypeComboBox.DataSource = null;
            sessionTypeComboBox.DataSource = sessionTypes;
        }

        private void ViewSessionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.returnSession = returnSession;
        }

        private void UpdateSessionButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out string errorMessage))
            {
                SessionType sessionType;
                Enum.TryParse(sessionTypeComboBox.Text, out sessionType);
                bool isChecked = yesRadioButton.Checked;
                string strippedNotes = notesTextBox.Text.Replace(",", "");

                Session test1 = new Session();
                test1.Id = returnSession.Id;
                test1.client = returnSession.client;
                test1.Time = dateTimePicker1.Value;
                test1.Rate = decimal.Parse(rateTextBox.Text);
                test1.Type = sessionType;
                test1.PaymentReceived = isChecked;
                test1.Notes = strippedNotes;

                this.returnSession = test1;
                this.DialogResult = DialogResult.OK;
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
    }
}
