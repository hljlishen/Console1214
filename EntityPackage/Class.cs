using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Class : ActiveRecord
    { 
        public int? id { get; set; }
        public int? Techer_id{ get; set; }
        public string ClassName { get; set; }
        public string State { get; set; }

        public Class() : base("tb_Class", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }

    }
}
