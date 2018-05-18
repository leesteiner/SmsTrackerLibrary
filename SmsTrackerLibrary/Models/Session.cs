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
        public string basicSummary
        {
            get
            {
                return $"{Time} - {client.FullName}";
            }
        }

        public Session() {}

        public Session(Client c, DateTime time, decimal rate, SessionType type, bool paymentReceived, string notes)
        {
            client = c;
            Time = time;
            Rate = rate;
            Type = type;
            PaymentReceived = paymentReceived;
            Notes = notes;
        }
    }
}
