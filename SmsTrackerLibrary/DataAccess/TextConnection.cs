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
        private const string ClientFile = "Clients.csv";
        private const string SessionFile = "Sessions.csv";

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
            throw new NotImplementedException();
        }

        public List<Client> GetAllClients()
        {
            return ClientFile.FullFilePath().LoadFile().ConvertToClient();
        }
    }
}
