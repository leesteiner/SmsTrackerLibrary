using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmsTrackerLibrary.DataAccess;

namespace SmsTrackerLibrary.DataAccess
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections()
        {
            TextConnection txt = new TextConnection();
            Connection = txt;
        }
    }
}
