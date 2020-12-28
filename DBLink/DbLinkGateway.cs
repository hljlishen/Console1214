using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.DBLink
{
    public enum DatabaseType
    {
        MySql,
        Access,
        SqlServer
    }
    internal class DbLinkGateway
    {
        public static DbLinkFactory CreateFactory(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.MySql:
                    return new MySqlFactory();
                case DatabaseType.Access:
                    return new AccessFactory();
                case DatabaseType.SqlServer:
                    return new SqlServerFactory();
                default:
                    throw new Exception("错误的数据库类型");
            }
        }
    }
}
