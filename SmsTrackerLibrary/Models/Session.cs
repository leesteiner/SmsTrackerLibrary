using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmsTrackerLibrary.DataAccess;

namespace SmsTrackerLibrary.Models
{
    public class Session
    {
        public int Id { get; set; }
        public Client client{ get; set; }
        public DateTime Time { get; set; }
        public decimal Rate { get; set; }
        public SessionType Type { get; set; }
        public bool PaymentReceived { get; set; }
        public string Notes { get; set; }

        public Session() {}

        public Session(Client name)
        {
            client = name;
            
        }
    }
}
