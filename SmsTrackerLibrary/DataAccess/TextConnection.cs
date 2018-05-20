using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmsTrackerLibrary.Models;

namespace SmsTrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection
    {
        public const string ClientFile = "Clients.json";
        public const string SessionFile = "Sessions.json";
        public const string EmailList = "EmailList.txt";

        public Client CreateClient(Client model)
        {
            List<Client> clients = ClientFile.FullFilePath().LoadFile().ConvertToClient();

            int currentId = 1;

            if(clients.Count > 0)
            {
                currentId = clients.Max(p => p.Id + 1);
            }

            model.Id = currentId;

            clients.Add(model);
            clients.SaveToClientFile(ClientFile);
            return model;
        }

        public Session CreateSession(Session model)
        {
            List<Session> sessions = SessionFile.FullFilePath().LoadFile().ConvertToSession();

            int currentId = 1;

            if(sessions.Count > 0)
            {
                currentId = sessions.Max(p => p.Id + 1);
            }

            model.Id = currentId;

            sessions.Add(model);
            sessions.SaveToSessionFile(SessionFile);
            return model;
        }

        public List<Client> GetAllClients()
        {
            return ClientFile.FullFilePath().LoadFile().ConvertToClient();
        }

        public List<Session> GetAllSessions()
        {
            return SessionFile.FullFilePath().LoadFile().ConvertToSession();
        }
    }
}
