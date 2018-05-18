using SmsTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        Client CreateClient(Client model);
        Session CreateSession(Session model);
        List<Client> GetAllClients();
        List<Session> GetAllSessions();
    }
}
