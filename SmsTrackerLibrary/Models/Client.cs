using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTrackerLibrary.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
        public List<int> SessionIds { get; set; } = new List<int>();
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Client()
        {

        }
        //TODO: Constructor chains??

        public Client(string firstName, string lastName, string emailAddress, string cellphoneNumber, List<int> sessionIds)
        {
            
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellphoneNumber = cellphoneNumber;
            SessionIds = sessionIds;
        }
    }
}
