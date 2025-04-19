using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GetServerDBDetails
    {

        private static readonly string _serverName = ".";
        private static readonly string _serverPassword = "passWordHere";
        public static string serverName => _serverName;
        public static string serverPassword => _serverPassword;

    }
}
