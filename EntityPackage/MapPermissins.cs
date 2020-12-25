using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class MapPermissins : ActiveRecord
    {
        public int? id { get; set; }
        public int? Administrator_id { get; set; }
        public int? Permissins_id { get; set; }
        public MapPermissins() : base("tb_MapPermissins", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
