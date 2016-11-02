using PensionConsultants.Data.Access;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpTool.Business.Components
{
    public class Database
    {
        private static DataAccessComponent.Connections _connection = DataAccessComponent.Connections.PCIDB_RfpTool;
        private static DataAccessComponent.SecurityTypes _securityType = DataAccessComponent.SecurityTypes.Impersonate;
        public static DataAccessComponent RfpTool = new DataAccessComponent(_connection, _securityType);

        public static bool ConnectionSucceeded()
        {
            return RfpTool.ConnectionSucceeded();
        }
    }
}