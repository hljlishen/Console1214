using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class DbLinkManager
    {
        public static DatabaseType databaseType = DatabaseType.SqlServer;
        //public static string connectString = "Server=localhost;user id=root;password=mysql;database=cangku";
        public static string connectString = "server=.;database=ConsoleDB;uid=sa;pwd=123456";
        public static DbLinkFactory factory = DbLinkGateway.CreateFactory(databaseType);
    }
}
