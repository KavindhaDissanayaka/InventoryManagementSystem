using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class SqlHelper
    {
        static string strConnection;


        public static string connectionstring()
        {
            strConnection = $"Data Source={GetServerDBDetails.serverName};Initial Catalog=inventory_db;User ID=sa;Password={GetServerDBDetails.serverPassword};Pooling=False;Encrypt=True;Trust Server Certificate=True";

            return strConnection;
        }
    }
}
