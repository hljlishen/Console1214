using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Permissins : ActiveRecord
    {
        public int? id { get; set; }
        public string Operation { get; set; }
        public Permissins() : base("tb_Permissins", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
