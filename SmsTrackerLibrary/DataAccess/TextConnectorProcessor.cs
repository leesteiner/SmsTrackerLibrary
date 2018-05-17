using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using SmsTrackerLibrary.Models;


namespace SmsTrackerLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (Directory.Exists(ConfigurationManager.AppSettings["filePath"]))
            {
                if (!File.Exists(file))
                {
                    
                    var myFile = File.Create(file);
                    myFile.Close();
                    return new List<string>();
                }

            }


            else
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["filePath"]);
                var myFile = File.Create(file);
                myFile.Close();
                return new List<string>();

            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Client> ConvertToClient(this List<string> lines)
        {
            List<Client> output = new List<Client>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Client c = new Client();
                c.Id = int.Parse(cols[0]);
                c.FirstName = cols[1];
                c.LastName = cols[2];
                c.EmailAddress = cols[3];
                c.CellphoneNumber = cols[4];

                output.Add(c);
            }
            return output;
        }

        public static void SaveToClientFile(this List<Client> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Client c in models)
            {
                lines.Add($"{c.Id},{c.FirstName},{c.LastName},{c.EmailAddress},{c.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<Session> ConvertToSession(this List<string> lines)
        {
            List<Session> output = new List<Session>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Session s = new Session();
                s.Id = int.Parse(cols[0]);
                s.client.Id = int.Parse(cols[1]); //TODO: Make this add a client with this ID
                s.Time = DateTime.Parse(cols[2]);
                s.Rate = decimal.Parse(cols[3]);
                s.Type = SessionType.Video; //TODO: Fix Enum Parsing for Session Type!
                s.PaymentReceived = bool.Parse(cols[5]);
                s.Notes = cols[6];

                output.Add(s);
            }
            return output;
        }
        

        public static void SaveToSessionFile(this List<Session> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Session s in models)
            {
                lines.Add($"{s.Id},{s.client.Id}{s.Time},{s.Rate},{s.Type.ToString()},{s.PaymentReceived},{s.Notes}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
